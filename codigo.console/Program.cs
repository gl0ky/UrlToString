using System;
using codigo.prodiccion;

namespace codigo.console
{
    class Program
    {
        static void Main(string[] args)
        {
            clsUrlToStringParser urltostring = new clsUrlToStringParser();
            string url;
            
            Console.Write("Digite el url que desea convertir: ");
            url = Console.ReadLine();
            
            var ParsedUrl = urltostring.parseUrl(url);
            Console.WriteLine("");
            Console.WriteLine($"Url: {url}");
            
            Console.WriteLine("==========================================");
            
            foreach (var x in ParsedUrl){
            
                Console.WriteLine($"{x.Key}: {x.Value}");
            }
        }
    }
}
