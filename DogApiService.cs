using System;
using System.Net.Http;
using System.Threading.Tasks;

public class DogApiService
{
    private readonly HttpClient _httpClient;

    public DogApiService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<string> ListSupportedDogBreeds()
    {
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync("https://dog.ceo/api/breeds/list/all");

            if (response.IsSuccessStatusCode)
            {
                string breedsJson = await response.Content.ReadAsStringAsync();
                return breedsJson;
            }
            else
            {
                // Handle unsuccessful API call
                return "Error: Unable to fetch dog breeds.";
            }
        }
        catch (Exception ex)
        {
            // Handle exception
            return $"Error: {ex.Message}";
        }
    }

    internal Task<string> GetDogImagesByBreed(string? breed)
    {
        throw new NotImplementedException();
    }

    internal Task<string> GetRandomDogImage()
    {
        throw new NotImplementedException();
    }
}
