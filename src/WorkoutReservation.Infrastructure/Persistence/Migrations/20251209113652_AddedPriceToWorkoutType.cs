using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkoutReservation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedPriceToWorkoutType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "WorkoutReservation",
                table: "Content",
                keyColumn: "Id",
                keyValue: new Guid("66247d3d-7f51-4ee3-a25e-560abd516003"));

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                schema: "WorkoutReservation",
                table: "WorkoutTypes",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                schema: "WorkoutReservation",
                table: "Content",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Type", "Value" },
                values: new object[] { new Guid("ce1db8f1-be88-4453-8e35-62ffd932173c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, "HomePageHtml", "The home page is empty." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "WorkoutReservation",
                table: "Content",
                keyColumn: "Id",
                keyValue: new Guid("ce1db8f1-be88-4453-8e35-62ffd932173c"));

            migrationBuilder.DropColumn(
                name: "Price",
                schema: "WorkoutReservation",
                table: "WorkoutTypes");

            migrationBuilder.InsertData(
                schema: "WorkoutReservation",
                table: "Content",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Type", "Value" },
                values: new object[] { new Guid("66247d3d-7f51-4ee3-a25e-560abd516003"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, "HomePageHtml", "The home page is empty." });
        }
    }
}
