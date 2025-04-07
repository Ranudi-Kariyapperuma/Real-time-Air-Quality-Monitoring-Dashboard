﻿using Microsoft.EntityFrameworkCore;
using Real_time_Air_Quality_Monitoring_Dashboard.Models;

namespace Real_time_Air_Quality_Monitoring_Dashboard.Data
{
    public class AirQualityDbContext : DbContext
        {
            public AirQualityDbContext(DbContextOptions<AirQualityDbContext> options)
                : base(options)
            {
            }

            public DbSet<AQIData> AQIRecords { get; set; }
        }
}



