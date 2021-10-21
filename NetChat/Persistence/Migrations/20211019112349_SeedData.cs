using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("d1dd080b-3beb-41ea-981d-351719680047"), "Canal dedicado a dotnet core", "DotnetCore" });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("144c9a71-4bde-4a74-84c1-b9690e7bca98"), "Canal dedicado a reactJs", "Reactjs" });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("0e8159ec-3eba-4e60-a3c4-cb94c364ea44"), "Canal dedicado a Angular", "Angular" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("0e8159ec-3eba-4e60-a3c4-cb94c364ea44"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("144c9a71-4bde-4a74-84c1-b9690e7bca98"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("d1dd080b-3beb-41ea-981d-351719680047"));
        }
    }
}
