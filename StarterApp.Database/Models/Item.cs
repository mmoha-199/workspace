using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StarterApp.Database.Models;

[Table("items")]
[PrimaryKey(nameof(Id))]
public class Item
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Description { get; set; } = string.Empty;
    [Required]
    //public string Condition { get; set; } = string.Empty;
    //[Required]
    
    public decimal PricePerDay { get; set; }
    [Required]
    public string CategoryId { get; set; } = string.Empty;
    [Required]

    public DateTime? AvailableFrom { get; set; }
    [Required]
    public DateTime? AvailableTo { get; set; }
    public bool IsAvailable { get; set; } = true;

    public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DeletedAt { get; set; }
    
    //public bool IsAvailable() => DeletedAt == null;
    
    ///<param name="review"></param>
    /*public void AddReviews(Review review)
    {
        Reviews.Add(review);
    }*/
}