using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AkinTestEF.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string? SurName { get; set; }
        public int BookId { get; set; }
       public ICollection<AuthorBook> AuthorBooks { get; set; }
    }
}
