using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AsdafObhurRealEstate.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    ProfilePic = table.Column<string>(type: "text", nullable: true),
                    AccountType = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Code = table.Column<int>(type: "integer", nullable: false),
                    DepartmentId = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<int>(type: "integer", nullable: false),
                    ClientName = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    BillsFile = table.Column<string>(type: "text", nullable: true),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    ClientStatus = table.Column<int>(type: "integer", nullable: false),
                    SendFirstMessageToClient = table.Column<bool>(type: "boolean", nullable: false),
                    SendSecondMessageToClient = table.Column<bool>(type: "boolean", nullable: false),
                    CodeNumber = table.Column<int>(type: "integer", nullable: false),
                    CustomerNeeded = table.Column<string>(type: "text", nullable: true),
                    BaseUserId = table.Column<string>(type: "text", nullable: true),
                    DepartmentId = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_AspNetUsers_BaseUserId",
                        column: x => x.BaseUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Multimedias",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Path = table.Column<string>(type: "text", nullable: true),
                    ClientId = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multimedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Multimedias_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", 0, 1, 1, "923eb281-3fbd-45eb-b483-1438ae525397", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "ceo-foad@asdaf-aom.com", true, "فؤاد", "الغامدي", false, null, "CEO-FOAD@ASDAF-AOM.COM", "CEO-FOAD@ASDAF-AOM.COM", "AOmyApFerYSAc94gyt5yn1i6bHxnr1fsYc8rTKSY4aBSJFYuZUtisNcHPzpQAgpGWQ==", "01100811024", true, null, "e150c682-7680-4c27-b2ab-7a03b1fc45c1", false, "ceo-foad@asdaf-aom.com" },
                    { "c3d0584e-fcd7-439c-8ae1-g5734664d6f4", 0, 3, 3, "793869dc-6509-472d-a5a3-2c8d46d1e3c8", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "Ghadeer.Sec@Asdaf-aom.com", true, "غدير", "ابو داود", false, null, "GHADEER.SEC@ASDAF-AOM.COM", "GHADEER.SEC@ASDAF-AOM.COM", "AMeUeE99E8cPzuesH0/5Ck7E/ijdZwR8ipbZsKS1U/hDc0ygjTaWN4Jlyx6a/wYnWQ==", "01100811024", true, null, "f356e1e1-8f59-41e7-b4ee-d2488e005bbf", false, "Ghadeer.Sec@Asdaf-aom.com" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedBy", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "الديكور", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "62fe29f0-c227-4a03-b2f6-z97279b2bc23", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "المالية", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "الأعلام و التسويق", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "f0157647-7016-41cc-9a56-3695acaa13e6", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "العقار", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "المقاولات", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                    { "82fe29f0-c227-4a03-b2f6-z97279b2bc23", 0, 5, 5, "18a7e417-02bf-4031-ba72-653238563f37", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", "Turki@Asdaf-aom.com", true, "تركي", "العصلاني", false, null, "TURKI@ASDAF-AOM.COM", "TURKI@ASDAF-AOM.COM", "AHDJ0yYhq5yVW2SFpkVU88XYRYUwYF7zaIH7qTIeTMeF7Jb2flkY+jCzwKQeSyvLbg==", "01100811024", true, null, "1124f8aa-308b-486a-9be8-18a988a7d8e2", false, "Turki@Asdaf-aom.com" },
                    { "b0157647-7016-41cc-9a56-3695acaa13e6", 0, 2, 2, "002cd0aa-a5aa-41a7-9a52-30970b2b7491", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "f0157647-7016-41cc-9a56-3695acaa13e6", "Muhannad@Asdaf-aom.com", true, "مهند", "حريري", false, null, "MUHANNAD@ASDAF-AOM.COM", "MUHANNAD@ASDAF-AOM.COM", "ACmaDVJSkVIGy2H7r94Nyckc+r8GJYRYphN/Ho1Ht1G6OndYRvXGJdSWtTtdXsQ2OQ==", "01100811024", true, null, "b2bb8a4e-dc6e-4eea-81cd-7dcaac54dcf0", false, "Muhannad@Asdaf-aom.com" },
                    { "x313a786-637d-40c5-8715-543bba115487", 0, 7, 7, "cfab2d7f-a7e8-4152-bcee-8289cc0ce018", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", "hossam@asdaf-aom.com", true, "حسام", "الديني", false, null, "HOSSAM@ASDAF-AOM.COM", "HOSSAM@ASDAF-AOM.COM", "AJLfZZgUFWnkfEsWkFcILxFTz56QM9gUMauef4N5vYeSXm4KC20HtSsog32lCjk1AQ==", "01100811024", true, null, "f1db2c77-096a-4d1c-9890-f583ad796e66", false, "hossam@asdaf-aom.com" },
                    { "zeaf5d3d-a6b3-3081-8ae5-724e07359bd6", 0, 7, 12, "23a5f5bd-d45f-45e0-89c7-a8b2f28c61d0", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", "Eng.mansour@asdaf-aom.com", true, "منصور", "الأحمدي", false, null, "ENG.MANSOUR@ASDAF-AOM.COM", "ENG.MANSOUR@ASDAF-AOM.COM", "AGz5I3B+BwPzXWDOzVX2OhRCT1n3FaQp3GG7ZbZg4TQ/spI84AhlCO1MN0mOujFBHg==", "01100811024", true, null, "d56776f8-69bc-43d2-8c86-b83b3a22f399", false, "Eng.mansour@asdaf-aom.com" },
                    { "zeaf5d3d-a7f3-3081-8ae5-724e07359bd6", 0, 5, 11, "a2c42d3f-e2cf-4430-83cc-b6d4c46a0772", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", "Amal@Asdaf-aom.com", true, "أمل", "الشريف", false, null, "AMAL@ASDAF-AOM.COM", "AMAL@ASDAF-AOM.COM", "ABCr/AmPagi7aqYjs3nA4TlaVMCOv3WIrsCYZJ6JqMx9BwVtjqpf7e20dUKzSEuPuA==", "01100811024", true, null, "7bbf403e-aeb1-456b-872b-9f62402341d5", false, "Amal@Asdaf-aom.com" },
                    { "zeaf5d3d-a7f3-4751-8ae5-724e07359bd6", 0, 2, 10, "70beee77-0a08-4af9-b17e-5e70bf33e333", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "f0157647-7016-41cc-9a56-3695acaa13e6", "khalil@asdaf-aom.com", true, "خليل", "محمد", false, null, "KHALIL@ASDAF-AOM.COM", "KHALIL@ASDAF-AOM.COM", "ACR3igMKvCVfDi/SiCFtdYcv/nMW4ayL4Jes+ipdjdjeifSeQdiPghaMq1hvcXc/qw==", "01100811024", true, null, "b9837065-0905-46d9-ac7a-a1791e1203fa", false, "khalil@asdaf-aom.com" },
                    { "zeaf5d3d-a7f3-4751-8ae5-724e07889bd6", 0, 2, 9, "eef07a36-d1cf-4314-8a86-6947c72c2e77", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "f0157647-7016-41cc-9a56-3695acaa13e6", "sadek@asdaf-aom.com", true, "صادق", "الأبيض", false, null, "SADEK@ASDAF-AOM.COM", "SADEK@ASDAF-AOM.COM", "ALAyPalC8nes/W9YCj23EmTJbshiPP6mb9NCOyFkQvGCMJY8eTEqjTDSiFnY3rwj1w==", "01100811024", true, null, "5e86db92-e6aa-4e6d-a3d1-9cbe64e028c8", false, "sadek@asdaf-aom.com" },
                    { "zecb5d3d-a7f3-4751-8ae5-724e07889bd6", 0, 8, 8, "6a6c578f-a3ef-445c-8e18-3e89e15184e1", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "62fe29f0-c227-4a03-b2f6-z97279b2bc23", "Marwa@Asdaf-aom.com", true, "مروة", "عبد العاطي", false, null, "MARWA@ASDAF-AOM.COM", "MARWA@ASDAF-AOM.COM", "ACZdoqytOSrKeluQwouZ7ZX6pL3OVneqvGzJR68go5+sHDU6TKFEf6q1ulr6NMw4bg==", "01100811024", true, null, "ea154124-36d0-4af0-bd08-e938684caff1", false, "Marwa@Asdaf-aom.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "42fe29f0-c227-4a03-b2f6-c97279b2bc23", "82fe29f0-c227-4a03-b2f6-z97279b2bc23" },
                    { "a0157647-7016-41cc-9a56-8695acaa13e6", "b0157647-7016-41cc-9a56-3695acaa13e6" },
                    { "e313a786-637d-40c5-8715-443bba115487", "x313a786-637d-40c5-8715-543bba115487" },
                    { "e313a786-637d-40c5-8715-443bba115487", "zeaf5d3d-a6b3-3081-8ae5-724e07359bd6" },
                    { "42fe29f0-c227-4a03-b2f6-c97279b2bc23", "zeaf5d3d-a7f3-3081-8ae5-724e07359bd6" },
                    { "a0157647-7016-41cc-9a56-8695acaa13e6", "zeaf5d3d-a7f3-4751-8ae5-724e07359bd6" },
                    { "a0157647-7016-41cc-9a56-8695acaa13e6", "zeaf5d3d-a7f3-4751-8ae5-724e07889bd6" },
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
