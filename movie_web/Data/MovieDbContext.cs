using Microsoft.EntityFrameworkCore;
using movie_web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_web.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) { }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Produser> Produsers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().ToTable("Actor");
            modelBuilder.Entity<Cinema>().ToTable("Cinema");
            modelBuilder.Entity<Produser>().ToTable("Produser");
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<Actor_Movie>().ToTable("Actor_Movie")
                .HasKey(am => new
                {
                    am.ActorID,
                    am.MovieID
                }
                );
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie)
                .WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieID);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor)
              .WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorID);
        }


    }
}