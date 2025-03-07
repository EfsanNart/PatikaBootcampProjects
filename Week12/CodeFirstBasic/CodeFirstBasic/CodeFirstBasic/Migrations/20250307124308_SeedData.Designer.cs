﻿// <auto-generated />
using CodeFirstBasic.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirstBasic.Migrations
{
    [DbContext(typeof(PatikaFirstDbContext))]
    [Migration("20250307124308_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodeFirstBasic.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Platform")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Rating")
                        .HasPrecision(3, 1)
                        .HasColumnType("decimal(3,1)");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "The Witcher 3",
                            Platform = "PC",
                            Rating = 9.5m
                        },
                        new
                        {
                            Id = 2,
                            Name = "God of War",
                            Platform = "PS5",
                            Rating = 9.8m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cyberpunk 2077",
                            Platform = "PC",
                            Rating = 8.0m
                        });
                });

            modelBuilder.Entity("CodeFirstBasic.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Genre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Sci-Fi",
                            ReleaseYear = 2010,
                            Title = "Inception"
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Action",
                            ReleaseYear = 2008,
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            Id = 3,
                            Genre = "Sci-Fi",
                            ReleaseYear = 2014,
                            Title = "Interstellar"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
