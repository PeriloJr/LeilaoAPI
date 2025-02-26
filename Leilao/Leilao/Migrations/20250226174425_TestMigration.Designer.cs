﻿// <auto-generated />
using System;
using Leilao.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Leilao.Migrations
{
    [DbContext(typeof(AuctionDbContext))]
    [Migration("20250226174425_TestMigration")]
    partial class TestMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Leilao.Models.Auction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Auctions");
                });

            modelBuilder.Entity("Leilao.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AuctionId")
                        .HasColumnType("int");

                    b.Property<int>("AunctionId")
                        .HasColumnType("int");

                    b.Property<decimal>("MinimumIncrement")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinumumValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuctionId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("Leilao.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuctionId")
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MinimumIncrement")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinimumValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuctionId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Leilao.Models.Property", b =>
                {
                    b.HasOne("Leilao.Models.Auction", "Auction")
                        .WithMany("Properties")
                        .HasForeignKey("AuctionId");

                    b.Navigation("Auction");
                });

            modelBuilder.Entity("Leilao.Models.Vehicle", b =>
                {
                    b.HasOne("Leilao.Models.Auction", "Auction")
                        .WithMany("Vehicles")
                        .HasForeignKey("AuctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auction");
                });

            modelBuilder.Entity("Leilao.Models.Auction", b =>
                {
                    b.Navigation("Properties");

                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
