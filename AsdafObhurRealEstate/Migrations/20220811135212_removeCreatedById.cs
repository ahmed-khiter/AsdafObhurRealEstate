using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsdafObhurRealEstate.Migrations
{
    public partial class removeCreatedById : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Clients");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42fe29f0-c227-4a03-b2f6-c97279b2bc23",
                column: "ConcurrencyStamp",
                value: "5c108824-1df2-4011-9e42-5ba9c9751f70");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6",
                column: "ConcurrencyStamp",
                value: "7c4b0367-156e-4ab1-894f-a16eaa8195ab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e",
                column: "ConcurrencyStamp",
                value: "d29b976b-368d-46fa-b2ff-e736341c8e7f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0157647-7016-41cc-9a56-8695acaa13e6",
                column: "ConcurrencyStamp",
                value: "ebab1d51-342a-44e6-a45e-8ac3e4ce98fe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b71282ed-85cf-4f7c-9e05-9b28051d04e4",
                column: "ConcurrencyStamp",
                value: "e42d9cb9-b29a-484c-8ec7-73426ae2408c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c",
                column: "ConcurrencyStamp",
                value: "330c9cf8-29d6-4dca-9318-1e6cda681cb5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3d0584e-fcd7-439c-8ae1-f5734664d6f4",
                column: "ConcurrencyStamp",
                value: "08cbcdc9-9e30-475b-8dff-ac24a9f907c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e313a786-637d-40c5-8715-443bba115487",
                column: "ConcurrencyStamp",
                value: "e22d3d2d-78fa-4670-9fec-360afa4b7315");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63351337-0238-48eb-a682-aefa292cb868", new DateTime(2022, 8, 11, 15, 52, 12, 343, DateTimeKind.Local).AddTicks(4510), "AOayN1tzQXjCa/mGHOi+FNicBMe2wDTwt4RHUil+NEkeK7JxvA6vKeQIGDlVK2NDzw==", "b23eea83-1bb7-4b84-b75d-fb489013886c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2953f53-440c-4e81-b6c5-eb84d434daa2", new DateTime(2022, 8, 11, 15, 52, 12, 346, DateTimeKind.Local).AddTicks(893), "AHRP1Ycrn0p/zuLl4kcigLdZla2aN9SDFIlCMoDomMs/dUrMl0NvSXv24MXK2OPSzg==", "17afb405-4333-4c39-bda9-be2cffa49cd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52cb769f-28b9-49e4-9a63-0d38b08f3961", new DateTime(2022, 8, 11, 15, 52, 12, 344, DateTimeKind.Local).AddTicks(1102), "ADV5fCtXRIqzOEo9ErUrQPh3JGt77ilU4mHP1mUUbs1pHxqOBGxowcqBg7RoOAVEnw==", "115e44be-31f9-4fb7-91ca-a2a5167a9678" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c31d6a94-99e2-4cc2-9788-ed502776f582", new DateTime(2022, 8, 11, 15, 52, 12, 344, DateTimeKind.Local).AddTicks(8017), "APLMVnVp1U+VN8buvewv6qDwrET/HjrxD5MUWmik/sJohVYgciVN2ccgpcnEMXSM8w==", "7a0e6d19-0df3-414a-be4d-01cfb06dedb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k71282ed-85cf-4f7c-9e05-4b28051d04e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31e83c6a-adca-4814-8a9a-73dc154741e1", new DateTime(2022, 8, 11, 15, 52, 12, 346, DateTimeKind.Local).AddTicks(7324), "AGF17TUgE9QPWEFZTRkSSg6TsPhe91+dOvrt+/U+TJmZnIq9QrNFpwUBe9+eb9s5lw==", "bf51c6e2-5046-47ed-a8f7-adea25e42775" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49bef7cd-9574-4e16-868c-0f863a531a1e", new DateTime(2022, 8, 11, 15, 52, 12, 345, DateTimeKind.Local).AddTicks(4468), "AKPW8a9BNlElwRhVUEhjuGahTJvzs1yL9a2Aq8hmLwcHv1MH+6728jAsru+bqwpqBw==", "b27b130f-0c07-4c12-82e8-f7af314a05f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f24051d-9ea3-4bfc-96bb-4b6d454e2b0f", new DateTime(2022, 8, 11, 15, 52, 12, 347, DateTimeKind.Local).AddTicks(3785), "AIwh1GmrmFcb4smqVeSxsTN6fny/qiwtngQm0y7LP+yhRs9SZscWrtcQz3M7l8VU/A==", "3247dc87-a331-4faf-a27f-758e1e0d9a1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5ab1300-8111-420a-aef2-4dce4087a0e1", new DateTime(2022, 8, 11, 15, 52, 12, 348, DateTimeKind.Local).AddTicks(231), "AHSBHLe7d8hCbYU4kC0PQvpxhDy7nmFGo6hSLnouaazD+n3z6klWCKHpRrk5+E8Urw==", "e333dbce-c20f-4ec4-8c34-d22a0942a23d" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 15, 52, 12, 343, DateTimeKind.Local).AddTicks(4469), new DateTime(2022, 8, 11, 15, 52, 12, 343, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "62fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 15, 52, 12, 343, DateTimeKind.Local).AddTicks(4478), new DateTime(2022, 8, 11, 15, 52, 12, 343, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 15, 52, 12, 343, DateTimeKind.Local).AddTicks(4476), new DateTime(2022, 8, 11, 15, 52, 12, 343, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "f0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 15, 52, 12, 343, DateTimeKind.Local).AddTicks(4472), new DateTime(2022, 8, 11, 15, 52, 12, 343, DateTimeKind.Local).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 15, 52, 12, 343, DateTimeKind.Local).AddTicks(4474), new DateTime(2022, 8, 11, 15, 52, 12, 343, DateTimeKind.Local).AddTicks(4475) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
