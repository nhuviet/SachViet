using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SachViet.Models
{
    public class Book
    {
        public long BookID { get; set; }

        [Required(ErrorMessage = "Nhập tên sách")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Nhập tên tác giả")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Nhập mô tả sách")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Nhập giá sản phẩm (k NVD)")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Nhập thể loại sách")]
        public string Genre { get; set; }

        public string ImgPath { get; set; }
    }
}