﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ismission4RyanPinkney.Models;

namespace ismission4RyanPinkney.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20220129023631_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("ismission4RyanPinkney.Models.Movie", b =>
                {
                    b.Property<int>("movie_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("bIsEdited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("sCategory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("sDirector")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("sLentToName")
                        .HasColumnType("TEXT");

                    b.Property<string>("sNotes")
                        .HasColumnType("TEXT");

                    b.Property<string>("sRating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("sTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("sYear")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("movie_id");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            movie_id = 1,
                            bIsEdited = false,
                            sCategory = "Action/Adventure",
                            sDirector = "Joss Whedon",
                            sLentToName = "",
                            sNotes = "",
                            sRating = "PG-13",
                            sTitle = "Avenger, The",
                            sYear = "2012"
                        },
                        new
                        {
                            movie_id = 2,
                            bIsEdited = false,
                            sCategory = "Action/Adventure",
                            sDirector = "Tim Burton",
                            sLentToName = "",
                            sNotes = "",
                            sRating = "PG-13",
                            sTitle = "Batman",
                            sYear = "1989"
                        },
                        new
                        {
                            movie_id = 3,
                            bIsEdited = false,
                            sCategory = "Action/Adventure",
                            sDirector = "Joel Schumacher",
                            sLentToName = "",
                            sNotes = "",
                            sRating = "PG-13",
                            sTitle = "Batman & Robin",
                            sYear = "1997"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}