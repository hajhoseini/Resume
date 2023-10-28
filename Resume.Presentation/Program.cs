using Resume.Application.Services.Implementations;
using Resume.Application.Services.Interfaces;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.DBContext;
using Resume.Infrastructure.Repository;

namespace Resume.Presentation
{
    public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

            //    builder.Services.AddDbContext<ResumeDBContext>(options =>
            //options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddDbContext<ResumeDBContext>();

			#region Repositories

			builder.Services.AddScoped<IContactUsRepository, ContactUsRepository>();
			builder.Services.AddScoped<IEducationRepository, EducationRepository>();
			builder.Services.AddScoped<IExperienceRepository, ExperienceRepository>();
			builder.Services.AddScoped<IMySkillsRepository, MySkillsRepository>();

			#endregion

			#region Services			

			builder.Services.AddScoped<IContactUsService, ContactUsService>();
			builder.Services.AddScoped<IEducationService, EducationService>();
			builder.Services.AddScoped<IExperienceService, ExperienceService>();
			builder.Services.AddScoped<IMySkillsService, MySkillsService>();
			builder.Services.AddScoped<IDashboardService, DashboardService>();

			#endregion

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
			name: "areas",
			pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
			);

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}