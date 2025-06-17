using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestApi;
using RestApi.Client;

namespace ConsoleApp2
{
    public class ConsoleApplication : IConsoleApplication
    {
        private readonly IProductClient _productClient;

        public ConsoleApplication(IProductClient productClient)
        {
            _productClient = productClient;
        }

        public async void LoadArtists()
        {
            Console.WriteLine("Called await _productClient.GetAsync(1)");
            var product = await _productClient.GetAsync(8);
            Console.WriteLine($"GetAsync returned with {product.Name}");
            Console.WriteLine($"Listing works");
            Console.WriteLine(product.Name);
            //foreach (var work in product.Works)
            //{
            //    Console.WriteLine(work.Name);
            //}
        }

        public void Run()
        {
            Console.WriteLine("Start");
            LoadArtists();
            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
