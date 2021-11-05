using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using WebApi;

namespace WebApi
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }


        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
    }
}