using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsdafObhurRealEstate.Migrations
{
    public partial class GenerateCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42fe29f0-c227-4a03-b2f6-c97279b2bc23",
                column: "ConcurrencyStamp",
                value: "c93d9163-dd93-4240-8926-364e48b7703d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6",
                column: "ConcurrencyStamp",
                value: "6a82aed9-61fc-4b5f-bd86-52f13accb2dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e",
                column: "ConcurrencyStamp",
                value: "59ff36a2-a86e-48cd-8899-9afc2bb80174");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0157647-7016-41cc-9a56-8695acaa13e6",
                column: "ConcurrencyStamp",
                value: "30119297-1fd4-47d1-9a3f-da885fbe6fcd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b71282ed-85cf-4f7c-9e05-9b28051d04e4",
                column: "ConcurrencyStamp",
                value: "2d1bf106-779f-4397-979e-3ba2477a5767");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c",
                column: "ConcurrencyStamp",
                value: "915e78f6-eaad-4fae-a0cb-6624f43c0a77");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3d0584e-fcd7-439c-8ae1-f5734664d6f4",
                column: "ConcurrencyStamp",
                value: "ba30dc7b-69db-4ce7-adda-02f82a229a62");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e313a786-637d-40c5-8715-443bba115487",
                column: "ConcurrencyStamp",
                value: "2699b7cf-d626-4a77-b29c-08c2d3924ca4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "Code", "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { 1, "9b0589f7-f799-46b5-9afe-a906bc1e484e", new DateTime(2022, 8, 13, 10, 24, 0, 571, DateTimeKind.Local).AddTicks(6772), "AGhfN6F0K3y9+KqJQSFBtpaOzotBFlgDDwBo5xSMnXt1EKxJh4vHWY3i461WwZLQMA==", "41dd1b61-e82a-4574-b5e8-ccee2f986120" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "Code", "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { 5, "e60ec1d9-64f2-4a04-95c5-d85c63c0b89a", new DateTime(2022, 8, 13, 10, 24, 0, 574, DateTimeKind.Local).AddTicks(6982), "AFFc/kxjx7nNh5r0Q5Jkh34lXWjtg5btw4M3D7/NdnStYrDWkHsAzi1MuQJvlqSe2A==", "bd6ef440-2a86-4685-b162-d8068328578b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "Code", "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { 2, "b7611167-c6e0-4400-a299-b94f3b54847d", new DateTime(2022, 8, 13, 10, 24, 0, 572, DateTimeKind.Local).AddTicks(3898), "ANfYgsqEMFhthIlgm9jUwReHRNF9Iw5xTsaTBP1QC2nNFSbHYRtdNZ/YdxDO4+F4Kw==", "64d2cec5-d1db-4cfd-900c-92d5ce8d066f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "Code", "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { 3, "7f321262-3cc8-4267-a703-a6e51cfc97dc", new DateTime(2022, 8, 13, 10, 24, 0, 573, DateTimeKind.Local).AddTicks(837), "AJw9no1mOuqAq2ZU2YN+2NSXmraXsenliJ8GsC6t6BeQeXFEESsvMXd4clX8R+XECg==", "48263cc8-4bf4-4199-b4ec-78d0d5edc7e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k71282ed-85cf-4f7c-9e05-4b28051d04e4",
                columns: new[] { "Code", "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { 6, "2e9d4830-f623-4812-9f3c-b5d46dd2765b", new DateTime(2022, 8, 13, 10, 24, 0, 575, DateTimeKind.Local).AddTicks(3890), "AK7cuCvZPpAxnneCVH/rhZv5g+jQsz+rP6GgXrDoDR0TW+52jv9vSqBLZUya3GjO2w==", "a364c234-0c33-4a86-a7c6-f59ab9d8f024" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "Code", "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { 4, "6cc42499-4b1b-4de7-8242-b350035b3871", new DateTime(2022, 8, 13, 10, 24, 0, 573, DateTimeKind.Local).AddTicks(9498), "AC4juSqQZf3k1xeJBA0c5lof9S51bwDLJwC9otKMEYa72KAdOApN2h9ZPS0SCzi2EQ==", "4e8edb17-2da5-4403-9a58-40c246518f7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "Code", "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { 7, "83211ab7-91e6-4ab6-83b5-c81a55713fd6", new DateTime(2022, 8, 13, 10, 24, 0, 576, DateTimeKind.Local).AddTicks(368), "APUoWoU5QCs6WuM5GJoMCJMxddTPqK3cnvbadqnFL6IlAZQUWaCwcG/qjM9EOwDSBQ==", "949e7231-d45c-4671-9bd4-f37e3d60c573" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "Code", "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { 8, "a2a1b604-8016-422b-b440-f7736a2337bb", new DateTime(2022, 8, 13, 10, 24, 0, 576, DateTimeKind.Local).AddTicks(7589), "AGK/AXZ+P36HjdsSUU4SkRud+lxyiI745x0jL3XdWycsWY4/xfHpQ438xiED23Wf5Q==", "7808796b-2d58-46da-adf9-211b33017a4f" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 10, 24, 0, 577, DateTimeKind.Local).AddTicks(4316), new DateTime(2022, 8, 13, 10, 24, 0, 577, DateTimeKind.Local).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 10, 24, 0, 577, DateTimeKind.Local).AddTicks(4319), new DateTime(2022, 8, 13, 10, 24, 0, 577, DateTimeKind.Local).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 10, 24, 0, 577, DateTimeKind.Local).AddTicks(4321), new DateTime(2022, 8, 13, 10, 24, 0, 577, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 10, 24, 0, 571, DateTimeKind.Local).AddTicks(6733), new DateTime(2022, 8, 13, 10, 24, 0, 571, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "62fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 10, 24, 0, 571, DateTimeKind.Local).AddTicks(6742), new DateTime(2022, 8, 13, 10, 24, 0, 571, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 10, 24, 0, 571, DateTimeKind.Local).AddTicks(6740), new DateTime(2022, 8, 13, 10, 24, 0, 571, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "f0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 10, 24, 0, 571, DateTimeKind.Local).AddTicks(6736), new DateTime(2022, 8, 13, 10, 24, 0, 571, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 10, 24, 0, 571, DateTimeKind.Local).AddTicks(6738), new DateTime(2022, 8, 13, 10, 24, 0, 571, DateTimeKind.Local).AddTicks(6739) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42fe29f0-c227-4a03-b2f6-c97279b2bc23",
                column: "ConcurrencyStamp",
                value: "be96fd1d-6684-491d-9f63-59fdb4c3685a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6",
                column: "ConcurrencyStamp",
                value: "ba286cf4-5a5c-47a7-9cb0-d5e07c951995");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e",
                column: "ConcurrencyStamp",
                value: "bd3d4a74-6c23-48ac-941a-1a8e25275335");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0157647-7016-41cc-9a56-8695acaa13e6",
                column: "ConcurrencyStamp",
                value: "6ec5744e-d82e-48dc-9971-6427b16d46cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b71282ed-85cf-4f7c-9e05-9b28051d04e4",
                column: "ConcurrencyStamp",
                value: "25c6f676-40db-40f0-9cc3-b6e765749813");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c",
                column: "ConcurrencyStamp",
                value: "2dd527f1-aefd-4cb6-94b6-cfcad8f48152");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3d0584e-fcd7-439c-8ae1-f5734664d6f4",
                column: "ConcurrencyStamp",
                value: "c2761ce8-60f3-4226-93e0-3919ce18dc4d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e313a786-637d-40c5-8715-443bba115487",
                column: "ConcurrencyStamp",
                value: "e06ba68f-1f31-4876-9bcb-acc54dcef70f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "Code", "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "d1104ef8-168b-4e9b-9afb-33871cb967c6", new DateTime(2022, 8, 13, 2, 27, 32, 812, DateTimeKind.Local).AddTicks(6343), "AJ7XSvxoP+r7gNMrklS/6SBad4d9M9cgWCoREp/xsHuLwugjaNVjHwctbwNXzlCwuA==", "3e55e6a8-e953-484f-9cb7-026b02b1e591" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "Code", "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "4a048d44-b3e5-4869-9356-f2310fed10a8", new DateTime(2022, 8, 13, 2, 27, 32, 817, DateTimeKind.Local).AddTicks(1195), "AKQf+sKBplj7ODouwViG+84P3c6Q3w2YCbE9vW3C3sLtmihOZhV1tLv0Puw0mfrwiQ==", "1eab708a-0597-4e30-aa67-88a8d9fd0a96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "Code", "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "6549da6b-6526-4c96-8744-540dbb1c7ae0", new DateTime(2022, 8, 13, 2, 27, 32, 814, DateTimeKind.Local).AddTicks(749), "AHrxDWoRZ1FJ/G7USjXQ/6I8cYubT/fjs8KFWluh1oDtQkD2qMTu4PgyhiA9QL+Fbg==", "a0d6bf5b-6efc-4e8c-9062-f2ebb9517b62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "Code", "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "32bfca20-5b70-444c-acec-2ef67fe98692", new DateTime(2022, 8, 13, 2, 27, 32, 815, DateTimeKind.Local).AddTicks(3912), "ANMerd2DAXRBEsz+NDHzRsf7zVp3+S9KS+nGICf6YEMFq7PfR8mPT5ygdsDNJXWIog==", "eca13395-865c-4c10-a470-d222386c499e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k71282ed-85cf-4f7c-9e05-4b28051d04e4",
                columns: new[] { "Code", "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "0ebe9f59-d9a8-4553-a589-76dcfb4edf13", new DateTime(2022, 8, 13, 2, 27, 32, 818, DateTimeKind.Local).AddTicks(1427), "AL+57wJEzJRal0imKSz6/84543T6U7L3su63wdXbCAoP+nPtar5s7kp/2v6i953mBg==", "e891aeb9-c3f8-4210-ac82-fe4f159dd430" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "Code", "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "8ef3fe14-ba86-4c55-9b99-a77a9611d3a0", new DateTime(2022, 8, 13, 2, 27, 32, 816, DateTimeKind.Local).AddTicks(3453), "AJQ2Tl6XmUrIWrSYrXa+Gpyieke4fBxNl6Nm5E11mO5mP7704/kyWX6NulmP+47d0g==", "ff1ed80f-12c3-4478-a015-802928fab704" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "Code", "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "9c6188e1-36ac-4fe2-90c1-1f7abaf8f7bb", new DateTime(2022, 8, 13, 2, 27, 32, 818, DateTimeKind.Local).AddTicks(8847), "AI19OpX8fZeGvGOKxE+xaC9v2+P/MVhXyMm+MTGWgY4BjPFBo2WPDo30S/drihZNWw==", "03d96971-6c09-439a-a343-61181eb15bf6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "Code", "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "43e43819-c248-4622-af3b-f70228af8601", new DateTime(2022, 8, 13, 2, 27, 32, 819, DateTimeKind.Local).AddTicks(6474), "AM375cKaIK0ZM1ejgFMAhuEfVndNgZjqIy1Ja4VSi1+AZJHRsGZnMGHJw7IVHwje+w==", "e5ca8478-c7dd-41e9-bf5e-e9225ad95237" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 2, 27, 32, 820, DateTimeKind.Local).AddTicks(5712), new DateTime(2022, 8, 13, 2, 27, 32, 820, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 2, 27, 32, 820, DateTimeKind.Local).AddTicks(5716), new DateTime(2022, 8, 13, 2, 27, 32, 820, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 2, 27, 32, 820, DateTimeKind.Local).AddTicks(5719), new DateTime(2022, 8, 13, 2, 27, 32, 820, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 2, 27, 32, 812, DateTimeKind.Local).AddTicks(6257), new DateTime(2022, 8, 13, 2, 27, 32, 812, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "62fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 2, 27, 32, 812, DateTimeKind.Local).AddTicks(6304), new DateTime(2022, 8, 13, 2, 27, 32, 812, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 2, 27, 32, 812, DateTimeKind.Local).AddTicks(6302), new DateTime(2022, 8, 13, 2, 27, 32, 812, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "f0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 2, 27, 32, 812, DateTimeKind.Local).AddTicks(6260), new DateTime(2022, 8, 13, 2, 27, 32, 812, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 2, 27, 32, 812, DateTimeKind.Local).AddTicks(6262), new DateTime(2022, 8, 13, 2, 27, 32, 812, DateTimeKind.Local).AddTicks(6263) });
        }
    }
}
