﻿// <auto-generated />
using System;
using BicycleCompany.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BicycleCompany.DAL.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20210727090010_RenamePartProblemToPartDetails")]
    partial class RenamePartProblemToPartDetails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BicycleCompany.DAL.Models.Bicycle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Bicycles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0ea19dcd-17ff-4284-bf9d-d9ccf7c15fd6"),
                            Model = "Rocco",
                            Name = "Stels"
                        },
                        new
                        {
                            Id = new Guid("09cf3df1-841e-4bc6-a776-2e1c39521537"),
                            Model = "Turbo",
                            Name = "LTD"
                        },
                        new
                        {
                            Id = new Guid("3f5854b5-3dd7-4e4a-8c56-002b343015f4"),
                            Model = "Tango",
                            Name = "Aist"
                        });
                });

            modelBuilder.Entity("BicycleCompany.DAL.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3b4e22be-c10d-4303-bf57-03eca2f13f2b"),
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = new Guid("1a4c61ff-d374-484e-9e48-3397155b210f"),
                            Name = "Andrew Vertuha"
                        });
                });

            modelBuilder.Entity("BicycleCompany.DAL.Models.Part", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Parts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8cc08fcb-1fdb-4353-8540-dde0b1fcce5b"),
                            Amount = 5,
                            Name = "Seat"
                        },
                        new
                        {
                            Id = new Guid("1db9b37c-89c6-4338-80f9-936d1b568e79"),
                            Amount = 7,
                            Name = "Wheel"
                        },
                        new
                        {
                            Id = new Guid("00cbaa19-0db5-4db7-ab0b-8808e5675609"),
                            Amount = 3,
                            Name = "Handlebar"
                        });
                });

            modelBuilder.Entity("BicycleCompany.DAL.Models.PartDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<Guid>("PartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProblemId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PartId");

                    b.HasIndex("ProblemId");

                    b.ToTable("PartDetails");
                });

            modelBuilder.Entity("BicycleCompany.DAL.Models.Problem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BicycleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("ReceivingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Stage")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BicycleId");

                    b.HasIndex("ClientId");

                    b.ToTable("Problems");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f451e4eb-c5fc-4ff4-a751-57eee391f9a7"),
                            BicycleId = new Guid("0ea19dcd-17ff-4284-bf9d-d9ccf7c15fd6"),
                            ClientId = new Guid("3b4e22be-c10d-4303-bf57-03eca2f13f2b"),
                            Description = "The seat was broken in half",
                            Place = "Outside the city",
                            ReceivingDate = new DateTime(2021, 7, 27, 12, 0, 10, 152, DateTimeKind.Local).AddTicks(8241),
                            Stage = 0
                        });
                });

            modelBuilder.Entity("BicycleCompany.DAL.Models.PartDetails", b =>
                {
                    b.HasOne("BicycleCompany.DAL.Models.Part", "Part")
                        .WithMany("PartProblems")
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BicycleCompany.DAL.Models.Problem", "Problem")
                        .WithMany("PartProblems")
                        .HasForeignKey("ProblemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Part");

                    b.Navigation("Problem");
                });

            modelBuilder.Entity("BicycleCompany.DAL.Models.Problem", b =>
                {
                    b.HasOne("BicycleCompany.DAL.Models.Bicycle", "Bicycle")
                        .WithMany("Problems")
                        .HasForeignKey("BicycleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BicycleCompany.DAL.Models.Client", "Client")
                        .WithMany("Problems")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bicycle");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("BicycleCompany.DAL.Models.Bicycle", b =>
                {
                    b.Navigation("Problems");
                });

            modelBuilder.Entity("BicycleCompany.DAL.Models.Client", b =>
                {
                    b.Navigation("Problems");
                });

            modelBuilder.Entity("BicycleCompany.DAL.Models.Part", b =>
                {
                    b.Navigation("PartProblems");
                });

            modelBuilder.Entity("BicycleCompany.DAL.Models.Problem", b =>
                {
                    b.Navigation("PartProblems");
                });
#pragma warning restore 612, 618
        }
    }
}
