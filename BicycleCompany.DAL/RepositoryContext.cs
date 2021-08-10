﻿using BicycleCompany.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BicycleCompany.DAL
{
    public class RepositoryContext : DbContext
    { 
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Bicycle> Bicycles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Problem> Problems { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Part>()
                .HasMany(p => p.Problems)
                .WithMany(pr => pr.Parts)
                .UsingEntity<PartDetails>(
                    j => j
                    .HasOne(k => k.Problem)
                    .WithMany(t => t.PartDetails)
                    .HasForeignKey(k => k.ProblemId),
                    j => j
                    .HasOne(k => k.Part)
                    .WithMany(s => s.PartDetails)
                    .HasForeignKey(k => k.PartId)
                );

            modelBuilder.Entity<Bicycle>().HasAlternateKey(b => new { b.Name, b.Model });
            modelBuilder.Entity<Part>().HasAlternateKey(p => p.Name);
            modelBuilder.Entity<User>().HasAlternateKey(u => u.Login);


            Guid bicycleId = new Guid("0EA19DCD-17FF-4284-BF9D-D9CCF7C15FD0");
            Guid clientId = new Guid("3B4E22BE-C10D-4303-BF57-03ECA2F13F20");
            Guid adminId = new Guid("677F9E56-7CCB-4CBF-BB46-1C38A0D48640");

            modelBuilder.Entity<Bicycle>()
                .HasData(
                new Bicycle
                {
                    Id = bicycleId,
                    Name = "Stels",
                    Model = "Rocco"
                },
                new Bicycle
                {
                    Id = new Guid("0EA19DCD-17FF-4284-BF9D-D9CCF7C15FD1"),
                    Name = "LTD",
                    Model = "Turbo"
                },
                new Bicycle
                {
                    Id = new Guid("0EA19DCD-17FF-4284-BF9D-D9CCF7C15FD2"),
                    Name = "Aist",
                    Model = "Tango"
                }
            );
            
            modelBuilder.Entity<Client>()
                .HasData(
                new Client
                {
                    Id = clientId,
                    Name = "John Doe"
                },
                new Client
                {
                    Id = new Guid("3B4E22BE-C10D-4303-BF57-03ECA2F13F21"),
                    Name = "Andrew Vertuha"
                }
            );

            modelBuilder.Entity<Problem>()
                .HasData(
                new Problem
                {
                    Id = new Guid("F451E4EB-C5FC-4FF4-A751-57EEE391F9A0"),
                    ClientId = clientId,
                    BicycleId = bicycleId,
                    Place = "Outside the city",
                    Stage = Stage.Received,
                    ReceivingDate = DateTime.Now,
                    Description = "The seat was broken in half"
                }
            );

            modelBuilder.Entity<Part>()
                .HasData(
                new Part
                {
                    Id = new Guid("8CC08FCB-1FDB-4353-8540-DDE0B1FCCE50"),
                    Name = "Seat"
                },
                new Part
                {
                    Id = new Guid("8CC08FCB-1FDB-4353-8540-DDE0B1FCCE51"),
                    Name = "Wheel"
                },
                new Part
                {
                    Id = new Guid("8CC08FCB-1FDB-4353-8540-DDE0B1FCCE52"),
                    Name = "Handlebar"
                }
            );

            modelBuilder.Entity<User>()
                .HasData(
                new User
                {
                    Id = adminId,
                    Login = "Admin",
                    Password = "7aekCVlgVr2mHBSiG7j4oYFRcuVvuQpsx/LGoBEn+WY=", // Admin
                    Salt = "U+c7ldHlOzDGQwkVtbo4rQ==",
                    Role = "Administrator"
                },
                new User
                {
                    Id = new Guid("677F9E56-7CCB-4CBF-BB46-1C38A0D48641"),
                    Login = "User",
                    Password = "Ugu85msDktPCb+4dq2eH9178FcPJPiJ1GoZDuVKvdI8=", // User
                    Salt = "UZ87zCZbv7Xn1nh7n1riYQ==",
                    Role = null
                },
                new User
                {
                    Id = new Guid("677F9E56-7CCB-4CBF-BB46-1C38A0D48642"),
                    Login = "Master",
                    Password = "Bf/97pp16vaCipEI2w/LM1P1XcP7WKVmSIT9XmpnbOo=", // Master
                    Salt = "N1UVkH2kwLrs6aoEADLuGg==",
                    Role = "Master"
                },
                new User
                {
                    Id = new Guid("677F9E56-7CCB-4CBF-BB46-1C38A0D48643"),
                    Login = "Manager",
                    Password = "wjPHtXpNvhueKzcqH+dgfLG1Lfi/EpuYqARC/p9T25c=", // Manager
                    Salt = "vm8TTiETaZAroOITxE6yJw==",
                    Role = "Manager"
                }
            );
        }
    }
}
