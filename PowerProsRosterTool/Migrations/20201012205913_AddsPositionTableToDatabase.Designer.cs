﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PowerProsRosterTool;

namespace PowerProsRosterTool.Migrations
{
    [DbContext(typeof(PowerProsDbContext))]
    [Migration("20201012205913_AddsPositionTableToDatabase")]
    partial class AddsPositionTableToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PowerProsRosterTool.Players.GlobalPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int>("PlayerType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GlobalPlayer");
                });

            modelBuilder.Entity("PowerProsRosterTool.Players.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GlobalPlayerId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GlobalPlayerId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("PowerProsRosterTool.Players.Player", b =>
                {
                    b.HasOne("PowerProsRosterTool.Players.GlobalPlayer", "GlobalPlayer")
                        .WithMany()
                        .HasForeignKey("GlobalPlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
