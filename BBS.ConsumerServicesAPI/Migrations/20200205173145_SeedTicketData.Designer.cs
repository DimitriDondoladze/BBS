﻿// <auto-generated />
using System;
using BBS.ConsumerServicesAPI.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BBS.ConsumerServicesAPI.Migrations
{
    [DbContext(typeof(ConsumerServiceDbContext))]
    [Migration("20200205173145_SeedTicketData")]
    partial class SeedTicketData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BBS.ConsumerServicesAPI.Repositories.BaseModels.Bus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeatsCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Buses","bs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Model = "Vacanza 13",
                            SeatsCount = 52
                        });
                });

            modelBuilder.Entity("BBS.ConsumerServicesAPI.Repositories.BaseModels.Destination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Tbilisi bus station",
                            IsDeleted = false,
                            Name = "Tbilisi"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Batumi bus station",
                            IsDeleted = false,
                            Name = "Batumi"
                        });
                });

            modelBuilder.Entity("BBS.ConsumerServicesAPI.Repositories.BaseModels.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PassangerName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TripId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            PassangerName = "Levan Jintcharadze",
                            PurchaseDate = new DateTime(2020, 2, 5, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            SeatNumber = 20,
                            TripId = 7
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            PassangerName = "Dimitri Dondoladze",
                            PurchaseDate = new DateTime(2020, 2, 7, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            SeatNumber = 14,
                            TripId = 3
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            PassangerName = "Zura Kavtaradze",
                            PurchaseDate = new DateTime(2020, 2, 8, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            SeatNumber = 33,
                            TripId = 5
                        });
                });

            modelBuilder.Entity("BBS.ConsumerServicesAPI.Repositories.BaseModels.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Departure")
                        .HasColumnType("datetime2");

                    b.Property<int>("DestinationFromId")
                        .HasColumnType("int");

                    b.Property<int>("DestinationToId")
                        .HasColumnType("int");

                    b.Property<int>("FreeSeatCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<TimeSpan>("TravelTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("BusId");

                    b.HasIndex("DestinationFromId");

                    b.HasIndex("DestinationToId");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusId = 1,
                            Departure = new DateTime(2020, 2, 1, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            DestinationFromId = 1,
                            DestinationToId = 2,
                            FreeSeatCount = 52,
                            IsDeleted = false,
                            TicketPrice = 10m,
                            TravelTime = new TimeSpan(0, 7, 0, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            BusId = 1,
                            Departure = new DateTime(2020, 2, 2, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            DestinationFromId = 1,
                            DestinationToId = 2,
                            FreeSeatCount = 52,
                            IsDeleted = false,
                            TicketPrice = 10m,
                            TravelTime = new TimeSpan(0, 7, 0, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            BusId = 1,
                            Departure = new DateTime(2020, 2, 3, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            DestinationFromId = 1,
                            DestinationToId = 2,
                            FreeSeatCount = 52,
                            IsDeleted = false,
                            TicketPrice = 10m,
                            TravelTime = new TimeSpan(0, 7, 0, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            BusId = 1,
                            Departure = new DateTime(2020, 2, 4, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            DestinationFromId = 1,
                            DestinationToId = 2,
                            FreeSeatCount = 52,
                            IsDeleted = false,
                            TicketPrice = 10m,
                            TravelTime = new TimeSpan(0, 7, 0, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            BusId = 1,
                            Departure = new DateTime(2020, 2, 5, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            DestinationFromId = 1,
                            DestinationToId = 2,
                            FreeSeatCount = 52,
                            IsDeleted = false,
                            TicketPrice = 10m,
                            TravelTime = new TimeSpan(0, 7, 0, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            BusId = 1,
                            Departure = new DateTime(2020, 2, 4, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            DestinationFromId = 2,
                            DestinationToId = 1,
                            FreeSeatCount = 52,
                            IsDeleted = false,
                            TicketPrice = 10m,
                            TravelTime = new TimeSpan(0, 7, 20, 0, 0)
                        },
                        new
                        {
                            Id = 7,
                            BusId = 1,
                            Departure = new DateTime(2020, 2, 5, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            DestinationFromId = 2,
                            DestinationToId = 1,
                            FreeSeatCount = 52,
                            IsDeleted = false,
                            TicketPrice = 10m,
                            TravelTime = new TimeSpan(0, 7, 20, 0, 0)
                        });
                });

            modelBuilder.Entity("BBS.ConsumerServicesAPI.Repositories.BaseModels.Ticket", b =>
                {
                    b.HasOne("BBS.ConsumerServicesAPI.Repositories.BaseModels.Trip", "Trip")
                        .WithMany("Tickets")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("BBS.ConsumerServicesAPI.Repositories.BaseModels.Trip", b =>
                {
                    b.HasOne("BBS.ConsumerServicesAPI.Repositories.BaseModels.Bus", "Bus")
                        .WithMany("Trips")
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("BBS.ConsumerServicesAPI.Repositories.BaseModels.Destination", "DestinationFrom")
                        .WithMany("TripsFromHere")
                        .HasForeignKey("DestinationFromId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("BBS.ConsumerServicesAPI.Repositories.BaseModels.Destination", "DestinationTo")
                        .WithMany("TripsToHere")
                        .HasForeignKey("DestinationToId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
