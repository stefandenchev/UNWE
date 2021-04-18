using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Catalog.Api.Dto.Books
{
    public class GenreResponse
    {
        public int GenreId { get; set; }
        public string Name { get; set; }

        public ICollection<BookResponse> Books { get; set; }
    }
}
