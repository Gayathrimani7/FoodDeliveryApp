using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp.Models
{
    public class ItemModel
    {
        [Key]
        public int ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
