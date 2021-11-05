using System;
using System.Buffers;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace WebApi
{
    public class GetAuthorDetailQuery
    {

        private readonly BookStoreDbContext _dbContext;
        public AuthorDetailViewModel Model { get; set; }
        private readonly IMapper _mapper;
        public int AuthorId { get; set; }


        public GetAuthorDetailQuery(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }


        public AuthorDetailViewModel Handle()
        {
            var author = _dbContext.Authors.Where(x => x.Id == AuthorId).SingleOrDefault(); ;

            if (author is null)
                throw new InvalidOperationException("İlgili yazar veritabanında bulunamadı!");



            var viewModel = _mapper.Map<AuthorDetailViewModel>(author);//new BookDetailViewModel();
            // viewModel.Title = book.Title;
            // viewModel.PageCount = book.PageCount;
            // viewModel.Genre = ((GenreEnum)book.GenreId).ToString();
            // viewModel.PublishDate = book.PublishDate.Date.ToString("dd/MM/yyyy");

            return viewModel;


        }

    }


    public class AuthorDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string birthDate { get; set; }

    }

}