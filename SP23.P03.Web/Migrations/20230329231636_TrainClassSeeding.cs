using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SP23.P03.Web.Migrations
{
    /// <inheritdoc />
    public partial class TrainClassSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainCart");
        }
    }
}
