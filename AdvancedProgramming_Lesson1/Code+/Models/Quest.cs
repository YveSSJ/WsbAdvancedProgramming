using System.ComponentModel.DataAnnotations;

namespace Code_.Models
{
    public class Quest
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }
        [Display(Name = "Tytuł")]
        [Required]
        [MinLength(7)]
        public string Title { get; set; }
        [Display(Name = "Zapłata")]
        [Required]
        public decimal Price { get; set; }
    }
}
