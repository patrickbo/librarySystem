using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Models
{
    [Table("book", Schema = "books")]
    public class Book
    {
        public long? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime InsertLibrary { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }

        public Secao Secao { get; set; }         
    }
}