﻿// <auto-generated />
using CRUDBiblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUDBiblioteca.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20230224134052_Inicial-criacao")]
    partial class Inicialcriacao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRUDBiblioteca.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Classification")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Edition")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<string>("NumPages")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}