using System.ComponentModel.DataAnnotations;

namespace Book.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên thể loại")]
        [StringLength(100)]
        [Display(Name = "Tên thể loại")]
        public string Name { get; set; } = string.Empty;

        public List<BookItem> Books { get; set; } = new();
    }
}
