﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MVCCoreData.Data;
using System;

namespace MVCCoreData.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180318175008_Alter1")]
    partial class Alter1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCCoreData.Models.CourseModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CourseId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("Price");

                    b.Property<bool>("Free");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000);
                    b.Property<DateTime>("StartDate");

                    b.Property<DateTime>("EndDate");

                    b.Property<bool>("IsActive");

                    b.HasKey("Id");

                    b.ToTable("Course");
                });
#pragma warning restore 612, 618
        }
    }
}
