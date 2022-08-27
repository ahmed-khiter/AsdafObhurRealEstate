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
                        principalColumn: "Id");
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clients_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
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
                        principalColumn: "Id");
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
                    { "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", 0, 1, 1, "6a22a428-b038-4f61-9cc9-b4373517f33e", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "fouad@asdaf.com", true, "فؤاد", "الغامدي", false, null, "FOUAD@ASDAF.COM", "FOUAD@ASDAF.COM", "AAfodOZsRQmlD3JUV6W+oiKLxc9dlcOEe73TlKTYXfnL7/MNhg2CpeO1J/D8HDUsAw==", "01100811024", true, null, "d7e425a3-5c16-4849-941b-ca69aefa3c11", false, "fouad@asdaf.com" },
                    { "c3d0584e-fcd7-439c-8ae1-g5734664d6f4", 0, 3, 3, "c9d77566-066d-475f-9fc5-581824821696", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "ghadeer@asdaf.com", true, "غدير", "ابو داود", false, null, "GHADEER@ASDAF.COM", "GHADEER@ASDAF.COM", "APIIySQNxTdvTM0MU10rAP7y+C6nkJrWNqRhxsglZUodKJj3vE7Kq7Q1LQaBPI+JsA==", "01100811024", true, null, "48758906-379c-4c04-8bf8-c87075b274d8", false, "ghadeer@asdaf.com" }
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
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountType", "Code", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DepartmentId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "82fe29f0-c227-4a03-b2f6-z97279b2bc23", 0, 5, 5, "2fb5d001-25cc-4e92-b610-f0cbd4b4b016", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", "turki@asdaf.com", true, "تركي", "العصلاني", false, null, "TURKI@ASDAF.COM", "TURKI@ASDAF.COM", "AHXSdWrzwGalREvjmWGcDA3JCmMxXTJZICLdARJ+rLJ80MOY4sYyp0XhvB6kc8PMbA==", "01100811024", true, null, "1624a481-0a0b-41df-8119-24eddceec683", false, "turki@asdaf.com" },
                    { "b0157647-7016-41cc-9a56-3695acaa13e6", 0, 2, 2, "89297646-10da-4aaa-9703-4abc31aea5f6", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "f0157647-7016-41cc-9a56-3695acaa13e6", "mohand@asdaf.com", true, "مهند", "حريري", false, null, "MOHAND@ASDAF.COM", "MOHAND@ASDAF.COM", "AJedi+MZhIbuzexokfoXmR3H26SKr3HB3DgW7sHc+3fTkwb6M/ZR/MvydoRO1LDEkA==", "01100811024", true, null, "e86840dd-143e-4db9-b249-001fc76efa8d", false, "mohand@asdaf.com" },
                    { "x313a786-637d-40c5-8715-543bba115487", 0, 7, 7, "be4ee4bf-39a3-43ee-98d5-7f347b049be3", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", "hossam@asdaf.com", true, "حسام", "الديني", false, null, "HOSSAM@ASDAF.COM", "HOSSAM@ASDAF.COM", "AAO9YMKKh2pEO/nV5B9EcFNV/2Wr64iYpUSymmOLvi9U3RqyWcDsotlYBC2sif96cQ==", "01100811024", true, null, "bf84bc6a-56ce-4b05-8c43-adf51e15738c", false, "hossam@asdaf.com" },
                    { "zeaf5d3d-a6b3-3081-8ae5-724e07359bd6", 0, 7, 12, "cf608b15-d460-469d-bd21-953275365dda", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", "mansor@asdaf.com", true, "منصور", "الأحمدي", false, null, "MANSOR@ASDAF.COM", "MANSOR@ASDAF.COM", "ALWik3gWTLtVJCdkHtku4UXKr+smGjeJRUHxm3jGMYYHqh6hB/VzxaB3GLVrvCEJkg==", "01100811024", true, null, "25be0e96-cd7a-4581-b9a8-e9cb6dbe9ccf", false, "mansor@asdaf.com" },
                    { "zeaf5d3d-a7f3-3081-8ae5-724e07359bd6", 0, 5, 11, "3b7c62d5-a0af-49fd-a8db-218996fe3bfb", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", "amal@asdaf.com", true, "أمل", "الشريف", false, null, "AMAL@ASDAF.COM", "AMAL@ASDAF.COM", "AN5Ggj0/sKXTKAXQvN/NWTMT5Arj2RI/l0Pwrx4jJYKuxWJDUXbX9hSG1W8s4DmnIw==", "01100811024", true, null, "440a6720-274a-41f0-8a28-e09462530aaa", false, "amal@asdaf.com" },
                    { "zeaf5d3d-a7f3-4751-8ae5-724e07359bd6", 0, 2, 10, "4b6aa10e-752a-47ef-a983-f13e5fde8e58", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "f0157647-7016-41cc-9a56-3695acaa13e6", "khalil@asdaf.com", true, "خليل", "محمد", false, null, "KHALIL@ASDAF.COM", "KHALIL@ASDAF.COM", "ACrkGH5cFwdIq92cgCl9VCq0kjElfkfG365MaqzksyxQ7O88k0RenUJvBCabEH6kfA==", "01100811024", true, null, "a099b70b-20ab-45a2-bf51-7e47530e911f", false, "khalil@asdaf.com" },
                    { "zeaf5d3d-a7f3-4751-8ae5-724e07889bd6", 0, 2, 9, "892512d1-0287-40b7-a6cb-304cf9cc8a69", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "f0157647-7016-41cc-9a56-3695acaa13e6", "sadek@asdaf.com", true, "صادق", "الأبيض", false, null, "SADEK@ASDAF.COM", "SADEK@ASDAF.COM", "ADT4E8hu5fNmiBM+3DEfY7Fq+HhaCvkwBCz+pQr+rtkQyh+syvAKrODhvIQ2eFzDzw==", "01100811024", true, null, "bcd8f075-51ad-4d01-95e8-a93b8399ab49", false, "sadek@asdaf.com" },
                    { "zecb5d3d-a7f3-4751-8ae5-724e07889bd6", 0, 8, 8, "fccd9e44-e3a6-4f4a-b19f-7fabc4139164", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "62fe29f0-c227-4a03-b2f6-z97279b2bc23", "marwa@asdaf.com", true, "مروة", "عبد العاطي", false, null, "MARWA@ASDAF.COM", "MARWA@ASDAF.COM", "AL8YxQ19urfucWJspoDqRpElOnSvgPRRvYHF5T2yaDF51VBxrmUGNoeaYTS6ulZteg==", "01100811024", true, null, "49fa450b-7a0a-4f18-94f5-08a3e65e255c", false, "marwa@asdaf.com" }
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
