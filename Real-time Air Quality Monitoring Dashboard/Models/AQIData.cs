namespace Real_time_Air_Quality_Monitoring_Dashboard.Data
{
    public class AQIData
    {
        public int Id { get; set; }
        public string SensorId { get; set; }
        public DateTime Timestamp { get; set; }
        public int AQIValue { get; set; }


    }
}
