using System.ComponentModel.DataAnnotations;

namespace Code_.Models
{
    public class Ability
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }
        [Display(Name = "Nazwa")]
        [Required]
        [MinLength(5)]
        public string Title { get; set; }
    }
}
