using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AProjektSupermarked.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dbsVare",
                columns: table => new
                {
                    VareID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Beskrivelse = table.Column<string>(nullable: true),
                    Navn = table.Column<string>(nullable: true),
                    Pris = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbsVare", x => x.VareID);
                });

            migrationBuilder.CreateTable(
                name: "dbsIndkob",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Dato = table.Column<DateTime>(nullable: false),
                    Fakturanummer = table.Column<int>(nullable: false),
                    VareID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbsIndkob", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dbsIndkob_dbsVare_VareID",
                        column: x => x.VareID,
                        principalTable: "dbsVare",
                        principalColumn: "VareID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dbsIndkob_VareID",
                table: "dbsIndkob",
                column: "VareID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbsIndkob");

            migrationBuilder.DropTable(
                name: "dbsVare");
        }
    }
}
