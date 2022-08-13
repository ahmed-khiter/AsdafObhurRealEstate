using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountType = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillsFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientStatus = table.Column<int>(type: "int", nullable: false),
                    BaseUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DepartmentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    { "42fe29f0-c227-4a03-b2f6-c97279b2bc23", "83ae465e-6777-48ff-8983-fb1a3e62f6ad", "Marketing", "MARKETING" },
                    { "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6", "b13f5b3c-6bcd-4ede-93d8-476c205d6931", "Financial", "FINANCIAL" },
                    { "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e", "b7d91ea6-4a30-4d87-9898-2282be2a8ee2", "GeneralManager", "GENERALMANAGER" },
                    { "a0157647-7016-41cc-9a56-8695acaa13e6", "7f5e6f34-e751-46a3-b868-64bc02590aa0", "ProjectSupervisor", "PROJECTSUPERVISOR" },
                    { "b71282ed-85cf-4f7c-9e05-9b28051d04e4", "d42ac547-afde-4f89-af16-086831b20ef1", "ProjectMonitor", "PROJECTMONITOR" },
                    { "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c", "846b5fa5-fe75-4bc5-869c-c686468e816b", "Personnel", "PERSONNEL" },
                    { "d3d0584e-fcd7-439c-8ae1-f5734664d6f4", "d541d348-1ed6-4ea4-bf83-0def38b04870", "ExecutiveSecretary", "EXECUTIVESECRETARY" },
                    { "e313a786-637d-40c5-8715-443bba115487", "695bc937-9392-4065-b77b-7e6ed9376244", "ProjectsEngineer", "PROJECTSENGINEER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountType", "Code", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DepartmentId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", 0, 1, 1, "68fd3b95-c2ec-44f2-a5b8-fd8f8f06e988", new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6944), "Developer", null, "gm@gmail.com", true, "المدير", "العام", false, null, "GM@GMAIL.COM", "GM@GMAIL.COM", "ABJ8PqwywNV0QrXQoi/OiBytOh0xe1y2jNlvWyvKuNpvMXT7cRtXLPu88Yj9+BLp6g==", "01100811024", true, null, "ced66b13-1ed3-4c1a-a8ad-25f031d00e7b", false, "gm@gmail.com" },
                    { "c3d0584e-fcd7-439c-8ae1-g5734664d6f4", 0, 1, 3, "27cc1a1b-6575-4434-9d95-8393361f1a75", new DateTime(2022, 8, 13, 13, 59, 58, 10, DateTimeKind.Local).AddTicks(646), "Developer", null, "es@gmail.com", true, "سكرتير", "التنفيذي", false, null, "ES@GMAIL.COM", "ES@GMAIL.COM", "AByb01yEeBCZoyqAzn1+NfJksgUgWixGkrUf58DMseAf+RJ0wkAoQQ+ZqqIEqVVuug==", "01100811024", true, null, "da9cf1e6-75f9-40ca-8c90-984243ed55b3", false, "es@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedBy", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e", new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6905), "Developer", "Developer", "الديكور", new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6907) },
                    { "62fe29f0-c227-4a03-b2f6-z97279b2bc23", new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6915), "Developer", "Developer", "المالية", new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6915) },
                    { "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6913), "Developer", "Developer", "الأعلام و التسويق", new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6913) },
                    { "f0157647-7016-41cc-9a56-3695acaa13e6", new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6909), "Developer", "Developer", "العقار", new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6909) },
                    { "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6911), "Developer", "Developer", "المقاولات", new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6911) }
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
                    { "82fe29f0-c227-4a03-b2f6-z97279b2bc23", 0, 1, 5, "e567255b-1c2b-490e-bd04-2da72493e5a7", new DateTime(2022, 8, 13, 13, 59, 58, 11, DateTimeKind.Local).AddTicks(8802), "Developer", "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", "m@gmail.com", true, "تسويق", "تسويق", false, null, "M@GMAIL.COM", "M@GMAIL.COM", "AIZZzSqW/GzRhdOvEqKcLdiH74mATxfQ9i6QKuLCOAS0+g+sImkDdohCpOp6mSZGvg==", "01100811024", true, null, "af83a596-6687-4e83-83af-38067661a29b", false, "m@gmail.com" },
                    { "b0157647-7016-41cc-9a56-3695acaa13e6", 0, 1, 2, "6aac7bba-2ca5-4fdd-b25f-1a570b7e37d8", new DateTime(2022, 8, 13, 13, 59, 58, 9, DateTimeKind.Local).AddTicks(3876), "Developer", "f0157647-7016-41cc-9a56-3695acaa13e6", "ps@gmail.com", true, "مشرف", "مشاريع", false, null, "PS@GMAIL.COM", "PS@GMAIL.COM", "AEtnaSryqSsDHy1Kb8ATy/cTh7hixeZ7iP6KvYGUWpWs5iKZXmq2ncV/HGSpsScyhA==", "01100811024", true, null, "7b71cc15-10b3-4ea8-b49d-43859d5b763d", false, "ps@gmail.com" },
                    { "k71282ed-85cf-4f7c-9e05-4b28051d04e4", 0, 1, 6, "d0553469-869e-40f2-bb07-dcfda6c604e0", new DateTime(2022, 8, 13, 13, 59, 58, 12, DateTimeKind.Local).AddTicks(7177), "Developer", "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", "pMonitor@gmail.com", true, "مراقب", "مشاريع", false, null, "PMONITOR@GMAIL.COM", "PMONITOR@GMAIL.COM", "AGOwtNjBFZLZO7053LflAG66DX0gs/RwRSF55S6u4JFDEiTxpV4hXPfETImsiLX1Kg==", "01100811024", true, null, "0985ea2e-94ca-4c30-94fa-80ce1b37c9de", false, "pMonitor@gmail.com" },
                    { "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", 0, 1, 4, "1453db57-193e-4e1c-80b8-59a4278755d3", new DateTime(2022, 8, 13, 13, 59, 58, 10, DateTimeKind.Local).AddTicks(9149), "Developer", "62fe29f0-c227-4a03-b2f6-z97279b2bc23", "p@gmail.com", true, "شؤون", "موظفين", false, null, "P@GMAIL.COM", "P@GMAIL.COM", "AJeq7TjIStEXC1pFjnEYCucWj/oorUDmPWV3flKfHwzuln5BmmAxIWEC90nwFzsGyg==", "01100811024", true, null, "3a059219-e840-4c0f-bf06-2ae1da096bec", false, "p@gmail.com" },
                    { "x313a786-637d-40c5-8715-543bba115487", 0, 1, 7, "b3ce9523-3099-4659-b7d4-8dffe859ac8d", new DateTime(2022, 8, 13, 13, 59, 58, 13, DateTimeKind.Local).AddTicks(3989), "Developer", "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", "pe@gmail.com", true, "مهندس", "مشاريع", false, null, "PE@GMAIL.COM", "PE@GMAIL.COM", "AL0wMzyMUmfHolHtCMVzFZG/Ywl5cX26EKe44TAS72gBZHaG9w+NS62D3n+yV47WrQ==", "01100811024", true, null, "b763f3d9-7dfa-4044-9224-c69bb37ebb19", false, "pe@gmail.com" },
                    { "zecb5d3d-a7f3-4751-8ae5-724e07889bd6", 0, 1, 8, "f85f02a8-1e26-49cd-bed3-9649c0309765", new DateTime(2022, 8, 13, 13, 59, 58, 14, DateTimeKind.Local).AddTicks(762), "Developer", "62fe29f0-c227-4a03-b2f6-z97279b2bc23", "f@gmail.com", true, "المالية", "مالية", false, null, "F@GMAIL.COM", "F@GMAIL.COM", "APWvK9Bcwh28CoAPCDNWTuI91/jpNQzj6WWNWhLpW/189c1aJ3/dDikHDxTAdlJHFQ==", "01100811024", true, null, "78ba5c57-6f8e-43ed-ba52-e07c7e553406", false, "f@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "BaseUserId", "BillsFile", "ClientName", "ClientStatus", "Code", "CreatedAt", "CreatedBy", "DepartmentId", "ModifiedBy", "Notes", "PhoneNumber", "UpdatedAt" },
                values: new object[,]
                {
                    { "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "Client Ahmed", 2, 1, new DateTime(2022, 8, 13, 13, 59, 58, 14, DateTimeKind.Local).AddTicks(7645), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "ملاحظات من المبرمج ", "035453650", new DateTime(2022, 8, 13, 13, 59, 58, 14, DateTimeKind.Local).AddTicks(7643) },
                    { "b0157647-7016-41cc-9a56-3695acaa13e6", "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "Client Ahmed2", 2, 2, new DateTime(2022, 8, 13, 13, 59, 58, 14, DateTimeKind.Local).AddTicks(7650), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "2ملاحظات من المبرمج ", "01122332150", new DateTime(2022, 8, 13, 13, 59, 58, 14, DateTimeKind.Local).AddTicks(7649) },
                    { "c3d0584e-fcd7-439c-8ae1-g5734664d6f4", "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "Client Ahmed 3 ", 2, 3, new DateTime(2022, 8, 13, 13, 59, 58, 14, DateTimeKind.Local).AddTicks(7652), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "2ملاحظات من المبرمج ", "24400", new DateTime(2022, 8, 13, 13, 59, 58, 14, DateTimeKind.Local).AddTicks(7651) }
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
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
