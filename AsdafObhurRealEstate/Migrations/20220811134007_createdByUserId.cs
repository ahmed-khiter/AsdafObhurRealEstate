using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsdafObhurRealEstate.Migrations
{
    public partial class createdByUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42fe29f0-c227-4a03-b2f6-c97279b2bc23",
                column: "ConcurrencyStamp",
                value: "32276061-6723-4997-aec8-c4d90fb3845e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6",
                column: "ConcurrencyStamp",
                value: "076a337e-b7df-4f0c-b919-acfefc44a5b7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e",
                column: "ConcurrencyStamp",
                value: "2bf10809-1605-4f88-8662-3f790ec027ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0157647-7016-41cc-9a56-8695acaa13e6",
                column: "ConcurrencyStamp",
                value: "2cabe725-1e5e-4f08-8e98-57365be6d15e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b71282ed-85cf-4f7c-9e05-9b28051d04e4",
                column: "ConcurrencyStamp",
                value: "b72003d1-27e7-4847-9e9a-c59283c7ab3c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c",
                column: "ConcurrencyStamp",
                value: "c82ac506-a59f-4c40-b7b2-3fe84d758113");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3d0584e-fcd7-439c-8ae1-f5734664d6f4",
                column: "ConcurrencyStamp",
                value: "e0ccc7e9-8b46-417c-9a61-5b094792b30e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e313a786-637d-40c5-8715-443bba115487",
                column: "ConcurrencyStamp",
                value: "c7af14ae-8a1c-420a-81da-47ad6e177d76");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3314d013-8ab3-4646-ae90-d3e583934f5e", new DateTime(2022, 8, 11, 15, 40, 6, 891, DateTimeKind.Local).AddTicks(9807), "ACAfQ32smi97XboByRAXBZc6eO87MEEy0fy6da4XKdrFzZmdrprJqQaH5RhaexJdAg==", "d9cd9fe5-788e-475a-8926-fac93f39b158" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c55f8cd-ddaf-49f2-ab26-e9f4e6396f7a", new DateTime(2022, 8, 11, 15, 40, 6, 894, DateTimeKind.Local).AddTicks(5393), "AAOzgbxEVqLGSqlcaG4V3CroSM/AeAGo1hwZpAF6JZxF7/5hDgokL83d7+o9KxS+Xw==", "a2144e27-67a2-45b8-8ac0-0c22d93ff4a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bdd8642-e5fd-41ae-a044-4e257b626f13", new DateTime(2022, 8, 11, 15, 40, 6, 892, DateTimeKind.Local).AddTicks(6432), "AG5QbFeGMUrNkrgProDD3WQLJzXgBGUBJCUvnpiXiZxxteEtp4qyWaryWeXaTNoumQ==", "d9996c66-d3d5-4192-9533-a0058c102c39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daa48867-54f3-40a1-b030-3a1202e48ab2", new DateTime(2022, 8, 11, 15, 40, 6, 893, DateTimeKind.Local).AddTicks(2755), "AN8w8D/v8UP9YMC6sBeNHoqk6SI0DOImxQT3zlz5uTPp0HkwPjll2DHJwfFTxoD53g==", "ca6a1c20-f1eb-41b1-a28f-ef0df339a07a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k71282ed-85cf-4f7c-9e05-4b28051d04e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85684ba0-7576-4697-9f1f-d7ae17bdbaff", new DateTime(2022, 8, 11, 15, 40, 6, 895, DateTimeKind.Local).AddTicks(1718), "AAhc3M0CXb6+iMZiSx/kEA77tsVKqBMXFk/VifbcwWMrokh3wAl3a9gQmjY5mZYMZw==", "72e0ae13-90bc-4d5e-bc4c-cfc35581e93d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e6a77dc-fc23-456b-a326-635b77236965", new DateTime(2022, 8, 11, 15, 40, 6, 893, DateTimeKind.Local).AddTicks(9104), "AGVqCE0Rp4CpOeqfbOxgKMgpEcaf4pJSiO1J1xk8ThWaU9kdCm6Ok8l4up0i6K5rMQ==", "cf94360d-bf88-46b7-a62c-adfd9e5e850e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a5e720a-b033-46f3-bf48-a5af4785ab79", new DateTime(2022, 8, 11, 15, 40, 6, 895, DateTimeKind.Local).AddTicks(8079), "ADczTU128ZIxttPY1wB04y51M4TLc63k1jzF+0bVZZe9no2s4xU080lnuuzESMhK4Q==", "c2f84766-dca4-4283-ad9a-ce97124fc786" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27b331ef-babb-4650-bedc-b3d4207deb40", new DateTime(2022, 8, 11, 15, 40, 6, 896, DateTimeKind.Local).AddTicks(6619), "AMfjbz5eJ8PZK9xUHztHw+hMXRl+vhbcDK+vHQF4gEcJDFNMMCUf/OV5Jp2R7Ny9eQ==", "d8640a0e-bdd3-403a-ab69-eb79502a5039" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 15, 40, 6, 891, DateTimeKind.Local).AddTicks(9772), new DateTime(2022, 8, 11, 15, 40, 6, 891, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "62fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 15, 40, 6, 891, DateTimeKind.Local).AddTicks(9781), new DateTime(2022, 8, 11, 15, 40, 6, 891, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 15, 40, 6, 891, DateTimeKind.Local).AddTicks(9779), new DateTime(2022, 8, 11, 15, 40, 6, 891, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "f0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 15, 40, 6, 891, DateTimeKind.Local).AddTicks(9775), new DateTime(2022, 8, 11, 15, 40, 6, 891, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 15, 40, 6, 891, DateTimeKind.Local).AddTicks(9777), new DateTime(2022, 8, 11, 15, 40, 6, 891, DateTimeKind.Local).AddTicks(9778) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Clients");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42fe29f0-c227-4a03-b2f6-c97279b2bc23",
                column: "ConcurrencyStamp",
                value: "c0d28df0-9e57-4321-a5f5-10aa0da1b80b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6",
                column: "ConcurrencyStamp",
                value: "36060ade-63a9-49bb-b3af-5b6693e41b14");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e",
                column: "ConcurrencyStamp",
                value: "4bf2b514-910a-48da-815e-3d9b96e888be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0157647-7016-41cc-9a56-8695acaa13e6",
                column: "ConcurrencyStamp",
                value: "a5549932-87fc-4818-a40d-f25757864abc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b71282ed-85cf-4f7c-9e05-9b28051d04e4",
                column: "ConcurrencyStamp",
                value: "14d8f51a-c2a0-45bf-aaa6-8029fb08401b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c",
                column: "ConcurrencyStamp",
                value: "abe8d1ad-0165-4e43-ac40-a39fcf132a76");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3d0584e-fcd7-439c-8ae1-f5734664d6f4",
                column: "ConcurrencyStamp",
                value: "e37e7f20-477c-43ee-9459-cac6138aa33b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e313a786-637d-40c5-8715-443bba115487",
                column: "ConcurrencyStamp",
                value: "4ff2652b-bf59-4513-8766-6fb35c10ac55");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1ab4eca-5a35-47fd-b86a-790a5fefca64", new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4115), "ALJpOAcTmGoWtMIFFTGxhLj+AIWjUHUEn15ZIy/49UhLvvsLNTVXTfV8wuwOuA+zjg==", "e1319e15-c8ed-417a-bfa0-7e0b23f44877" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51eea0bf-815e-48ed-9eea-a28ceace77c9", new DateTime(2022, 8, 11, 15, 21, 51, 691, DateTimeKind.Local).AddTicks(9852), "AOirL8RYuslmQXQDLDuf1YKqvU1aFNIM5OAEljj9maJmFQTofFuBPo8oTBoYgTZFfA==", "0d6d25ad-ed07-4f50-9a84-45a99e04544a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49d33868-5fa4-4967-903d-2ec010766e3e", new DateTime(2022, 8, 11, 15, 21, 51, 689, DateTimeKind.Local).AddTicks(2369), "AGUazktKFxVs13kWOO5Db1gWXWvw67n9MFU7PTp6vMKGUg7xUPejx72iqFWhsR7ZDw==", "d949dcec-1f33-42e5-884c-98c9055cdae1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c790b55-27d9-4d40-ba99-2a0674a22906", new DateTime(2022, 8, 11, 15, 21, 51, 689, DateTimeKind.Local).AddTicks(9891), "ANIQGskrqSBGVQJdhdFmYmk9X6CJiboNViOWPl+gjhZDgW3kGA0rwZge0g7r4XA1jQ==", "ace4d266-57ea-4f7c-bead-a82a9f4dd7b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k71282ed-85cf-4f7c-9e05-4b28051d04e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5dbbb5b8-cfae-4bdc-9dfe-b7584a8d341b", new DateTime(2022, 8, 11, 15, 21, 51, 692, DateTimeKind.Local).AddTicks(6923), "AEZPg1Nlk1BHmLWRCpGXJRxEN7nvS7x6LSS+0P7V7YEfbEQnsFJviKS2xFo7WYKfzg==", "79d33c4b-f900-4a8b-b234-091fd756cd8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c61c8aa-93c5-4d50-88c8-bfe00a389c81", new DateTime(2022, 8, 11, 15, 21, 51, 690, DateTimeKind.Local).AddTicks(7883), "AER1HKOFX3Sg2XKBogSOroOTf0Hzk6pK/DzxcqLJUPFfIOj9aBroXqOVNDSTwO1zRg==", "eb031d26-2a4a-4f59-92ed-af3eaf159c0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "101ad08e-2001-4009-aafa-9665a1960aeb", new DateTime(2022, 8, 11, 15, 21, 51, 693, DateTimeKind.Local).AddTicks(3993), "AFzNIRUpzU1X8dfBBQZ+Ed/IBzU838do6sHbQOJM0sP8nTE8cysF1h2c0DEXxTEsOg==", "0f8d9890-d108-490f-a26c-dd9793e48260" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcccaa9a-832d-407e-b071-6e61432aaeb7", new DateTime(2022, 8, 11, 15, 21, 51, 694, DateTimeKind.Local).AddTicks(971), "AIQ6oOqvT2Bt43YeSJF0rwcOtjaoy6U7isnbCd1qVEbvX9XAJDkgN7LCgI3LvSo92w==", "7bd2c3bf-3f49-4e3f-8020-0f6ad4e38af8" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4032), new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "62fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4041), new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4039), new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "f0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4035), new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4037), new DateTime(2022, 8, 11, 15, 21, 51, 688, DateTimeKind.Local).AddTicks(4037) });
        }
    }
}
