﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoyalstarAdminPanel.Data;

namespace RoyalstarAdminPanel.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210920123721_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RoyalstarAdminPanel.Models.Machine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ActivePower")
                        .HasColumnType("int");

                    b.Property<int>("ApparentPower")
                        .HasColumnType("int");

                    b.Property<int>("DeviceBarcodeNo")
                        .HasColumnType("int");

                    b.Property<bool>("DeviceOnOff")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("RoyalstarAdminPanel.Models.MainMachine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DeviceBarcodeNo")
                        .HasColumnType("int");

                    b.Property<int>("MainsActivePower")
                        .HasColumnType("int");

                    b.Property<int>("MainsApparentPower")
                        .HasColumnType("int");

                    b.Property<bool>("MainsBreakerOff")
                        .HasColumnType("bit");

                    b.Property<bool>("MainsBreakerOn")
                        .HasColumnType("bit");

                    b.Property<int>("MainsCurrent")
                        .HasColumnType("int");

                    b.Property<bool>("MainsDeviceOnOff")
                        .HasColumnType("bit");

                    b.Property<int>("MainsFrequence")
                        .HasColumnType("int");

                    b.Property<bool>("MainsModeManuel")
                        .HasColumnType("bit");

                    b.Property<bool>("MainsModeSemi")
                        .HasColumnType("bit");

                    b.Property<int>("MainsReactivePower")
                        .HasColumnType("int");

                    b.Property<bool>("MainsStatusOff")
                        .HasColumnType("bit");

                    b.Property<bool>("MainsStatusOn")
                        .HasColumnType("bit");

                    b.Property<int>("MainsVolt")
                        .HasColumnType("int");

                    b.Property<bool>("WriteCommand")
                        .HasColumnType("bit");

                    b.Property<int>("deviceAdded")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MainMachines");
                });

            modelBuilder.Entity("RoyalstarAdminPanel.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}