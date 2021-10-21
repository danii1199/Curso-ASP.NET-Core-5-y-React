using Microsoft.EntityFrameworkCore.Migrations;

namespace apiApp.Migrations
{
    public partial class SampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Descripción de la película 1", "Película 1" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Descripción de la película 2", "Película 2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Descripción de la película 3", "Película 3" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 1, null, "Personaje Cast 1", 1, "Cast 1" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 2, null, "Personaje Cast 2", 1, "Cast 2" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 3, null, "Personaje Cast 3", 1, "Cast 3" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 4, null, "Personaje Cast 4", 2, "Cast 4" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 5, null, "Personaje Cast 5", 2, "Cast 5" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 6, null, "Personaje Cast 6", 2, "Cast 6" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 7, null, "Personaje Cast 7", 3, "Cast 7" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 8, null, "Personaje Cast 8", 3, "Cast 8" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 9, null, "Personaje Cast 9", 3, "Cast 9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
