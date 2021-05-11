using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AdvancedProgramming_Lesson2.Resources;

namespace AdvancedProgramming_Lesson2.Models
    
{
    public class Movie
    {
        
        public int Id { get; set; }
        [Required(ErrorMessageResourceName = "Error", ErrorMessageResourceType = typeof(Resources.SharedResource))]
        [LocalizedDisplayName("Title", NameResourceType = typeof(Resources.SharedResource))]
        public string Title { get; set; }
        [Required(ErrorMessageResourceName ="Error", ErrorMessageResourceType = typeof(Resources.SharedResource))]
        [LocalizedDisplayName("Date", NameResourceType = typeof(Resources.SharedResource))]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessageResourceName = "Error", ErrorMessageResourceType = typeof(Resources.SharedResource))]
        [LocalizedDisplayName("Genre", NameResourceType = typeof(Resources.SharedResource))]
        public string Genre { get; set; }
        [Required(ErrorMessageResourceName = "Error", ErrorMessageResourceType = typeof(Resources.SharedResource))]
        [LocalizedDisplayName("Price", NameResourceType = typeof(Resources.SharedResource))]
        public decimal Price { get; set; }
    }
}
