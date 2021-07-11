using System.ComponentModel.DataAnnotations.Schema;

namespace RestWith.Net5.Model
{
    [Table("person")]
    public class Person
    {
        [Column("address")]
        public string Address { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        [Column("id")]
        public long Id { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }
    }
}