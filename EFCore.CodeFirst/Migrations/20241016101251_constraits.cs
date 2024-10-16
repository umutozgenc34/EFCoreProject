﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class constraits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(9,2)",
                precision: 9,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountPrice",
                table: "Products",
                type: "decimal(9,2)",
                precision: 9,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddCheckConstraint(
                name: "PriceDiscountCheck",
                table: "Products",
                sql: "[Price] > [DiscountPrice]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "PriceDiscountCheck",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "Products");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,2)",
                oldPrecision: 9,
                oldScale: 2);
        }
    }
}
