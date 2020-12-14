using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CategoryDto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Mã loại sản phẩm là bắt buộc")]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<ProductDto> ProductDtos { get; set; }
    }
}
