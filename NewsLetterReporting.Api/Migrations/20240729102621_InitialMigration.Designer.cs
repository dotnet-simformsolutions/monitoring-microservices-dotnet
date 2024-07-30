﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsLetterReporting.Api.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NewsLetterReporting.Api.Migrations
{
    [DbContext(typeof(NewsLetterReportingDbContext))]
    [Migration("20240729102621_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("NewsLetterReporting.Api.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("PublishedOnUtc")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("NewsLetterReporting.Api.Entities.ArticleEvent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ArticleId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EventType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ArticleEvents");
                });
#pragma warning restore 612, 618
        }
    }
}