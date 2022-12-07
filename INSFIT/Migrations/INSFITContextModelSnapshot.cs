﻿// <auto-generated />
using System;
using INSFIT.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace INSFIT.Migrations
{
    [DbContext(typeof(INSFITContext))]
    partial class INSFITContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("INSFIT.Models.Cadastro", b =>
                {
                    b.Property<int>("id_cadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_cadastro"), 1L, 1);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipoUsuario")
                        .HasColumnType("int");

                    b.HasKey("id_cadastro");

                    b.ToTable("Cadastro");
                });

            modelBuilder.Entity("INSFIT.Models.Dieta", b =>
                {
                    b.Property<int>("Id_Dieta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Dieta"), 1L, 1);

                    b.Property<string>("CampoImgem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CampodePesquisa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataPublicacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Dieta");

                    b.ToTable("Dieta");
                });

            modelBuilder.Entity("INSFIT.Models.Feed", b =>
                {
                    b.Property<int>("Id_Feed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Feed"), 1L, 1);

                    b.Property<string>("CampoImgem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CampoTexto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataPublicacao")
                        .HasColumnType("datetime2");

                    b.HasKey("Id_Feed");

                    b.ToTable("Feed");
                });

            modelBuilder.Entity("INSFIT.Models.Perfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Altura")
                        .HasColumnType("float");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.Property<int>("Usuario")
                        .HasColumnType("int");

                    b.Property<int>("indetificador")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("indetificador");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("INSFIT.Models.Relatorio", b =>
                {
                    b.Property<int>("Id_relatorio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_relatorio"), 1L, 1);

                    b.Property<double>("altura")
                        .HasColumnType("float");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("peso")
                        .HasColumnType("float");

                    b.HasKey("Id_relatorio");

                    b.ToTable("relatorio");
                });

            modelBuilder.Entity("INSFIT.Models.Perfil", b =>
                {
                    b.HasOne("INSFIT.Models.Cadastro", "Cadastro")
                        .WithMany("Perfil")
                        .HasForeignKey("indetificador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cadastro");
                });

            modelBuilder.Entity("INSFIT.Models.Cadastro", b =>
                {
                    b.Navigation("Perfil");
                });
#pragma warning restore 612, 618
        }
    }
}
