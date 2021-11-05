using System;
using System.Buffers;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace WebApi
{
    public class GetBookDetailQuery
    {

        private readonly BookStoreDbContext _dbContext;
        public BookDetailViewModel Model { get; set; }
        private readonly IMapper _mapper;
        public int BookId { get; set; }


        public GetBookDetailQuery(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }


        public BookDetailViewModel Handle()
        {
            var book = _dbContext.Books.Include(x => x.Genre).Include(x=>x.Author).Where(book => book.Id == BookId).SingleOrDefault();

            if (book is null)
                throw new InvalidOperationException("İlgili kitap veritabanında bulunamadı!");



            var viewModel = _mapper.Map<BookDetailViewModel>(book);//new BookDetailViewModel();
            // viewModel.Title = book.Title;
            // viewModel.PageCount = book.PageCount;
            // viewModel.Genre = ((GenreEnum)book.GenreId).ToString();
            // viewModel.PublishDate = book.PublishDate.Date.ToString("dd/MM/yyyy");

            return viewModel;


        }

    }


    public class BookDetailViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }

    }

}