﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoyalstarAdminPanel.Data;

namespace RoyalstarAdminPanel.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210825073341_MachineMainMachineAdded")]
    partial class MachineMainMachineAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("RoyalstarAdminPanel.Models.Machine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("ActivePower")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ApparentPower")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DeviceBarcodeNo")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DeviceOnOff")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("RoyalstarAdminPanel.Models.MainMachine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("DeviceBarcodeNo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MainsActivePower")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MainsApparentPower")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MainsBreakerOff")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MainsBreakerOn")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MainsCurrent")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MainsDeviceOnOff")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MainsFrequence")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MainsModeManuel")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MainsModeSemi")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MainsReactivePower")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MainsStatusOff")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MainsStatusOn")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MainsVolt")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("WriteCommand")
                        .HasColumnType("INTEGER");

                    b.Property<int>("deviceAdded")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("MainMachines");
                });

            modelBuilder.Entity("RoyalstarAdminPanel.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
