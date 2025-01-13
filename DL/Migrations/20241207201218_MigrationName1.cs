using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DL.Migrations
{
    public partial class MigrationName1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DL.IDataContext.Appointments_DL.IDataContext.Babies_BabyId",
                table: "DL.IDataContext.Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_DL.IDataContext.Appointments_DL.IDataContext.Nurses_NurseId",
                table: "DL.IDataContext.Appointments");

            migrationBuilder.DropIndex(
                name: "IX_DL.IDataContext.Appointments_BabyId",
                table: "DL.IDataContext.Appointments");

            migrationBuilder.DropIndex(
                name: "IX_DL.IDataContext.Appointments_NurseId",
                table: "DL.IDataContext.Appointments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_DL.IDataContext.Appointments_BabyId",
                table: "DL.IDataContext.Appointments",
                column: "BabyId");

            migrationBuilder.CreateIndex(
                name: "IX_DL.IDataContext.Appointments_NurseId",
                table: "DL.IDataContext.Appointments",
                column: "NurseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DL.IDataContext.Appointments_DL.IDataContext.Babies_BabyId",
                table: "DL.IDataContext.Appointments",
                column: "BabyId",
                principalTable: "DL.IDataContext.Babies",
                principalColumn: "BabyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DL.IDataContext.Appointments_DL.IDataContext.Nurses_NurseId",
                table: "DL.IDataContext.Appointments",
                column: "NurseId",
                principalTable: "DL.IDataContext.Nurses",
                principalColumn: "NurseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
