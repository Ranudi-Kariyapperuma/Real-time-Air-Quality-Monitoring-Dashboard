using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Real_time_Air_Quality_Monitoring_Dashboard.Models;

namespace Real_time_Air_Quality_Monitoring_Dashboard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["CurrentAQI"] = 75;
            ViewData["AQIStatus"] = "Moderate";
            ViewData["MostPollutedArea"] = "Colombo 07 - AQI: 150";
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
