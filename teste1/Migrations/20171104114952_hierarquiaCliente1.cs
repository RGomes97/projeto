using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace teste.Migrations
{
    public partial class hierarquiaCliente1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "cpf",
                table: "Clientes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nome",
                table: "Clientes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "rg",
                table: "Clientes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cnpj",
                table: "Clientes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "inscricaoEstadual",
                table: "Clientes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "razaoSocial",
                table: "Clientes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "cpf",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "nome",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "rg",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "cnpj",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "inscricaoEstadual",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "razaoSocial",
                table: "Clientes");
        }
    }
}
