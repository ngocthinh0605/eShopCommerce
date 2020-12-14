using Domain.Entities.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Category : IAggregateRoot
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Mã loại sản phẩm là bắt buộc")]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Description {get;set;}

        public ICollection<Product> Products {get;set;}
        
        
    }
}