using System.ComponentModel.DataAnnotations;

namespace AventureWorksAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
