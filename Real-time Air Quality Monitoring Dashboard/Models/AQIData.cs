using System.ComponentModel.DataAnnotations.Schema;

namespace Real_time_Air_Quality_Monitoring_Dashboard.Data
{
    [Table("aqi_records")]
    public class AQIData
    {
        public int Id { get; set; }
        public string SensorId { get; set; }
        public string Period { get; set; }
        public DateTime Timestamp { get; set; }
        public int AQIValue { get; set; }


    }
}
