﻿// <auto-generated />
using System;
using AsdafObhurRealEstate.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AsdafObhurRealEstate.Migrations
{
    [DbContext(typeof(AsdafObhurContext))]
    [Migration("20220828130340_UpdateNumber")]
    partial class UpdateNumber
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            ConcurrencyStamp = "a564f90a-519c-4498-9b7d-7ee76f1530eb",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            Email = "ceo-foad@asdaf-aom.com",
                            EmailConfirmed = true,
                            FirstName = "فؤاد",
                            LastName = "الغامدي",
                            LockoutEnabled = false,
                            NormalizedEmail = "CEO-FOAD@ASDAF-AOM.COM",
                            NormalizedUserName = "CEO-FOAD@ASDAF-AOM.COM",
                            PasswordHash = "ALSQVebTiIYVs22s7f9V5Omv83ldJzAMnqhPBPEwJ/pnvrCe48glZ6uig7tEr2dchQ==",
                            PhoneNumber = "966565523432",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "91da3ca4-cf6a-4f0b-8bd9-444927915fb6",
                            TwoFactorEnabled = false,
                            UserName = "ceo-foad@asdaf-aom.com"
                        },
                        new
                        {
                            Id = "b0157647-7016-41cc-9a56-3695acaa13e6",
                            AccessFailedCount = 0,
                            AccountType = 2,
                            Code = 2,
                            ConcurrencyStamp = "dd4480c9-d734-44fc-a196-fe3d0e508b0c",
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
                            PasswordHash = "ADDH2DgkWmSTF3SedEqfFFgzXsv6fWK3hpuaX91w7nLlgiQJWLNJ5wePRRC4kUDwtg==",
                            PhoneNumber = "966554331959",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "d61d65a0-4852-4a6b-ba9f-36ae4a959446",
                            TwoFactorEnabled = false,
                            UserName = "Muhannad@Asdaf-aom.com"
                        },
                        new
                        {
                            Id = "zeaf5d3d-a7f3-4751-8ae5-724e07889bd6",
                            AccessFailedCount = 0,
                            AccountType = 2,
                            Code = 9,
                            ConcurrencyStamp = "8aad24fa-d459-4266-9e7a-7a13f2c843c9",
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
                            PasswordHash = "AH/arIkilk+SynMuk8f/DnUnls+2noG2oAueGTf+L2H66w94wLTmjRXSwcup7gvGsg==",
                            PhoneNumber = "966556567826",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "67818b41-3b0f-4898-90ea-f6e92a26ce60",
                            TwoFactorEnabled = false,
                            UserName = "sadek@asdaf-aom.com"
                        },
                        new
                        {
                            Id = "zeaf5d3d-a7f3-4751-8ae5-724e07359bd6",
                            AccessFailedCount = 0,
                            AccountType = 2,
                            Code = 10,
                            ConcurrencyStamp = "81417cca-0ffe-41a3-a26c-dba95e5c632a",
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
                            PasswordHash = "ABjipXI119S6ZbPb05wAoEknOGH5mZPg3f4k4Cp18tp/6f3FevSNvO5lgo29fg14mQ==",
                            PhoneNumber = "966556986415",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "dac3e9f3-0a99-48be-8869-6b0f0ad160e0",
                            TwoFactorEnabled = false,
                            UserName = "khalil@asdaf-aom.com"
                        },
                        new
                        {
                            Id = "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                            AccessFailedCount = 0,
                            AccountType = 3,
                            Code = 3,
                            ConcurrencyStamp = "34e0fb4d-fe20-4203-ab25-c7234ec3881f",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            Email = "Ghadeer.Sec@Asdaf-aom.com",
                            EmailConfirmed = true,
                            FirstName = "غدير",
                            LastName = "ابو داود",
                            LockoutEnabled = false,
                            NormalizedEmail = "GHADEER.SEC@ASDAF-AOM.COM",
                            NormalizedUserName = "GHADEER.SEC@ASDAF-AOM.COM",
                            PasswordHash = "AJ11FgtW1FlL//fzPhXU0Ztbpd4rGfDM8IcCaP/1PzEnb186bMm2lDiJ7Fu4O+cJ6A==",
                            PhoneNumber = "966544113770",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "a25e74d4-ba83-4532-9c2b-ebd5c5552859",
                            TwoFactorEnabled = false,
                            UserName = "Ghadeer.Sec@Asdaf-aom.com"
                        },
                        new
                        {
                            Id = "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                            AccessFailedCount = 0,
                            AccountType = 5,
                            Code = 5,
                            ConcurrencyStamp = "55535518-2251-4ee5-a91f-adec22dc60bf",
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
                            PasswordHash = "ADWwuxI0BJbtQf4wXaEVtfEWtMc1haszFQ1FoZzMp9DJuFCnuGnPC7lVs1gDQTEjYQ==",
                            PhoneNumber = "966506278000",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "f49c86d8-47af-446a-9525-3d223fd411e5",
                            TwoFactorEnabled = false,
                            UserName = "Turki@Asdaf-aom.com"
                        },
                        new
                        {
                            Id = "zeaf5d3d-a7f3-3081-8ae5-724e07359bd6",
                            AccessFailedCount = 0,
                            AccountType = 5,
                            Code = 11,
                            ConcurrencyStamp = "3abc566f-5542-4339-b63b-302a2105aeba",
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
                            PasswordHash = "AKPvSyZEn48ig7KvOH6Jtkf4O/XB2gKDUvK8ngNDRz6crDmNK66kK8BM4XOxcddKxw==",
                            PhoneNumber = "966505798800",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "93d50215-174b-42ff-b5a8-e7e937c985ba",
                            TwoFactorEnabled = false,
                            UserName = "Amal@Asdaf-aom.com"
                        },
                        new
                        {
                            Id = "x313a786-637d-40c5-8715-543bba115487",
                            AccessFailedCount = 0,
                            AccountType = 7,
                            Code = 7,
                            ConcurrencyStamp = "f926ef21-c022-47ea-b657-0989d3262fe9",
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
                            PasswordHash = "AO4lfpQ2d13Pw+bki+XycxlMD4ZiZxHxhOSH6CkJay5SiHKIKyULrxSp45MR0OWDyg==",
                            PhoneNumber = "966547027990",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "58f1634f-6e5c-48ca-99f7-324783d2f90d",
                            TwoFactorEnabled = false,
                            UserName = "hossam@asdaf-aom.com"
                        },
                        new
                        {
                            Id = "zeaf5d3d-a6b3-3081-8ae5-724e07359bd6",
                            AccessFailedCount = 0,
                            AccountType = 7,
                            Code = 12,
                            ConcurrencyStamp = "6a4596de-f356-4362-841f-86ef1217b6cc",
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
                            PasswordHash = "ANe5YXzH2PIiyu7bOxBVi32sqa/eQxkd9XkRHwmrtSCyLJz6nl/Y+RkV3lQMgMtKiQ==",
                            PhoneNumber = "966549810302",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "b8d1d402-c319-46b0-b177-660cb469d92a",
                            TwoFactorEnabled = false,
                            UserName = "Eng.mansour@asdaf-aom.com"
                        },
                        new
                        {
                            Id = "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                            AccessFailedCount = 0,
                            AccountType = 8,
                            Code = 8,
                            ConcurrencyStamp = "1030861f-6c07-49c5-8cfa-5a6b9b6ae26b",
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
                            PasswordHash = "AHppaQf2LBHOEC041QH5NRVuu4NAoe6eWe/0tqkvMjWILpB0X8wj6KhJt4NW9vXqtA==",
                            PhoneNumber = "966567791554",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "0e32f0da-36d9-436f-9f83-f96d98ce83d5",
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