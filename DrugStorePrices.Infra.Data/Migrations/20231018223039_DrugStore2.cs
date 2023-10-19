using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrugStorePrices.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class DrugStore2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateAt",
                table: "DrugStores",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdateAt",
                table: "DrugStores");
        }
    }
}
