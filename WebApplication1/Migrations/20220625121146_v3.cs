using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Hotels");

            migrationBuilder.AddColumn<int>(
                name: "LocationRefId",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_LocationRefId",
                table: "Hotels",
                column: "LocationRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Locations_LocationRefId",
                table: "Hotels",
                column: "LocationRefId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Locations_LocationRefId",
                table: "Hotels");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_LocationRefId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "LocationRefId",
                table: "Hotels");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Hotels",
                type: "varchar(max)",
                unicode: false,
                nullable: false,
                defaultValue: "");
        }
    }
}
