﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SosWebApp.Data;

namespace SosWebApp.Migrations
{
    [DbContext(typeof(ContextoBD))]
    [Migration("20220124103004_DeleteUniqueRelationshipBetweenTriageCodeAndService")]
    partial class DeleteUniqueRelationshipBetweenTriageCodeAndService
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SosWebApp.Models.Ambulance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AmbulanceCategory")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Patente")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Ambulances");
                });

            modelBuilder.Entity("SosWebApp.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DNI")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MAT")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("SosWebApp.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DNI")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("SosWebApp.Models.Guard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AmbulanceId")
                        .HasColumnType("int");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int?>("DriverId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Finish")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AmbulanceId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("DriverId");

                    b.ToTable("Guards");
                });

            modelBuilder.Entity("SosWebApp.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorCodigo")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double?>("Coseguro")
                        .HasColumnType("float");

                    b.Property<string>("Dx")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GuardId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<string>("NroIncidente")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Obs")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Paciente")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("TriageCodeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GuardId");

                    b.HasIndex("TriageCodeId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("SosWebApp.Models.TriageCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LegalName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<double>("TarifaRegular")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("TriageCodes");
                });

            modelBuilder.Entity("SosWebApp.Models.Guard", b =>
                {
                    b.HasOne("SosWebApp.Models.Ambulance", "Ambulance")
                        .WithMany()
                        .HasForeignKey("AmbulanceId");

                    b.HasOne("SosWebApp.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId");

                    b.HasOne("SosWebApp.Models.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId");

                    b.Navigation("Ambulance");

                    b.Navigation("Doctor");

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("SosWebApp.Models.Service", b =>
                {
                    b.HasOne("SosWebApp.Models.Guard", null)
                        .WithMany("Services")
                        .HasForeignKey("GuardId");

                    b.HasOne("SosWebApp.Models.TriageCode", "TriageCode")
                        .WithMany()
                        .HasForeignKey("TriageCodeId");

                    b.Navigation("TriageCode");
                });

            modelBuilder.Entity("SosWebApp.Models.Guard", b =>
                {
                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
