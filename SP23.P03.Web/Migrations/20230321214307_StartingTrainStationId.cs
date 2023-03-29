using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SP23.P03.Web.Migrations
{
    /// <inheritdoc />
    public partial class StartingTrainStationId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "endingDestination",
                table: "Ticket");

            migrationBuilder.RenameColumn(
                name: "startingDestination",
                table: "Ticket",
                newName: "StartingTrainStationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartingTrainStationId",
                table: "Ticket",
                newName: "startingDestination");

            migrationBuilder.AddColumn<int>(
                name: "endingDestination",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
