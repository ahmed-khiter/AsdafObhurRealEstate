using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsdafObhurRealEstate.Migrations
{
    public partial class addedNoteToClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42fe29f0-c227-4a03-b2f6-c97279b2bc23",
                column: "ConcurrencyStamp",
                value: "36c2c10d-cd0c-4a5c-a0a0-490565cdea4b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6",
                column: "ConcurrencyStamp",
                value: "a0214b0a-e138-451c-872f-b59081c605d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e",
                column: "ConcurrencyStamp",
                value: "90d14d90-7404-48e1-a5b4-6d7bd7818120");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0157647-7016-41cc-9a56-8695acaa13e6",
                column: "ConcurrencyStamp",
                value: "258d7654-f605-4621-a38c-ec474381cae2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b71282ed-85cf-4f7c-9e05-9b28051d04e4",
                column: "ConcurrencyStamp",
                value: "132b5192-4921-4770-998f-6cfab5df9e37");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c",
                column: "ConcurrencyStamp",
                value: "ea291647-56f1-4725-b10a-5d96abc7792d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3d0584e-fcd7-439c-8ae1-f5734664d6f4",
                column: "ConcurrencyStamp",
                value: "f2fd3b7a-cf72-4ba4-aa64-e79ac85a58a2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e313a786-637d-40c5-8715-443bba115487",
                column: "ConcurrencyStamp",
                value: "f197b71b-c5e3-4bf1-9b7c-7eef9c2ef943");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd96ef8a-d8af-4af6-bc4c-117d0191dcd4", new DateTime(2022, 8, 13, 0, 26, 28, 285, DateTimeKind.Local).AddTicks(8893), "ALGBZSgPdNroYdiyGcg/C+CKy5row6lf/MlkkT4/UeA9+uJnkcNtKOoPn5O0GjauUw==", "231d2cd8-2728-4f79-ba6d-fde50ff09131" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "024275b1-0bdf-4056-99d6-e60842a646d7", new DateTime(2022, 8, 13, 0, 26, 28, 289, DateTimeKind.Local).AddTicks(265), "AM7dhFh9v+/7X+EOXuj7hoRxC0bynm3QGNs/k/PzE4yl+F+WrSAXODBmldetWDiHCA==", "8dfb98a2-a0d5-4392-b538-4c24a8713c20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60b92d23-0211-42f1-bb94-aa1579cc7edc", new DateTime(2022, 8, 13, 0, 26, 28, 286, DateTimeKind.Local).AddTicks(7851), "ALck2xGaELlif0Ju8hB2O5lyzVgbvMBKEwCbaswJGkWMt3TMG8B4EA2eVQB3N8gwMg==", "1ab221d9-9541-4596-ab8a-a4eee7c096da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "041c29af-f0c7-4d57-93b5-d2545f50372c", new DateTime(2022, 8, 13, 0, 26, 28, 287, DateTimeKind.Local).AddTicks(5306), "AMfuvavzAsBi7ELpdBAbmfvo6uEMQD1Og+ihunNMJBrM1V+QLc87OJuVXXUJin1cNw==", "23d7767e-a9e3-447a-bb71-cf7049cb8ba3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k71282ed-85cf-4f7c-9e05-4b28051d04e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "704b957c-b371-4860-9474-c077a5f3a748", new DateTime(2022, 8, 13, 0, 26, 28, 289, DateTimeKind.Local).AddTicks(8170), "AKkbRy37rqkH0cNkf2+51ljnnnlja4W3YyMU92rGGhcfsvQ4ZIhHf4ThlrcS0U8DCA==", "661a93a0-e40f-4c00-8367-daa8cea42e26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3204b458-e9fc-4fa8-bfe1-880bc250769f", new DateTime(2022, 8, 13, 0, 26, 28, 288, DateTimeKind.Local).AddTicks(3142), "AGlLiVPJ3bp/uh96YVwErBsrd/2RGx4pfP6U6I/ULpX2TMugEWcBr2+PMkG65wx7Rw==", "5017b430-a43c-475d-b1fc-9bf39361b538" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92031b21-06ac-43ce-95ca-f5374d5d8f5e", new DateTime(2022, 8, 13, 0, 26, 28, 290, DateTimeKind.Local).AddTicks(4930), "AJDDq9cTyGjaGvDn0c4haGKoPr9og3tz3o6n73MH/A9A+dCzwPsPg/s6QfKDZCzdOA==", "6d0e7245-920e-4df8-94a6-0b29ae8ec6e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a83ce9e-ba6a-4efd-97af-d226d9238bb4", new DateTime(2022, 8, 13, 0, 26, 28, 291, DateTimeKind.Local).AddTicks(2689), "AOcRbjf1cKGk8eeqaKMS6tmFLw0g14ifPgY6stktI70VpzfrYG1VJ+t5kaGSn1CVxg==", "4b40ed3c-483f-4ec8-81e8-2476290d77dc" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 0, 26, 28, 285, DateTimeKind.Local).AddTicks(8857), new DateTime(2022, 8, 13, 0, 26, 28, 285, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "62fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 0, 26, 28, 285, DateTimeKind.Local).AddTicks(8866), new DateTime(2022, 8, 13, 0, 26, 28, 285, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 0, 26, 28, 285, DateTimeKind.Local).AddTicks(8864), new DateTime(2022, 8, 13, 0, 26, 28, 285, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "f0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 0, 26, 28, 285, DateTimeKind.Local).AddTicks(8860), new DateTime(2022, 8, 13, 0, 26, 28, 285, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 0, 26, 28, 285, DateTimeKind.Local).AddTicks(8862), new DateTime(2022, 8, 13, 0, 26, 28, 285, DateTimeKind.Local).AddTicks(8863) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Clients");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42fe29f0-c227-4a03-b2f6-c97279b2bc23",
                column: "ConcurrencyStamp",
                value: "273e60af-c143-491f-8b4c-67aca602b261");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6",
                column: "ConcurrencyStamp",
                value: "0f32509f-150b-40a2-b2cc-e341142f4a6e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e",
                column: "ConcurrencyStamp",
                value: "9cc4db53-31ab-4054-a370-2cc868c02b51");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0157647-7016-41cc-9a56-8695acaa13e6",
                column: "ConcurrencyStamp",
                value: "67913d4a-be08-48c2-a0ed-8a15449ca4d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b71282ed-85cf-4f7c-9e05-9b28051d04e4",
                column: "ConcurrencyStamp",
                value: "2ae6c2df-05be-4824-8d86-971a6c6b5369");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c",
                column: "ConcurrencyStamp",
                value: "d76050ba-9431-471b-83e8-a6e585304502");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3d0584e-fcd7-439c-8ae1-f5734664d6f4",
                column: "ConcurrencyStamp",
                value: "093394be-cdec-46e2-b144-0c44a34e7f5b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e313a786-637d-40c5-8715-443bba115487",
                column: "ConcurrencyStamp",
                value: "c7e3f0fd-7a7c-4c70-8cd4-184eebc6d7eb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f250516d-bf8d-4de7-8bd2-c10517ab71ff", new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7364), "APA1GTBMecexo9ISAMt0CM+1qRikaJfUbG91vE7gU9bfm5GsNL5bFwcb2I/q2uPtPA==", "4847121d-2c6b-485a-9943-05bd5b00d3bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "548db51c-ac4a-4c57-a9ba-db29fa495861", new DateTime(2022, 8, 12, 1, 41, 37, 610, DateTimeKind.Local).AddTicks(5514), "AE2c+qFXCGcZIMfnUaK4qrQlnSJb2wOuEZ89AYR5kpq120It2tUBllbPXh80P3BPTw==", "a8f83ed8-a4a3-4b97-8335-2aa05dda419d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46347ec9-dbd1-4cdd-8475-4319b3d8a0dc", new DateTime(2022, 8, 12, 1, 41, 37, 608, DateTimeKind.Local).AddTicks(4959), "AL+cphKEA/qwevTqsSBr8V92F/s9BCFcqbIfR7TuSlPsYHdtYYNlhGzlO47uQOAa5A==", "6ccbaf9e-80e0-4146-ac79-1b902416cdf0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d673c9e3-066f-43cc-a698-9f26001d9653", new DateTime(2022, 8, 12, 1, 41, 37, 609, DateTimeKind.Local).AddTicks(1807), "AGkZUMbArPqSjrkztxi4n2/RQwaR617eaD/Ausl9sXS8sbm4qkhm0YclKoncj4OZZg==", "1bfb4d67-45ec-4766-b7ba-4acaa8cc74de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k71282ed-85cf-4f7c-9e05-4b28051d04e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5106698d-ffbd-4916-be6a-26edecc656f0", new DateTime(2022, 8, 12, 1, 41, 37, 611, DateTimeKind.Local).AddTicks(2310), "AMc2L7evYhCAL7WOY1g2K2WMkxojxS/5DG8crPFFME0oat3DW/icLpmDHekgmSHREA==", "95394045-788b-4311-89c3-fe454d2fcc89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bf44382-2471-405b-816e-b06aa2b9902f", new DateTime(2022, 8, 12, 1, 41, 37, 609, DateTimeKind.Local).AddTicks(8706), "AHilXuFXFdi8aOJiKLYIcjlQCwfEsc16CPuSSHvOlt/xLeBqenYcBeYJEvDULHl+ow==", "9fea7da8-ee98-41fd-bcfc-d6e4751c5a64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29941622-1ea9-4f29-84cb-dcf2de847353", new DateTime(2022, 8, 12, 1, 41, 37, 611, DateTimeKind.Local).AddTicks(9137), "AI5Y8P3jSAYP2k6BVd/bpkqaXrwpv3qzh6sHiKLceden59W3IaFbsX36VKFeBxtw5Q==", "e2535a42-6074-4cbf-ae0b-1016ee9c2a1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "865a6577-1164-4ebe-824c-2f31f25b5dc8", new DateTime(2022, 8, 12, 1, 41, 37, 612, DateTimeKind.Local).AddTicks(5900), "APGgalOTt8I8mPFwih3sI3BHSTbhQbV3NUtvgfy4XZ4uGgfivgW2neTcmMD97k+EAg==", "77f766af-608d-405c-8db4-246f836853a5" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7325), new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "62fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7334), new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7332), new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "f0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7328), new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7330), new DateTime(2022, 8, 12, 1, 41, 37, 607, DateTimeKind.Local).AddTicks(7331) });
        }
    }
}
