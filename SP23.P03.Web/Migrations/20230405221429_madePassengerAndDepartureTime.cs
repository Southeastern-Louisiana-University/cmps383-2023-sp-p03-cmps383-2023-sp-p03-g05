using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SP23.P03.Web.Migrations
{
    /// <inheritdoc />
    public partial class madePassengerAndDepartureTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DepartureTime",
                table: "Ticket",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PassengerId",
                table: "Ticket",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PassengerId",
                table: "Ticket",
                column: "PassengerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_AspNetUsers_PassengerId",
                table: "Ticket",
                column: "PassengerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_AspNetUsers_PassengerId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_PassengerId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "DepartureTime",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "PassengerId",
                table: "Ticket");
        }
    }
}
