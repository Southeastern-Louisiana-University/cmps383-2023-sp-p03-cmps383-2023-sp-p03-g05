using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SP23.P03.Web.Migrations
{
    /// <inheritdoc />
    public partial class take1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StartingTrainStationId",
                table: "Ticket",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EndingTrainStationId",
                table: "Ticket",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_EndingTrainStationId",
                table: "Ticket",
                column: "EndingTrainStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_StartingTrainStationId",
                table: "Ticket",
                column: "StartingTrainStationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_TrainStation_EndingTrainStationId",
                table: "Ticket",
                column: "EndingTrainStationId",
                principalTable: "TrainStation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_TrainStation_StartingTrainStationId",
                table: "Ticket",
                column: "StartingTrainStationId",
                principalTable: "TrainStation",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_TrainStation_EndingTrainStationId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_TrainStation_StartingTrainStationId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_EndingTrainStationId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_StartingTrainStationId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "EndingTrainStationId",
                table: "Ticket");

            migrationBuilder.AlterColumn<int>(
                name: "StartingTrainStationId",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
