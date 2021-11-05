using System.Collections.Generic;
using AutoMapper;

namespace WebApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateBookModel, Book>();

            CreateMap<CreateAuthorModel, Author>();

            CreateMap<Book, BookDetailViewModel>()
            .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name))
            .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.Name))
            .ForMember(dest => dest.AuthorSurname, opt => opt.MapFrom(src => src.Author.Surname));

            CreateMap<Book, BooksViewModel>()
            .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name))
            .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.Name))
            .ForMember(dest => dest.AuthorSurname, opt => opt.MapFrom(src => src.Author.Surname));

            CreateMap<Genre, GenresViewModel>();//genre'yı GenresViewModel'e dönüştürüyoruz.

            CreateMap<Genre, GenreDetailViewModel>();

            CreateMap<Author, AuthorsViewModel>();

            CreateMap<Author, AuthorDetailViewModel>();
        }

    }

}