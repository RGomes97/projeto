﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;
using teste;

namespace teste.Migrations
{
    [DbContext(typeof(TesteContext))]
    partial class TesteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("teste.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("bairro")
                        .HasMaxLength(50);

                    b.Property<string>("cep")
                        .HasMaxLength(15);

                    b.Property<string>("cidade")
                        .HasMaxLength(50);

                    b.Property<string>("complemento")
                        .HasMaxLength(100);

                    b.Property<string>("contato")
                        .HasMaxLength(20);

                    b.Property<string>("dataCadastro")
                        .HasMaxLength(20);

                    b.Property<string>("endereco")
                        .HasMaxLength(100);

                    b.Property<string>("estado")
                        .HasMaxLength(2);

                    b.Property<string>("observacao")
                        .HasMaxLength(100);

                    b.Property<string>("situacaoDeCompra")
                        .HasMaxLength(100);

                    b.Property<string>("tel1")
                        .HasMaxLength(20);

                    b.Property<string>("tel2")
                        .HasMaxLength(20);

                    b.Property<string>("tel3")
                        .HasMaxLength(20);

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Cliente");
                });

            modelBuilder.Entity("teste.ClientePessoaFisica", b =>
                {
                    b.HasBaseType("teste.Cliente");

                    b.Property<string>("cpf")
                        .HasMaxLength(20);

                    b.Property<string>("nome")
                        .HasMaxLength(100);

                    b.Property<string>("rg")
                        .HasMaxLength(20);

                    b.ToTable("ClientePessoaFisica");

                    b.HasDiscriminator().HasValue("ClientePessoaFisica");
                });

            modelBuilder.Entity("teste.ClientePessoaJuridica", b =>
                {
                    b.HasBaseType("teste.Cliente");

                    b.Property<string>("cnpj")
                        .HasMaxLength(20);

                    b.Property<string>("inscricaoEstadual")
                        .HasMaxLength(20);

                    b.Property<string>("razaoSocial")
                        .HasMaxLength(100);

                    b.ToTable("ClientePessoaJuridica");

                    b.HasDiscriminator().HasValue("ClientePessoaJuridica");
                });
#pragma warning restore 612, 618
        }
    }
}
