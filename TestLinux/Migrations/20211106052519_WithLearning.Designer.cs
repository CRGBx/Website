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
    [Migration("20211106052519_WithLearning")]
    partial class WithLearning
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
                        .HasColumnType("varchar(95)");

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

            modelBuilder.Entity("TestLinux.Grievance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("longtext");

                    b.Property<float>("AmountInvolved")
                        .HasColumnType("float");

                    b.Property<string>("ApplicantName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Branch")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ClosureDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Complaint")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DigitalTxn")
                        .HasColumnType("longtext");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("InternalReply")
                        .HasColumnType("longtext");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("RO")
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

            modelBuilder.Entity("TestLinux.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(95)");

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
                        .HasColumnType("varchar(95)");

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
#pragma warning restore 612, 618
        }
    }
}
