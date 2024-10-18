using System;

namespace MyApp
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            Console.WriteLine("About to call API...");
            Console.ReadLine();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5002");
            var response = await client.GetAsync("/api/Ryan/test");
            if (response != null && response.IsSuccessStatusCode)
            {
                Console.WriteLine("Got success from API");
                var realResult = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"{realResult}");
            }
            else
            {
                Console.WriteLine("Got error from API");
            }
            Console.ReadLine();
        }
    }
}