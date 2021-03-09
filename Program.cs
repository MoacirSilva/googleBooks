using System;
using static System.Console;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using googleBooksApp;

namespace googleBooksApp
{
    class Program
    {
        
        public static void Main(string[] args)
        {            
            WriteLine("Acessando...");                
            var task = Task.Run(async () => await BooksRepo.GetBookssAsync());
            var result = task.Result;
            
        }

    }
}
