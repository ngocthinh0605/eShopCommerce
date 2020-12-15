using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ProductDto
    {

        public ProductDto()
        {
            Price = 0;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Mã sản phẩm là bắt buộc")]
        public int Id { set; get; }
        [Required(ErrorMessage = "Mã loại là bắt buộc")]
        public int Category_Id { set; get; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { set; get; }
        [Required]
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }

        public bool? IsFeatured { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
