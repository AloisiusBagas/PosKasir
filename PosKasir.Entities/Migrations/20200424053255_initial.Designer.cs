﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PosKasir.Entities;

namespace PosKasir.Entities.Migrations
{
    [DbContext(typeof(AppPosDBContext))]
    [Migration("20200424053255_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("PosKasir.Entities.Semen", b =>
                {
                    b.Property<int>("SemenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue("Date('Now')");

                    b.Property<string>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue("SYSTEM");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("SemenName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("SemenID");

                    b.ToTable("semen");
                });
#pragma warning restore 612, 618
        }
    }
}
