using System;
using System.Collections.Generic;
using System.Linq;

using AutoMapper;


namespace WebApi
{

    public class GetAuthorsQuery
    {
        private IMapper _mapper;
        private readonly BookStoreDbContext _dbContext;
        public GetAuthorsQuery(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<AuthorsViewModel> Handle()
        {
            var authorList = _dbContext.Authors.OrderBy(x => x.Id).ToList();
            if (authorList is null) throw new InvalidOperationException("Hiçbir yazar veritabanında bulunamadı!");

            var vm = _mapper.Map<List<AuthorsViewModel>>(authorList);//new List<BooksViewModel>(

            return vm;
        }
    }



    public class AuthorsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }

    }

}