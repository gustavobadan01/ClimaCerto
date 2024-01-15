using System;

namespace GustavoASP.Models
{
    public class RespostaOpenWeatherMap
    {
        public CoordInfo Coord { get; set; }
        public WeatherInfo[] Weather { get; set; }
        public string Base { get; set; }
        public MainInfo Main { get; set; }
        public int Visibility { get; set; }
        public WindInfo Wind { get; set; }
        public CloudsInfo Clouds { get; set; }
        public long Dt { get; set; }
        public SysInfo Sys { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
    }

    public class CoordInfo
    {
        public float Lon { get; set; }
        public float Lat { get; set; }
    }

    public class WeatherInfo
    {
        public string Description { get; set; }
    }

    public class MainInfo
    {
        public float Temp { get; set; }
        public float FeelsLike { get; set; }
        public float TempMin { get; set; }
        public float TempMax { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
    }

    public class WindInfo
    {
        public float Speed { get; set; }
        public int Deg { get; set; }
        public float Gust { get; set; }
    }

    public class CloudsInfo
    {
        public int All { get; set; }
    }

    public class SysInfo
    {
        public int Type { get; set; }
        public int Id { get; set; }
        public string Country { get; set; }
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
    }
}
