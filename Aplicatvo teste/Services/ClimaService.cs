using System.Text.Json;

namespace Aplicatvo_teste.Services
{
    internal class ClimaService
    {
        private readonly HttpClient _httpClient;

        public ClimaService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> ObterClimaAsync()
        {
            string url =
                "https://api.open-meteo.com/v1/forecast?" +
                "latitude=-22.2841" +
                "&longitude=-48.1267" +
                "&current=temperature_2m,wind_speed_10m";

            try
            {
                var resposta = await _httpClient.GetAsync(url);

                resposta.EnsureSuccessStatusCode();

                string json = await resposta.Content.ReadAsStringAsync();

                using JsonDocument documento = JsonDocument.Parse(json);

                var current = documento.RootElement.GetProperty("current");

                double temperatura =
                    current.GetProperty("temperature_2m").GetDouble();

                double vento =
                    current.GetProperty("wind_speed_10m").GetDouble();

                return $"Temperatura: {temperatura}°C\n " +
                    $"Vento: {vento} Km/h";
            }
            catch (Exception ex)
            {
                return $"Erro ao consultar API: {ex.Message}";

            }
        }

    }
}
