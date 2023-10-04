﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestLinux.Models;

namespace TestLinux.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20211231013753_InspectionVS")]
    partial class InspectionVS
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("TestLinux.AttendanceProfie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Attendance")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ForDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LatLong")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("MarkDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("TestLinux.BranchMaster", b =>
                {
                    b.Property<string>("BrCode")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("BrCode");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("TestLinux.CSPVisit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CSPId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ClosureDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ClosureOfficialId")
                        .HasColumnType("longtext");

                    b.Property<string>("Location_lat")
                        .HasColumnType("longtext");

                    b.Property<string>("Location_long")
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("SystemLogDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("VisitRemarks")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("CSPVisits");
                });

            modelBuilder.Entity("TestLinux.Csp", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("BrCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CSPName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CorporateAgency")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Csps");
                });

            modelBuilder.Entity("TestLinux.DeafData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cust_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Deafs");
                });

            modelBuilder.Entity("TestLinux.EmployeeMaster", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("BranchCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Scale")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("EmployeeMasters");
                });

            modelBuilder.Entity("TestLinux.Grievance", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("longtext");

                    b.Property<float>("AmountInvolved")
                        .HasColumnType("float");

                    b.Property<string>("ApplicantName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("BrReplyDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("BrReplyId")
                        .HasColumnType("longtext");

                    b.Property<string>("Branch")
                        .HasColumnType("longtext");

                    b.Property<string>("CheckerReply")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CheckerReplyDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CheckerReplyId")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ClosureDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Complaint")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DigitalTxn")
                        .HasColumnType("longtext");

                    b.Property<string>("District")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("HOReply")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("HOReplyDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("HOReplyId")
                        .HasColumnType("longtext");

                    b.Property<string>("InternalReply")
                        .HasColumnType("longtext");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("RO")
                        .HasColumnType("longtext");

                    b.Property<string>("ROReply")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ROReplyDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ROReplyId")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Reply")
                        .HasColumnType("longtext");

                    b.Property<string>("Segment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("TransactionDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Grievances");
                });

            modelBuilder.Entity("TestLinux.LearningData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Learnings");
                });

            modelBuilder.Entity("TestLinux.Logs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("LogDateTime")
                        .HasColumnType("longtext");

                    b.Property<string>("Remarks")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("TestLinux.OTP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Application")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("IsUsed")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OTPValue")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("OTPs");
                });

            modelBuilder.Entity("TestLinux.PostInspection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ClosureDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ClosureOfficialId")
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("SystemLogDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("VisitRemarks")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PostInspections");
                });

            modelBuilder.Entity("TestLinux.PreInspection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ApplicationId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ClosureDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ClosureOfficialId")
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("SystemLogDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("VisitRemarks")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PreInspection");
                });

            modelBuilder.Entity("TestLinux.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RegionalOffice")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TestLinux.UserProfile", b =>
                {
                    b.Property<string>("MobileNumber")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Posting")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MobileNumber");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("TestLinux.ValueStatement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("InputType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Statement")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ValueStatement");
                });

            modelBuilder.Entity("TestLinux.VisitRemark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("RemarksVerifyingOfficial")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RemarksVisitingOfficial")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ValueStatementId")
                        .HasColumnType("int");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VisitRemark");
                });
#pragma warning restore 612, 618
        }
    }
}
