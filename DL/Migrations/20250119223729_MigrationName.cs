using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DL.Migrations
{
    public partial class MigrationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DL.IDataContext.Babies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DL.IDataContext.Babies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DL.IDataContext.Nurses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DL.IDataContext.Nurses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DL.IDataContext.Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BabyId = table.Column<int>(type: "int", nullable: false),
                    NurseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DL.IDataContext.Appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_DL.IDataContext.Appointments_DL.IDataContext.Babies_BabyId",
                        column: x => x.BabyId,
                        principalTable: "DL.IDataContext.Babies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DL.IDataContext.Appointments_DL.IDataContext.Nurses_NurseId",
                        column: x => x.NurseId,
                        principalTable: "DL.IDataContext.Nurses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DL.IDataContext.Appointments_BabyId",
                table: "DL.IDataContext.Appointments",
                column: "BabyId");

            migrationBuilder.CreateIndex(
                name: "IX_DL.IDataContext.Appointments_NurseId",
                table: "DL.IDataContext.Appointments",
                column: "NurseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DL.IDataContext.Appointments");

            migrationBuilder.DropTable(
                name: "DL.IDataContext.Babies");

            migrationBuilder.DropTable(
                name: "DL.IDataContext.Nurses");
        }
    }
}
