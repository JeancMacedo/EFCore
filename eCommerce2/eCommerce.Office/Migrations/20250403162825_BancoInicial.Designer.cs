﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eCommerce.Office;

#nullable disable

namespace eCommerce.Office.Migrations
{
    [DbContext(typeof(eCommerceOfficeContext))]
    [Migration("20250403162825_BancoInicial")]
    partial class BancoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ColaboradorTurma", b =>
                {
                    b.Property<int>("ColaboradoresId")
                        .HasColumnType("int");

                    b.Property<int>("TurmasId")
                        .HasColumnType("int");

                    b.HasKey("ColaboradoresId", "TurmasId");

                    b.HasIndex("TurmasId");

                    b.ToTable("ColaboradorTurma");
                });

            modelBuilder.Entity("ColaboradorVeiculo", b =>
                {
                    b.Property<int>("ColaboradoresId")
                        .HasColumnType("int");

                    b.Property<int>("VeiculosId")
                        .HasColumnType("int");

                    b.HasKey("ColaboradoresId", "VeiculosId");

                    b.HasIndex("VeiculosId");

                    b.ToTable("ColaboradorVeiculo");
                });

            modelBuilder.Entity("eCommerce.Office.Models.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colaboradores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "José"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Maria"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Felipe"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Tiago"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Mariano"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Jessica"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Vivian"
                        });
                });

            modelBuilder.Entity("eCommerce.Office.Models.ColaboradorSetor", b =>
                {
                    b.Property<int>("SetorId")
                        .HasColumnType("int");

                    b.Property<int>("ColaboradorId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("Criado")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("SetorId", "ColaboradorId");

                    b.HasIndex("ColaboradorId");

                    b.ToTable("ColaboradoresSetores");

                    b.HasData(
                        new
                        {
                            SetorId = 1,
                            ColaboradorId = 1,
                            Criado = new DateTimeOffset(new DateTime(2025, 4, 3, 13, 28, 25, 586, DateTimeKind.Unspecified).AddTicks(2955), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SetorId = 1,
                            ColaboradorId = 6,
                            Criado = new DateTimeOffset(new DateTime(2025, 4, 3, 13, 28, 25, 586, DateTimeKind.Unspecified).AddTicks(2976), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SetorId = 2,
                            ColaboradorId = 5,
                            Criado = new DateTimeOffset(new DateTime(2025, 4, 3, 13, 28, 25, 586, DateTimeKind.Unspecified).AddTicks(2978), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SetorId = 2,
                            ColaboradorId = 4,
                            Criado = new DateTimeOffset(new DateTime(2025, 4, 3, 13, 28, 25, 586, DateTimeKind.Unspecified).AddTicks(2980), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SetorId = 3,
                            ColaboradorId = 7,
                            Criado = new DateTimeOffset(new DateTime(2025, 4, 3, 13, 28, 25, 586, DateTimeKind.Unspecified).AddTicks(2981), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SetorId = 4,
                            ColaboradorId = 2,
                            Criado = new DateTimeOffset(new DateTime(2025, 4, 3, 13, 28, 25, 586, DateTimeKind.Unspecified).AddTicks(2983), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SetorId = 4,
                            ColaboradorId = 3,
                            Criado = new DateTimeOffset(new DateTime(2025, 4, 3, 13, 28, 25, 586, DateTimeKind.Unspecified).AddTicks(2984), new TimeSpan(0, -3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("eCommerce.Office.Models.Setor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ColaboradorId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ColaboradorId");

                    b.ToTable("Setores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Lógistica"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Separação"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Financeiro"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Administrativo"
                        });
                });

            modelBuilder.Entity("eCommerce.Office.Models.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("eCommerce.Office.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("ColaboradorTurma", b =>
                {
                    b.HasOne("eCommerce.Office.Models.Colaborador", null)
                        .WithMany()
                        .HasForeignKey("ColaboradoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerce.Office.Models.Turma", null)
                        .WithMany()
                        .HasForeignKey("TurmasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ColaboradorVeiculo", b =>
                {
                    b.HasOne("eCommerce.Office.Models.Colaborador", null)
                        .WithMany()
                        .HasForeignKey("ColaboradoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerce.Office.Models.Veiculo", null)
                        .WithMany()
                        .HasForeignKey("VeiculosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eCommerce.Office.Models.ColaboradorSetor", b =>
                {
                    b.HasOne("eCommerce.Office.Models.Colaborador", "Colaborador")
                        .WithMany("ColaboradorSetores")
                        .HasForeignKey("ColaboradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerce.Office.Models.Setor", "Setor")
                        .WithMany("ColaboradoresSetores")
                        .HasForeignKey("SetorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colaborador");

                    b.Navigation("Setor");
                });

            modelBuilder.Entity("eCommerce.Office.Models.Setor", b =>
                {
                    b.HasOne("eCommerce.Office.Models.Colaborador", null)
                        .WithMany("Setores")
                        .HasForeignKey("ColaboradorId");
                });

            modelBuilder.Entity("eCommerce.Office.Models.Colaborador", b =>
                {
                    b.Navigation("ColaboradorSetores");

                    b.Navigation("Setores");
                });

            modelBuilder.Entity("eCommerce.Office.Models.Setor", b =>
                {
                    b.Navigation("ColaboradoresSetores");
                });
#pragma warning restore 612, 618
        }
    }
}
