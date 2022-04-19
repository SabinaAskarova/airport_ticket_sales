﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProject.Migrations
{
    public partial class SeatNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Tickets",
                newName: "SeatNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SeatNumber",
                table: "Tickets",
                newName: "Number");
        }
    }
}
