namespace FreelancersModel.Entity
{
    public interface IEntity
    {
        long ID { get; set; }

        string CreateBy { get; set; }

        DateTime CreateDate { get; set; }

        string ModifiedBy { get; set; }

        DateTime ModifiedDate { get; set; }
    }
}
