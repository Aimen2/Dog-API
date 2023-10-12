using System;
using System.Threading.Tasks;

public class Menu
{
    private readonly DogApiService _apiService;

    public Menu(DogApiService apiService)
    {
        _apiService = apiService;
    }

    public async Task ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("Dog API Menu:");
            Console.WriteLine("1. Get Random Dog Image");
            Console.WriteLine("2. List Supported Dog Breeds");
            Console.WriteLine("3. Get Dog Images by Breed");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    await DisplayResult(_apiService.GetRandomDogImage());
                    break;
                case "2":
                    await DisplayResult(_apiService.ListSupportedDogBreeds());
                    break;
                case "3":
                    Console.Write("Enter breed: ");
                    string breed = Console.ReadLine();
                    await DisplayResult(_apiService.GetDogImagesByBreed(breed));
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    internal Task GetDogImagesByBreed(string breed)
    {
        throw new NotImplementedException();
    }

    private async Task DisplayResult(Task<string> resultTask)
    {
        string result = await resultTask;
        Console.WriteLine(result);
        Console.WriteLine();
    }
}
