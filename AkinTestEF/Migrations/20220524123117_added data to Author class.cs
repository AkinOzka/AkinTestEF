using Microsoft.EntityFrameworkCore.Migrations;

namespace AkinTestEF.Migrations
{
    public partial class addeddatatoAuthorclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Authors",
                newName: "SurName");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "BookId", "Name", "SurName" },
                values: new object[,]
                {
                    { 1, 0, "Marcel", "Proust" },
                    { 2, 0, "James", "Joyce" },
                    { 3, 0, "Miguel", "Cervantes" },
                    { 4, 0, "Gabriel Garcia", "Marquez" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "SurName",
                table: "Authors",
                newName: "Surname");
        }
    }
}
