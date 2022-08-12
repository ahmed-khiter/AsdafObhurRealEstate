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
                    { "42fe29f0-c227-4a03-b2f6-c97279b2bc23", "273e60af-c143-491f-8b4c-67aca602b261", "Marketing", "MARKETING" },
                    { "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6", "0f32509f-150b-40a2-b2cc-e341142f4a6e", "Financial", "FINANCIAL" },
                    { "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e", "9cc4db53-31ab-4054-a370-2cc868c02b51", "GeneralManager", "GENERALMANAGER" },
                    { "a0157647-7016-41cc-9a56-8695acaa13e6", "67913d4a-be08-48c2-a0ed-8a15449ca4d8", "ProjectSupervisor", "PROJECTSUPERVISOR" },
                    { "b71282ed-85cf-4f7c-9e05-9b28051d04e4", "2ae6c2df-05be-4824-8d86-971a6c6b5369", "ProjectMonitor", "PROJECTMONITOR" },
                    { "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c", "d76050ba-9431-471b-83e8-a6e585304502", "Personnel", "PERSONNEL" },
                    { "d3d0584e-fcd7-439c-8ae1-f5734664d6f4", "093394be-cdec-46e2-b144-0c44a34e7f5b", "ExecutiveSecretary", "EXECUTIVESECRETARY" },
                    { "e313a786-637d-40c5-8715-443bba115487", "c7e3f0fd-7a7c-4c70-8cd4-184eebc6d7eb", "ProjectsEngineer", "PROJECTSENGINEER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountType", "Code", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DepartmentId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePic", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e", 0, 1, 0, "f250516d-bf8d-4de7-8bd2-c10517ab71ff", new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7364), "Developer", null, "gm@gmail.com", true, "المدير", "العام", false, null, "GM@GMAIL.COM", "GM@GMAIL.COM", "APA1GTBMecexo9ISAMt0CM+1qRikaJfUbG91vE7gU9bfm5GsNL5bFwcb2I/q2uPtPA==", "01100811024", true, null, "4847121d-2c6b-485a-9943-05bd5b00d3bd", false, "gm@gmail.com" },
                    { "c3d0584e-fcd7-439c-8ae1-g5734664d6f4", 0, 1, 0, "d673c9e3-066f-43cc-a698-9f26001d9653", new DateTime(2022, 8, 12, 1, 41, 37, 609, DateTimeKind.Local).AddTicks(1807), "Developer", null, "es@gmail.com", true, "سكرتير", "التنفيذي", false, null, "ES@GMAIL.COM", "ES@GMAIL.COM", "AGkZUMbArPqSjrkztxi4n2/RQwaR617eaD/Ausl9sXS8sbm4qkhm0YclKoncj4OZZg==", "01100811024", true, null, "1bfb4d67-45ec-4766-b7ba-4acaa8cc74de", false, "es@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedBy", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e", new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7325), "Developer", "Developer", "الديكور", new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7326) },
                    { "62fe29f0-c227-4a03-b2f6-z97279b2bc23", new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7334), "Developer", "Developer", "المالية", new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7334) },
                    { "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7332), "Developer", "Developer", "الأعلام و التسويق", new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7332) },
                    { "f0157647-7016-41cc-9a56-3695acaa13e6", new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7328), "Developer", "Developer", "العقار", new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7329) },
                    { "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7330), "Developer", "Developer", "المقاولات", new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7331) }
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
                    { "82fe29f0-c227-4a03-b2f6-z97279b2bc23", 0, 1, 0, "548db51c-ac4a-4c57-a9ba-db29fa495861", new DateTime(2022, 8, 12, 1, 41, 37, 610, DateTimeKind.Local).AddTicks(5514), "Developer", "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", "m@gmail.com", true, "تسويق", "تسويق", false, null, "M@GMAIL.COM", "M@GMAIL.COM", "AE2c+qFXCGcZIMfnUaK4qrQlnSJb2wOuEZ89AYR5kpq120It2tUBllbPXh80P3BPTw==", "01100811024", true, null, "a8f83ed8-a4a3-4b97-8335-2aa05dda419d", false, "m@gmail.com" },
                    { "b0157647-7016-41cc-9a56-3695acaa13e6", 0, 1, 0, "46347ec9-dbd1-4cdd-8475-4319b3d8a0dc", new DateTime(2022, 8, 12, 1, 41, 37, 608, DateTimeKind.Local).AddTicks(4959), "Developer", "f0157647-7016-41cc-9a56-3695acaa13e6", "ps@gmail.com", true, "مشرف", "مشاريع", false, null, "PS@GMAIL.COM", "PS@GMAIL.COM", "AL+cphKEA/qwevTqsSBr8V92F/s9BCFcqbIfR7TuSlPsYHdtYYNlhGzlO47uQOAa5A==", "01100811024", true, null, "6ccbaf9e-80e0-4146-ac79-1b902416cdf0", false, "ps@gmail.com" },
                    { "k71282ed-85cf-4f7c-9e05-4b28051d04e4", 0, 1, 0, "5106698d-ffbd-4916-be6a-26edecc656f0", new DateTime(2022, 8, 12, 1, 41, 37, 611, DateTimeKind.Local).AddTicks(2310), "Developer", "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", "pMonitor@gmail.com", true, "مراقب", "مشاريع", false, null, "PMONITOR@GMAIL.COM", "PMONITOR@GMAIL.COM", "AMc2L7evYhCAL7WOY1g2K2WMkxojxS/5DG8crPFFME0oat3DW/icLpmDHekgmSHREA==", "01100811024", true, null, "95394045-788b-4311-89c3-fe454d2fcc89", false, "pMonitor@gmail.com" },
                    { "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", 0, 1, 0, "1bf44382-2471-405b-816e-b06aa2b9902f", new DateTime(2022, 8, 12, 1, 41, 37, 609, DateTimeKind.Local).AddTicks(8706), "Developer", "62fe29f0-c227-4a03-b2f6-z97279b2bc23", "p@gmail.com", true, "شؤون", "موظفين", false, null, "P@GMAIL.COM", "P@GMAIL.COM", "AHilXuFXFdi8aOJiKLYIcjlQCwfEsc16CPuSSHvOlt/xLeBqenYcBeYJEvDULHl+ow==", "01100811024", true, null, "9fea7da8-ee98-41fd-bcfc-d6e4751c5a64", false, "p@gmail.com" },
                    { "x313a786-637d-40c5-8715-543bba115487", 0, 1, 0, "29941622-1ea9-4f29-84cb-dcf2de847353", new DateTime(2022, 8, 12, 1, 41, 37, 611, DateTimeKind.Local).AddTicks(9137), "Developer", "h3d0584e-fcd7-439c-8ae1-g5734664d6f4", "pe@gmail.com", true, "مهندس", "مشاريع", false, null, "PE@GMAIL.COM", "PE@GMAIL.COM", "AI5Y8P3jSAYP2k6BVd/bpkqaXrwpv3qzh6sHiKLceden59W3IaFbsX36VKFeBxtw5Q==", "01100811024", true, null, "e2535a42-6074-4cbf-ae0b-1016ee9c2a1e", false, "pe@gmail.com" },
                    { "zecb5d3d-a7f3-4751-8ae5-724e07889bd6", 0, 1, 0, "865a6577-1164-4ebe-824c-2f31f25b5dc8", new DateTime(2022, 8, 12, 1, 41, 37, 612, DateTimeKind.Local).AddTicks(5900), "Developer", "62fe29f0-c227-4a03-b2f6-z97279b2bc23", "f@gmail.com", true, "المالية", "مالية", false, null, "F@GMAIL.COM", "F@GMAIL.COM", "APGgalOTt8I8mPFwih3sI3BHSTbhQbV3NUtvgfy4XZ4uGgfivgW2neTcmMD97k+EAg==", "01100811024", true, null, "77f766af-608d-405c-8db4-246f836853a5", false, "f@gmail.com" }
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
