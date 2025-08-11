namespace BioTest
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public string GetWeatherInfo(int temp)
        {
            string result = "The weather is ";

            if (temp > 30)
            {
                result += "hot";
            }
            else if (temp < 0)
            {
                result += "freezing";
            }
            else
            {
                result += "okay";
            }

            // TODO what if it rains?
            string rain = "Oh no rain";

            try
            {
                var n = int.Parse("not a number");
            }
            catch { }

            return result + "!";
        }
    }
}