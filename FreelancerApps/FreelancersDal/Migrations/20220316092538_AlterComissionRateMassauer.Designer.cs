﻿// <auto-generated />
using System;
using HotelLiveDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelLiveDAL.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20220316092538_AlterComissionRateMassauer")]
    partial class AlterComissionRateMassauer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("HotelLiveDAL.Model.TblAccessRights", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT(20)");

                    b.Property<string>("Action")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Area")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Controller")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnName("CreateDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Locale")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnName("ModifiedBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnName("ModifiedDate")
                        .HasColumnType("DateTime");

                    b.HasKey("ID");

                    b.ToTable("access_rights");
                });

            modelBuilder.Entity("HotelLiveDAL.Model.TblAdmin", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT(20)");

                    b.Property<string>("ContactNo")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnName("CreateDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("DefaultLanguage")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(200)");

                    b.Property<long>("GroupId")
                        .HasColumnType("BIGINT(20)");

                    b.Property<DateTime>("LastLoginDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastLoginIP")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnName("ModifiedBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnName("ModifiedDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Password")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Picture")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Remark")
                        .HasColumnType("varchar(255)");

                    b.Property<short>("ShopID")
                        .HasColumnType("smallint(6)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Username")
                        .HasColumnType("varchar(20)");

                    b.HasKey("ID");

                    b.HasIndex("GroupId");

                    b.ToTable("admin");
                });

            modelBuilder.Entity("HotelLiveDAL.Model.TblAdminAccessRights", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT(20)");

                    b.Property<long>("AccessRightsID")
                        .HasColumnType("BIGINT(20)");

                    b.Property<long>("AdminGroupID")
                        .HasColumnType("BIGINT(20)");

                    b.Property<string>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnName("CreateDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("ModifiedBy")
                        .HasColumnName("ModifiedBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnName("ModifiedDate")
                        .HasColumnType("DateTime");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ID");

                    b.HasIndex("AccessRightsID");

                    b.HasIndex("AdminGroupID");

                    b.ToTable("admin_access_rights");
                });

            modelBuilder.Entity("HotelLiveDAL.Model.TblAdminGroup", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT(20)");

                    b.Property<string>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnName("CreateDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("GroupName")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnName("ModifiedBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnName("ModifiedDate")
                        .HasColumnType("DateTime");

                    b.Property<short>("ShopID")
                        .HasColumnType("smallint(6)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ID");

                    b.ToTable("admin_group");
                });

            modelBuilder.Entity("HotelLiveDAL.Model.TblAdminLog", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT(20)");

                    b.Property<short>("Action")
                        .HasColumnType("smallint(6)");

                    b.Property<string>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnName("CreateDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("IpAddress")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("ModelString")
                        .HasColumnType("text");

                    b.Property<string>("ModifiedBy")
                        .HasColumnName("ModifiedBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnName("ModifiedDate")
                        .HasColumnType("DateTime");

                    b.Property<short>("ShopID")
                        .HasColumnType("smallint(6)");

                    b.Property<string>("Username")
                        .HasColumnType("varchar(20)");

                    b.HasKey("ID");

                    b.ToTable("admin_log");
                });

            modelBuilder.Entity("HotelLiveDAL.Model.TblBooking", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT(20)");

                    b.Property<int>("BookingType")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Comission")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("ComissionRate")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnName("CreateDate")
                        .HasColumnType("DateTime");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("DiscountPercent")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int>("Duration")
                        .HasColumnType("int(11)");

                    b.Property<decimal>("GrandTotal")
                        .HasColumnType("decimal(10,2)");

                    b.Property<long>("MassauersID")
                        .HasColumnType("BIGINT(20)");

                    b.Property<long>("MemberID")
                        .HasColumnType("BIGINT(20)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnName("ModifiedBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnName("ModifiedDate")
                        .HasColumnType("DateTime");

                    b.Property<long>("PackageID")
                        .HasColumnType("BIGINT(20)");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<short>("ShopID")
                        .HasColumnType("smallint(6)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MassauersID");

                    b.HasIndex("MemberID");

                    b.HasIndex("PackageID");

                    b.ToTable("booking");
                });

            modelBuilder.Entity("HotelLiveDAL.Model.TblConfig", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT(20)");

                    b.Property<string>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnName("CreateDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("ModifiedBy")
                        .HasColumnName("ModifiedBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnName("ModifiedDate")
                        .HasColumnType("DateTime");

                    b.HasKey("ID");

                    b.ToTable("config");
                });

            modelBuilder.Entity("HotelLiveDAL.Model.TblExpenses", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT(20)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnName("CreateDate")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("ExpensesDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ExpensesType")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnName("ModifiedBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnName("ModifiedDate")
                        .HasColumnType("DateTime");

                    b.Property<short>("ShopID")
                        .HasColumnType("smallint(6)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ID");

                    b.ToTable("expenses");
                });

            modelBuilder.Entity("HotelLiveDAL.Model.TblMassauer", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT(20)");

                    b.Property<string>("Address")
                        .HasColumnType("varchar(150)");

                    b.Property<int>("BonusType")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckupDate")
                        .HasColumnType("datetime");

                    b.Property<decimal>("ComissionRate")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("ComissionRateBooked")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("ComissionRateOther")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("ComissionRateOtherBooked")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("ComissionType")
                        .HasColumnType("int");

                    b.Property<string>("ContactNo")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnName("CreateDate")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("DateJoin")
                        .HasColumnType("datetime");

                    b.Property<string>("FinNo")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("MassauerCode")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("MassauerName")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnName("ModifiedBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnName("ModifiedDate")
                        .HasColumnType("DateTime");

                    b.Property<short>("Priority")
                        .HasColumnType("smallint(6)");

                    b.Property<string>("Remark")
                        .HasColumnType("varchar(255)");

                    b.Property<short>("ShopID")
                        .HasColumnType("smallint(6)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ID");

                    b.ToTable("massauer");
                });

            modelBuilder.Entity("HotelLiveDAL.Model.TblMember", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT(20)");

                    b.Property<string>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnName("CreateDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("ICNo")
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("LastCheckInDate")
                        .HasColumnType("datetime");

                    b.Property<int>("MemberType")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .HasColumnName("ModifiedBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnName("ModifiedDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nationality")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("varchar(30)");

                    b.Property<short>("ShopID")
                        .HasColumnType("smallint(6)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("member");
                });

            modelBuilder.Entity("HotelLiveDAL.Model.TblMemberLog", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT(20)");

                    b.Property<short>("Action")
                        .HasColumnType("smallint(6)");

                    b.Property<string>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnName("CreateDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("IpAddress")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("ModelString")
                        .HasColumnType("text");

                    b.Property<string>("ModifiedBy")
                        .HasColumnName("ModifiedBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnName("ModifiedDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("Username")
                        .HasColumnType("varchar(20)");

                    b.HasKey("ID");

                    b.ToTable("member_log");
                });

            modelBuilder.Entity("HotelLiveDAL.Model.TblPackage", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT(20)");

                    b.Property<string>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnName("CreateDate")
                        .HasColumnType("DateTime");

                    b.Property<short>("Duration")
                        .HasColumnType("smallint(6)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnName("ModifiedBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnName("ModifiedDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("PackageName")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("PackageType")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Remark")
                        .HasColumnType("varchar(255)");

                    b.Property<short>("ShopID")
                        .HasColumnType("smallint(6)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ID");

                    b.ToTable("package");
                });

            modelBuilder.Entity("HotelLiveDAL.Model.TblSystemDocNumber", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIGINT(20)");

                    b.Property<string>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnName("CreateDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("DocCode")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("FieldName")
                        .HasColumnType("varchar(25)");

                    b.Property<bool>("LeadZero")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("LeadingZero")
                        .HasColumnType("int(11)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnName("ModifiedBy")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnName("ModifiedDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("Prefix")
                        .HasColumnType("varchar(10)");

                    b.Property<int>("RunningNumber")
                        .HasColumnType("int(11)");

                    b.Property<short>("ShopID")
                        .HasColumnType("smallint(6)");

                    b.Property<string>("TableName")
                        .HasColumnType("varchar(25)");

                    b.HasKey("ID");

                    b.ToTable("system_docnumbering");
                });

            modelBuilder.Entity("HotelLiveDAL.Model.TblAdmin", b =>
                {
                    b.HasOne("HotelLiveDAL.Model.TblAdminGroup", "TblAdminGroup")
                        .WithMany("TblAdmins")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HotelLiveDAL.Model.TblAdminAccessRights", b =>
                {
                    b.HasOne("HotelLiveDAL.Model.TblAccessRights", "TblAccessRightss")
                        .WithMany()
                        .HasForeignKey("AccessRightsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelLiveDAL.Model.TblAdminGroup", "TblAdminGroups")
                        .WithMany("TblAdminAccessRightss")
                        .HasForeignKey("AdminGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HotelLiveDAL.Model.TblBooking", b =>
                {
                    b.HasOne("HotelLiveDAL.Model.TblMassauer", "TblMassauers")
                        .WithMany()
                        .HasForeignKey("MassauersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelLiveDAL.Model.TblMember", "TblMembers")
                        .WithMany("TblBookings")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelLiveDAL.Model.TblPackage", "TblPackages")
                        .WithMany()
                        .HasForeignKey("PackageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
