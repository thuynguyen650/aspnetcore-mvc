using System.ComponentModel.DataAnnotations;

namespace Bulky.Models;

public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    [MaxLength(14)]
    public string ISBN { get; set; }

    [Required]
    [MaxLength(50)]
    public string Author { get; set; }

    [Required]
    [Range(0, 100)]
    public long ListPrice { get; set; }

    [Required]
    [Range(0, 100)]
    public long Price { get; set; }

    [Required]
    [Range(0, 5000)]
    public long Price50 { get; set; }

    [Required]
    [Range(0, 10000)]
    public long Price100 { get; set; }
}
