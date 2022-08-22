using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsdafObhurRealEstate.Migrations
{
    public partial class AddedCodeNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CodeNumber",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "333605b5-8ad1-42d8-b298-52f540b97faa", "ADb9R9GmQHov81hd0NvmTF/37K4noL4EtcuKqn6hKKMACeA4XEc2jx3xAqR3weF83g==", "0336b048-6a1a-4680-af7f-d295d661751d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "457bd2f4-d8ff-4b45-b005-bebc0776baeb", "AJCbScnTvK/BCoS0PQ09yY9Kl48/wbjL1Y94ozzgZjCby+6RvyhoQWZbj7jpWURdZw==", "812659d8-0c6b-4e31-8968-2457057e1d41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "280700be-4b91-4fc4-bfeb-726d1a7f6788", "AA57C1hLuLuY5iPypbG6Myjh1UxockhQHZqfj6/zMuqU5eWi4zrzmxeGt3rvy6VhzQ==", "f4d9438b-3272-43aa-b1c0-8e7bdf7577de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3818dc8d-f9cc-4ee6-b2ea-83eab0a3b718", "AKVMA0dj7hv0DnqSpYC0BdT62akJRgcJp3qZhQIhq5ankcIgwz/akLWLYx0ed94Seg==", "587ff881-9967-4151-8ab7-54af62b48850" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "k71282ed-85cf-4f7c-9e05-4b28051d04e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63d28c4f-89af-4bc0-b287-edc3a4e363e7", "AKzdCGfIUwYA2xa4sJttZhtraxV4O4stO2P8DGre+rTklZRKCbi8/OTlapHmLTUZbQ==", "10f174e3-9ecb-4af1-b8ee-5c07dc2984c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "sf8ac5ac-ee3f-4cac-988d-v45ef0eed54c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37819f54-37a1-45bf-89ab-03977f9f3248", "AHEUkNMWy2tdhndRweynnTFLFyag7tFeB87K0LMhf4ThViiLanGWilAJ9b6uvcxaWw==", "892b7beb-42ee-4a84-95b0-f6d3fd687d58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "885d639d-a4a9-4d4b-bd75-55c38bdd8c74", "AK0aO5sXvfzPwjxr2IR8VYpqe0OmXbb6AQ6Bkq+rfEiKjIQFG7olNT+XSFtRut8OEA==", "2700c260-35cb-44e1-8041-923992ef6fd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4589faf9-1cf1-4f3e-873e-39b70aafab9f", "ALPBM9dtjEcVxKarKY8U6L8F5JGFVSyjqK7izruMf7+SPLBI8oMPr4aAhBVzSvP+nw==", "ff1bacbb-75fe-44d4-8ef9-d5af75277a31" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 22, 21, 22, 28, 95, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 22, 21, 22, 28, 95, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 22, 21, 22, 28, 95, DateTimeKind.Local).AddTicks(1537));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodeNumber",
                table: "Clients");

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
    }
}
