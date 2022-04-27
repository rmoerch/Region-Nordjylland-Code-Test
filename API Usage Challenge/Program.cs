using System;
using System.Threading.Tasks;
using System.Net;
using RestSharp;

namespace APIUsageChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();
        }

        static async Task MainAsync()
        {
            try
            {
                Console.WriteLine("Enter an integer, and receive a character from the Star Wars universe! ");
                int id = int.Parse(Console.ReadLine());
                
                var client = new RestClient("https://swapi.dev/");
                var request = new RestRequest("api/people/" + id);
                var response = await client.GetAsync(request);
                if(response.StatusCode == HttpStatusCode.NotFound)
                {
                    Console.WriteLine("The character could not be found!");
                }
                Console.WriteLine(response.Content.ToString());
                Console.Read();
  
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
