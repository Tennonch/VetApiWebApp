using Microsoft.EntityFrameworkCore;

namespace VetApiWebApp.Models
{
    public class VetApiContext : DbContext
    {
        public virtual DbSet<Patient> Patients { get; set; }

        public virtual DbSet<Visit> Visits { get; set; }

        public virtual DbSet<Doctor> Doctors { get; set; }

        public virtual DbSet<Service> Services { get; set; }

        public virtual DbSet<VisitService> VisitServices { get; set; }

        public VetApiContext(DbContextOptions<VetApiContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
