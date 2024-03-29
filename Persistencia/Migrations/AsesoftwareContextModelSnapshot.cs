﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

namespace Persistencia.Migrations
{
    [DbContext(typeof(AsesoftwareContext))]
    partial class AsesoftwareContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dominio.Comercios", b =>
                {
                    b.Property<int>("id_comercio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("non_comercio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("num_aforo")
                        .HasColumnType("int");

                    b.HasKey("id_comercio");

                    b.ToTable("Comercio");
                });

            modelBuilder.Entity("Dominio.Estado", b =>
                {
                    b.Property<int>("id_estado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre_estado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_estado");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("Dominio.Servicios", b =>
                {
                    b.Property<int>("id_servicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("hora_apertura")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("hora_cierre")
                        .HasColumnType("time");

                    b.Property<int>("id_comercio")
                        .HasColumnType("int");

                    b.Property<string>("nom_servicio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_servicio");

                    b.HasIndex("id_comercio");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("Dominio.Turnos", b =>
                {
                    b.Property<int>("id_turno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("fecha_turno")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("hora_fin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("hora_inicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_estado")
                        .HasColumnType("int");

                    b.Property<int>("id_servicio")
                        .HasColumnType("int");

                    b.HasKey("id_turno");

                    b.HasIndex("id_estado");

                    b.HasIndex("id_servicio");

                    b.ToTable("Turno");
                });

            modelBuilder.Entity("Dominio.Servicios", b =>
                {
                    b.HasOne("Dominio.Comercios", "Comercio")
                        .WithMany("Servicio")
                        .HasForeignKey("id_comercio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.Turnos", b =>
                {
                    b.HasOne("Dominio.Estado", "Estado")
                        .WithMany("Turno")
                        .HasForeignKey("id_estado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Servicios", "Servicio")
                        .WithMany("turno")
                        .HasForeignKey("id_servicio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
