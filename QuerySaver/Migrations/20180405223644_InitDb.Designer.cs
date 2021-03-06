﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using QuerySaver.Data;
using System;

namespace QuerySaver.Migrations
{
    [DbContext(typeof(QuerySaverContext))]
    [Migration("20180405223644_InitDb")]
    partial class InitDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuerySaver.Data.Entities.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("FileSize");

                    b.Property<int>("FileType");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<int?>("QueryId");

                    b.HasKey("Id");

                    b.HasIndex("QueryId")
                        .IsUnique()
                        .HasFilter("[QueryId] IS NOT NULL");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("QuerySaver.Data.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("QuerySaver.Data.Entities.ProjectPart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int?>("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectParts");
                });

            modelBuilder.Entity("QuerySaver.Data.Entities.Query", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProjectPartId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectPartId");

                    b.ToTable("Queries");
                });

            modelBuilder.Entity("QuerySaver.Data.Entities.QueryTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("QueryId");

                    b.Property<int?>("TagId");

                    b.HasKey("Id");

                    b.HasIndex("QueryId");

                    b.HasIndex("TagId");

                    b.ToTable("QueryTag");
                });

            modelBuilder.Entity("QuerySaver.Data.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("QuerySaver.Data.Entities.File", b =>
                {
                    b.HasOne("QuerySaver.Data.Entities.Query", "Query")
                        .WithOne("File")
                        .HasForeignKey("QuerySaver.Data.Entities.File", "QueryId");
                });

            modelBuilder.Entity("QuerySaver.Data.Entities.ProjectPart", b =>
                {
                    b.HasOne("QuerySaver.Data.Entities.Project", "Project")
                        .WithMany("ProjectParts")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("QuerySaver.Data.Entities.Query", b =>
                {
                    b.HasOne("QuerySaver.Data.Entities.ProjectPart", "ProjectPart")
                        .WithMany("Queries")
                        .HasForeignKey("ProjectPartId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuerySaver.Data.Entities.QueryTag", b =>
                {
                    b.HasOne("QuerySaver.Data.Entities.Query", "Query")
                        .WithMany("QueryTags")
                        .HasForeignKey("QueryId");

                    b.HasOne("QuerySaver.Data.Entities.Tag", "Tag")
                        .WithMany("QueryTags")
                        .HasForeignKey("TagId");
                });
#pragma warning restore 612, 618
        }
    }
}
