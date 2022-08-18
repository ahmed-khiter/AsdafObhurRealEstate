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
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    { "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", 0, 1, 1, "c6ba1da2-70a0-42a5-90a4-ccc8eac36709", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", null, "gm@gmail.com", true, "المدير", "العام", false, null, "GM@GMAIL.COM", "GM@GMAIL.COM", "ALKyjdyF2kVmEvimIEI4525LNnwzBWJzzAzrdQW5B7emCxhEe9r9u4nkjREkOlW1dQ==", "01100811024", true, null, "5356d251-7e0d-4cb3-b734-347db0a7b1a3", false, "gm@gmail.com" },
                    { "c3d0584e-fcd7-439c-8ae1-g5734664d6f4", 0, 1, 3, "3fb091f5-8114-4efa-a8f5-ddd281523fbb", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", null, "es@gmail.com", true, "سكرتير", "التنفيذي", false, null, "ES@GMAIL.COM", "ES@GMAIL.COM", "ACOQKXTR6l51zbunG/0P0d5Ah8YA/FLDgixSxTCbTz3UQIklrCBd0ED0yCDuTpbzjA==", "01100811024", true, null, "7b7276bc-e2c9-45e4-9107-f8fa085ea671", false, "es@gmail.com" }
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
                    { "82fe29f0-c227-4a03-b2f6-z97279b2bc23", 0, 1, 5, "423fdc6e-26a2-4960-97ff-83d6c429d399", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", "m@gmail.com", true, "تسويق", "تسويق", false, null, "M@GMAIL.COM", "M@GMAIL.COM", "AOeqJgTvAb/L9VGFOJ7bV6Y20v+KG8x85yftLBVujXBzaJTO14FgS9LJfbo1w+kJkA==", "01100811024", true, null, "22387486-81d1-4b11-ad5b-e32c7a847397", false, "m@gmail.com" },
                    { "b0157647-7016-41cc-9a56-3695acaa13e6", 0, 1, 2, "7a8b6ec0-6bc5-4ce7-a8e4-51656fbe14bf", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", "f0157647-7016-41cc-9a56-3695acaa13e6", "ps@gmail.com", true, "مشرف", "مشاريع", false, null, "PS@GMAIL.COM", "PS@GMAIL.COM", "ABOHW6f8xQ3C3Fi5ETHnLGZlsDTUntp2S+pSluRO9OuWqZRdkIiY/K4z6JypKJnCRQ==", "01100811024", true, null, "66166ad8-a3db-4a9b-b7be-e219bcb7a2e4", false, "ps@gmail.com" },
                    { "k71282ed-85cf-4f7c-9e05-4b28051d04e4", 0, 1, 6, "38fb86f8-2ad5-4cfe-862b-e225cf1ef7cd", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", "pMonitor@gmail.com", true, "مراقب", "مشاريع", false, null, "PMONITOR@GMAIL.COM", "PMONITOR@GMAIL.COM", "AHxEUZM3HuwDBNxTTO8e5B9xydNCps3FJ8SlNBbSbvfNVtkVBik2yQQNUGzq+ItYBw==", "01100811024", true, null, "e7d73efd-6b52-4d5a-b8cf-66fa50978385", false, "pMonitor@gmail.com" },
                    { "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", 0, 1, 4, "8534a137-b420-420b-a13e-22bce6bffa23", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", "62fe29f0-c227-4a03-b2f6-z97279b2bc23", "p@gmail.com", true, "شؤون", "موظفين", false, null, "P@GMAIL.COM", "P@GMAIL.COM", "AAsiEFqnjI3VWg0xi55Gs85E2Sd/H/+S6YZZ8MdPyrDn9FoBR4uzkzJwaJdiIqJFRg==", "01100811024", true, null, "fe3d360b-2c16-4859-9c9e-d8a16faa4bb7", false, "p@gmail.com" },
                    { "x313a786-637d-40c5-8715-543bba115487", 0, 1, 7, "aa379277-610d-46ef-b433-d4abf6e93d12", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", "pe@gmail.com", true, "مهندس", "مشاريع", false, null, "PE@GMAIL.COM", "PE@GMAIL.COM", "APfOHTK4Ye/KUNoVfgEP1ZJVDyXS2MLW7EGChlHPpJ2ZrAbIilS0H2yRF+tX1TCVTA==", "01100811024", true, null, "9d84773c-8a91-47b8-91bc-b0e7ac203d44", false, "pe@gmail.com" },
                    { "zecb5d3d-a7f3-4751-8ae5-724e07889bd6", 0, 1, 8, "fbd8e8fb-65bb-499f-9869-83fbee5e3010", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer", "62fe29f0-c227-4a03-b2f6-z97279b2bc23", "f@gmail.com", true, "المالية", "مالية", false, null, "F@GMAIL.COM", "F@GMAIL.COM", "ALGR/QaCNJwITDVYFMQDGw4dAuJm+QMZ/LyW0+n7wcdi6EI1oGiOcRbaF4T+6kFJ7g==", "01100811024", true, null, "d8786704-a986-4c05-a319-91f1a12380bb", false, "f@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "BaseUserId", "BillsFile", "ClientName", "ClientStatus", "Code", "CreatedAt", "CreatedBy", "DepartmentId", "ModifiedBy", "Notes", "PhoneNumber", "UpdatedAt" },
                values: new object[,]
                {
                    { "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "Client Ahmed", 2, 1, new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "ملاحظات من المبرمج ", "035453650", new DateTime(2022, 8, 18, 18, 50, 54, 940, DateTimeKind.Local).AddTicks(2987) },
                    { "b0157647-7016-41cc-9a56-3695acaa13e6", null, "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "Client Ahmed2", 2, 2, new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "2ملاحظات من المبرمج ", "01122332150", new DateTime(2022, 8, 18, 18, 50, 54, 940, DateTimeKind.Local).AddTicks(2993) },
                    { "c3d0584e-fcd7-439c-8ae1-g5734664d6f4", null, "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "Client Ahmed 3 ", 2, 3, new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e", null, "2ملاحظات من المبرمج ", "24400", new DateTime(2022, 8, 18, 18, 50, 54, 940, DateTimeKind.Local).AddTicks(2996) }
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
