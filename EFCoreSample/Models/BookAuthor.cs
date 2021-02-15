﻿using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreSample.Models
{
    public class BookAuthor
    {
        [ForeignKey("Book")]
        public int BookId { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
