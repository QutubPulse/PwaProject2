﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PwaProject2.Server.Data;

namespace PwaProject2.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220112071502_added pwauser & Session details")]
    partial class addedpwauserSessiondetails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("PwaProject2.Shared.Product", b =>
                {
                    b.Property<int?>("inId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal?>("dcPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("flgOutOfStock")
                        .HasColumnType("bit");

                    b.Property<int?>("inQuantity")
                        .HasColumnType("int");

                    b.Property<string>("stDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("stDiscount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("stName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("inId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("PwaProject2.Shared.PwaUsers", b =>
                {
                    b.Property<int?>("inUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("stFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("stLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("unUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("inUserId");

                    b.ToTable("PwaUsers");
                });

            modelBuilder.Entity("PwaProject2.Shared.UserSessionDetail", b =>
                {
                    b.Property<int?>("inId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("flgIsActive")
                        .HasColumnType("bit");

                    b.Property<int>("inUserId")
                        .HasColumnType("int");

                    b.Property<string>("stBrowserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("stIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("stSessionId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("inId");

                    b.ToTable("UserSessionDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
