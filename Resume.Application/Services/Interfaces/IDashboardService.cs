using Resume.Application.DTOs.SiteSide.Home;

namespace Resume.Application.Services.Interfaces;

public interface IDashboardService
{
	Task<HomeIndexModelDTO> FillDashboardModel();
}
