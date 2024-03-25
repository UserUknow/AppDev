﻿// <auto-generated />
using BookShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookShop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240325013412_CreateNewColumnInCategory")]
    partial class CreateNewColumnInCategory
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "So funny",
                            DisplayOrder = 0,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 2,
                            Description = "So romantic",
                            DisplayOrder = 0,
                            Name = "Roman"
                        },
                        new
                        {
                            Id = 3,
                            Description = "So scary",
                            DisplayOrder = 0,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 4,
                            Description = "So Boring",
                            DisplayOrder = 0,
                            Name = "Science"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
