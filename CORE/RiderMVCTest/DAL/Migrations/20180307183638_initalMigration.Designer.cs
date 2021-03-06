﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RiderMVCTest.DAL.Context;
using System;

namespace RiderMVCTest.Migrations
{
    [DbContext(typeof(EntityContext))]
    [Migration("20180307183638_initalMigration")]
    partial class initalMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RiderMVCTest.DAL.Models.TestTable", b =>
                {
                    b.Property<int>("Unid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Unid");

                    b.ToTable("TestTable");
                });
#pragma warning restore 612, 618
        }
    }
}
