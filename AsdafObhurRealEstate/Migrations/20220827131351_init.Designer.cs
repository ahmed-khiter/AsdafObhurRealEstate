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
    [Migration("20220827131351_init")]
    partial class init
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
                            ConcurrencyStamp = "6a22a428-b038-4f61-9cc9-b4373517f33e",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            Email = "fouad@asdaf.com",
                            EmailConfirmed = true,
                            FirstName = "فؤاد",
                            LastName = "الغامدي",
                            LockoutEnabled = false,
                            NormalizedEmail = "FOUAD@ASDAF.COM",
                            NormalizedUserName = "FOUAD@ASDAF.COM",
                            PasswordHash = "AAfodOZsRQmlD3JUV6W+oiKLxc9dlcOEe73TlKTYXfnL7/MNhg2CpeO1J/D8HDUsAw==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "d7e425a3-5c16-4849-941b-ca69aefa3c11",
                            TwoFactorEnabled = false,
                            UserName = "fouad@asdaf.com"
                        },
                        new
                        {
                            Id = "b0157647-7016-41cc-9a56-3695acaa13e6",
                            AccessFailedCount = 0,
                            AccountType = 2,
                            Code = 2,
                            ConcurrencyStamp = "89297646-10da-4aaa-9703-4abc31aea5f6",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            DepartmentId = "f0157647-7016-41cc-9a56-3695acaa13e6",
                            Email = "mohand@asdaf.com",
                            EmailConfirmed = true,
                            FirstName = "مهند",
                            LastName = "حريري",
                            LockoutEnabled = false,
                            NormalizedEmail = "MOHAND@ASDAF.COM",
                            NormalizedUserName = "MOHAND@ASDAF.COM",
                            PasswordHash = "AJedi+MZhIbuzexokfoXmR3H26SKr3HB3DgW7sHc+3fTkwb6M/ZR/MvydoRO1LDEkA==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "e86840dd-143e-4db9-b249-001fc76efa8d",
                            TwoFactorEnabled = false,
                            UserName = "mohand@asdaf.com"
                        },
                        new
                        {
                            Id = "zeaf5d3d-a7f3-4751-8ae5-724e07889bd6",
                            AccessFailedCount = 0,
                            AccountType = 2,
                            Code = 9,
                            ConcurrencyStamp = "892512d1-0287-40b7-a6cb-304cf9cc8a69",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            DepartmentId = "f0157647-7016-41cc-9a56-3695acaa13e6",
                            Email = "sadek@asdaf.com",
                            EmailConfirmed = true,
                            FirstName = "صادق",
                            LastName = "الأبيض",
                            LockoutEnabled = false,
                            NormalizedEmail = "SADEK@ASDAF.COM",
                            NormalizedUserName = "SADEK@ASDAF.COM",
                            PasswordHash = "ADT4E8hu5fNmiBM+3DEfY7Fq+HhaCvkwBCz+pQr+rtkQyh+syvAKrODhvIQ2eFzDzw==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "bcd8f075-51ad-4d01-95e8-a93b8399ab49",
                            TwoFactorEnabled = false,
                            UserName = "sadek@asdaf.com"
                        },
                        new
                        {
                            Id = "zeaf5d3d-a7f3-4751-8ae5-724e07359bd6",
                            AccessFailedCount = 0,
                            AccountType = 2,
                            Code = 10,
                            ConcurrencyStamp = "4b6aa10e-752a-47ef-a983-f13e5fde8e58",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            DepartmentId = "f0157647-7016-41cc-9a56-3695acaa13e6",
                            Email = "khalil@asdaf.com",
                            EmailConfirmed = true,
                            FirstName = "خليل",
                            LastName = "محمد",
                            LockoutEnabled = false,
                            NormalizedEmail = "KHALIL@ASDAF.COM",
                            NormalizedUserName = "KHALIL@ASDAF.COM",
                            PasswordHash = "ACrkGH5cFwdIq92cgCl9VCq0kjElfkfG365MaqzksyxQ7O88k0RenUJvBCabEH6kfA==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "a099b70b-20ab-45a2-bf51-7e47530e911f",
                            TwoFactorEnabled = false,
                            UserName = "khalil@asdaf.com"
                        },
                        new
                        {
                            Id = "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                            AccessFailedCount = 0,
                            AccountType = 3,
                            Code = 3,
                            ConcurrencyStamp = "c9d77566-066d-475f-9fc5-581824821696",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            Email = "ghadeer@asdaf.com",
                            EmailConfirmed = true,
                            FirstName = "غدير",
                            LastName = "ابو داود",
                            LockoutEnabled = false,
                            NormalizedEmail = "GHADEER@ASDAF.COM",
                            NormalizedUserName = "GHADEER@ASDAF.COM",
                            PasswordHash = "APIIySQNxTdvTM0MU10rAP7y+C6nkJrWNqRhxsglZUodKJj3vE7Kq7Q1LQaBPI+JsA==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "48758906-379c-4c04-8bf8-c87075b274d8",
                            TwoFactorEnabled = false,
                            UserName = "ghadeer@asdaf.com"
                        },
                        new
                        {
                            Id = "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                            AccessFailedCount = 0,
                            AccountType = 5,
                            Code = 5,
                            ConcurrencyStamp = "2fb5d001-25cc-4e92-b610-f0cbd4b4b016",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            DepartmentId = "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                            Email = "turki@asdaf.com",
                            EmailConfirmed = true,
                            FirstName = "تركي",
                            LastName = "العصلاني",
                            LockoutEnabled = false,
                            NormalizedEmail = "TURKI@ASDAF.COM",
                            NormalizedUserName = "TURKI@ASDAF.COM",
                            PasswordHash = "AHXSdWrzwGalREvjmWGcDA3JCmMxXTJZICLdARJ+rLJ80MOY4sYyp0XhvB6kc8PMbA==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "1624a481-0a0b-41df-8119-24eddceec683",
                            TwoFactorEnabled = false,
                            UserName = "turki@asdaf.com"
                        },
                        new
                        {
                            Id = "zeaf5d3d-a7f3-3081-8ae5-724e07359bd6",
                            AccessFailedCount = 0,
                            AccountType = 5,
                            Code = 11,
                            ConcurrencyStamp = "3b7c62d5-a0af-49fd-a8db-218996fe3bfb",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            DepartmentId = "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                            Email = "amal@asdaf.com",
                            EmailConfirmed = true,
                            FirstName = "أمل",
                            LastName = "الشريف",
                            LockoutEnabled = false,
                            NormalizedEmail = "AMAL@ASDAF.COM",
                            NormalizedUserName = "AMAL@ASDAF.COM",
                            PasswordHash = "AN5Ggj0/sKXTKAXQvN/NWTMT5Arj2RI/l0Pwrx4jJYKuxWJDUXbX9hSG1W8s4DmnIw==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "440a6720-274a-41f0-8a28-e09462530aaa",
                            TwoFactorEnabled = false,
                            UserName = "amal@asdaf.com"
                        },
                        new
                        {
                            Id = "x313a786-637d-40c5-8715-543bba115487",
                            AccessFailedCount = 0,
                            AccountType = 7,
                            Code = 7,
                            ConcurrencyStamp = "be4ee4bf-39a3-43ee-98d5-7f347b049be3",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            DepartmentId = "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                            Email = "hossam@asdaf.com",
                            EmailConfirmed = true,
                            FirstName = "حسام",
                            LastName = "الديني",
                            LockoutEnabled = false,
                            NormalizedEmail = "HOSSAM@ASDAF.COM",
                            NormalizedUserName = "HOSSAM@ASDAF.COM",
                            PasswordHash = "AAO9YMKKh2pEO/nV5B9EcFNV/2Wr64iYpUSymmOLvi9U3RqyWcDsotlYBC2sif96cQ==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "bf84bc6a-56ce-4b05-8c43-adf51e15738c",
                            TwoFactorEnabled = false,
                            UserName = "hossam@asdaf.com"
                        },
                        new
                        {
                            Id = "zeaf5d3d-a6b3-3081-8ae5-724e07359bd6",
                            AccessFailedCount = 0,
                            AccountType = 7,
                            Code = 12,
                            ConcurrencyStamp = "cf608b15-d460-469d-bd21-953275365dda",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            DepartmentId = "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                            Email = "mansor@asdaf.com",
                            EmailConfirmed = true,
                            FirstName = "منصور",
                            LastName = "الأحمدي",
                            LockoutEnabled = false,
                            NormalizedEmail = "MANSOR@ASDAF.COM",
                            NormalizedUserName = "MANSOR@ASDAF.COM",
                            PasswordHash = "ALWik3gWTLtVJCdkHtku4UXKr+smGjeJRUHxm3jGMYYHqh6hB/VzxaB3GLVrvCEJkg==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "25be0e96-cd7a-4581-b9a8-e9cb6dbe9ccf",
                            TwoFactorEnabled = false,
                            UserName = "mansor@asdaf.com"
                        },
                        new
                        {
                            Id = "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                            AccessFailedCount = 0,
                            AccountType = 8,
                            Code = 8,
                            ConcurrencyStamp = "fccd9e44-e3a6-4f4a-b19f-7fabc4139164",
                            CreatedAt = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                            DepartmentId = "62fe29f0-c227-4a03-b2f6-z97279b2bc23",
                            Email = "marwa@asdaf.com",
                            EmailConfirmed = true,
                            FirstName = "مروة",
                            LastName = "عبد العاطي",
                            LockoutEnabled = false,
                            NormalizedEmail = "MARWA@ASDAF.COM",
                            NormalizedUserName = "MARWA@ASDAF.COM",
                            PasswordHash = "AL8YxQ19urfucWJspoDqRpElOnSvgPRRvYHF5T2yaDF51VBxrmUGNoeaYTS6ulZteg==",
                            PhoneNumber = "01100811024",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "49fa450b-7a0a-4f18-94f5-08a3e65e255c",
                            TwoFactorEnabled = false,
                            UserName = "marwa@asdaf.com"
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
                        .HasForeignKey("ClientId");

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
