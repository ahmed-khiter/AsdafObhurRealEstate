using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsdafObhurRealEstate.Migrations
{
    public partial class removeCreatedById1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Multimedias_Clients_ClientID",
                table: "Multimedias");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "Multimedias",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Multimedias_ClientID",
                table: "Multimedias",
                newName: "IX_Multimedias_ClientId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42fe29f0-c227-4a03-b2f6-c97279b2bc23",
                column: "ConcurrencyStamp",
                value: "df72cf77-17af-45ff-b721-ef8265acc6d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6",
                column: "ConcurrencyStamp",
                value: "d38dd93b-fc1a-457f-a10c-40832f432c12");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e",
                column: "ConcurrencyStamp",
                value: "d833d824-4fa3-49a6-bf02-b7e0b07ab131");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0157647-7016-41cc-9a56-8695acaa13e6",
                column: "ConcurrencyStamp",
                value: "abf9d9c4-cf1e-4add-a704-7e7f0c42c0b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b71282ed-85cf-4f7c-9e05-9b28051d04e4",
                column: "ConcurrencyStamp",
                value: "e8a60933-9642-4f11-b2b9-9e152d00e76a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-f45ef0eed54c",
                column: "ConcurrencyStamp",
                value: "a3ed5c06-a85b-41b2-9877-117787fe1467");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3d0584e-fcd7-439c-8ae1-f5734664d6f4",
                column: "ConcurrencyStamp",
                value: "f0e1a8ac-c451-456d-9f8f-2d08399a01c2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e313a786-637d-40c5-8715-443bba115487",
                column: "ConcurrencyStamp",
                value: "f28f6590-10fb-4db0-91f1-196ad0baf8c8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9205deef-f276-41f0-94ff-f0a2608ae251", new DateTime(2022, 8, 11, 17, 55, 33, 316, DateTimeKind.Local).AddTicks(1615), "ADz9z7+igh6Y0MXV8NaOYksI5fu5q/a2lQNfFoFvGKi9XKvTL4hpWd1n4FSGgDpe1Q==", "47b2f788-5e02-45db-8dd5-196003c67188" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2e9f631-44ba-4262-a90d-5d969ab667b9", new DateTime(2022, 8, 11, 17, 55, 33, 319, DateTimeKind.Local).AddTicks(1766), "AHgcSPmV7/Wv741kxk77O0sWQ1XWT2GfsUkDBpGUCsJPxGnhssgeC3RLSmtlShlJHw==", "33edb227-12f6-44ba-8f07-0d1130dd0d70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72540d14-d54f-4301-8191-d5fed5018aa7", new DateTime(2022, 8, 11, 17, 55, 33, 316, DateTimeKind.Local).AddTicks(8268), "AD3Ntq1natPSwUVdawK81u3UsqYFvxSgJDxEliY59I46OezoGNeciR13S9oNQgagBQ==", "bece7918-66ff-48e4-8f31-8c2bbdaa9196" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a05f31f-1c39-42d6-adb6-9426b3cf03e7", new DateTime(2022, 8, 11, 17, 55, 33, 317, DateTimeKind.Local).AddTicks(4808), "APfsjIoATUR3e7O2VhVZtDHnuh5No4wZ+aUrtdyHQkAa0FjxnPqRdSMdWkwO+pbCfA==", "4152d977-4061-4168-b07a-258407369ea7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k71282ed-85cf-4f7c-9e05-4b28051d04e4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f185d23-83e3-4279-8a1a-6502d98d93e9", new DateTime(2022, 8, 11, 17, 55, 33, 319, DateTimeKind.Local).AddTicks(9621), "AHCTWNqbvKkru7FET/cksFHdyFyfCP++/iY2VqleJeb3GLdXCXIq5Zdk0eNEFBiS8w==", "66381399-917b-418e-8473-de468c796a7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "708be2e5-7534-41f2-acba-e878e236e431", new DateTime(2022, 8, 11, 17, 55, 33, 318, DateTimeKind.Local).AddTicks(2579), "AJy8vZZhoHXqTEGkwtHV/XtERu0lYBgkpdt+mVAy/gwS7X3hSS7q01BwdYwn/CFDzg==", "fa2385ed-5d4b-4614-bc3d-6845489efae2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44bb2416-657c-4ca3-86ae-af9d69da998c", new DateTime(2022, 8, 11, 17, 55, 33, 320, DateTimeKind.Local).AddTicks(8664), "ACF8bEyvrUtcAdRwqnA/IVYf2f6TKfebojG2ODPy83ApC4ewvKLgch+KB9vXi/Hy1Q==", "bdffa63b-8700-423d-b01e-925e4a5cb678" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eddcfba6-5e13-42d2-b600-32b0772c40c3", new DateTime(2022, 8, 11, 17, 55, 33, 321, DateTimeKind.Local).AddTicks(5986), "AM4Ag77crufHYTuI/nxsqdHToZOW1QzN/OPP0hvtzuHYf+QmOkFe1HSpwvJGVxHI/A==", "edbbbfca-fdd6-4387-8818-a769ef67773b" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 17, 55, 33, 316, DateTimeKind.Local).AddTicks(1581), new DateTime(2022, 8, 11, 17, 55, 33, 316, DateTimeKind.Local).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "62fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 17, 55, 33, 316, DateTimeKind.Local).AddTicks(1589), new DateTime(2022, 8, 11, 17, 55, 33, 316, DateTimeKind.Local).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 17, 55, 33, 316, DateTimeKind.Local).AddTicks(1587), new DateTime(2022, 8, 11, 17, 55, 33, 316, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "f0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 17, 55, 33, 316, DateTimeKind.Local).AddTicks(1583), new DateTime(2022, 8, 11, 17, 55, 33, 316, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "h3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 8, 11, 17, 55, 33, 316, DateTimeKind.Local).AddTicks(1585), new DateTime(2022, 8, 11, 17, 55, 33, 316, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.AddForeignKey(
                name: "FK_Multimedias_Clients_ClientId",
                table: "Multimedias",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Multimedias_Clients_ClientId",
                table: "Multimedias");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Multimedias",
                newName: "ClientID");

            migrationBuilder.RenameIndex(
                name: "IX_Multimedias_ClientId",
                table: "Multimedias",
                newName: "IX_Multimedias_ClientID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Multimedias_Clients_ClientID",
                table: "Multimedias",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "Id");
        }
    }
}
