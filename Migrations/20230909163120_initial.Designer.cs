﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RaptorsCoreRazor.Data;

#nullable disable

namespace RaptorsCoreRazor.Migrations
{
    [DbContext(typeof(RaptorsCoreRazorContext))]
    [Migration("20230909163120_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RaptorsCoreRazor.Models.Raptor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerHeight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerNumber")
                        .HasColumnType("int");

                    b.Property<string>("PlayerPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PlayerSalary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Raptor");
                });
#pragma warning restore 612, 618
        }
    }
}