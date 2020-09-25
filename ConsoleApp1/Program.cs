using Flurl.Http;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var o = await $"https://192.168.15.27:45457/api/perfil/1".GetJsonAsync();

            var a = 1;
        }
    }
}
