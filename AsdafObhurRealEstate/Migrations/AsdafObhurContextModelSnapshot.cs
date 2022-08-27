﻿// <auto-generated />
using System;
using AsdafObhurRealEstate.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AsdafObhurRealEstate.Migrations
{
    [DbContext(typeof(AsdafObhurContext))]
    partial class AsdafObhurContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AsdafObhurRealEstate.Models.BaseUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<int>("AccountType")
                        .HasColumnType("integer");

                    b.Property<int>("Code")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("DepartmentId")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("ProfilePic")
                        .HasColumnType("text");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            AccessFailedCount = 0,
                            AccountType = 1,
                            Code = 1,
                            ConcurrencyStamp = "923eb281-3fbd-45eb-b483-1438ae525397",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            Email = "ceo-foad@asdaf-aom.com",
                            EmailConfirmed = true,
                            FirstName = "فؤاد",
                            LastName = "الغامدي",
                            LockoutEnabled = false,
                            NormalizedEmail = "CEO-FOAD@ASDAF-AOM.COM",
                            NormalizedUserName = "CEO-FOAD@ASDAF-AOM.COM",
                            PasswordHash = "AOmyApFerYSAc94gyt5yn1i6bHxnr1fsYc8rTKSY4aBSJFYuZUtisNcHPzpQAgpGWQ==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "e150c682-7680-4c27-b2ab-7a03b1fc45c1",
                            TwoFactorEnabled = false,
                            UserName = "ceo-foad@asdaf-aom.com"
                        },
                        new
                        {
                            Id = "b0157647-7016-41cc-9a56-3695acaa13e6",
                            AccessFailedCount = 0,
                            AccountType = 2,
                            Code = 2,
                            ConcurrencyStamp = "002cd0aa-a5aa-41a7-9a52-30970b2b7491",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            DepartmentId = "f0157647-7016-41cc-9a56-3695acaa13e6",
                            Email = "Muhannad@Asdaf-aom.com",
                            EmailConfirmed = true,
                            FirstName = "مهند",
                            LastName = "حريري",
                            LockoutEnabled = false,
                            NormalizedEmail = "MUHANNAD@ASDAF-AOM.COM",
                            NormalizedUserName = "MUHANNAD@ASDAF-AOM.COM",
                            PasswordHash = "ACmaDVJSkVIGy2H7r94Nyckc+r8GJYRYphN/Ho1Ht1G6OndYRvXGJdSWtTtdXsQ2OQ==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "b2bb8a4e-dc6e-4eea-81cd-7dcaac54dcf0",
                            TwoFactorEnabled = false,
                            UserName = "Muhannad@Asdaf-aom.com"
                        },
                        new
                        {
                            Id = "zeaf5d3d-a7f3-4751-8ae5-724e07889bd6",
                            AccessFailedCount = 0,
                            AccountType = 2,
                            Code = 9,
                            ConcurrencyStamp = "eef07a36-d1cf-4314-8a86-6947c72c2e77",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            DepartmentId = "f0157647-7016-41cc-9a56-3695acaa13e6",
                            Email = "sadek@asdaf-aom.com",
                            EmailConfirmed = true,
                            FirstName = "صادق",
                            LastName = "الأبيض",
                            LockoutEnabled = false,
                            NormalizedEmail = "SADEK@ASDAF-AOM.COM",
                            NormalizedUserName = "SADEK@ASDAF-AOM.COM",
                            PasswordHash = "ALAyPalC8nes/W9YCj23EmTJbshiPP6mb9NCOyFkQvGCMJY8eTEqjTDSiFnY3rwj1w==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "5e86db92-e6aa-4e6d-a3d1-9cbe64e028c8",
                            TwoFactorEnabled = false,
                            UserName = "sadek@asdaf-aom.com"
                        },
                        new
                        {
                            Id = "zeaf5d3d-a7f3-4751-8ae5-724e07359bd6",
                            AccessFailedCount = 0,
                            AccountType = 2,
                            Code = 10,
                            ConcurrencyStamp = "70beee77-0a08-4af9-b17e-5e70bf33e333",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            DepartmentId = "f0157647-7016-41cc-9a56-3695acaa13e6",
                            Email = "khalil@asdaf-aom.com",
                            EmailConfirmed = true,
                            FirstName = "خليل",
                            LastName = "محمد",
                            LockoutEnabled = false,
                            NormalizedEmail = "KHALIL@ASDAF-AOM.COM",
                            NormalizedUserName = "KHALIL@ASDAF-AOM.COM",
                            PasswordHash = "ACR3igMKvCVfDi/SiCFtdYcv/nMW4ayL4Jes+ipdjdjeifSeQdiPghaMq1hvcXc/qw==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "b9837065-0905-46d9-ac7a-a1791e1203fa",
                            TwoFactorEnabled = false,
                            UserName = "khalil@asdaf-aom.com"
                        },
                        new
                        {
                            Id = "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                            AccessFailedCount = 0,
                            AccountType = 3,
                            Code = 3,
                            ConcurrencyStamp = "793869dc-6509-472d-a5a3-2c8d46d1e3c8",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            Email = "Ghadeer.Sec@Asdaf-aom.com",
                            EmailConfirmed = true,
                            FirstName = "غدير",
                            LastName = "ابو داود",
                            LockoutEnabled = false,
                            NormalizedEmail = "GHADEER.SEC@ASDAF-AOM.COM",
                            NormalizedUserName = "GHADEER.SEC@ASDAF-AOM.COM",
                            PasswordHash = "AMeUeE99E8cPzuesH0/5Ck7E/ijdZwR8ipbZsKS1U/hDc0ygjTaWN4Jlyx6a/wYnWQ==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "f356e1e1-8f59-41e7-b4ee-d2488e005bbf",
                            TwoFactorEnabled = false,
                            UserName = "Ghadeer.Sec@Asdaf-aom.com"
                        },
                        new
                        {
                            Id = "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                            AccessFailedCount = 0,
                            AccountType = 5,
                            Code = 5,
                            ConcurrencyStamp = "18a7e417-02bf-4031-ba72-653238563f37",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            DepartmentId = "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                            Email = "Turki@Asdaf-aom.com",
                            EmailConfirmed = true,
                            FirstName = "تركي",
                            LastName = "العصلاني",
                            LockoutEnabled = false,
                            NormalizedEmail = "TURKI@ASDAF-AOM.COM",
                            NormalizedUserName = "TURKI@ASDAF-AOM.COM",
                            PasswordHash = "AHDJ0yYhq5yVW2SFpkVU88XYRYUwYF7zaIH7qTIeTMeF7Jb2flkY+jCzwKQeSyvLbg==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "1124f8aa-308b-486a-9be8-18a988a7d8e2",
                            TwoFactorEnabled = false,
                            UserName = "Turki@Asdaf-aom.com"
                        },
                        new
                        {
                            Id = "zeaf5d3d-a7f3-3081-8ae5-724e07359bd6",
                            AccessFailedCount = 0,
                            AccountType = 5,
                            Code = 11,
                            ConcurrencyStamp = "a2c42d3f-e2cf-4430-83cc-b6d4c46a0772",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            DepartmentId = "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                            Email = "Amal@Asdaf-aom.com",
                            EmailConfirmed = true,
                            FirstName = "أمل",
                            LastName = "الشريف",
                            LockoutEnabled = false,
                            NormalizedEmail = "AMAL@ASDAF-AOM.COM",
                            NormalizedUserName = "AMAL@ASDAF-AOM.COM",
                            PasswordHash = "ABCr/AmPagi7aqYjs3nA4TlaVMCOv3WIrsCYZJ6JqMx9BwVtjqpf7e20dUKzSEuPuA==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "7bbf403e-aeb1-456b-872b-9f62402341d5",
                            TwoFactorEnabled = false,
                            UserName = "Amal@Asdaf-aom.com"
                        },
                        new
                        {
                            Id = "x313a786-637d-40c5-8715-543bba115487",
                            AccessFailedCount = 0,
                            AccountType = 7,
                            Code = 7,
                            ConcurrencyStamp = "cfab2d7f-a7e8-4152-bcee-8289cc0ce018",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            DepartmentId = "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                            Email = "hossam@asdaf-aom.com",
                            EmailConfirmed = true,
                            FirstName = "حسام",
                            LastName = "الديني",
                            LockoutEnabled = false,
                            NormalizedEmail = "HOSSAM@ASDAF-AOM.COM",
                            NormalizedUserName = "HOSSAM@ASDAF-AOM.COM",
                            PasswordHash = "AJLfZZgUFWnkfEsWkFcILxFTz56QM9gUMauef4N5vYeSXm4KC20HtSsog32lCjk1AQ==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "f1db2c77-096a-4d1c-9890-f583ad796e66",
                            TwoFactorEnabled = false,
                            UserName = "hossam@asdaf-aom.com"
                        },
                        new
                        {
                            Id = "zeaf5d3d-a6b3-3081-8ae5-724e07359bd6",
                            AccessFailedCount = 0,
                            AccountType = 7,
                            Code = 12,
                            ConcurrencyStamp = "23a5f5bd-d45f-45e0-89c7-a8b2f28c61d0",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            DepartmentId = "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                            Email = "Eng.mansour@asdaf-aom.com",
                            EmailConfirmed = true,
                            FirstName = "منصور",
                            LastName = "الأحمدي",
                            LockoutEnabled = false,
                            NormalizedEmail = "ENG.MANSOUR@ASDAF-AOM.COM",
                            NormalizedUserName = "ENG.MANSOUR@ASDAF-AOM.COM",
                            PasswordHash = "AGz5I3B+BwPzXWDOzVX2OhRCT1n3FaQp3GG7ZbZg4TQ/spI84AhlCO1MN0mOujFBHg==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "d56776f8-69bc-43d2-8c86-b83b3a22f399",
                            TwoFactorEnabled = false,
                            UserName = "Eng.mansour@asdaf-aom.com"
                        },
                        new
                        {
                            Id = "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                            AccessFailedCount = 0,
                            AccountType = 8,
                            Code = 8,
                            ConcurrencyStamp = "6a6c578f-a3ef-445c-8e18-3e89e15184e1",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            DepartmentId = "62fe29f0-c227-4a03-b2f6-z97279b2bc23",
                            Email = "Marwa@Asdaf-aom.com",
                            EmailConfirmed = true,
                            FirstName = "مروة",
                            LastName = "عبد العاطي",
                            LockoutEnabled = false,
                            NormalizedEmail = "MARWA@ASDAF-AOM.COM",
                            NormalizedUserName = "MARWA@ASDAF-AOM.COM",
                            PasswordHash = "ACZdoqytOSrKeluQwouZ7ZX6pL3OVneqvGzJR68go5+sHDU6TKFEf6q1ulr6NMw4bg==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "ea154124-36d0-4af0-bd08-e938684caff1",
                            TwoFactorEnabled = false,
                            UserName = "Marwa@Asdaf-aom.com"
                        });
                });

            modelBuilder.Entity("AsdafObhurRealEstate.Models.Client", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("BaseUserId")
                        .HasColumnType("text");

                    b.Property<string>("BillsFile")
                        .HasColumnType("text");

                    b.Property<string>("ClientName")
                        .HasColumnType("text");

                    b.Property<int>("ClientStatus")
                        .HasColumnType("integer");

                    b.Property<int>("Code")
                        .HasColumnType("integer");

                    b.Property<int>("CodeNumber")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("CustomerNeeded")
                        .HasColumnType("text");

                    b.Property<string>("DepartmentId")
                        .HasColumnType("text");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("SendFirstMessageToClient")
                        .HasColumnType("boolean");

                    b.Property<bool>("SendSecondMessageToClient")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("BaseUserId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("AsdafObhurRealEstate.Models.Department", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            ModifiedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            Name = "الديكور",
                            UpdatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "f0157647-7016-41cc-9a56-3695acaa13e6",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            ModifiedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            Name = "العقار",
                            UpdatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            ModifiedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            Name = "المقاولات",
                            UpdatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            ModifiedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            Name = "الأعلام و التسويق",
                            UpdatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "62fe29f0-c227-4a03-b2f6-z97279b2bc23",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            ModifiedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            Name = "المالية",
                            UpdatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("AsdafObhurRealEstate.Models.Multimedia", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("ClientId")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Multimedias");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e",
                            ConcurrencyStamp = "d0584e-fcd7-439c-8ae1-f5734664d6f",
                            Name = "GeneralManager",
                            NormalizedName = "GENERALMANAGER"
                        },
                        new
                        {
                            Id = "a0157647-7016-41cc-9a56-8695acaa13e6",
                            ConcurrencyStamp = "d0584e-fcd7-439c-8ae1-f5734666d6f",
                            Name = "ProjectSupervisor",
                            NormalizedName = "PROJECTSUPERVISOR"
                        },
                        new
                        {
                            Id = "d3d0584e-fcd7-439c-8ae1-f5734664d6f4",
                            ConcurrencyStamp = "d0584e-fcd7-439c-9ae1-f5734666d6f",
                            Name = "ExecutiveSecretary",
                            NormalizedName = "EXECUTIVESECRETARY"
                        },
                        new
                        {
                            Id = "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c",
                            ConcurrencyStamp = "d0554e-fcd7-439c-8ae1-f5734666d6f",
                            Name = "Personnel",
                            NormalizedName = "PERSONNEL"
                        },
                        new
                        {
                            Id = "42fe29f0-c227-4a03-b2f6-c97279b2bc23",
                            ConcurrencyStamp = "d0584e-fgd7-439c-8ae1-f5734666d6f",
                            Name = "Marketing",
                            NormalizedName = "MARKETING"
                        },
                        new
                        {
                            Id = "b71282ed-85cf-4f7c-9e05-9b28051d04e4",
                            ConcurrencyStamp = "d3584e-fcd7-439c-8ae1-f5734666d6f",
                            Name = "ProjectMonitor",
                            NormalizedName = "PROJECTMONITOR"
                        },
                        new
                        {
                            Id = "e313a786-637d-40c5-8715-443bba115487",
                            ConcurrencyStamp = "s1584e-fcd7-439c-8ae1-f5734666d6f",
                            Name = "ProjectsEngineer",
                            NormalizedName = "PROJECTSENGINEER"
                        },
                        new
                        {
                            Id = "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6",
                            ConcurrencyStamp = "d0584e-fcd7-439c-8ae1-f5734236d6f",
                            Name = "Financial",
                            NormalizedName = "FINANCIAL"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            RoleId = "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e"
                        },
                        new
                        {
                            UserId = "b0157647-7016-41cc-9a56-3695acaa13e6",
                            RoleId = "a0157647-7016-41cc-9a56-8695acaa13e6"
                        },
                        new
                        {
                            UserId = "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                            RoleId = "d3d0584e-fcd7-439c-8ae1-f5734664d6f4"
                        },
                        new
                        {
                            UserId = "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                            RoleId = "42fe29f0-c227-4a03-b2f6-c97279b2bc23"
                        },
                        new
                        {
                            UserId = "x313a786-637d-40c5-8715-543bba115487",
                            RoleId = "e313a786-637d-40c5-8715-443bba115487"
                        },
                        new
                        {
                            UserId = "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                            RoleId = "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6"
                        },
                        new
                        {
                            UserId = "zeaf5d3d-a7f3-4751-8ae5-724e07889bd6",
                            RoleId = "a0157647-7016-41cc-9a56-8695acaa13e6"
                        },
                        new
                        {
                            UserId = "zeaf5d3d-a7f3-4751-8ae5-724e07359bd6",
                            RoleId = "a0157647-7016-41cc-9a56-8695acaa13e6"
                        },
                        new
                        {
                            UserId = "zeaf5d3d-a7f3-3081-8ae5-724e07359bd6",
                            RoleId = "42fe29f0-c227-4a03-b2f6-c97279b2bc23"
                        },
                        new
                        {
                            UserId = "zeaf5d3d-a6b3-3081-8ae5-724e07359bd6",
                            RoleId = "e313a786-637d-40c5-8715-443bba115487"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AsdafObhurRealEstate.Models.BaseUser", b =>
                {
                    b.HasOne("AsdafObhurRealEstate.Models.Department", "Department")
                        .WithMany("Users")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Department");
                });

            modelBuilder.Entity("AsdafObhurRealEstate.Models.Client", b =>
                {
                    b.HasOne("AsdafObhurRealEstate.Models.BaseUser", "BaseUser")
                        .WithMany()
                        .HasForeignKey("BaseUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AsdafObhurRealEstate.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("BaseUser");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("AsdafObhurRealEstate.Models.Multimedia", b =>
                {
                    b.HasOne("AsdafObhurRealEstate.Models.Client", "Client")
                        .WithMany("Multimedias")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AsdafObhurRealEstate.Models.BaseUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AsdafObhurRealEstate.Models.BaseUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AsdafObhurRealEstate.Models.BaseUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AsdafObhurRealEstate.Models.BaseUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AsdafObhurRealEstate.Models.Client", b =>
                {
                    b.Navigation("Multimedias");
                });

            modelBuilder.Entity("AsdafObhurRealEstate.Models.Department", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
