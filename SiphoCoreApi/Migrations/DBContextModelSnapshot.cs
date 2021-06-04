﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiphoCoreApi.Contex;

namespace SiphoCoreApi.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SiphoCoreApi.Model.ImagesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StockItemModelid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StockItemModelid");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("SiphoCoreApi.Model.StockAccessoryModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StockItemModelid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("StockItemModelid");

                    b.ToTable("StockAccessory");
                });

            modelBuilder.Entity("SiphoCoreApi.Model.StockItemModel", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Colour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CostPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime>("DTCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DTUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("KMS")
                        .HasColumnType("int");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModelYear")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("RetailPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("VIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleRegistration")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("StockItem");
                });

            modelBuilder.Entity("SiphoCoreApi.Model.ImagesModel", b =>
                {
                    b.HasOne("SiphoCoreApi.Model.StockItemModel", "StockItemModel")
                        .WithMany("Images")
                        .HasForeignKey("StockItemModelid");

                    b.Navigation("StockItemModel");
                });

            modelBuilder.Entity("SiphoCoreApi.Model.StockAccessoryModel", b =>
                {
                    b.HasOne("SiphoCoreApi.Model.StockItemModel", "StockItemModel")
                        .WithMany("Assesorry")
                        .HasForeignKey("StockItemModelid");

                    b.Navigation("StockItemModel");
                });

            modelBuilder.Entity("SiphoCoreApi.Model.StockItemModel", b =>
                {
                    b.Navigation("Assesorry");

                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
