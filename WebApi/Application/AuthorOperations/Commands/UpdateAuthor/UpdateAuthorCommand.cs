using System;
using System.Linq;

namespace WebApi
{
    public class UpdateAuthorCommand
    {
        public int AuthorId { get; set; }
        public UpdateAuthorModel Model { get; set; }
        private readonly BookStoreDbContext _context;
        public UpdateAuthorCommand(BookStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);
            if (author is null) throw new InvalidOperationException("Yazar bulunamadı!");
            if (_context.Authors.Any(x => x.Name.ToLower() == Model.AuthorName.ToLower() && x.Id != AuthorId))
            { throw new InvalidOperationException("Bu isimde bir yazar zaten var!"); }

            author.Name = string.IsNullOrEmpty(Model.AuthorName.Trim()) ? author.Name : Model.AuthorName;
            author.Surname = string.IsNullOrEmpty(Model.AuthorSurname.Trim()) ? author.Surname : Model.AuthorSurname;

            _context.SaveChanges();
        }


    }

    public class UpdateAuthorModel
    {
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public DateTime birthDate { get; set; }
    }
}