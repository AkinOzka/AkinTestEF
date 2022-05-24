using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AkinTestEF.Migrations
{
    public partial class addeddatatoBookclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Published", "StudentId", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(1913, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, " In Search of Lost Time" },
                    { 2, new DateTime(1904, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ulysses" },
                    { 3, new DateTime(1605, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, " Don Quixote" },
                    { 4, new DateTime(1967, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, " One Hundred Years of Solitude" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);
        }
    }
}
