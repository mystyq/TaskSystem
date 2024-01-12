using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddTargetCompleteDate_CompletedDate_EstimateDurationColumnstoTasktable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedDate",
                table: "Tasks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "EstimateDuration",
                table: "Tasks",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TargetCompleteDate",
                table: "Tasks",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletedDate",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "EstimateDuration",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TargetCompleteDate",
                table: "Tasks");
        }
    }
}
