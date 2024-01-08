﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using movie_web.Data;

namespace movie_web.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20240108040539_Second_Mig")]
    partial class Second_Mig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("movie_web.Models.Actor", b =>
                {
                    b.Property<int>("ActorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictueUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActorID");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("movie_web.Models.Actor_Movie", b =>
                {
                    b.Property<int>("ActorID")
                        .HasColumnType("int");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.HasKey("ActorID", "MovieID");

                    b.HasIndex("MovieID");

                    b.ToTable("Actor_Movie");
                });

            modelBuilder.Entity("movie_web.Models.Cinema", b =>
                {
                    b.Property<int>("CinemaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CinemaID");

                    b.ToTable("Cinema");
                });

            modelBuilder.Entity("movie_web.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CinemaID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieCatagory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProduserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("MovieID");

                    b.HasIndex("CinemaID");

                    b.HasIndex("ProduserID");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("movie_web.Models.Produser", b =>
                {
                    b.Property<int>("ProduserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProduserID");

                    b.ToTable("Produser");
                });

            modelBuilder.Entity("movie_web.Models.Actor_Movie", b =>
                {
                    b.HasOne("movie_web.Models.Actor", "Actor")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("ActorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("movie_web.Models.Movie", "Movie")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("movie_web.Models.Movie", b =>
                {
                    b.HasOne("movie_web.Models.Cinema", "Cinema")
                        .WithMany("Movies")
                        .HasForeignKey("CinemaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("movie_web.Models.Produser", "Produser")
                        .WithMany("Movies")
                        .HasForeignKey("ProduserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Produser");
                });

            modelBuilder.Entity("movie_web.Models.Actor", b =>
                {
                    b.Navigation("Actors_Movies");
                });

            modelBuilder.Entity("movie_web.Models.Cinema", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("movie_web.Models.Movie", b =>
                {
                    b.Navigation("Actors_Movies");
                });

            modelBuilder.Entity("movie_web.Models.Produser", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}