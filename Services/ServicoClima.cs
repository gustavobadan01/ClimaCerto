using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using GustavoASP.Models;

public class ServicoClima
{
    private readonly string apiKey = "4d61ec2d497a600736ababd19343a0d3"; 
    private readonly string apiUrl = "http://api.openweathermap.org/data/2.5/weather";

    private readonly ILogger<ServicoClima> _logger;

    public ServicoClima(ILogger<ServicoClima> logger)
    {
        _logger = logger;
    }

    public async Task<DadosClima> ObterDadosClima(string cidade)
    {
        try
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{apiUrl}?q={cidade}&APPID={apiKey}&units=metric");

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var weatherInfo = JsonConvert.DeserializeObject<RespostaOpenWeatherMap>(json);

                    var dadosClima = new DadosClima
                    {
                        Cidade = weatherInfo.Name,
                        Descricao = weatherInfo.Weather[0].Description,
                        Temperatura = weatherInfo.Main.Temp,
                        SensacaoTermica = weatherInfo.Main.FeelsLike,
                        TemperaturaMinima = weatherInfo.Main.TempMin,
                        TemperaturaMaxima = weatherInfo.Main.TempMax,
                        Pressao = weatherInfo.Main.Pressure,
                        Umidade = weatherInfo.Main.Humidity,
                        VelocidadeVento = weatherInfo.Wind.Speed,
                        DirecaoVento = weatherInfo.Wind.Deg,
                        RajadaVento = weatherInfo.Wind.Gust,
                        Nuvens = weatherInfo.Clouds.All,
                        Visibilidade = weatherInfo.Visibility,
                        Amanhecer = DateTimeOffset.FromUnixTimeSeconds(weatherInfo.Sys.Sunrise).DateTime,
                        Anoitecer = DateTimeOffset.FromUnixTimeSeconds(weatherInfo.Sys.Sunset).DateTime
                    };

                    return dadosClima;
                }
                else
                {

                    return null;
                }
            }
        }
        catch (HttpRequestException ex)
        {

            return null;
        }
    }
}
