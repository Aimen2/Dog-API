using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class DogController : Controller
{
    public class Menu
    {
        private readonly DogApiService _apiService;

        public Menu(DogApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<string> GetRandomDogImage()
        {
            return await _apiService.GetRandomDogImage();
        }

        public async Task<string> ListSupportedDogBreeds()
        {
            return await _apiService.ListSupportedDogBreeds();
        }

        public async Task<string> GetDogImagesByBreed(string breed)
        {
            return await _apiService.GetDogImagesByBreed(breed);
        }
    }
}

