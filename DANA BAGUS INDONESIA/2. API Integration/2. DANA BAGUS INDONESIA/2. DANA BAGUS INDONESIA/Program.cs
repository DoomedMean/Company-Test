using System.Text.Json;

public class Weather
{
	private readonly static string apiKey = "229a9b7705ddf427419c5edf3ccaf55a";
	private readonly static string CityID = "1642911"; //Jakarta

	public static async Task Main()
	{
		string apiUrl = $"https://api.openweathermap.org/data/2.5/forecast?id={CityID}&appid={apiKey}&units=metric";

		using(HttpClient client = new HttpClient())
		{
			try
			{
				HttpResponseMessage responseMessage = await client.GetAsync(apiUrl);
				responseMessage.EnsureSuccessStatusCode();
				string responseBody = await responseMessage.Content.ReadAsStringAsync();
				//PrintJson(responseBody);

				var weatherData = JsonDocument.Parse(responseBody);
				var getCity = weatherData.RootElement.GetProperty("city").GetProperty("name");
				var forecasts = weatherData.RootElement.GetProperty("list");
				Console.WriteLine("Weather Forecast:");
				string recordDate = "";

				foreach(var forecast in forecasts.EnumerateArray())
				{
					var Date = DateTime.Parse(forecast.GetProperty("dt_txt").GetString()).ToString("dd MMM yyyy");

					if (Date != recordDate)
					{
						recordDate = Date;
						Console.WriteLine($"{getCity}, {Date}: {forecast.GetProperty("main").GetProperty("temp")}°C");
					}
				}
			}
			catch (HttpRequestException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
	private static void PrintJson(string jsonString)
	{
		using (JsonDocument doc = JsonDocument.Parse(jsonString))
		{
			var options = new JsonSerializerOptions { WriteIndented = true };
			string formattedJson = JsonSerializer.Serialize(doc.RootElement, options);
			Console.WriteLine(formattedJson);
		}
	}
}