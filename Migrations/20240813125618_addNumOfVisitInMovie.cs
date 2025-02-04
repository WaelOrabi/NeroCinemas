﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nero.Migrations
{
    /// <inheritdoc />
    public partial class addNumOfVisitInMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumOfVisit",
                table: "Movies",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumOfVisit",
                table: "Movies");
        }
    }
}
