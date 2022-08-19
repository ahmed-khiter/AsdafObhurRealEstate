using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsdafObhurRealEstate.Migrations
{
    public partial class addedCustomerNeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerNeeded",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6da21ff-ea9f-4fa3-9c98-5b713101ee45", "AKveg8eL0lRf710nkomCi4XM/GE9DYkpsPj30PvHhlqUsoUd5qBJJfFxMf8G3OdwQg==", "4dfb73d1-6983-43fd-a276-5dcfdbba9deb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdef1cc2-0dd9-4f70-bcdb-aaed0d5e270d", "AJvgFarR2Wzjsqb2ogxglccMt6A9rHQu6te+qk0XUv9/wJZqkq7Ma3Y4BDIV/MmnwQ==", "56a1c2e4-8952-46c9-a21a-ad47d17b937c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52343f64-e937-4697-ab80-67ab5aeddf3f", "ABt4uQoTZRgd8N6oIU9Iu9vSH8vP9S1EmLYbbQQoluS1SLVTo1h+V3O7u+vgaM9uog==", "f0ef8dd9-c081-412d-a42d-f164672988d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcc2af4a-8157-4198-a2c0-6a042b138c29", "AAR5ZB6Aan1yw8/PgrQHNaCvO1WqgP5R8fWp50YgGnQwj2B5sKrwkY/tqzWZ1gpuzg==", "bb41dcd4-ea86-40f5-bbf2-b3717bc427c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k71282ed-85cf-4f7c-9e05-4b28051d04e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2eb51f62-7b17-45e2-9285-720e2db5f20f", "AJUVe2HEusjKWT/de55W7szFINFqapfsHaqpMEIeTWY48RdU08kDoHoM3hF5u7XNnw==", "06e57bcf-deb8-4d23-97ac-e9dad3067b71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8af203f5-46aa-4aa6-a949-33341b9f9556", "ACGbyvJs07hLjBY+JDxzhLiczWME2gytpWfWEqIb7c6nOs7kkMO3Lma+ZJHZcpwn0g==", "dc2a0f31-4625-4cf9-80ad-bb927c1963d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcd59c0d-91c5-4d73-96bf-7cb88b6cb0b6", "ADj+fcJUe1Mjec2bh0PH2lGoeedX3UEhfG3oyo52rAJ62iEj2pydkTp7XGJ1ZPiPDw==", "a7d107c9-c7e8-4e7b-ad2f-07560e5a74ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce8b636c-9cba-4695-802f-3694a9ed9b3d", "AHojhVG7ulm+2BJ2vo104omA2pQRqKpFx49Uwc5IdCf6oo7SfOiemi1LXXdvN1XOsg==", "72655e07-c834-4824-bb45-02317dac97d8" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 23, 27, 5, 385, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 23, 27, 5, 385, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 23, 27, 5, 385, DateTimeKind.Local).AddTicks(9897));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerNeeded",
                table: "Clients");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "286cfba3-7585-485e-b886-5b8faf10cc57", "ALhj9VhzW0Yhsc5/0jV2uBXTFqh7AY8INdhKk7SX3uKYIpVjWIr4j/NFZ5EATasyXQ==", "30737849-ade0-4a02-b430-d50040f32f0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da00be1c-d2f2-42e6-88c7-5b7784dfabfc", "AIkZ/9AxTtMT4YKYH90HjK9eUHimCxGC6Y+Fl8rtUerWOMUb1pT192KXurqBc/95kg==", "6c0e9bfe-35bc-4459-b406-beda5cfa91af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b1247c7-d453-4cf7-ad12-d662e7dcebd9", "ABqg6ikEva6iqkurI5L2URajN0gZB+FnyV9z9TZTb0/FiMSglgkwI9nvnJBEkqQ5zA==", "95463ed8-f857-4f8f-929c-049bb1e88079" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9680ed7-7188-443d-9f25-2a3bb8a4d32d", "ALaN0XF7LUQ7gT0U6leS/Hm6oeL6oEWyJG2uG+DDnGHHA+QwlC44UnxMD/gR8Sc7rQ==", "c55ccd0d-1b92-4ba6-84c8-d99b85f30a72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k71282ed-85cf-4f7c-9e05-4b28051d04e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d66fdb08-b35e-4b5d-8917-65119b8b0243", "ABVuEC/MNCGV3X6NKpRr9EfiM777UZXPmDcQQQfYYGmqEXJ/ipgC3kawJpOq9nuvbg==", "90c377cb-fe44-4d3d-a798-5c2cb541c1f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9a58923-6e58-4fd4-8760-63bfab15f4e6", "AAsENtfq8ABeLwszcqrNieCFfmZcTm1+McDhKDlAWAtV4o8nY51Bx46li6ifaP+qsA==", "4be30767-462c-4387-8b5e-851705479bcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46fa6a64-1a7e-4b15-84b7-5ce8582ba5b1", "ALQ8rD3Lo6OBoWdEv0DiImBNOqBHPBDftdJxO0VZf4p0+4I4iFW2+ftIwsKCutc7QA==", "eca2fb35-19c8-4b9c-8a9e-308f17937326" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40107c4b-442b-401c-9cfc-04865fb8054e", "AAFkZ5KftqQjy/xoCav0qATHSmzow+crboydKCYsPUq/5Y5SPNTrxpIzOiNT89XXug==", "b666ec08-9b11-4f8c-9cd1-257159002147" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 17, 14, 38, 828, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 17, 14, 38, 828, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 17, 14, 38, 828, DateTimeKind.Local).AddTicks(888));
        }
    }
}
