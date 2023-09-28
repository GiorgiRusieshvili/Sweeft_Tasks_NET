using Newtonsoft.Json;

namespace assignment_8
{
    public class Program
    {
        static async Task Main(string[] args)
        {

           await GenerateCountryDataFiles();
        }

        static async Task GenerateCountryDataFiles()
        {
            const String url = "https://restcountries.com/v3.1/all";
            HttpClient client = new HttpClient();

            try
            {
                var res = await client.GetAsync(url);

                var jsonResponse = await res.Content.ReadAsStringAsync();

                var countries = JsonConvert.DeserializeObject<Country[]>(jsonResponse);

                foreach (var country in countries)
                {
                    // ATTENTION!!! change the path on a different computer
                    string filePath = Path.Combine(@"C:\Users\giorgi\Desktop\", country.name.common + ".txt");

                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        sw.WriteLine($"Region: {country.region}\n" +
                                     $"Subregion: {country.subregion}\n" +
                                     $"Latlng: {string.Join(",", country.latlng)}\n" +
                                     $"Area: {country.area}\n" +
                                     $"Population: {country.population}");

                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }

        }
    }
    
}
