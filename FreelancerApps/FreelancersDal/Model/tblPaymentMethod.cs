using HotelLiveModel.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLiveDAL.Model
{
    /// <summary>
    /// Author : Kelvin
    /// </summary>
    [Table("payment_method")]
    public class TblPaymentMethod : MySqlEntity
    {
        [Column(TypeName = "smallint(6)")]
        public long ShopID { get; set; }
        
        public PaymentTypeEnum PaymentMethod { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Description { get; set; }
        
        public bool Status { get; set; }

        [Column("CreateBy", TypeName = "varchar(20)")]
        public override string CreateBy { get; set; }

        [Column("CreateDate", TypeName = "DateTime")]
        public override DateTime CreateDate { get; set; }

        [Column("ModifiedBy", TypeName = "varchar(20)")]
        public override string ModifiedBy { get; set; }

        [Column("ModifiedDate", TypeName = "DateTime")]
        public override DateTime ModifiedDate { get; set; }

    }
}
