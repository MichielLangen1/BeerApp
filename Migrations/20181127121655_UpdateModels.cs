using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class UpdateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserBeer",
                columns: table => new
                {
                    UserID = table.Column<string>(nullable: false),
                    BeerId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBeer", x => new { x.UserID, x.BeerId });
                    table.ForeignKey(
                        name: "FK_UserBeer_Beer_BeerId",
                        column: x => x.BeerId,
                        principalTable: "Beer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBeer_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserBeer_BeerId",
                table: "UserBeer",
                column: "BeerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBeer");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
