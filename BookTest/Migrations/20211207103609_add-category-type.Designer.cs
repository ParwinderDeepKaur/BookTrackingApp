﻿// <auto-generated />
using BookTest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookTest.Migrations
{
    [DbContext(typeof(BookTestDBContext))]
    [Migration("20211207103609_add-category-type")]
    partial class addcategorytype
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("BookTest.Models.CategoryType", b =>
                {
                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Type");

                    b.ToTable("CategType");
                });
#pragma warning restore 612, 618
        }
    }
}