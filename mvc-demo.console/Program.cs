using System;
using Microsoft.Owin.Hosting;

namespace mvc_demo.console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var startOptions = new StartOptions("http://localhost:4000");
            using (WebApp.Start<Startup>(startOptions))
            {
                Console.WriteLine($"Started on {string.Join(",", startOptions.Urls)}");
                Console.ReadKey();
            }
        }
    }
}