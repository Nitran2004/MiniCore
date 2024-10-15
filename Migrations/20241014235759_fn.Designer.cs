﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniCore.Models;

#nullable disable

namespace MiniCore.Migrations
{
    [DbContext(typeof(MinicoreContext))]
    [Migration("20241014235759_fn")]
    partial class fn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MiniCore.Models.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__Empleado__3214EC0741FDB3FE");

                    b.ToTable("Empleado", (string)null);
                });

            modelBuilder.Entity("MiniCore.Models.Proyecto", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__Proyecto__3214EC07D37085AA");

                    b.ToTable("Proyecto", (string)null);
                });

            modelBuilder.Entity("MiniCore.Models.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<string>("EstadoProgreso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("FechadeInicio")
                        .HasColumnType("date");

                    b.Property<string>("Nombredelatarea")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ProyectoId")
                        .HasColumnType("int");

                    b.Property<double?>("TiempoEstimado")
                        .HasColumnType("float");

                    b.HasKey("Id")
                        .HasName("PK__Tareas__3214EC072B780C36");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("ProyectoId");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("MiniCore.Models.Tarea", b =>
                {
                    b.HasOne("MiniCore.Models.Empleado", "Empleado")
                        .WithMany("Tareas")
                        .HasForeignKey("EmpleadoId")
                        .HasConstraintName("FK__Tareas__Empleado__3C69FB99");

                    b.HasOne("MiniCore.Models.Proyecto", "Proyecto")
                        .WithMany("Tareas")
                        .HasForeignKey("ProyectoId")
                        .HasConstraintName("FK__Tareas__Proyecto__3B75D760");

                    b.Navigation("Empleado");

                    b.Navigation("Proyecto");
                });

            modelBuilder.Entity("MiniCore.Models.Empleado", b =>
                {
                    b.Navigation("Tareas");
                });

            modelBuilder.Entity("MiniCore.Models.Proyecto", b =>
                {
                    b.Navigation("Tareas");
                });
#pragma warning restore 612, 618
        }
    }
}
