using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }

        [Range(0,10)]
        [Required]
        public int Rating { get; set; }

        [Required]
        [MaxLength(256)]
        public string Body { get; set; }

        public string ReviewerName { get; set; }

        public int RestaurantId { get; set; }
    }
}
