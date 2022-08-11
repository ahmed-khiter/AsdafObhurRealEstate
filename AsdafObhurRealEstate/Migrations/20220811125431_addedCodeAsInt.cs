using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsdafObhurRealEstate.Migrations
{
    public partial class addedCodeAsInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Code",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42fe29f0-c227-4a03-b2f6-c97279b2bc23",
                column: "ConcurrencyStamp",
                value: "75bc177d-c71b-4ce0-a436-a54938010b94");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6",
                column: "ConcurrencyStamp",
                value: "b1ca10f5-6f61-4227-a7c3-f6b45b061bfa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e",
                column: "ConcurrencyStamp",
                value: "ffa8d8c5-9d03-4da8-b2c7-6dcf3087e180");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0157647-7016-41cc-9a56-8695acaa13e6",
                column: "ConcurrencyStamp",
                value: "94014792-5f17-4e6d-ac44-2fe5143d5426");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b71282ed-85cf-4f7c-9e05-9b28051d04e4",
                column: "ConcurrencyStamp",
                value: "8b026dfa-fb4f-4c1c-ad59-84923e8bb12d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c",
                column: "ConcurrencyStamp",
                value: "738c2d07-28fc-4ed7-abc8-6e33f4ba9c93");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3d0584e-fcd7-439c-8ae1-f5734664d6f4",
                column: "ConcurrencyStamp",
                value: "97d67439-d6b7-4fb6-b3fc-0289bc8edf27");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e313a786-637d-40c5-8715-443bba115487",
                column: "ConcurrencyStamp",
                value: "6dfca833-7796-40f6-a84f-50bab7e5226c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c25124f0-649b-4139-825c-732e214ac0a0", new DateTime(2022, 8, 11, 14, 54, 30, 783, DateTimeKind.Local).AddTicks(3741), "AOCJNU7HvuKwMmYG2A659Lw+OEdoVdRtVSC56ihd1oRoO+WR4eicfBeoG01Pr3Dv6w==", "dfd1eaa1-a9dd-4d73-8ff3-5dd24f2bd8cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bad0db4d-376c-45a3-8aaa-9bf43dd9bf17", new DateTime(2022, 8, 11, 14, 54, 30, 786, DateTimeKind.Local).AddTicks(4969), "ALYkaIGiiI8ucWiapekHjwwBt7aCg26qjtbCz08IsfYoVvL2jgeJj2glPgL36Ex0YA==", "1b98c9f3-f2a8-4bd6-9f0e-57c3b538353c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff595f72-2085-4b07-b2e4-24d7a3842e20", new DateTime(2022, 8, 11, 14, 54, 30, 784, DateTimeKind.Local).AddTicks(1951), "AA1JPkKSW3JnKj7d80cmibRmIeToI5CGIrMwW2m6aNFGVONlBXfU+YQjDK4P9Gq5vQ==", "7d18bbf9-9b23-4360-989c-efc364c10bac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00850556-0c17-4706-ae32-43cc04cb47d2", new DateTime(2022, 8, 11, 14, 54, 30, 784, DateTimeKind.Local).AddTicks(9519), "AGRp+OrzBisqAHHVtV+BWjwXxKPCZwI2WFOptg+PUhrz5wHP/bg2WyfDvGX06Fv2Aw==", "dc101d79-6d31-4369-ac19-a4e52921bc4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k71282ed-85cf-4f7c-9e05-4b28051d04e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65ba2bcb-63a7-48ce-9873-7f3de8975bdc", new DateTime(2022, 8, 11, 14, 54, 30, 787, DateTimeKind.Local).AddTicks(1618), "AChMeeve/R8IDsA9+vrhMijKsxKEUaCc0kl3L39oBKB4GnDMKgCBrJX51uJkw7FKYA==", "ba9840e3-ad95-4c7b-9475-15c8b97636a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "189ab64f-ba2d-40b4-bd26-f1ccf1241392", new DateTime(2022, 8, 11, 14, 54, 30, 785, DateTimeKind.Local).AddTicks(7139), "AAGYxrP4e1fEodDzip2y4fwD1ToKp1v0K0E3BJ59433dCMM9hM6mrZ8WggpMBGyjRQ==", "4ba64906-d3f0-425e-bca2-dc192007cdb6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd701c79-056d-4150-9f15-2808f5d9a503", new DateTime(2022, 8, 11, 14, 54, 30, 787, DateTimeKind.Local).AddTicks(8721), "AGduBZGmBfeJ2HDk2/tgL0Lrbx9n9wHVSl9jQZwK3e8rFqu0g51e3zz5y7bMfNl6vg==", "a02b95d3-b988-4dd9-bf86-e885aedae48a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a2ccc88-2478-4a96-a2a2-c9c4aa227c44", new DateTime(2022, 8, 11, 14, 54, 30, 788, DateTimeKind.Local).AddTicks(5747), "AFGMEMHgCL5/kQhlprUE62rwLjqFsvv+B7mEPpROfpBQ8jxDSapC3+RdCmljTsVGhg==", "282be6a7-8d3a-458a-9cff-845c3d9c3c07" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 14, 54, 30, 783, DateTimeKind.Local).AddTicks(3647), new DateTime(2022, 8, 11, 14, 54, 30, 783, DateTimeKind.Local).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "62fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 14, 54, 30, 783, DateTimeKind.Local).AddTicks(3707), new DateTime(2022, 8, 11, 14, 54, 30, 783, DateTimeKind.Local).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 14, 54, 30, 783, DateTimeKind.Local).AddTicks(3704), new DateTime(2022, 8, 11, 14, 54, 30, 783, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "f0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 14, 54, 30, 783, DateTimeKind.Local).AddTicks(3649), new DateTime(2022, 8, 11, 14, 54, 30, 783, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 14, 54, 30, 783, DateTimeKind.Local).AddTicks(3651), new DateTime(2022, 8, 11, 14, 54, 30, 783, DateTimeKind.Local).AddTicks(3651) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42fe29f0-c227-4a03-b2f6-c97279b2bc23",
                column: "ConcurrencyStamp",
                value: "1cad508f-2eeb-434e-a798-54279089fce8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6",
                column: "ConcurrencyStamp",
                value: "a29ea321-1336-4ec9-99b8-d657be58885c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e",
                column: "ConcurrencyStamp",
                value: "797aebff-0a7e-41bf-b726-52f2be1150c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0157647-7016-41cc-9a56-8695acaa13e6",
                column: "ConcurrencyStamp",
                value: "6a520722-70c2-4393-9cdf-b4f54315ea95");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b71282ed-85cf-4f7c-9e05-9b28051d04e4",
                column: "ConcurrencyStamp",
                value: "2a2e137c-715f-44e7-b947-56e3af12225e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c",
                column: "ConcurrencyStamp",
                value: "7111939b-ebf6-472e-add9-42dbb21d59e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3d0584e-fcd7-439c-8ae1-f5734664d6f4",
                column: "ConcurrencyStamp",
                value: "1d598462-dfbd-47a5-a416-7d2765c689df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e313a786-637d-40c5-8715-443bba115487",
                column: "ConcurrencyStamp",
                value: "7fa73a81-3814-4a4c-bb1a-e32e4280a75e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74bab8bc-12e4-4d53-a32e-e85a3a5b0ee5", new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1684), "ADs8rnfm4IMQaK3ClDyHOGizux5SJIsufQUte/DSj1TQfXptIG9niTHhHre+wqo+vA==", "e028e2fb-db12-4fb9-ab02-a430ce665b90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d24eeec3-643e-43b4-884e-75ebc5010c27", new DateTime(2022, 8, 11, 0, 9, 49, 620, DateTimeKind.Local).AddTicks(7828), "AJexQ9r+1UyNIlmWFvr/JTOTbTYdT5UgMxwrtWzh0TnlSV59YeDdUAFjM6ZzRa9rgA==", "902cf20d-28cc-4dd5-9aaa-cc3346e02515" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05ddab0a-59dc-46c0-853a-8414d6655eaa", new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(8472), "AOaqg5dkdBIUYGsR/82FlPhfuajWnIgUNKHFOqgWAkx2D29Z3JoVomtzSB4gzZlu6w==", "09d5fc4c-8e02-40bf-863c-4255d3a864a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c4eb44f-3b99-47d6-8650-c7da5e140deb", new DateTime(2022, 8, 11, 0, 9, 49, 619, DateTimeKind.Local).AddTicks(4922), "AAUoQPb6SGEbsIa7N9yiPsv8dInbn0CGvIHl9E43+dQHc7t5knGIiynSIq5u0C1puQ==", "0dcc42d4-240e-4325-8276-b6fc2d85cf74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k71282ed-85cf-4f7c-9e05-4b28051d04e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9cdbaba-c5e5-42c6-8864-ca9322c941b8", new DateTime(2022, 8, 11, 0, 9, 49, 621, DateTimeKind.Local).AddTicks(6585), "AGXlevEmcJ5giPsbsT3/KVQ8aq8BKyNYy6sUpykRxY5B3LpKx8B0E4ApXH6hhwP9BQ==", "ecc1d0ae-1652-4c54-b0ca-1c4f2a4ef432" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb555aba-af6a-4c10-b784-642b0429d98d", new DateTime(2022, 8, 11, 0, 9, 49, 620, DateTimeKind.Local).AddTicks(1389), "AKTYMNKcVUqmTw7S0mz+XK1Ie73bKWfxWZiscFdfz1yvqwFlyI69eInSZtHIOv5GZw==", "a9b14a1b-2889-4547-862a-da486972ca12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77561481-579f-4267-b2fc-411b7b4c6983", new DateTime(2022, 8, 11, 0, 9, 49, 622, DateTimeKind.Local).AddTicks(3486), "AKTbSVrLP9rEPFQ6pMI3GN3JIPIbS9hULgWg4EwiKJklg7n33e7HpgwhD8XHU7J3Pw==", "c968ca09-f755-4111-a306-50d8b3c7a825" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34729ef4-db74-4f07-b7de-52237187123d", new DateTime(2022, 8, 11, 0, 9, 49, 623, DateTimeKind.Local).AddTicks(3190), "AMDMZGmi0wWHCGqeN/om7jHq3Uuc/6FQgF1vFo+AZtju+4CSw/OlMgcl5W4qU3Rn3Q==", "eed4f5cc-5df3-4785-9154-860610affbbc" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1652), new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "62fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1661), new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1659), new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "f0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1655), new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1657), new DateTime(2022, 8, 11, 0, 9, 49, 618, DateTimeKind.Local).AddTicks(1657) });
        }
    }
}
