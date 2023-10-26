using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Experience;
using Resume.Domain.Entities.MySkills;

namespace Resume.Infrastructure.DBContext
{
    public class ResumeDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Resume;User Id=sa;Password=!@#123qwe;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<ContactUsLocation> ContactUsLocation { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<MySkills> MySkills { get; set; }
    }
}
