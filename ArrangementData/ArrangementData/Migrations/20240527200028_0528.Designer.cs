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
    [Migration("20240527200028_0528")]
    partial class _0528
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BedId = "A",
                            Day = new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5196),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 2,
                            BedId = "A",
                            Day = new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5211),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 3,
                            BedId = "A",
                            Day = new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5217),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 4,
                            BedId = "A",
                            Day = new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5218),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 5,
                            BedId = "A",
                            Day = new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5220),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 6,
                            BedId = "A",
                            Day = new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5221),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 7,
                            BedId = "A",
                            Day = new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5222),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 8,
                            BedId = "A",
                            Day = new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5223),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 9,
                            BedId = "A",
                            Day = new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5224),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 10,
                            BedId = "A",
                            Day = new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5226),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 11,
                            BedId = "A",
                            Day = new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5227),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 12,
                            BedId = "A",
                            Day = new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5228),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 13,
                            BedId = "A",
                            Day = new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5229),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 14,
                            BedId = "A",
                            Day = new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5229),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 15,
                            BedId = "A",
                            Day = new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5230),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 16,
                            BedId = "A",
                            Day = new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5231),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 17,
                            BedId = "A",
                            Day = new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5232),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 18,
                            BedId = "A",
                            Day = new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5234),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 19,
                            BedId = "A",
                            Day = new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5235),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 20,
                            BedId = "A",
                            Day = new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5236),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 21,
                            BedId = "B",
                            Day = new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5238),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 22,
                            BedId = "B",
                            Day = new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5239),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 23,
                            BedId = "B",
                            Day = new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5240),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 24,
                            BedId = "B",
                            Day = new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5241),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 25,
                            BedId = "B",
                            Day = new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5242),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 26,
                            BedId = "B",
                            Day = new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5243),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 27,
                            BedId = "B",
                            Day = new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5244),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 28,
                            BedId = "B",
                            Day = new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5244),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 29,
                            BedId = "B",
                            Day = new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5245),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 30,
                            BedId = "B",
                            Day = new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5246),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 31,
                            BedId = "B",
                            Day = new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5247),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 32,
                            BedId = "B",
                            Day = new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5248),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 33,
                            BedId = "B",
                            Day = new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5249),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 34,
                            BedId = "B",
                            Day = new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5250),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 35,
                            BedId = "B",
                            Day = new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5251),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 36,
                            BedId = "B",
                            Day = new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5252),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 37,
                            BedId = "B",
                            Day = new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5253),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 38,
                            BedId = "B",
                            Day = new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5254),
                            PatientId = "",
                            SlOt = "afterning"
                        },
                        new
                        {
                            Id = 39,
                            BedId = "B",
                            Day = new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5255),
                            PatientId = "",
                            SlOt = "morning"
                        },
                        new
                        {
                            Id = 40,
                            BedId = "B",
                            Day = new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NursingStation = "",
                            OperatOr = "",
                            OperatingTime = new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5256),
                            PatientId = "",
                            SlOt = "afterning"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
