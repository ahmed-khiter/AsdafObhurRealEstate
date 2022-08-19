using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsdafObhurRealEstate.Migrations
{
    public partial class addedFlag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SendFirstMessageToClient",
                table: "Clients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SendSecondMessageToClient",
                table: "Clients",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SendFirstMessageToClient",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "SendSecondMessageToClient",
                table: "Clients");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6ba1da2-70a0-42a5-90a4-ccc8eac36709", "ALKyjdyF2kVmEvimIEI4525LNnwzBWJzzAzrdQW5B7emCxhEe9r9u4nkjREkOlW1dQ==", "5356d251-7e0d-4cb3-b734-347db0a7b1a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "423fdc6e-26a2-4960-97ff-83d6c429d399", "AOeqJgTvAb/L9VGFOJ7bV6Y20v+KG8x85yftLBVujXBzaJTO14FgS9LJfbo1w+kJkA==", "22387486-81d1-4b11-ad5b-e32c7a847397" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a8b6ec0-6bc5-4ce7-a8e4-51656fbe14bf", "ABOHW6f8xQ3C3Fi5ETHnLGZlsDTUntp2S+pSluRO9OuWqZRdkIiY/K4z6JypKJnCRQ==", "66166ad8-a3db-4a9b-b7be-e219bcb7a2e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fb091f5-8114-4efa-a8f5-ddd281523fbb", "ACOQKXTR6l51zbunG/0P0d5Ah8YA/FLDgixSxTCbTz3UQIklrCBd0ED0yCDuTpbzjA==", "7b7276bc-e2c9-45e4-9107-f8fa085ea671" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k71282ed-85cf-4f7c-9e05-4b28051d04e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38fb86f8-2ad5-4cfe-862b-e225cf1ef7cd", "AHxEUZM3HuwDBNxTTO8e5B9xydNCps3FJ8SlNBbSbvfNVtkVBik2yQQNUGzq+ItYBw==", "e7d73efd-6b52-4d5a-b8cf-66fa50978385" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8534a137-b420-420b-a13e-22bce6bffa23", "AAsiEFqnjI3VWg0xi55Gs85E2Sd/H/+S6YZZ8MdPyrDn9FoBR4uzkzJwaJdiIqJFRg==", "fe3d360b-2c16-4859-9c9e-d8a16faa4bb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa379277-610d-46ef-b433-d4abf6e93d12", "APfOHTK4Ye/KUNoVfgEP1ZJVDyXS2MLW7EGChlHPpJ2ZrAbIilS0H2yRF+tX1TCVTA==", "9d84773c-8a91-47b8-91bc-b0e7ac203d44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbd8e8fb-65bb-499f-9869-83fbee5e3010", "ALGR/QaCNJwITDVYFMQDGw4dAuJm+QMZ/LyW0+n7wcdi6EI1oGiOcRbaF4T+6kFJ7g==", "d8786704-a986-4c05-a319-91f1a12380bb" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 18, 50, 54, 940, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 18, 50, 54, 940, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 18, 50, 54, 940, DateTimeKind.Local).AddTicks(2996));
        }
    }
}
