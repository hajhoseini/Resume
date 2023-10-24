using Microsoft.EntityFrameworkCore;
using Resume.Presentation.Models.Entities.ContactUs;
using Resume.Presentation.Models.Entities.Education;
using Resume.Presentation.Models.Entities.Experience;
using Resume.Presentation.Models.Entities.MySkills;

namespace Resume.Presentation.Models.ResumeDBContext
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
