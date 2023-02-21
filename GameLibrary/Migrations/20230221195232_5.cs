using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameLibrary.Migrations
{
    /// <inheritdoc />
    public partial class _5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublisherModelId",
                table: "BoardGames",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PublisherModelBoardGameModel",
                columns: table => new
                {
                    BoardGameId = table.Column<int>(type: "int", nullable: false),
                    PublisherID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublisherModelBoardGameModel", x => new { x.PublisherID, x.BoardGameId });
                    table.ForeignKey(
                        name: "FK_PublisherModelBoardGameModel_BoardGames_BoardGameId",
                        column: x => x.BoardGameId,
                        principalTable: "BoardGames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublisherModelBoardGameModel_Publishers_PublisherID",
                        column: x => x.PublisherID,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublisherModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublisherModelId",
                value: null);

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Days of Wonder" },
                    { 2, "Stonemaier Games" }
                });

            migrationBuilder.InsertData(
                table: "PublisherModelBoardGameModel",
                columns: new[] { "BoardGameId", "PublisherID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoardGames_PublisherModelId",
                table: "BoardGames",
                column: "PublisherModelId");

            migrationBuilder.CreateIndex(
                name: "IX_PublisherModelBoardGameModel_BoardGameId",
                table: "PublisherModelBoardGameModel",
                column: "BoardGameId");

            migrationBuilder.AddForeignKey(
                name: "FK_BoardGames_Publishers_PublisherModelId",
                table: "BoardGames",
                column: "PublisherModelId",
                principalTable: "Publishers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoardGames_Publishers_PublisherModelId",
                table: "BoardGames");

            migrationBuilder.DropTable(
                name: "PublisherModelBoardGameModel");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropIndex(
                name: "IX_BoardGames_PublisherModelId",
                table: "BoardGames");

            migrationBuilder.DropColumn(
                name: "PublisherModelId",
                table: "BoardGames");
        }
    }
}
