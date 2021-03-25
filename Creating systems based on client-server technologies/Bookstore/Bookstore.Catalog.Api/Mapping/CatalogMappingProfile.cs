using AutoMapper;
using Bookstore.Catalog.Api.Dto.Books;
using Bookstore.Catalog.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Catalog.Api.Mapping
{
    public class CatalogMappingProfile : Profile
    {
        public CatalogMappingProfile()
        {
            CreateMap<Book, BookResponse>().ReverseMap();
            CreateMap<BookAuthor, BookAuthorResponse>().ReverseMap();
            CreateMap<BookGenre, BookGenreResponse>().ReverseMap();
            CreateMap<BookRequest, Book>().ReverseMap();
        }
    }
}