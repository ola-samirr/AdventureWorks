using System.ComponentModel.DataAnnotations;

namespace AventureWorksAPI.Models
{
    public class Customer
  
        {
            [Key]
            public int CustomerId { get; set; }

            [Required]
            [MaxLength(100)]
            public string FullName { get; set; }

            [EmailAddress]
            public string Email { get; set; }
        }
    

}

