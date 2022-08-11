﻿// <auto-generated />
using System;
using AsdafObhurRealEstate.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AsdafObhurRealEstate.Migrations
{
    [DbContext(typeof(AsdafObhurContext))]
    [Migration("20220811132152_addedRelationWithMultimedias")]
    partial class addedRelationWithMultimedias
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AsdafObhurRealEstate.Models.BaseUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("AccountType")
                        .HasColumnType("int");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            AccessFailedCount = 0,
                            AccountType = 1,
                            Code = 0,
                            ConcurrencyStamp = "b1ab4eca-5a35-47fd-b86a-790a5fefca64",
                            CreatedAt = new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4115),
                            CreatedBy = "Developer",
                            Email = "gm@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "المدير",
                            LastName = "العام",
                            LockoutEnabled = false,
                            NormalizedEmail = "GM@GMAIL.COM",
                            NormalizedUserName = "GM@GMAIL.COM",
                            PasswordHash = "ALJpOAcTmGoWtMIFFTGxhLj+AIWjUHUEn15ZIy/49UhLvvsLNTVXTfV8wuwOuA+zjg==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "e1319e15-c8ed-417a-bfa0-7e0b23f44877",
                            TwoFactorEnabled = false,
                            UserName = "gm@gmail.com"
                        },
                        new
                        {
                            Id = "b0157647-7016-41cc-9a56-3695acaa13e6",
                            AccessFailedCount = 0,
                            AccountType = 1,
                            Code = 0,
                            ConcurrencyStamp = "49d33868-5fa4-4967-903d-2ec010766e3e",
                            CreatedAt = new DateTime(2022, 8, 11, 15, 21, 51, 689, DateTimeKind.Local).AddTicks(2369),
                            CreatedBy = "Developer",
                            DepartmentId = "f0157647-7016-41cc-9a56-3695acaa13e6",
                            Email = "ps@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "مشرف",
                            LastName = "مشاريع",
                            LockoutEnabled = false,
                            NormalizedEmail = "PS@GMAIL.COM",
                            NormalizedUserName = "PS@GMAIL.COM",
                            PasswordHash = "AGUazktKFxVs13kWOO5Db1gWXWvw67n9MFU7PTp6vMKGUg7xUPejx72iqFWhsR7ZDw==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "d949dcec-1f33-42e5-884c-98c9055cdae1",
                            TwoFactorEnabled = false,
                            UserName = "ps@gmail.com"
                        },
                        new
                        {
                            Id = "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                            AccessFailedCount = 0,
                            AccountType = 1,
                            Code = 0,
                            ConcurrencyStamp = "3c790b55-27d9-4d40-ba99-2a0674a22906",
                            CreatedAt = new DateTime(2022, 8, 11, 15, 21, 51, 689, DateTimeKind.Local).AddTicks(9891),
                            CreatedBy = "Developer",
                            Email = "es@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "سكرتير",
                            LastName = "التنفيذي",
                            LockoutEnabled = false,
                            NormalizedEmail = "ES@GMAIL.COM",
                            NormalizedUserName = "ES@GMAIL.COM",
                            PasswordHash = "ANIQGskrqSBGVQJdhdFmYmk9X6CJiboNViOWPl+gjhZDgW3kGA0rwZge0g7r4XA1jQ==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "ace4d266-57ea-4f7c-bead-a82a9f4dd7b5",
                            TwoFactorEnabled = false,
                            UserName = "es@gmail.com"
                        },
                        new
                        {
                            Id = "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                            AccessFailedCount = 0,
                            AccountType = 1,
                            Code = 0,
                            ConcurrencyStamp = "5c61c8aa-93c5-4d50-88c8-bfe00a389c81",
                            CreatedAt = new DateTime(2022, 8, 11, 15, 21, 51, 690, DateTimeKind.Local).AddTicks(7883),
                            CreatedBy = "Developer",
                            DepartmentId = "62fe29f0-c227-4a03-b2f6-z97279b2bc23",
                            Email = "p@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "شؤون",
                            LastName = "موظفين",
                            LockoutEnabled = false,
                            NormalizedEmail = "P@GMAIL.COM",
                            NormalizedUserName = "P@GMAIL.COM",
                            PasswordHash = "AER1HKOFX3Sg2XKBogSOroOTf0Hzk6pK/DzxcqLJUPFfIOj9aBroXqOVNDSTwO1zRg==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "eb031d26-2a4a-4f59-92ed-af3eaf159c0e",
                            TwoFactorEnabled = false,
                            UserName = "p@gmail.com"
                        },
                        new
                        {
                            Id = "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                            AccessFailedCount = 0,
                            AccountType = 1,
                            Code = 0,
                            ConcurrencyStamp = "51eea0bf-815e-48ed-9eea-a28ceace77c9",
                            CreatedAt = new DateTime(2022, 8, 11, 15, 21, 51, 691, DateTimeKind.Local).AddTicks(9852),
                            CreatedBy = "Developer",
                            DepartmentId = "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                            Email = "m@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "تسويق",
                            LastName = "تسويق",
                            LockoutEnabled = false,
                            NormalizedEmail = "M@GMAIL.COM",
                            NormalizedUserName = "M@GMAIL.COM",
                            PasswordHash = "AOirL8RYuslmQXQDLDuf1YKqvU1aFNIM5OAEljj9maJmFQTofFuBPo8oTBoYgTZFfA==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "0d6d25ad-ed07-4f50-9a84-45a99e04544a",
                            TwoFactorEnabled = false,
                            UserName = "m@gmail.com"
                        },
                        new
                        {
                            Id = "k71282ed-85cf-4f7c-9e05-4b28051d04e4",
                            AccessFailedCount = 0,
                            AccountType = 1,
                            Code = 0,
                            ConcurrencyStamp = "5dbbb5b8-cfae-4bdc-9dfe-b7584a8d341b",
                            CreatedAt = new DateTime(2022, 8, 11, 15, 21, 51, 692, DateTimeKind.Local).AddTicks(6923),
                            CreatedBy = "Developer",
                            DepartmentId = "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                            Email = "pMonitor@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "مراقب",
                            LastName = "مشاريع",
                            LockoutEnabled = false,
                            NormalizedEmail = "PMONITOR@GMAIL.COM",
                            NormalizedUserName = "PMONITOR@GMAIL.COM",
                            PasswordHash = "AEZPg1Nlk1BHmLWRCpGXJRxEN7nvS7x6LSS+0P7V7YEfbEQnsFJviKS2xFo7WYKfzg==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "79d33c4b-f900-4a8b-b234-091fd756cd8f",
                            TwoFactorEnabled = false,
                            UserName = "pMonitor@gmail.com"
                        },
                        new
                        {
                            Id = "x313a786-637d-40c5-8715-543bba115487",
                            AccessFailedCount = 0,
                            AccountType = 1,
                            Code = 0,
                            ConcurrencyStamp = "101ad08e-2001-4009-aafa-9665a1960aeb",
                            CreatedAt = new DateTime(2022, 8, 11, 15, 21, 51, 693, DateTimeKind.Local).AddTicks(3993),
                            CreatedBy = "Developer",
                            DepartmentId = "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                            Email = "pe@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "مهندس",
                            LastName = "مشاريع",
                            LockoutEnabled = false,
                            NormalizedEmail = "PE@GMAIL.COM",
                            NormalizedUserName = "PE@GMAIL.COM",
                            PasswordHash = "AFzNIRUpzU1X8dfBBQZ+Ed/IBzU838do6sHbQOJM0sP8nTE8cysF1h2c0DEXxTEsOg==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "0f8d9890-d108-490f-a26c-dd9793e48260",
                            TwoFactorEnabled = false,
                            UserName = "pe@gmail.com"
                        },
                        new
                        {
                            Id = "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                            AccessFailedCount = 0,
                            AccountType = 1,
                            Code = 0,
                            ConcurrencyStamp = "bcccaa9a-832d-407e-b071-6e61432aaeb7",
                            CreatedAt = new DateTime(2022, 8, 11, 15, 21, 51, 694, DateTimeKind.Local).AddTicks(971),
                            CreatedBy = "Developer",
                            DepartmentId = "62fe29f0-c227-4a03-b2f6-z97279b2bc23",
                            Email = "f@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "المالية",
                            LastName = "مالية",
                            LockoutEnabled = false,
                            NormalizedEmail = "F@GMAIL.COM",
                            NormalizedUserName = "F@GMAIL.COM",
                            PasswordHash = "AIQ6oOqvT2Bt43YeSJF0rwcOtjaoy6U7isnbCd1qVEbvX9XAJDkgN7LCgI3LvSo92w==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "7bd2c3bf-3f49-4e3f-8020-0f6ad4e38af8",
                            TwoFactorEnabled = false,
                            UserName = "f@gmail.com"
                        });
                });

            modelBuilder.Entity("AsdafObhurRealEstate.Models.Client", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BaseUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BillsFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BaseUserId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("AsdafObhurRealEstate.Models.Department", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            CreatedAt = new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4032),
                            CreatedBy = "Developer",
                            ModifiedBy = "Developer",
                            Name = "الديكور",
                            UpdatedAt = new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4033)
                        },
                        new
                        {
                            Id = "f0157647-7016-41cc-9a56-3695acaa13e6",
                            CreatedAt = new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4035),
                            CreatedBy = "Developer",
                            ModifiedBy = "Developer",
                            Name = "العقار",
                            UpdatedAt = new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4035)
                        },
                        new
                        {
                            Id = "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                            CreatedAt = new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4037),
                            CreatedBy = "Developer",
                            ModifiedBy = "Developer",
                            Name = "المقاولات",
                            UpdatedAt = new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4037)
                        },
                        new
                        {
                            Id = "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                            CreatedAt = new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4039),
                            CreatedBy = "Developer",
                            ModifiedBy = "Developer",
                            Name = "الأعلام و التسويق",
                            UpdatedAt = new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4039)
                        },
                        new
                        {
                            Id = "62fe29f0-c227-4a03-b2f6-z97279b2bc23",
                            CreatedAt = new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4041),
                            CreatedBy = "Developer",
                            ModifiedBy = "Developer",
                            Name = "المالية",
                            UpdatedAt = new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4041)
                        });
                });

            modelBuilder.Entity("AsdafObhurRealEstate.Models.Multimedia", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClientID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClientID");

                    b.ToTable("Multimedias");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e",
                            ConcurrencyStamp = "4bf2b514-910a-48da-815e-3d9b96e888be",
                            Name = "GeneralManager",
                            NormalizedName = "GENERALMANAGER"
                        },
                        new
                        {
                            Id = "a0157647-7016-41cc-9a56-8695acaa13e6",
                            ConcurrencyStamp = "a5549932-87fc-4818-a40d-f25757864abc",
                            Name = "ProjectSupervisor",
                            NormalizedName = "PROJECTSUPERVISOR"
                        },
                        new
                        {
                            Id = "d3d0584e-fcd7-439c-8ae1-f5734664d6f4",
                            ConcurrencyStamp = "e37e7f20-477c-43ee-9459-cac6138aa33b",
                            Name = "ExecutiveSecretary",
                            NormalizedName = "EXECUTIVESECRETARY"
                        },
                        new
                        {
                            Id = "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c",
                            ConcurrencyStamp = "abe8d1ad-0165-4e43-ac40-a39fcf132a76",
                            Name = "Personnel",
                            NormalizedName = "PERSONNEL"
                        },
                        new
                        {
                            Id = "42fe29f0-c227-4a03-b2f6-c97279b2bc23",
                            ConcurrencyStamp = "c0d28df0-9e57-4321-a5f5-10aa0da1b80b",
                            Name = "Marketing",
                            NormalizedName = "MARKETING"
                        },
                        new
                        {
                            Id = "b71282ed-85cf-4f7c-9e05-9b28051d04e4",
                            ConcurrencyStamp = "14d8f51a-c2a0-45bf-aaa6-8029fb08401b",
                            Name = "ProjectMonitor",
                            NormalizedName = "PROJECTMONITOR"
                        },
                        new
                        {
                            Id = "e313a786-637d-40c5-8715-443bba115487",
                            ConcurrencyStamp = "4ff2652b-bf59-4513-8766-6fb35c10ac55",
                            Name = "ProjectsEngineer",
                            NormalizedName = "PROJECTSENGINEER"
                        },
                        new
                        {
                            Id = "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6",
                            ConcurrencyStamp = "36060ade-63a9-49bb-b3af-5b6693e41b14",
                            Name = "Financial",
                            NormalizedName = "FINANCIAL"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

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
                            UserId = "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                            RoleId = "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c"
                        },
                        new
                        {
                            UserId = "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                            RoleId = "42fe29f0-c227-4a03-b2f6-c97279b2bc23"
                        },
                        new
                        {
                            UserId = "k71282ed-85cf-4f7c-9e05-4b28051d04e4",
                            RoleId = "b71282ed-85cf-4f7c-9e05-9b28051d04e4"
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
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AsdafObhurRealEstate.Models.BaseUser", b =>
                {
                    b.HasOne("AsdafObhurRealEstate.Models.Department", "Department")
                        .WithMany("Users")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("AsdafObhurRealEstate.Models.Client", b =>
                {
                    b.HasOne("AsdafObhurRealEstate.Models.BaseUser", "BaseUser")
                        .WithMany()
                        .HasForeignKey("BaseUserId");

                    b.HasOne("AsdafObhurRealEstate.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.Navigation("BaseUser");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("AsdafObhurRealEstate.Models.Multimedia", b =>
                {
                    b.HasOne("AsdafObhurRealEstate.Models.Client", "Client")
                        .WithMany("Multimedias")
                        .HasForeignKey("ClientID");

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
