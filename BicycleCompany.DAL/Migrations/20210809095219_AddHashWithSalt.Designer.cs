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
    [Migration("20210809095219_AddHashWithSalt")]
    partial class AddHashWithSalt
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

                    b.HasAlternateKey("Name", "Model");

                    b.ToTable("Bicycles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0ea19dcd-17ff-4284-bf9d-d9ccf7c15fd0"),
                            Model = "Rocco",
                            Name = "Stels"
                        },
                        new
                        {
                            Id = new Guid("0ea19dcd-17ff-4284-bf9d-d9ccf7c15fd1"),
                            Model = "Turbo",
                            Name = "LTD"
                        },
                        new
                        {
                            Id = new Guid("0ea19dcd-17ff-4284-bf9d-d9ccf7c15fd2"),
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
                            Id = new Guid("3b4e22be-c10d-4303-bf57-03eca2f13f20"),
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = new Guid("3b4e22be-c10d-4303-bf57-03eca2f13f21"),
                            Name = "Andrew Vertuha"
                        });
                });

            modelBuilder.Entity("BicycleCompany.DAL.Models.Part", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Name");

                    b.ToTable("Parts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8cc08fcb-1fdb-4353-8540-dde0b1fcce50"),
                            Name = "Seat"
                        },
                        new
                        {
                            Id = new Guid("8cc08fcb-1fdb-4353-8540-dde0b1fcce51"),
                            Name = "Wheel"
                        },
                        new
                        {
                            Id = new Guid("8cc08fcb-1fdb-4353-8540-dde0b1fcce52"),
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
                            Id = new Guid("f451e4eb-c5fc-4ff4-a751-57eee391f9a0"),
                            BicycleId = new Guid("0ea19dcd-17ff-4284-bf9d-d9ccf7c15fd0"),
                            ClientId = new Guid("3b4e22be-c10d-4303-bf57-03eca2f13f20"),
                            Description = "The seat was broken in half",
                            Place = "Outside the city",
                            ReceivingDate = new DateTime(2021, 8, 9, 12, 52, 19, 31, DateTimeKind.Local).AddTicks(4771),
                            Stage = 0
                        });
                });

            modelBuilder.Entity("BicycleCompany.DAL.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(44)
                        .HasColumnType("nvarchar(44)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Login");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("677f9e56-7ccb-4cbf-bb46-1c38a0d48640"),
                            Login = "Admin",
                            Password = "7aekCVlgVr2mHBSiG7j4oYFRcuVvuQpsx/LGoBEn+WY=",
                            Role = "Administrator",
                            Salt = "U+c7ldHlOzDGQwkVtbo4rQ=="
                        },
                        new
                        {
                            Id = new Guid("677f9e56-7ccb-4cbf-bb46-1c38a0d48641"),
                            Login = "User",
                            Password = "Ugu85msDktPCb+4dq2eH9178FcPJPiJ1GoZDuVKvdI8=",
                            Salt = "UZ87zCZbv7Xn1nh7n1riYQ=="
                        },
                        new
                        {
                            Id = new Guid("677f9e56-7ccb-4cbf-bb46-1c38a0d48642"),
                            Login = "Master",
                            Password = "Bf/97pp16vaCipEI2w/LM1P1XcP7WKVmSIT9XmpnbOo=",
                            Role = "Master",
                            Salt = "N1UVkH2kwLrs6aoEADLuGg=="
                        },
                        new
                        {
                            Id = new Guid("677f9e56-7ccb-4cbf-bb46-1c38a0d48643"),
                            Login = "Manager",
                            Password = "wjPHtXpNvhueKzcqH+dgfLG1Lfi/EpuYqARC/p9T25c=",
                            Role = "Manager",
                            Salt = "vm8TTiETaZAroOITxE6yJw=="
                        });
                });

            modelBuilder.Entity("BicycleCompany.DAL.Models.PartDetails", b =>
                {
                    b.HasOne("BicycleCompany.DAL.Models.Part", "Part")
                        .WithMany("PartDetails")
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BicycleCompany.DAL.Models.Problem", "Problem")
                        .WithMany("PartDetails")
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
                    b.Navigation("PartDetails");
                });

            modelBuilder.Entity("BicycleCompany.DAL.Models.Problem", b =>
                {
                    b.Navigation("PartDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
