using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class Trying : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointment_Doctors_DoctorId",
                table: "appointment");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "appointment",
                newName: "DocId");

            migrationBuilder.RenameIndex(
                name: "IX_appointment_DoctorId",
                table: "appointment",
                newName: "IX_appointment_DocId");

            migrationBuilder.AddForeignKey(
                name: "FK_appointment_Doctors_DocId",
                table: "appointment",
                column: "DocId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointment_Doctors_DocId",
                table: "appointment");

            migrationBuilder.RenameColumn(
                name: "DocId",
                table: "appointment",
                newName: "DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_appointment_DocId",
                table: "appointment",
                newName: "IX_appointment_DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_appointment_Doctors_DoctorId",
                table: "appointment",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
