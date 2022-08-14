using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsdafObhurRealEstate.Migrations
{
    public partial class AddedAddressToClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42fe29f0-c227-4a03-b2f6-c97279b2bc23",
                column: "ConcurrencyStamp",
                value: "c91b9669-a5bf-4ba0-a621-3bf385074fac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6",
                column: "ConcurrencyStamp",
                value: "c3422861-7882-4912-af53-cc253427a85a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e",
                column: "ConcurrencyStamp",
                value: "e47f972e-07e3-41f0-a04d-d0f08b34d307");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0157647-7016-41cc-9a56-8695acaa13e6",
                column: "ConcurrencyStamp",
                value: "76fba6a8-ffa4-488d-8191-8bdd87eb8fcb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b71282ed-85cf-4f7c-9e05-9b28051d04e4",
                column: "ConcurrencyStamp",
                value: "f0b2b03a-d745-491f-8100-3ea9272d6580");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c",
                column: "ConcurrencyStamp",
                value: "912a002b-cb01-4c94-8c2f-fb37dd5658ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3d0584e-fcd7-439c-8ae1-f5734664d6f4",
                column: "ConcurrencyStamp",
                value: "bc4cfcf4-5e35-4abc-a8fc-088edfce6480");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e313a786-637d-40c5-8715-443bba115487",
                column: "ConcurrencyStamp",
                value: "80f0f7b4-29cc-4bd9-989f-085f43095ce5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c09b680-2244-411f-86ff-fc4a60c3f130", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AIIZFoWIpfTeRj6JZhE0RH4ip+qkF7Hcu+P+lGBF8+zfIdfDvA21Ex0REw4DY5CPxg==", "e89109b0-f2ce-47d2-8c0a-9d66104153db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61088ff4-925e-4d89-826a-0c18637b4b21", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AHzMh+8yxSRY/zTg/HfmqXyrRijP+OMIkeUbwtqAYpP7inqeSB+gU3cdmTkv0RaxLg==", "edca684d-31f4-420c-8acb-b40cfad8785e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4cf5b2d-f44f-4fb1-9c72-b23e35517b97", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AGQBmse3J9N/fEoVFx4m81ONJdVN3UWzJUe/e3lWTPyseqQK0xPVpDhVgwqd09fwTA==", "9c2f154b-c90c-4d76-9e82-00fa4e40f3a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf110940-2b00-4758-b13e-e9a327f0348f", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AFnkx2yIGB1cKGjFZTPiPbSRnLv5kHIuqxVAp0VwhH/3hF7oiI+4OPl3IjcPvex9VA==", "b5c61a13-cf0f-4270-bba4-94534fa8986c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k71282ed-85cf-4f7c-9e05-4b28051d04e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ba7cb56-ae2d-44bd-b3ba-16842cd19eec", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AIZeglSqPtbZLE8f9ddGIrDO/AAwF7905ydslDK+CzFY2QpTTZFlAyBOpWQIA3/wIA==", "fafe63f2-3a7e-4435-b1a0-c12d06a50b2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a10f586a-2e20-4f5b-8160-a32d99467a02", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AOc30b3KpLmQjeN04XCRyRDUfnWsWeUSeT4C6XNiZsZIzW0yTVcXyEkYXKoIypumdA==", "da4cb116-a06a-4ca5-a514-e3fa931970b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6200098-557e-428d-8059-dcfb0a9a538f", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "ALbIoV4hOQ6jAODF3PtNYhjP072DfAP+9zuY+rrCdZSFh3MsRJY+L0A8+DkI2f9p+A==", "59acd7ce-28b9-4143-8a76-6c1d09014cb1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "333cc64a-bdb9-4c98-9462-efcb073360fc", new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AInMWkqSKRcdxeqx6r1CR0pR2X1R2SLaaJgBiiXx7xLGLoYDJyRmhx9KlEAteD1KSQ==", "0f91a397-982d-46fd-a3a4-db6f852379a3" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 14, 22, 44, 0, 208, DateTimeKind.Local).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 14, 22, 44, 0, 208, DateTimeKind.Local).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 14, 22, 44, 0, 208, DateTimeKind.Local).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "62fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "f0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Clients");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42fe29f0-c227-4a03-b2f6-c97279b2bc23",
                column: "ConcurrencyStamp",
                value: "83ae465e-6777-48ff-8983-fb1a3e62f6ad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6",
                column: "ConcurrencyStamp",
                value: "b13f5b3c-6bcd-4ede-93d8-476c205d6931");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e",
                column: "ConcurrencyStamp",
                value: "b7d91ea6-4a30-4d87-9898-2282be2a8ee2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0157647-7016-41cc-9a56-8695acaa13e6",
                column: "ConcurrencyStamp",
                value: "7f5e6f34-e751-46a3-b868-64bc02590aa0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b71282ed-85cf-4f7c-9e05-9b28051d04e4",
                column: "ConcurrencyStamp",
                value: "d42ac547-afde-4f89-af16-086831b20ef1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c",
                column: "ConcurrencyStamp",
                value: "846b5fa5-fe75-4bc5-869c-c686468e816b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3d0584e-fcd7-439c-8ae1-f5734664d6f4",
                column: "ConcurrencyStamp",
                value: "d541d348-1ed6-4ea4-bf83-0def38b04870");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e313a786-637d-40c5-8715-443bba115487",
                column: "ConcurrencyStamp",
                value: "695bc937-9392-4065-b77b-7e6ed9376244");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68fd3b95-c2ec-44f2-a5b8-fd8f8f06e988", new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6944), "ABJ8PqwywNV0QrXQoi/OiBytOh0xe1y2jNlvWyvKuNpvMXT7cRtXLPu88Yj9+BLp6g==", "ced66b13-1ed3-4c1a-a8ad-25f031d00e7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e567255b-1c2b-490e-bd04-2da72493e5a7", new DateTime(2022, 8, 13, 13, 59, 58, 11, DateTimeKind.Local).AddTicks(8802), "AIZZzSqW/GzRhdOvEqKcLdiH74mATxfQ9i6QKuLCOAS0+g+sImkDdohCpOp6mSZGvg==", "af83a596-6687-4e83-83af-38067661a29b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6aac7bba-2ca5-4fdd-b25f-1a570b7e37d8", new DateTime(2022, 8, 13, 13, 59, 58, 9, DateTimeKind.Local).AddTicks(3876), "AEtnaSryqSsDHy1Kb8ATy/cTh7hixeZ7iP6KvYGUWpWs5iKZXmq2ncV/HGSpsScyhA==", "7b71cc15-10b3-4ea8-b49d-43859d5b763d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27cc1a1b-6575-4434-9d95-8393361f1a75", new DateTime(2022, 8, 13, 13, 59, 58, 10, DateTimeKind.Local).AddTicks(646), "AByb01yEeBCZoyqAzn1+NfJksgUgWixGkrUf58DMseAf+RJ0wkAoQQ+ZqqIEqVVuug==", "da9cf1e6-75f9-40ca-8c90-984243ed55b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k71282ed-85cf-4f7c-9e05-4b28051d04e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0553469-869e-40f2-bb07-dcfda6c604e0", new DateTime(2022, 8, 13, 13, 59, 58, 12, DateTimeKind.Local).AddTicks(7177), "AGOwtNjBFZLZO7053LflAG66DX0gs/RwRSF55S6u4JFDEiTxpV4hXPfETImsiLX1Kg==", "0985ea2e-94ca-4c30-94fa-80ce1b37c9de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1453db57-193e-4e1c-80b8-59a4278755d3", new DateTime(2022, 8, 13, 13, 59, 58, 10, DateTimeKind.Local).AddTicks(9149), "AJeq7TjIStEXC1pFjnEYCucWj/oorUDmPWV3flKfHwzuln5BmmAxIWEC90nwFzsGyg==", "3a059219-e840-4c0f-bf06-2ae1da096bec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3ce9523-3099-4659-b7d4-8dffe859ac8d", new DateTime(2022, 8, 13, 13, 59, 58, 13, DateTimeKind.Local).AddTicks(3989), "AL0wMzyMUmfHolHtCMVzFZG/Ywl5cX26EKe44TAS72gBZHaG9w+NS62D3n+yV47WrQ==", "b763f3d9-7dfa-4044-9224-c69bb37ebb19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f85f02a8-1e26-49cd-bed3-9649c0309765", new DateTime(2022, 8, 13, 13, 59, 58, 14, DateTimeKind.Local).AddTicks(762), "APWvK9Bcwh28CoAPCDNWTuI91/jpNQzj6WWNWhLpW/189c1aJ3/dDikHDxTAdlJHFQ==", "78ba5c57-6f8e-43ed-ba52-e07c7e553406" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 13, 59, 58, 14, DateTimeKind.Local).AddTicks(7645), new DateTime(2022, 8, 13, 13, 59, 58, 14, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 13, 59, 58, 14, DateTimeKind.Local).AddTicks(7650), new DateTime(2022, 8, 13, 13, 59, 58, 14, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 13, 59, 58, 14, DateTimeKind.Local).AddTicks(7652), new DateTime(2022, 8, 13, 13, 59, 58, 14, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6905), new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "62fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6915), new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6913), new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "f0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6909), new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6911), new DateTime(2022, 8, 13, 13, 59, 58, 8, DateTimeKind.Local).AddTicks(6911) });
        }
    }
}
