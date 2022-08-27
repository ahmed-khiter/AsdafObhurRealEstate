using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsdafObhurRealEstate.Migrations
{
    public partial class rolesUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e", "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e" },
                    { "42fe29f0-c227-4a03-b2f6-c97279b2bc23", "82fe29f0-c227-4a03-b2f6-z97279b2bc23" },
                    { "a0157647-7016-41cc-9a56-8695acaa13e6", "b0157647-7016-41cc-9a56-3695acaa13e6" },
                    { "d3d0584e-fcd7-439c-8ae1-f5734664d6f4", "c3d0584e-fcd7-439c-8ae1-g5734664d6f4" },
                    { "e313a786-637d-40c5-8715-443bba115487", "x313a786-637d-40c5-8715-543bba115487" },
                    { "e313a786-637d-40c5-8715-443bba115487", "zeaf5d3d-a6b3-3081-8ae5-724e07359bd6" },
                    { "42fe29f0-c227-4a03-b2f6-c97279b2bc23", "zeaf5d3d-a7f3-3081-8ae5-724e07359bd6" },
                    { "a0157647-7016-41cc-9a56-8695acaa13e6", "zeaf5d3d-a7f3-4751-8ae5-724e07359bd6" },
                    { "a0157647-7016-41cc-9a56-8695acaa13e6", "zeaf5d3d-a7f3-4751-8ae5-724e07889bd6" },
                    { "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6", "zecb5d3d-a7f3-4751-8ae5-724e07889bd6" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3857c4d-9812-436a-8e9a-4f9fc1011058", "ADmI2fW0o/bK9eumP7R7bRJ1ahB7Z6K1P71l/SmEnfsatT5hFTJWbEip4aP8O3l+Mg==", "cd0e7da9-41bc-4a83-9b6a-288e05052a9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01be1180-d3a9-4344-bb9c-881b62727203", "ACBa42boTg5i2dlED/7CEyAGu3HMij8roatZex7zXVTY845EtLy1M8m7UTEzL4vvlg==", "424dc041-65d7-4859-b42e-cffd40d7863b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74d2d985-b98f-4454-b00b-38dc3b653a4f", "AMq3vpWokXql4QzJNY5HTvdmA+CDLyrZzcmCxNq2UuEXCbIcNtZbgKUMMbNIWIzsyA==", "4b464725-5927-4143-977c-d43317acdd6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29788d59-7c4b-4230-9c88-f79bacebb999", "AA0VFIbOq5NGr6WxchQbPqcleafGhDbi0Ndn9tfexb+B/Ri+pkD1a1dkagHjhQgfEA==", "c360324b-6b4f-4be8-af84-f48f3b7ce8bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4b67b75-86ba-44d7-bf72-516d8a0b5eb2", "AMeK1o+rsj8kmhRfQZZ5EG+CTb2EOPC3KsAJ004SeK/pqmJx7iFuyJJX704GYe7V3A==", "76751379-3972-4498-8d1d-6efc688d80c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a6b3-3081-8ae5-724e07359bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39c3ce77-a8e4-4e6a-a600-6f06dedb63e0", "AJm3GL5xMO8CjcaWVuM/iTltLVyyhucVYm0SX/mirqjGWsMi5Ja0AMjm80o5IkC0CA==", "4f884628-2390-4851-ba1c-05b22a0ecb4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a7f3-3081-8ae5-724e07359bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40e03862-5f56-44a3-80e1-cb84d62f7768", "AMSz7qFhusQ4BzGWv7oxXLBWCokbyHifmEfwd8o0OMwFqEi0Y+i0yb/QPLUGPpM4BQ==", "17738801-8d45-4a3e-91db-e8984ba1ad51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a7f3-4751-8ae5-724e07359bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40472def-1d14-4db3-9401-e92691244c45", "ALO4nJ6Xpbm1mk7avM/EYjriOvBSK35ae7LZia99xkc1Q80JnsflQQt+yMqvcrL64w==", "f67bef1d-6336-4af3-bf97-601e351066e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddbdbd4b-2845-46d8-a5d6-876bb9cd3dfe", "AMbPxp2You9jlBywHF6IC3URP+h70CwMz3UA5rOplAYaHyhNOnXSLcjTuA4ejQjlCg==", "5cb7165c-3630-4248-ba91-ddae2774951a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27c59104-80d4-40ca-bfbf-f0cd9860cbcc", "AFr+CN+xX6muV1Halsz4umt1+uOkeBItvMCNSD6J9w6y4Iu3YaU5nL6VyGDSjCnOzw==", "15cb7910-5c83-4212-8b20-388be79694d6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7bf40edf-af65-4d9e-8e6d-8f40d683cc3e", "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "42fe29f0-c227-4a03-b2f6-c97279b2bc23", "82fe29f0-c227-4a03-b2f6-z97279b2bc23" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a0157647-7016-41cc-9a56-8695acaa13e6", "b0157647-7016-41cc-9a56-3695acaa13e6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d3d0584e-fcd7-439c-8ae1-f5734664d6f4", "c3d0584e-fcd7-439c-8ae1-g5734664d6f4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e313a786-637d-40c5-8715-443bba115487", "x313a786-637d-40c5-8715-543bba115487" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e313a786-637d-40c5-8715-443bba115487", "zeaf5d3d-a6b3-3081-8ae5-724e07359bd6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "42fe29f0-c227-4a03-b2f6-c97279b2bc23", "zeaf5d3d-a7f3-3081-8ae5-724e07359bd6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a0157647-7016-41cc-9a56-8695acaa13e6", "zeaf5d3d-a7f3-4751-8ae5-724e07359bd6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a0157647-7016-41cc-9a56-8695acaa13e6", "zeaf5d3d-a7f3-4751-8ae5-724e07889bd6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6ecb5d3d-a7f3-4751-8ae5-524e07889bd6", "zecb5d3d-a7f3-4751-8ae5-724e07889bd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a22a428-b038-4f61-9cc9-b4373517f33e", "AAfodOZsRQmlD3JUV6W+oiKLxc9dlcOEe73TlKTYXfnL7/MNhg2CpeO1J/D8HDUsAw==", "d7e425a3-5c16-4849-941b-ca69aefa3c11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fb5d001-25cc-4e92-b610-f0cbd4b4b016", "AHXSdWrzwGalREvjmWGcDA3JCmMxXTJZICLdARJ+rLJ80MOY4sYyp0XhvB6kc8PMbA==", "1624a481-0a0b-41df-8119-24eddceec683" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89297646-10da-4aaa-9703-4abc31aea5f6", "AJedi+MZhIbuzexokfoXmR3H26SKr3HB3DgW7sHc+3fTkwb6M/ZR/MvydoRO1LDEkA==", "e86840dd-143e-4db9-b249-001fc76efa8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9d77566-066d-475f-9fc5-581824821696", "APIIySQNxTdvTM0MU10rAP7y+C6nkJrWNqRhxsglZUodKJj3vE7Kq7Q1LQaBPI+JsA==", "48758906-379c-4c04-8bf8-c87075b274d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be4ee4bf-39a3-43ee-98d5-7f347b049be3", "AAO9YMKKh2pEO/nV5B9EcFNV/2Wr64iYpUSymmOLvi9U3RqyWcDsotlYBC2sif96cQ==", "bf84bc6a-56ce-4b05-8c43-adf51e15738c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a6b3-3081-8ae5-724e07359bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf608b15-d460-469d-bd21-953275365dda", "ALWik3gWTLtVJCdkHtku4UXKr+smGjeJRUHxm3jGMYYHqh6hB/VzxaB3GLVrvCEJkg==", "25be0e96-cd7a-4581-b9a8-e9cb6dbe9ccf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a7f3-3081-8ae5-724e07359bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b7c62d5-a0af-49fd-a8db-218996fe3bfb", "AN5Ggj0/sKXTKAXQvN/NWTMT5Arj2RI/l0Pwrx4jJYKuxWJDUXbX9hSG1W8s4DmnIw==", "440a6720-274a-41f0-8a28-e09462530aaa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a7f3-4751-8ae5-724e07359bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b6aa10e-752a-47ef-a983-f13e5fde8e58", "ACrkGH5cFwdIq92cgCl9VCq0kjElfkfG365MaqzksyxQ7O88k0RenUJvBCabEH6kfA==", "a099b70b-20ab-45a2-bf51-7e47530e911f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "892512d1-0287-40b7-a6cb-304cf9cc8a69", "ADT4E8hu5fNmiBM+3DEfY7Fq+HhaCvkwBCz+pQr+rtkQyh+syvAKrODhvIQ2eFzDzw==", "bcd8f075-51ad-4d01-95e8-a93b8399ab49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fccd9e44-e3a6-4f4a-b19f-7fabc4139164", "AL8YxQ19urfucWJspoDqRpElOnSvgPRRvYHF5T2yaDF51VBxrmUGNoeaYTS6ulZteg==", "49fa450b-7a0a-4f18-94f5-08a3e65e255c" });
        }
    }
}
