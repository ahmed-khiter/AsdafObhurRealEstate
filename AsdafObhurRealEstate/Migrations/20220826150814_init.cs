using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsdafObhurRealEstate.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProfilePic = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccountType = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    ClientName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BillsFile = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Notes = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientStatus = table.Column<int>(type: "int", nullable: false),
                    SendFirstMessageToClient = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SendSecondMessageToClient = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CodeNumber = table.Column<int>(type: "int", nullable: false),
                    CustomerNeeded = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BaseUserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DepartmentId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_AspNetUsers_BaseUserId",
                        column: x => x.BaseUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clients_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Multimedias",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Path = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multimedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Multimedias_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "42fe29f0-c227-4a03-b2f6-c97279b2bc23", "d0584e-fgd7-439c-8ae1-f5734666d6f", "Marketing", "MARKETING" },
                    { "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6", "d0584e-fcd7-439c-8ae1-f5734236d6f", "Financial", "FINANCIAL" },
                    { "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e", "d0584e-fcd7-439c-8ae1-f5734664d6f", "GeneralManager", "GENERALMANAGER" },
                    { "a0157647-7016-41cc-9a56-8695acaa13e6", "d0584e-fcd7-439c-8ae1-f5734666d6f", "ProjectSupervisor", "PROJECTSUPERVISOR" },
                    { "b71282ed-85cf-4f7c-9e05-9b28051d04e4", "d3584e-fcd7-439c-8ae1-f5734666d6f", "ProjectMonitor", "PROJECTMONITOR" },
                    { "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c", "d0554e-fcd7-439c-8ae1-f5734666d6f", "Personnel", "PERSONNEL" },
                    { "d3d0584e-fcd7-439c-8ae1-f5734664d6f4", "d0584e-fcd7-439c-9ae1-f5734666d6f", "ExecutiveSecretary", "EXECUTIVESECRETARY" },
                    { "e313a786-637d-40c5-8715-443bba115487", "s1584e-fcd7-439c-8ae1-f5734666d6f", "ProjectsEngineer", "PROJECTSENGINEER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountType", "Code", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DepartmentId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", 0, 1, 1, "afe716c8-911a-4c0e-8254-94a0951caa9e", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", null, "gm@gmail.com", true, "المدير", "العام", false, null, "GM@GMAIL.COM", "GM@GMAIL.COM", "ALbkWs6y7xmRpW3fWzRVAJ1bz2cqxgSDcBcyVGP0Met/q04FvonaFTWHxAVZI2YwBg==", "01100811024", true, null, "e1a51bfa-6c14-4d0c-a191-919ff2bcf7d5", false, "gm@gmail.com" },
                    { "c3d0584e-fcd7-439c-8ae1-g5734664d6f4", 0, 1, 3, "bf358dbc-cfbb-4960-acd7-1546c9095301", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", null, "es@gmail.com", true, "سكرتير", "التنفيذي", false, null, "ES@GMAIL.COM", "ES@GMAIL.COM", "AFea7sS6foAH5KlPFPQpNYBP/gFfoSW6xIbtWKr8XYVGrQn0UR59UciKyNcxdjTZLQ==", "01100811024", true, null, "ed9a9dbf-4f8c-4f49-8b29-27b3ba458d64", false, "es@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedBy", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", "Developer", "الديكور", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "62fe29f0-c227-4a03-b2f6-z97279b2bc23", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", "Developer", "المالية", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", "Developer", "الأعلام و التسويق", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "f0157647-7016-41cc-9a56-3695acaa13e6", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", "Developer", "العقار", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", "Developer", "المقاولات", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e", "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e" },
                    { "d3d0584e-fcd7-439c-8ae1-f5734664d6f4", "c3d0584e-fcd7-439c-8ae1-g5734664d6f4" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountType", "Code", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DepartmentId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "82fe29f0-c227-4a03-b2f6-z97279b2bc23", 0, 1, 5, "8c2573f7-da70-4825-8c7b-842fd0841db3", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", "m@gmail.com", true, "تسويق", "تسويق", false, null, "M@GMAIL.COM", "M@GMAIL.COM", "ADEQoQ5tZKfUtvEcrLAcx/WcPsc4Fk1acHTsX36vdTmGE18EJu1RAB/4sU72qOzDLw==", "01100811024", true, null, "1d6063de-f60d-47cf-a88d-eb73aa5d1b82", false, "m@gmail.com" },
                    { "b0157647-7016-41cc-9a56-3695acaa13e6", 0, 1, 2, "fb3e18c3-6093-4327-a5c5-c32431d8f19e", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", "f0157647-7016-41cc-9a56-3695acaa13e6", "ps@gmail.com", true, "مشرف", "مشاريع", false, null, "PS@GMAIL.COM", "PS@GMAIL.COM", "AApamNeyA+w8U5n/MeI56uVK4p9a9+zZ1AvKiLM8LF+O6P4yTJExydsfsio9XyWQog==", "01100811024", true, null, "02d6e2d8-db12-4ed2-a7e0-615fd3584d30", false, "ps@gmail.com" },
                    { "k71282ed-85cf-4f7c-9e05-4b28051d04e4", 0, 1, 6, "50b652dc-4a3a-4cfe-8954-21d2941dd1ea", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", "pMonitor@gmail.com", true, "مراقب", "مشاريع", false, null, "PMONITOR@GMAIL.COM", "PMONITOR@GMAIL.COM", "AA7kcNsDqjJiiI3MRmbUb1pQddVq+RDGMhFLtFYOrNR8WuThj3xz4IWgGqYDnH0A6Q==", "01100811024", true, null, "66f59237-9830-4bae-81b0-f3204c95c539", false, "pMonitor@gmail.com" },
                    { "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", 0, 1, 4, "626f6a4d-4ddc-4de0-b4c4-4ac2ea5d750f", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", "62fe29f0-c227-4a03-b2f6-z97279b2bc23", "p@gmail.com", true, "شؤون", "موظفين", false, null, "P@GMAIL.COM", "P@GMAIL.COM", "AKqO91KlKAyYvfyxdOaZf0tuSW6Ar85EYrl7ZjYCTjDuysIYXs8fU4PeIkx/bk3QlA==", "01100811024", true, null, "e55d2945-ec6a-45ca-9a93-f8bb2365b218", false, "p@gmail.com" },
                    { "x313a786-637d-40c5-8715-543bba115487", 0, 1, 7, "99660d57-f69d-43ab-81cd-1f1bc47a615f", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", "pe@gmail.com", true, "مهندس", "مشاريع", false, null, "PE@GMAIL.COM", "PE@GMAIL.COM", "ABSd8uc8lq/E1U8psxv8v7JgF05hXBpp09jLtywIFKKrGFHNXosk4HNt6LhqACaKTw==", "01100811024", true, null, "8f0d0f6d-0592-4495-88ff-9c29efc249f3", false, "pe@gmail.com" },
                    { "zecb5d3d-a7f3-4751-8ae5-724e07889bd6", 0, 1, 8, "90fc32a5-0ae8-4279-87ca-b5037dceab1d", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", "62fe29f0-c227-4a03-b2f6-z97279b2bc23", "f@gmail.com", true, "المالية", "مالية", false, null, "F@GMAIL.COM", "F@GMAIL.COM", "AHCjY1rNRHap+jEldKXeHK8wJvEQBlzPvi7eDLggjR5wTQWoTFcnT1FBg6IShaA67A==", "01100811024", true, null, "f83d2ef3-36b4-428d-a847-a5b967080685", false, "f@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "BaseUserId", "BillsFile", "ClientName", "ClientStatus", "Code", "CodeNumber", "CreatedAt", "CreatedBy", "CustomerNeeded", "DepartmentId", "ModifiedBy", "Notes", "PhoneNumber", "SendFirstMessageToClient", "SendSecondMessageToClient", "UpdatedAt" },
                values: new object[,]
                {
                    { "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "Client Ahmed", 2, 1, 0, new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "ملاحظات من المبرمج ", "035453650", false, false, new DateTime(2022, 8, 26, 17, 8, 13, 632, DateTimeKind.Local).AddTicks(8716) },
                    { "b0157647-7016-41cc-9a56-3695acaa13e6", null, "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "Client Ahmed2", 2, 2, 0, new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "2ملاحظات من المبرمج ", "01122332150", false, false, new DateTime(2022, 8, 26, 17, 8, 13, 632, DateTimeKind.Local).AddTicks(8723) },
                    { "c3d0584e-fcd7-439c-8ae1-g5734664d6f4", null, "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "Client Ahmed 3 ", 2, 3, 0, new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "2ملاحظات من المبرمج ", "24400", false, false, new DateTime(2022, 8, 26, 17, 8, 13, 632, DateTimeKind.Local).AddTicks(8726) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "42fe29f0-c227-4a03-b2f6-c97279b2bc23", "82fe29f0-c227-4a03-b2f6-z97279b2bc23" },
                    { "a0157647-7016-41cc-9a56-8695acaa13e6", "b0157647-7016-41cc-9a56-3695acaa13e6" },
                    { "b71282ed-85cf-4f7c-9e05-9b28051d04e4", "k71282ed-85cf-4f7c-9e05-4b28051d04e4" },
                    { "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c", "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c" },
                    { "e313a786-637d-40c5-8715-443bba115487", "x313a786-637d-40c5-8715-543bba115487" },
                    { "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6", "zecb5d3d-a7f3-4751-8ae5-724e07889bd6" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepartmentId",
                table: "AspNetUsers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_BaseUserId",
                table: "Clients",
                column: "BaseUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_DepartmentId",
                table: "Clients",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Multimedias_ClientId",
                table: "Multimedias",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Multimedias");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
