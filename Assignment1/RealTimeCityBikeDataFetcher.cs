using System.Net.Http;
using System.Threading.Tasks;

public class RealTimeCityBikeDataFetcher : ICityBikeDataFetcher
{
    HttpClient client = new HttpClient();

    async Task<int> GetBikeCountInStation(string stationName)
    {
        try
        {
            HttpResponseMessage response = await client.GetAsync("http://api.digitransit.fi/routing/v1/routers/hsl/bike_rental");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            // Above three lines can be replaced with new helper method below
            // string responseBody = await client.GetStringAsync(uri);

            BikeRentalStationList list = JsonConvert.DeserializeObject<BikeRentalStationList>(stations); 
            
        }
        catch(HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ", e.Message);
        }
        
    }

}