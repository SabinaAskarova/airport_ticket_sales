using Microsoft.EntityFrameworkCore;
using MyProject.Models;

namespace MyProject.DAL.DataContext
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> dbContextOptions) : base(dbContextOptions){}

        public DbSet<User> Users { get; set; }
        public DbSet<FromCity> FromCities { get; set; }
        public DbSet<ToCity> ToCities { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Flight>()
            //    .HasMany<FromCity>(s => s.Fr)
            //    .WithMany(c => c.Students)
            //    .Map(cs =>
            //    {
            //        cs.MapLeftKey("StudentRefId");
            //        cs.MapRightKey("CourseRefId");
            //        cs.ToTable("StudentCourse");
            //    });

            //modelBuilder.Entity<Flight>().HasData(new Flight() 
            //{
            //    FlightId = 3,
            //    FCityId=1, 
            //    TCityId=1 , 
            //    TotalCount=1,
            //    CariCount=1,
            //    Price=10,
            //    IsDeleted = false 
            //}
            //);

            modelBuilder.Entity<ToCity>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<User>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<FromCity>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<ToCity>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Flight>().HasQueryFilter(m => !m.IsDeleted);
        }

    }
}
