﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leilao.Migrations
{
    /// <inheritdoc />
    public partial class ConfigurationProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Auctions_AuctionId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "AunctionId",
                table: "Properties");

            migrationBuilder.AlterColumn<int>(
                name: "AuctionId",
                table: "Vehicles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Auctions_AuctionId",
                table: "Vehicles",
                column: "AuctionId",
                principalTable: "Auctions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Auctions_AuctionId",
                table: "Vehicles");

            migrationBuilder.AlterColumn<int>(
                name: "AuctionId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AunctionId",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Auctions_AuctionId",
                table: "Vehicles",
                column: "AuctionId",
                principalTable: "Auctions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
