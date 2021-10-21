﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apiApp.Context;

namespace apiApp.Migrations
{
    [DbContext(typeof(MovieInfoContext))]
    partial class MovieInfoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("apiApp.Entities.Cast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Character")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("MovieId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Casts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Character = "Personaje Cast 1",
                            MovieId = 1,
                            Name = "Cast 1"
                        },
                        new
                        {
                            Id = 2,
                            Character = "Personaje Cast 2",
                            MovieId = 1,
                            Name = "Cast 2"
                        },
                        new
                        {
                            Id = 3,
                            Character = "Personaje Cast 3",
                            MovieId = 1,
                            Name = "Cast 3"
                        },
                        new
                        {
                            Id = 4,
                            Character = "Personaje Cast 4",
                            MovieId = 2,
                            Name = "Cast 4"
                        },
                        new
                        {
                            Id = 5,
                            Character = "Personaje Cast 5",
                            MovieId = 2,
                            Name = "Cast 5"
                        },
                        new
                        {
                            Id = 6,
                            Character = "Personaje Cast 6",
                            MovieId = 2,
                            Name = "Cast 6"
                        },
                        new
                        {
                            Id = 7,
                            Character = "Personaje Cast 7",
                            MovieId = 3,
                            Name = "Cast 7"
                        },
                        new
                        {
                            Id = 8,
                            Character = "Personaje Cast 8",
                            MovieId = 3,
                            Name = "Cast 8"
                        },
                        new
                        {
                            Id = 9,
                            Character = "Personaje Cast 9",
                            MovieId = 3,
                            Name = "Cast 9"
                        });
                });

            modelBuilder.Entity("apiApp.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(400);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Descripción de la película 1",
                            Name = "Película 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Descripción de la película 2",
                            Name = "Película 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Descripción de la película 3",
                            Name = "Película 3"
                        });
                });

            modelBuilder.Entity("apiApp.Entities.Cast", b =>
                {
                    b.HasOne("apiApp.Entities.Movie", "movie")
                        .WithMany("Casts")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
