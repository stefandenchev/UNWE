using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookstoreConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetStringAsync("https://localhost:44303/api/books");
                var allBooks = JsonSerializer.Deserialize<List<Book>>(result,
                    new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

                foreach (var book in allBooks)
                {
                    Console.WriteLine(book.Title);
                }

                /*var api = new Bookstore("https://localhost:44303", client);
                var books = await api.GetAllAsync();

                foreach (var book in books)
                {
                    Console.WriteLine(book.Title);
                }*/

                var refitApi = RestService.For<IBookstoreApi>("https://localhost:44303/api/books");
                var refitBooks = await refitApi.GetAllBooks();

                foreach (var book in refitBooks)
                {
                    Console.WriteLine(book.Title);
                }

            }
        }
    }

    public interface IBookstoreApi
    {
        [Get("/api/books")]
        Task<List<Book>> GetAllBooks();

        [Get("/api/books/{id}")]
        Task<List<Book>> GetById(int id);
    }

    public class Book
    {
        public int BookID { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int PublisherID { get; set; }
        public int LanguageID { get; set; }
        public decimal Price { get; set; }

        public string LanguageName { get; set; }
        public string PublisherCompanyName { get; set; }
    }
}
