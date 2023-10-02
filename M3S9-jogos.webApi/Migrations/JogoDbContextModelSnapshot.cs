﻿// <auto-generated />
using System;
using M3S9_jogos.webApi.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace M3S9_jogos.webApi.Migrations
{
    [DbContext(typeof(JogoDbContext))]
    partial class JogoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("M3S9_jogos.webApi.Domain.Estudio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("Estudios", (string)null);
                });

            modelBuilder.Entity("M3S9_jogos.webApi.Domain.Jogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<int>("EstudioId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EstudioId");

                    b.ToTable("Jogos", (string)null);
                });

            modelBuilder.Entity("M3S9_jogos.webApi.Domain.Jogo", b =>
                {
                    b.HasOne("M3S9_jogos.webApi.Domain.Estudio", "Estudio")
                        .WithMany("Jogos")
                        .HasForeignKey("EstudioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estudio");
                });

            modelBuilder.Entity("M3S9_jogos.webApi.Domain.Estudio", b =>
                {
                    b.Navigation("Jogos");
                });
#pragma warning restore 612, 618
        }
    }
}
