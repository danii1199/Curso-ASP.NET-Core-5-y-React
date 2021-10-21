﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("Domain.Channel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Channels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d1dd080b-3beb-41ea-981d-351719680047"),
                            Description = "Canal dedicado a dotnet core",
                            Name = "DotnetCore"
                        },
                        new
                        {
                            Id = new Guid("144c9a71-4bde-4a74-84c1-b9690e7bca98"),
                            Description = "Canal dedicado a reactJs",
                            Name = "Reactjs"
                        },
                        new
                        {
                            Id = new Guid("0e8159ec-3eba-4e60-a3c4-cb94c364ea44"),
                            Description = "Canal dedicado a Angular",
                            Name = "Angular"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
