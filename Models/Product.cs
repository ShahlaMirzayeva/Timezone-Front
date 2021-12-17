using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public int Count { get; set; }
        [MaxLength(500)]
        public string ImageName { get; set; }
        [Column(TypeName = "nText")]
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        [ForeignKey("Image")]
        public int ImageId { get; set; }
        public Image Image { get; set; }


    }
}
