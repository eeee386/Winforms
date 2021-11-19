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
        public string Title { get; set; }


        [Display(Name = "Előadó")]
        [Required]
        public string Artist { get; set; }


        [Display(Name = "Kiadási év")]
        [Required]
        public int PublishYear { get; set; }


        [Display(Name = "Hossz")]
        [Required]
        public int MusicLength { get; set; }


        [Display(Name = "Prioritás")]
        [Required]
        public int Priority { get; set; }
    }
}
