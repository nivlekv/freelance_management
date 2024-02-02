namespace FreelancersApi.Services
{
    public class UserService : IUserService
    {
        private RepositoryContext _db;
        private IRepositoryBase<TblUser> _userRep;        
        private IWebHostEnvironment _environment;
        private AppSetting _appSetting;

        public UserService(IRepositoryBase<TblUser> arg1, IOptions<AppSetting> arg2, RepositoryContext arg3, IWebHostEnvironment arg4)
        {
            _userRep     = arg1;
            _appSetting  = arg2.Value;
            _db          = arg3;
            _environment = arg4;
        }

        public ListResponseModel<UserListResponseModel> GetList(UserListRequestModel model) /// stop here
        {
            try
            {
                List<Expression<Func<TblUser, bool>>> listFilter = new List<Expression<Func<TblUser, bool>>>();

                if (model.Status != null)
                {
                    listFilter.Add(p => p.Status == model.Status);
                }

                if (model.Name.IsNotEmpty())
                {
                    listFilter.Add(p => p.Name.IsContains(model.Name));
                }

                if (model.PhoneNo.IsNotEmpty())
                {
                    listFilter.Add(p => p.PhoneNo.IsContains(model.PhoneNo));
                }

                if (model.Email.IsNotEmpty())
                {
                    listFilter.Add(p => p.Email.IsContains(model.Email));
                }

                var userlist = _userRep.GetAllByPageSorting(model.Page, model.PageSize, listFilter, model.OrderBy.ToString(), model.Asc, out long totalItem)
                                        .Select(x => new UserListResponseModel()
                                        {
                                            Id             = x.ID,
                                            Name           = x.Name,
                                            PhoneNo        = x.PhoneNo,
                                            Email          = x.Email,
                                            Status         = x.Status,
                                            LastUpdateDate = x.ModifiedDate,
                                            SkillSets      = x.TblUserSkillSets.Select(x=>new UserSkillSetModel()
                                                             {
                                                                Id         = x.ID,
                                                                Proficieny = x.Proficieny,
                                                                SkillName  = x.SkillName
                                                             }),
                                            Hobby          = x.TblUserHobbies.Select(x=>new UserHobbyModel()
                                                             {
                                                                Id         = x.ID,
                                                                Hobby      = x.Hobby
                                                             })
                                        });

                return new ListResponseModel<UserListResponseModel>(ResponseStatusEnum.OK, ResponseStatusEnum.OK.ToString(), userlist, totalItem);
            }
            catch (Exception ex)
            {
                return new ListResponseModel<UserListResponseModel>(ResponseStatusEnum.ErrorSystem, ex.Message + " \n" + ex.StackTrace, null, 0);
            }
        }

        public async Task<ContentResponseModel<UserDetailResponseModel>> GetUserDetails(long id)
        {
            try
            {
                TblUser userItem = await _userRep.Get(id);

                if (userItem == null)
                {
                    return new ContentResponseModel<UserDetailResponseModel>(ResponseStatusEnum.Error, ResponseErrorMsgEnum.INVALID_USER_ID.ToString(), null);
                }

                UserDetailResponseModel respModel = new UserDetailResponseModel()
                {
                    Id              = userItem.ID,
                    Name            = userItem.Name,
                    PhoneNo         = userItem.PhoneNo,
                    Status          = userItem.Status,
                    Email           = userItem.Email,
                    SkillSets       = userItem.TblUserSkillSets.Select(x => new UserSkillSetModel()
                                      {
                                            Id         = x.ID,
                                            Proficieny = x.Proficieny,
                                            SkillName  = x.SkillName
                                      }).ToList(),
                    Hobby           = userItem.TblUserHobbies.Select(x => new UserHobbyModel()
                                      {
                                            Id = x.ID,
                                            Hobby = x.Hobby
                                      }).ToList()
                };

                return new ContentResponseModel<UserDetailResponseModel>(ResponseStatusEnum.OK, ResponseStatusEnum.OK.ToString(), respModel);
            }
            catch (Exception ex)
            {
                return new ContentResponseModel<UserDetailResponseModel>(ResponseStatusEnum.ErrorSystem, ex.Message + " \n" + ex.StackTrace, null);
            }

        }


        public async Task<BaseResponseModel> Add(UserCreateRequestModel entity)
        {
            try
            {
                var valid = await CheckValid(entity);
                if (valid.Status != ResponseStatusEnum.OK)
                {
                    return valid;
                }

                using (var transaction = _db.Database.BeginTransaction())
                {
                    try
                    {
                        // user            
                        TblUser newUser = new TblUser
                        {
                            Name       = entity.Name,
                            Email      = entity.Email,                            
                            PhoneNo    = entity.PhoneNo,
                            Status     = true,                            
                            CreateDate = DateTime.Now,
                            CreateBy   = entity.RequestBy,
                        };

                        if (entity.SkillSets != null)
                        {
                            foreach (var skill in entity.SkillSets)
                            {
                                TblUserSkillSet newSkill = new TblUserSkillSet()
                                {
                                    SkillName  = skill.SkillName,
                                    Proficieny = skill.Proficieny,
                                    CreateBy   = entity.RequestBy,
                                    CreateDate = DateTime.Now
                                };

                                newUser.TblUserSkillSets.Add(newSkill);
                            }
                        }

                        if (entity.Hobby != null)
                        {
                            foreach (var hobby in entity.Hobby)
                            {
                                TblUserHobby newHobby = new TblUserHobby()
                                {
                                    Hobby      = hobby.Hobby,
                                    CreateBy   = entity.RequestBy,
                                    CreateDate = DateTime.Now
                                };

                                newUser.TblUserHobbies.Add(newHobby);
                            }
                        }

                        await _userRep.CreateAsync(newUser);                        

                        await _db.SaveChangesAsync();

                        transaction.Commit();

                        return new BaseResponseModel(ResponseStatusEnum.Created, ResponseStatusEnum.Created.ToString());
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return new BaseResponseModel(ResponseStatusEnum.ErrorSystem, ex.Message + " \n" + ex.StackTrace);
                    }
                }
            }
            catch (Exception ex)
            {
                return new BaseResponseModel(ResponseStatusEnum.ErrorSystem, ex.Message + " \n" + ex.StackTrace);
            }



        }


        public async Task<BaseResponseModel> Update(UserUpdateRequestModel entity)
        {
            try
            {
                var tblUser = await _userRep.Get(entity.Id);
                if (tblUser == null)
                {
                    return new BaseResponseModel(ResponseStatusEnum.Error, ResponseErrorMsgEnum.INVALID_ID.ToString());
                }

                using (var transaction = _db.Database.BeginTransaction())
                {
                    try
                    {
                        tblUser.Name         = entity.Name;
                        tblUser.Email        = entity.Email;
                        tblUser.PhoneNo      = entity.PhoneNo;
                        tblUser.Status       = entity.Status;
                        tblUser.ModifiedBy   = entity.RequestBy;
                        tblUser.ModifiedDate = DateTime.Now;

                        if (entity.SkillSets != null)
                        {
                            foreach (var skill in tblUser.TblUserSkillSets)
                            {
                                var skillExist = entity.SkillSets.Where(p => p.Id == skill.ID).FirstOrDefault();
                                if (skillExist == null)
                                {
                                    _db.TblUserSkillSets.Remove(skill);
                                }
                            }

                            foreach (var skill in entity.SkillSets)
                            {
                                if (skill.Id == 0)
                                {
                                    TblUserSkillSet newSkill = new TblUserSkillSet()
                                    {
                                        SkillName  = skill.SkillName,
                                        Proficieny = skill.Proficieny,
                                        CreateBy   = entity.RequestBy,
                                        CreateDate = DateTime.Now
                                    };

                                    tblUser.TblUserSkillSets.Add(newSkill);
                                }
                                else
                                {
                                    var skillExist = tblUser.TblUserSkillSets.Where(p => p.ID == skill.Id).FirstOrDefault();
                                    if (skillExist != null)
                                    {
                                        skillExist.SkillName    = skill.SkillName;
                                        skillExist.Proficieny   = skill.Proficieny;
                                        skillExist.ModifiedBy   = entity.RequestBy;
                                        skillExist.ModifiedDate = DateTime.Now;
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (var skill in tblUser.TblUserSkillSets)
                            {
                                _db.TblUserSkillSets.Remove(skill);
                            }
                        }

                        if (entity.Hobby != null)
                        {
                            foreach (var hobby in tblUser.TblUserHobbies)
                            {
                                var hobbyExist = entity.Hobby.Where(p => p.Id == hobby.ID).FirstOrDefault();
                                if (hobbyExist == null)
                                {
                                    _db.TblUserHobbies.Remove(hobby);
                                }
                            }

                            foreach (var hobby in entity.Hobby)
                            {
                                if (hobby.Id == 0)
                                {
                                    TblUserHobby newHobby = new TblUserHobby()
                                    {
                                        Hobby      = hobby.Hobby,
                                        CreateBy   = entity.RequestBy,
                                        CreateDate = DateTime.Now
                                    };

                                    tblUser.TblUserHobbies.Add(newHobby);
                                }
                                else
                                {
                                    var hobbyExist = tblUser.TblUserHobbies.Where(p => p.ID == hobby.Id).FirstOrDefault();
                                    if (hobbyExist != null)
                                    {
                                        hobbyExist.Hobby        = hobby.Hobby;
                                        hobbyExist.ModifiedBy   = entity.RequestBy;
                                        hobbyExist.ModifiedDate = DateTime.Now;
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (var hobby in tblUser.TblUserHobbies)
                            {
                                _db.TblUserHobbies.Remove(hobby);
                            }
                        }


                        _userRep.Update(tblUser);

                        await _db.SaveChangesAsync();

                        transaction.Commit();

                        return await GetUserDetails(entity.Id);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return new BaseResponseModel(ResponseStatusEnum.ErrorSystem, ex.Message + " \n" + ex.StackTrace);
                    }
                }
            }
            catch (Exception ex)
            {
                return new BaseResponseModel(ResponseStatusEnum.ErrorSystem, ex.Message + " \n" + ex.StackTrace);
            }
        }

        public async Task<BaseResponseModel> Delete(UserUpdateRequestModel entity)
        {
            try
            {
                var tblUser = await _userRep.Get(entity.Id);
                if (tblUser == null)
                {
                    return new BaseResponseModel(ResponseStatusEnum.Error, ResponseErrorMsgEnum.INVALID_ID.ToString());
                }

                using (var transaction = _db.Database.BeginTransaction())
                {
                    try
                    {
                        if(tblUser.TblUserHobbies !=null)
                        {
                            foreach (var hobby in tblUser.TblUserHobbies)
                            {
                               
                                _db.TblUserHobbies.Remove(hobby);
                            }
                        }

                        if (tblUser.TblUserSkillSets != null)
                        {
                            foreach (var skill in tblUser.TblUserSkillSets)
                            {

                                _db.TblUserSkillSets.Remove(skill);
                            }
                        }

                        _userRep.Delete(tblUser);

                        await _db.SaveChangesAsync();

                        transaction.Commit();

                        return new BaseResponseModel(ResponseStatusEnum.OK, ResponseStatusEnum.OK.ToString());
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return new BaseResponseModel(ResponseStatusEnum.ErrorSystem, ex.Message + " \n" + ex.StackTrace);
                    }
                }
            }
            catch (Exception ex)
            {
                return new BaseResponseModel(ResponseStatusEnum.ErrorSystem, ex.Message + " \n" + ex.StackTrace);
            }
        }

        private async Task<BaseResponseModel> CheckValid(UserCreateRequestModel model)
        {
            try
            {
                if(!model.Name.IsNotEmpty())
                {
                    return new BaseResponseModel(ResponseStatusEnum.Error, ResponseErrorMsgEnum.FORMS_NAME_EMPTY.ToString());
                }

                if (!model.Email.IsNotEmpty())
                {
                    return new BaseResponseModel(ResponseStatusEnum.Error, ResponseErrorMsgEnum.FORMS_EMAIL_EMPTY.ToString());
                }

                if (!model.PhoneNo.IsNotEmpty())
                {
                    return new BaseResponseModel(ResponseStatusEnum.Error, ResponseErrorMsgEnum.FORMS_PHONE_EMPTY.ToString());
                }

                if (!model.Email.IsEmail())
                {
                    return new BaseResponseModel(ResponseStatusEnum.Error, ResponseErrorMsgEnum.INVALID_EMAIL_FORMAT.ToString());
                }

                var result = await _userRep.GetByCondition(p => p.PhoneNo == model.PhoneNo);
                if (result != null)
                {
                    return new BaseResponseModel(ResponseStatusEnum.Error, ResponseErrorMsgEnum.PHONE_EXIST.ToString());
                }

                result = await _userRep.GetByCondition(p => p.Email == model.Email);
                if (result != null)
                {
                    return new BaseResponseModel(ResponseStatusEnum.Error, ResponseErrorMsgEnum.EMAIL_EXIST.ToString());
                }


                return new BaseResponseModel(ResponseStatusEnum.OK, ResponseStatusEnum.OK.ToString());
            }
            catch (Exception ex)
            {
                return new BaseResponseModel(ResponseStatusEnum.ErrorSystem, ex.Message + " \n" + ex.StackTrace, null);
            }
        }

    }
}
