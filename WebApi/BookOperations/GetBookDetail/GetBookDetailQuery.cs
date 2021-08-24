using System;
using System.Linq;

namespace WebApi
{
    public class GetBookDetailQuery
    {

        private readonly BookStoreDbContext _dbContext;
        public int BookId { get; set; }
        public GetBookDetailQuery(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public BookDetailViewModel Handle()
        {
            var book = _dbContext.Books.Where(book => book.Id == BookId).SingleOrDefault();

            if (book is null)
                throw new InvalidOperationException("İlgili kitap veritabanında bulunamadı!");

            BookDetailViewModel viewModel = new BookDetailViewModel();
            viewModel.Title = book.Title;
            viewModel.PageCount = book.PageCount;
            viewModel.GenreId = ((GenreEnum)book.GenreId).ToString();
            viewModel.PublishDate = book.PublishDate.Date.ToString("dd/MM/yyyy");

            return viewModel;


        }

    }


    public class BookDetailViewModel
    {
        public string Title { get; set; }
        public string GenreId { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }

    }

}