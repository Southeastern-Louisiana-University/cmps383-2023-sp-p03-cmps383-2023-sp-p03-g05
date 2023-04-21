using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SP23.P03.Web.Migrations
{
    /// <inheritdoc />
    public partial class _4212023 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_AspNetUsers_PassengerId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_TrainStation_EndingTrainStationId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_TrainStation_StartingTrainStationId",
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

            migrationBuilder.AlterColumn<int>(
                name: "PassengerId",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EndingTrainStationId",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DepartureTime",
                table: "Ticket",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "TrainCart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassLetter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coach = table.Column<int>(type: "int", nullable: true),
                    firstClass = table.Column<int>(type: "int", nullable: true),
                    roomlet = table.Column<int>(type: "int", nullable: true),
                    sleeper = table.Column<int>(type: "int", nullable: true),
                    dining = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainCart", x => x.Id);
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_AspNetUsers_PassengerId",
                table: "Ticket",
                column: "PassengerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_TrainStation_EndingTrainStationId",
                table: "Ticket",
                column: "EndingTrainStationId",
                principalTable: "TrainStation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_TrainStation_StartingTrainStationId",
                table: "Ticket",
                column: "StartingTrainStationId",
                principalTable: "TrainStation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_AspNetUsers_PassengerId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_TrainStation_EndingTrainStationId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_TrainStation_StartingTrainStationId",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "Train");

            migrationBuilder.DropTable(
                name: "TrainCart");

            migrationBuilder.AlterColumn<int>(
                name: "StartingTrainStationId",
                table: "Ticket",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PassengerId",
                table: "Ticket",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EndingTrainStationId",
                table: "Ticket",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DepartureTime",
                table: "Ticket",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_AspNetUsers_PassengerId",
                table: "Ticket",
                column: "PassengerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

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
    }
}
