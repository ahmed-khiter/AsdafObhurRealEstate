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
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillsFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ClientID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multimedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Multimedias_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "42fe29f0-c227-4a03-b2f6-c97279b2bc23", "1cad508f-2eeb-434e-a798-54279089fce8", "Marketing", "MARKETING" },
                    { "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6", "a29ea321-1336-4ec9-99b8-d657be58885c", "Financial", "FINANCIAL" },
                    { "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e", "797aebff-0a7e-41bf-b726-52f2be1150c8", "GeneralManager", "GENERALMANAGER" },
                    { "a0157647-7016-41cc-9a56-8695acaa13e6", "6a520722-70c2-4393-9cdf-b4f54315ea95", "ProjectSupervisor", "PROJECTSUPERVISOR" },
                    { "b71282ed-85cf-4f7c-9e05-9b28051d04e4", "2a2e137c-715f-44e7-b947-56e3af12225e", "ProjectMonitor", "PROJECTMONITOR" },
                    { "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c", "7111939b-ebf6-472e-add9-42dbb21d59e3", "Personnel", "PERSONNEL" },
                    { "d3d0584e-fcd7-439c-8ae1-f5734664d6f4", "1d598462-dfbd-47a5-a416-7d2765c689df", "ExecutiveSecretary", "EXECUTIVESECRETARY" },
                    { "e313a786-637d-40c5-8715-443bba115487", "7fa73a81-3814-4a4c-bb1a-e32e4280a75e", "ProjectsEngineer", "PROJECTSENGINEER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountType", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DepartmentId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", 0, 1, "74bab8bc-12e4-4d53-a32e-e85a3a5b0ee5", new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1684), "Developer", null, "gm@gmail.com", true, "المدير", "العام", false, null, "GM@GMAIL.COM", "GM@GMAIL.COM", "ADs8rnfm4IMQaK3ClDyHOGizux5SJIsufQUte/DSj1TQfXptIG9niTHhHre+wqo+vA==", "01100811024", true, null, "e028e2fb-db12-4fb9-ab02-a430ce665b90", false, "gm@gmail.com" },
                    { "c3d0584e-fcd7-439c-8ae1-g5734664d6f4", 0, 1, "9c4eb44f-3b99-47d6-8650-c7da5e140deb", new DateTime(2022, 8, 11, 0, 9, 49, 619, DateTimeKind.Local).AddTicks(4922), "Developer", null, "es@gmail.com", true, "سكرتير", "التنفيذي", false, null, "ES@GMAIL.COM", "ES@GMAIL.COM", "AAUoQPb6SGEbsIa7N9yiPsv8dInbn0CGvIHl9E43+dQHc7t5knGIiynSIq5u0C1puQ==", "01100811024", true, null, "0dcc42d4-240e-4325-8276-b6fc2d85cf74", false, "es@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedBy", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e", new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1652), "Developer", "Developer", "الديكور", new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1653) },
                    { "62fe29f0-c227-4a03-b2f6-z97279b2bc23", new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1661), "Developer", "Developer", "المالية", new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1661) },
                    { "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1659), "Developer", "Developer", "الأعلام و التسويق", new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1659) },
                    { "f0157647-7016-41cc-9a56-3695acaa13e6", new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1655), "Developer", "Developer", "العقار", new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1656) },
                    { "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1657), "Developer", "Developer", "المقاولات", new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1657) }
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
                columns: new[] { "Id", "AccessFailedCount", "AccountType", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DepartmentId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "82fe29f0-c227-4a03-b2f6-z97279b2bc23", 0, 1, "d24eeec3-643e-43b4-884e-75ebc5010c27", new DateTime(2022, 8, 11, 0, 9, 49, 620, DateTimeKind.Local).AddTicks(7828), "Developer", "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", "m@gmail.com", true, "تسويق", "تسويق", false, null, "M@GMAIL.COM", "M@GMAIL.COM", "AJexQ9r+1UyNIlmWFvr/JTOTbTYdT5UgMxwrtWzh0TnlSV59YeDdUAFjM6ZzRa9rgA==", "01100811024", true, null, "902cf20d-28cc-4dd5-9aaa-cc3346e02515", false, "m@gmail.com" },
                    { "b0157647-7016-41cc-9a56-3695acaa13e6", 0, 1, "05ddab0a-59dc-46c0-853a-8414d6655eaa", new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(8472), "Developer", "f0157647-7016-41cc-9a56-3695acaa13e6", "ps@gmail.com", true, "مشرف", "مشاريع", false, null, "PS@GMAIL.COM", "PS@GMAIL.COM", "AOaqg5dkdBIUYGsR/82FlPhfuajWnIgUNKHFOqgWAkx2D29Z3JoVomtzSB4gzZlu6w==", "01100811024", true, null, "09d5fc4c-8e02-40bf-863c-4255d3a864a1", false, "ps@gmail.com" },
                    { "k71282ed-85cf-4f7c-9e05-4b28051d04e4", 0, 1, "c9cdbaba-c5e5-42c6-8864-ca9322c941b8", new DateTime(2022, 8, 11, 0, 9, 49, 621, DateTimeKind.Local).AddTicks(6585), "Developer", "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", "pMonitor@gmail.com", true, "مراقب", "مشاريع", false, null, "PMONITOR@GMAIL.COM", "PMONITOR@GMAIL.COM", "AGXlevEmcJ5giPsbsT3/KVQ8aq8BKyNYy6sUpykRxY5B3LpKx8B0E4ApXH6hhwP9BQ==", "01100811024", true, null, "ecc1d0ae-1652-4c54-b0ca-1c4f2a4ef432", false, "pMonitor@gmail.com" },
                    { "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", 0, 1, "cb555aba-af6a-4c10-b784-642b0429d98d", new DateTime(2022, 8, 11, 0, 9, 49, 620, DateTimeKind.Local).AddTicks(1389), "Developer", "62fe29f0-c227-4a03-b2f6-z97279b2bc23", "p@gmail.com", true, "شؤون", "موظفين", false, null, "P@GMAIL.COM", "P@GMAIL.COM", "AKTYMNKcVUqmTw7S0mz+XK1Ie73bKWfxWZiscFdfz1yvqwFlyI69eInSZtHIOv5GZw==", "01100811024", true, null, "a9b14a1b-2889-4547-862a-da486972ca12", false, "p@gmail.com" },
                    { "x313a786-637d-40c5-8715-543bba115487", 0, 1, "77561481-579f-4267-b2fc-411b7b4c6983", new DateTime(2022, 8, 11, 0, 9, 49, 622, DateTimeKind.Local).AddTicks(3486), "Developer", "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", "pe@gmail.com", true, "مهندس", "مشاريع", false, null, "PE@GMAIL.COM", "PE@GMAIL.COM", "AKTbSVrLP9rEPFQ6pMI3GN3JIPIbS9hULgWg4EwiKJklg7n33e7HpgwhD8XHU7J3Pw==", "01100811024", true, null, "c968ca09-f755-4111-a306-50d8b3c7a825", false, "pe@gmail.com" },
                    { "zecb5d3d-a7f3-4751-8ae5-724e07889bd6", 0, 1, "34729ef4-db74-4f07-b7de-52237187123d", new DateTime(2022, 8, 11, 0, 9, 49, 623, DateTimeKind.Local).AddTicks(3190), "Developer", "62fe29f0-c227-4a03-b2f6-z97279b2bc23", "f@gmail.com", true, "المالية", "مالية", false, null, "F@GMAIL.COM", "F@GMAIL.COM", "AMDMZGmi0wWHCGqeN/om7jHq3Uuc/6FQgF1vFo+AZtju+4CSw/OlMgcl5W4qU3Rn3Q==", "01100811024", true, null, "eed4f5cc-5df3-4785-9154-860610affbbc", false, "f@gmail.com" }
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
                name: "IX_Multimedias_ClientID",
                table: "Multimedias",
                column: "ClientID");
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
