using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWith.Net5.Model
{
    [Table("books")]
    public class Books
    {
        [Column("author")]
        public string Author { get; set; }

        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }

        [Column("price")]
        public float Price { get; set; }

        [Column("id")]
        public long Id { get; set; }

        [Column("title")]
        public string Titulo { get; set; }
    }
}