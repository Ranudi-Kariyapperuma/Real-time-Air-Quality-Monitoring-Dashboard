using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

public class AirQualityController : Controller
{
    public IActionResult GetAqiData()
    {
        var aqiData = new
        {
            labels = new List<string>(),
            values = new List<int>()
        };

        Random rand = new Random();
        for (int i = 6; i >= 0; i--)
        {
            aqiData.labels.Add(DateTime.Now.AddDays(-i).ToString("yyyy-MM-dd"));
            aqiData.values.Add(rand.Next(50, 200)); // Simulating AQI values
        }

        return Json(aqiData);
    }

}