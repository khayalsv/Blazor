using System;
using System.Collections.Generic;

namespace BookStoreAPI.Data
{
    public partial class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime? Year { get; set; }
        public decimal? Price { get; set; }
        public string? Image { get; set; }
        public int? AuthorId { get; set; }

        public virtual Author? Author { get; set; }
    }
}
