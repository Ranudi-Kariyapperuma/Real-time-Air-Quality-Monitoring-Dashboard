using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Real_time_Air_Quality_Monitoring_Dashboard.Models;

namespace Real_time_Air_Quality_Monitoring_Dashboard.Data
{

    [ApiController]
    [Route("AirQuality")]
    public class AirQualityController : Controller
    {
        private readonly AirQualityDbContext _context;

        public AirQualityController(AirQualityDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAQIData")]
        public IActionResult GetAQIData([FromQuery]string sensorId, [FromQuery] string period)
        {

            if (string.IsNullOrWhiteSpace(sensorId) || string.IsNullOrWhiteSpace(period))
                return BadRequest(new { message = "sensorId and period are required." });

            var now = DateTime.Now;
            DateTime fromDate;

            switch (period.ToLower())
            {
                case "day": fromDate = now.AddDays(-1); break;
                case "week": fromDate = now.AddDays(-7); break;
                case "month": fromDate = now.AddMonths(-1); break;
                default: fromDate = now.AddDays(-7); break;
            }


            var data = _context.AQIRecords
                        .Where(r => r.SensorId == sensorId && r.Timestamp >= fromDate)
                        .OrderBy(r => r.Timestamp)
                        .ToList();

            var labels = data.Select(d => d.Timestamp.ToString("yyyy-MM-dd")).ToList();
            var values = data.Select(d => d.AQIValue).ToList();

            return Json(new { labels, values });


        }
    }
}