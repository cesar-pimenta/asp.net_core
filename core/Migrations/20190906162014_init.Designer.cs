﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using core.Data;

namespace core.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190906162014_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("core.Models.Atributo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<int?>("ProdutoId");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Atributos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "chave"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "motor"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "abraçadeira"
                        });
                });

            modelBuilder.Entity("core.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "chave"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "motor"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "abraçadeira"
                        });
                });

            modelBuilder.Entity("core.Models.Atributo", b =>
                {
                    b.HasOne("core.Models.Produto")
                        .WithMany("Atributos")
                        .HasForeignKey("ProdutoId");
                });
#pragma warning restore 612, 618
        }
    }
}