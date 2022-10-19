using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsdafObhurRealEstate.Migrations
{
    public partial class AddedNewColumInClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NotesBeforeWhileCreating",
                table: "Clients",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89f56f59-bf16-4c27-b9aa-26528c604cc0", "AEjcTPU6x4VaW9l+zqT332LhpSFUlDLIXIklnW9A5FfoLjlChooudugb4EpTcjN56A==", "90e02e0c-acd3-4f44-8a3c-9b7412be3b29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "679c16b0-b45b-498c-886b-e380ee67b7ad", "AKisOGcl+RNiGOy2GTLrF2jh02G+vTEVw7epCfuPUG1Aqcfs2uOtm6qA9+QJVJvN1A==", "7ff5b6d2-09c8-4f01-92ff-6dc95f26ccf8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c148e81-c788-41f8-aa98-dcb2e4bc6af9", "APcDsfM6H7nqgoACymaTPEtqsBwNH6EsMjerxC1rKlai96afel+JnINGcFKoqRISOA==", "3d28c369-0a93-4d8f-9279-5f9e13245f6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc3c72da-5268-48a0-8cad-76bf32dd1d58", "ANRerAR5x5f1nEJPZnJwWIAOHKtA3j+jsng19zTpqDr2sQIegIIb6REoSpYsBBw0hg==", "d521a8c3-0789-4557-87f6-85ed113546b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07418a7f-b689-45ad-ab4d-b5c3e03e41f9", "ALAndsqQXLJIKjebcKU7kcHUmx4ofvHxAyueCfY966U7tANI3BkqwCwioE91uFfIJw==", "fd4a47ba-8580-4677-a936-234d6a068728" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a6b3-3081-8ae5-724e07359bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92683fde-4b94-465d-a55f-bf49adefb22f", "ACbY7enGNF4NM0S4XPZ8P5kqjBORcZCiv+tiJPAFrgDugw+PpzuAmA/zMdzSsFEQOQ==", "c4ea1fb3-dd8c-4350-b66b-31700891976b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a6b3-3081-8ev5-724e0359xxd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b55f3e63-d488-489a-ad13-df963f5be28e", "AKbJgYmOmX1OKCrHn87H2isHZTfO/FLSAmX6/HIDVWNC3JUG1PMmJ4D/ZyFSVVQEEw==", "ed8581aa-8bab-41e6-94e0-2d9e28d83d46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a7f3-3081-8ae5-724e07359bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a7e95a6-f58f-415e-aa0b-a91c6a17ca50", "AP0CR2Kk+1TasLqrN1qt+q2ziXJ1G6mOmE6+Wve+70ku1gGJ+iKd9xRBlSVyZO21rg==", "f5e95013-9e06-4ecd-a65e-6febe6f2b116" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a7f3-4751-8ae5-724e07359bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa517630-220e-4270-8205-8c9e0870b488", "ANEdNzgpgyP58HELdVXAngOWBPH0B/RfeOhpYzAAoJhJUxtkR8iQy7g+jY2/+wpgqA==", "e8b1c734-2c73-4ba3-aa99-2a7ed06cf4ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "266e0ca3-3acd-49be-aaac-e9e9320b761a", "ALclSzGwMyt6cCRUmYdUp3AoaGGCzdSS76JCj+vzKOgcs0b/qFUFhM9PS2yWh/XRAQ==", "f8d99092-7bc0-43a8-81fe-1aebbfb5c933" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d761fc3-c6a5-4930-840b-28bb9f8dd87d", "AN/T3bcmskg20zsPWqOGeOp3plDpPj2hJg/WIHlxCM3BOXeIB/pTbL8Ob0wQG8V6Zg==", "0274fb46-643c-4dcf-a6ef-f8aa7f9499fd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotesBeforeWhileCreating",
                table: "Clients");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf40edf-af65-4d9e-8e6d-5f40d683cc3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13af7d41-9360-4e22-ae96-68492699d49c", "AM/ZDVd7Ftbr4N1ZveAEnz4M87QZL5Rru6a/029FFJ86CC191uKZMXMfyXYEEz6OVQ==", "1e19237c-f5d0-4963-8d3c-4038711234c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82fe29f0-c227-4a03-b2f6-z97279b2bc23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d961699-c39b-4059-9dc2-e1e17a2dc7b0", "AEYkI7ert5fAGitSyiqU0tnagkgCTh1rF1l9MP0qub83Nh3yawyrAqomIGIGehLPyA==", "408c61c7-ca33-42fc-bc38-a00c7708f130" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0157647-7016-41cc-9a56-3695acaa13e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "831bf6fc-9a94-42ab-923c-b9082c951cc8", "AOCm+1tOLPsCoh5uyShLFFhGIS/lsJMZRa1b3HcOYg5hw8QbuxBqeBlnuslATYWcJQ==", "5fa12b19-6a0e-401e-906c-dfcb2d68a364" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d0584e-fcd7-439c-8ae1-g5734664d6f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cec43b38-34fa-4758-a166-eca4bb3ef45b", "ABiwg97DsfaxVkG4es30GHzq2KykgiVflydfaackeMWdUcqQqvD71QUUbXwxY9bA9Q==", "d2f61227-3aa0-43b8-9af0-ceafb1015f1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "x313a786-637d-40c5-8715-543bba115487",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c2e5c6e-91a2-49b8-a8dc-088a0cc0f74e", "AH1hpIk+pMXPD3Z4hCqOkNHtfvd7/4s6xNu8/OFNY/2Fz5S3UCkcGlZxl3I4JFVNKg==", "da8eca5a-9d1c-4695-8103-a66c0380625a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a6b3-3081-8ae5-724e07359bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "241f71e5-4eb8-4f43-a9a0-fce60609e157", "AMCkVRn8tVJeXFX7IhcdeKrwL8xqer2queh4+UKAYoaTLmflwfgfwqiVSpa2rpcmzA==", "1b556865-393c-4926-8b23-cd5a77b600c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a6b3-3081-8ev5-724e0359xxd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25fe24e5-755c-4cf0-a1a6-b2217d6b1d39", "ADPSNAup8fKBbcoCGZ32FaDOaaD5FgZwKN/5Zu+1nvfztQ0NRyi0nSY5bto+Xx426w==", "5cf67740-f427-48f3-9f8d-309811c74d29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a7f3-3081-8ae5-724e07359bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0f87e79-6f0f-457f-8c71-e35aae239a0c", "AGiNfNX9xHPRro3mOrgJxR6/4SJ4gSR7TozCluJZL4ILNkyd+p2p/uvZZU4s8oTUyA==", "900609ce-eb42-489e-8de0-382f7fdf9e8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a7f3-4751-8ae5-724e07359bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69e9c245-8cc5-42e8-9409-7c63bb8ec1b5", "AJzTw94zDB30fy0c9Epn6MKlJ9nd3UwzbwACNgW5yP61jWwmBmueEENwrdK0y0wYxQ==", "4cfc5747-b90b-4290-8df7-b9e77b9d85bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea13bdaf-0542-49c0-895d-a445b3f31d60", "AC8+93J7h05eqfk8SvUrHOyhOrPn0iUn+p+l2kKagULWAEG+I+oNuJLKBBONYLzM0Q==", "a4e1700b-d491-450d-939b-c179f2bc40d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zecb5d3d-a7f3-4751-8ae5-724e07889bd6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1f8043d-bf78-4bc0-ba9f-fd1b7eb0a028", "AJdOkI2ZaejtpUx4S2UEDxewdMkTgCKp1lRXMteEWdCQhxsnZdksEcciJxnyLhYXHQ==", "1fb292b0-1ae9-40dc-87df-bf30fefd69a3" });
        }
    }
}
