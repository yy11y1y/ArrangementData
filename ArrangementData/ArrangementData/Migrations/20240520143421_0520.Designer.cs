﻿// <auto-generated />
using System;
using ArrangementData.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ArrangementData.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240520143421_0520")]
    partial class _0520
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SharedLibrary.Models.Arrange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bed_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Date")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsReserved")
                        .HasColumnType("bit");

                    b.Property<string>("Nursing_station")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Operating_time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Operator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patient_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Slot")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Arranges");
                });

            modelBuilder.Entity("SharedLibrary.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BedId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Day")
                        .HasColumnType("datetime2");

                    b.Property<string>("NursingStation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperatOr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OperatingTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PatientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlOt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}