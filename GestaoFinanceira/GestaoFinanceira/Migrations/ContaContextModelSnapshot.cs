// <auto-generated />
using System;
using GestaoFinanceira.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestaoFinanceira.Migrations
{
    [DbContext(typeof(ContaContext))]
    partial class ContaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("GestaoFinanceira.Models.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Contas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataHora = new DateTime(2022, 6, 10, 12, 40, 30, 268, DateTimeKind.Local).AddTicks(6692),
                            Descricao = "Pago",
                            Valor = 100.0
                        },
                        new
                        {
                            Id = 2,
                            DataHora = new DateTime(2022, 6, 10, 12, 40, 30, 268, DateTimeKind.Local).AddTicks(6709),
                            Descricao = "Pago",
                            Valor = 700.0
                        },
                        new
                        {
                            Id = 3,
                            DataHora = new DateTime(2022, 6, 10, 12, 40, 30, 268, DateTimeKind.Local).AddTicks(6710),
                            Descricao = "Pago",
                            Valor = 50.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
