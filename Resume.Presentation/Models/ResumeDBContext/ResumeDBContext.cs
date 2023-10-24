using Microsoft.EntityFrameworkCore;

namespace Resume.Presentation.Models.ResumeDBContext
{
    public class ResumeDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Resume;User Id=sa;Password=!@#123qwe;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
