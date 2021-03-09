using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace googleBooksApp
{
    public class BooksRepo
    {           
        public static async Task<Books> GetBookssAsync()
        {
            HttpClient client = new HttpClient();
            try
            {
                string url = "https://www.googleapis.com/books/v1/volumes?q=z_JRBQAAQBAJ";
                var response = await client.GetStringAsync(url);
                var produtos = JsonConvert.DeserializeObject <Books>(response);
                return produtos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
    }
}