﻿// <auto-generated />
using ASyncInn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASyncInn.Migrations
{
    [DbContext(typeof(AsyncInnDbContext))]
    [Migration("20200913005319_RoomsRepo")]
    partial class RoomsRepo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASyncInn.Models.Hotel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            City = "Iowa City",
                            Name = "Async Inn",
                            Phone = "319 - 541 - 7504",
                            State = "Iowa",
                            StreetAddress = "515 W. Burlington St"
                        },
                        new
                        {
                            Id = 2L,
                            City = "Moline",
                            Name = "Async Hotel",
                            Phone = "630 - 772 - 1411",
                            State = "Illinois",
                            StreetAddress = "1216 Aurora Ln"
                        },
                        new
                        {
                            Id = 3L,
                            City = "St. Paul",
                            Name = "Async Spa",
                            Phone = "612 - 424 - 2468",
                            State = "Minnesota",
                            StreetAddress = "1984 Wasatch Pl"
                        });
                });

            modelBuilder.Entity("ASyncInn.Models.Room", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Amenities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Layout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Layout = "0br.",
                            Name = "Studio"
                        },
                        new
                        {
                            Id = 2L,
                            Layout = "1br.",
                            Name = "OneBdr"
                        },
                        new
                        {
                            Id = 3L,
                            Layout = "2br.",
                            Name = "TwoBdr"
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.Amenity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "AC"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Wireless"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Coffee Maker"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}