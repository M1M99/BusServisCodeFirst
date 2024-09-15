using CodeFirst_SchoolServise.Model;
using Microsoft.EntityFrameworkCore;



namespace CodeFirst_SchoolServise.ContextBus
{
    public class BusContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-NB7MT4D\\SQLEXPRESS;Initial Catalog=BusServis;Integrated Security=True;Trust Server Certificate=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bus>().HasOne(b => b.Driver)
                                      .WithOne(d => d.Bus)
                                      .HasForeignKey<Driver>(d => d.Id);
            modelBuilder.Entity<Ride>().HasMany(r => r.Students)
                                       .WithOne(s => s.Rides) // burada manytomany ola bilerdi
                                       .HasForeignKey(s => s.RideId);
            modelBuilder.Entity<ClassForSchool>()
                                       .HasMany(cFS => cFS.Students)
                                       .WithOne(s => s.Class)
                                       .HasForeignKey(s => s.ClassId);
            modelBuilder.Entity<Driver>()
                                       .HasMany(d => d.Rides).WithOne(r => r.Driver)
                                       .HasForeignKey(r => r.DriverId);
            modelBuilder.Entity<Parent>()
                                       .HasMany(p => p.Students)
                                       .WithOne(s => s.Parent)
                                       .HasForeignKey(s => s.ParentId);
        }

        public DbSet<Ride> Rides { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<ClassForSchool> ClassForSchools { get; set; }
        public DbSet<Driver> Drives { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
