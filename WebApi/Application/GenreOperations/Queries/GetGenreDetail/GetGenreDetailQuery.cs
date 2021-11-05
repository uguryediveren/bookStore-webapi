using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using AutoMapper;

namespace WebApi
{

    public class GetGenreDetailQuery
    {
        public int GenreID { get; set; }
        public readonly BookStoreDbContext _context;
        public readonly IMapper _mapper;

        public GetGenreDetailQuery(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public GenreDetailViewModel Handle()
        {
            var genre = _context.Genres.SingleOrDefault(x => x.IsActive && x.Id == GenreID);
            if (genre is null)
            {
                throw new InvalidOperationException("Kitap türü bulunamadı!");
            }
            return _mapper.Map<GenreDetailViewModel>(genre);
        }



    }

    public class GenreDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
