using Microsoft.EntityFrameworkCore.Migrations;

namespace jurassicpark.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 5, 7, "Female", "Matilda", "Woolly Mammoth" },
                    { 6, 10, "Female", "Rexie", "Dinosaur" },
                    { 7, 2, "Female", "Matilda", "Dinosaur" },
                    { 24, 24, "Male", "Pip", "Sha5" },
                    { 22, 22, "Male", "Bartholomew", "Dinosaur" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 24);
        }
    }
}
