using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SP23.P03.Web.Migrations
{
    /// <inheritdoc />
    public partial class TrainDBSET : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Train",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainCart1Id = table.Column<int>(type: "int", nullable: true),
                    TrainCart2Id = table.Column<int>(type: "int", nullable: true),
                    TrainCart3Id = table.Column<int>(type: "int", nullable: true),
                    TrainCart4Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Train", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Train_TrainCart_TrainCart1Id",
                        column: x => x.TrainCart1Id,
                        principalTable: "TrainCart",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Train_TrainCart_TrainCart2Id",
                        column: x => x.TrainCart2Id,
                        principalTable: "TrainCart",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Train_TrainCart_TrainCart3Id",
                        column: x => x.TrainCart3Id,
                        principalTable: "TrainCart",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Train_TrainCart_TrainCart4Id",
                        column: x => x.TrainCart4Id,
                        principalTable: "TrainCart",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Train_TrainCart1Id",
                table: "Train",
                column: "TrainCart1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Train_TrainCart2Id",
                table: "Train",
                column: "TrainCart2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Train_TrainCart3Id",
                table: "Train",
                column: "TrainCart3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Train_TrainCart4Id",
                table: "Train",
                column: "TrainCart4Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Train");
        }
    }
}
