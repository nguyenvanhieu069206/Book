using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.Models
{
    public class BookItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên sách")]
        [StringLength(200)]
        [Display(Name = "Tên sách")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng nhập tác giả")]
        [StringLength(150)]
        [Display(Name = "Tác giả")]
        public string Author { get; set; } = string.Empty;

        [StringLength(150)]
        [Display(Name = "Nhà xuất bản")]
        public string? Publisher { get; set; }

        [Display(Name = "Năm xuất bản")]
        [Range(1000, 9999, ErrorMessage = "Năm xuất bản không hợp lệ")]
        public int PublishYear { get; set; }

        [Display(Name = "Giá (VNĐ)")]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Giá phải lớn hơn hoặc bằng 0")]
        public decimal Price { get; set; }

        [Display(Name = "Số lượng")]
        [Range(0, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn hoặc bằng 0")]
        public int Quantity { get; set; }

        [StringLength(500)]
        [Display(Name = "Mô tả")]
        public string? Description { get; set; }

        [Display(Name = "Thể loại")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
