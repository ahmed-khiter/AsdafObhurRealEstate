using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsdafObhurRealEstate.Migrations
{
    public partial class ChangeDepartmentAmal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a7f3-3081-8ae5-724e07359bd6",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0f87e79-6f0f-457f-8c71-e35aae239a0c", "2bf40edf-af65-4d9e-8e6d-5f40d683cc3e", "AGiNfNX9xHPRro3mOrgJxR6/4SJ4gSR7TozCluJZL4ILNkyd+p2p/uvZZU4s8oTUyA==", "900609ce-eb42-489e-8de0-382f7fdf9e8a" });

         }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "zeaf5d3d-a7f3-3081-8ae5-724e07359bd6",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1eab0788-d002-4bf5-aa67-8086b46c92aa", "cf8ac5ac-ee3f-4cac-988d-v45ef0eed54c", "AFDU0N52HO5L5Nua1YZLNUeLABH+JBOReFGPsrnVL18QuN0yb/qAxTHjmDzqr9su0g==", "a2916496-af40-4397-ae8f-17370e1f5d6c" });
}
    }
}
