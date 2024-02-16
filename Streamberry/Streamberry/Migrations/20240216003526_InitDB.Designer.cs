﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Streamberry.Data;

#nullable disable

namespace Streamberry.Migrations
{
    [DbContext(typeof(SystemFilmsDBContext))]
    [Migration("20240216003526_InitDB")]
    partial class InitDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Streamberry.Models.FilmModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("GeneroId")
                        .HasColumnType("int");

                    b.Property<Guid>("IdGenero")
                        .HasColumnType("char(36)")
                        .HasColumnName("IdGenero");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GeneroId");

                    b.ToTable("Film");
                });

            modelBuilder.Entity("Streamberry.Models.GenderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("GenderModel");
                });

            modelBuilder.Entity("Streamberry.Models.FilmModel", b =>
                {
                    b.HasOne("Streamberry.Models.GenderModel", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId");

                    b.Navigation("Genero");
                });
#pragma warning restore 612, 618
        }
    }
}