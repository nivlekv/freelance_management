namespace FreelancersModel.Enum
{
    public enum ResponseStatusEnum
    {
        [Display(Name ="Unauthorize")]
        Unauthorize   = 401,
        [Display(Name = "OK")]
        OK            = 200,
        [Display(Name = "Created")]
        Created       = 201,
        [Display(Name = "Server Error")]
        Error         = 500,
        [Display(Name = "System Error")]
        ErrorSystem   = 505        
    }

    public enum ResponseMessageEnum
    {
        Admin_Create_Success,
        Admin_Create_Failed,
        Admin_Update_Success,
        Admin_Update_Failed,
        Admin_Group_Create_Success,
        Admin_Group_Create_Failed,
        Admin_Group_Update_Success,
        Admin_Group_Update_Failed,
        Agreement_Create_Success,
        Agreement_Create_Failed,
        Agreement_Update_Success,
        Agreement_Update_Failed,
        Change_Password_Success,
        Change_Password_Failed,
        Reset_Password_Success,
        Reset_Password_Failed,
        Translate_Submit_Success,
        Translate_Refresh_Success,
        Member_Create_Success,
        Member_Create_Failed,
        Member_Update_Success,
        Member_Update_Failed,
        Member_Topup_Success,
        Member_Topup_Failed,
        Data_Create_Success,
        Data_Create_Failed,
        Data_Update_Success,
        Data_Update_Failed,
        Package_Create_Success,
        Package_Create_Failed,
        Package_Update_Success,
        Package_Update_Failed,
        Massauer_Create_Success,
        Massauer_Create_Failed,
        Massauer_Update_Success,
        Massauer_Update_Failed,
        Product_Create_Success,
        Product_Create_Failed,
        Product_Update_Success,
        Product_Update_Failed,
        RoomCategory_Create_Success,
        RoomCategory_Create_Failed,
        RoomCategory_Update_Success,
        RoomCategory_Update_Failed,
        Room_Create_Success,
        Room_Create_Failed,
        Room_Update_Success,
        Room_Update_Failed,
        Booking_Create_Success,
        Booking_Create_Failed,
        Booking_Update_Success,
        Booking_Update_Failed,
        Booking_End_Registered,
        Expenses_Create_Success,
        Expenses_Create_Failed,
        Expenses_Update_Success,
        Expenses_Update_Failed,
        TopupPlan_Create_Success,
        TopupPlan_Create_Failed,
        TopupPlan_Update_Success,
        TopupPlan_Update_Failed,
    }

    public enum ResponseMessageTypeEnum
    {
        Success,
        Error
    }
}
