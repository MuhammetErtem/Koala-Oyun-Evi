using Koala.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koala.DAL.DbContexts
{
    public class SqlContext: DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> opt) : base(opt)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GalleryPicture>().HasOne(ho => ho.Gallery).WithMany(wm => wm.GalleryPictures).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EventPicture>().HasOne(ho => ho.Event).WithMany(wm => wm.EventPictures).OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Cold> Cold { get; set; }
        public DbSet<Desert> Desert { get; set; }
        public DbSet<Drink> Drink { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<EventPicture> EventPicture { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<GalleryPicture> GalleryPicture { get; set; }
        public DbSet<Hot> Hot { get; set; }
        public DbSet<Kitchen> Kitchen { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Snack> Snack { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<Reservation> Reservation { get; set; }

    }
}
