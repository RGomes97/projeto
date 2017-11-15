using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace teste.Migrations
{
    public partial class SituacaoDeCompra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "situacaoDeCompra",
                table: "Clientes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "situacaoDeCompra",
                table: "Clientes");
        }
    }
}
