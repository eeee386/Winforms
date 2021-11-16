using System.ComponentModel.DataAnnotations;

namespace MusicListASP.Models
{
    public class Music
    {
        [Display(Name = "ID")]
        [Key]
        public int id { get; set; }


        [Display(Name = "Cím")]
        [Required]
        public string title { get; set; }


        [Display(Name = "Előadó")]
        [Required]
        public string artist { get; set; }


        [Display(Name = "Kiadási év")]
        [Required]
        public int publishYear { get; set; }


        [Display(Name = "Hossz")]
        [Required]
        public int length { get; set; }


        [Display(Name = "Prioritás")]
        [Required]
        public int priority { get; set; }
    }
}
