using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace teste.Migrations
{
    public partial class hierarquiaCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    bairro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    cep = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    cidade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    complemento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    contato = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    dataCadastro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    endereco = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    estado = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    observacao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    tel1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    tel2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    tel3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
