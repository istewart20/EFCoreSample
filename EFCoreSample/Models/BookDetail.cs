using System.ComponentModel.DataAnnotations;

namespace EFCoreSample.Models
{
    public class BookDetail
    {
        [Key]
        public int BookDetail_Id { get; set; }
        public int NumberOfChapters { get; set; }
        [Required]
        public int NumberOfPages { get; set; }
        public Book Book { get; set; }
    }
}
