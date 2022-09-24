using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestWAT.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personnes",
                columns: table => new
                {
                    PersonneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: false),
                    Prenom = table.Column<string>(nullable: true),
                    DateDeNaissance = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnes", x => x.PersonneId);
                });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "PersonneId", "DateDeNaissance", "Nom", "Prenom" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mak", "Sheti" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "PersonneId", "DateDeNaissance", "Nom", "Prenom" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mak", "Cindy" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "PersonneId", "DateDeNaissance", "Nom", "Prenom" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mak", "Elijaah" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personnes");
        }
    }
}
