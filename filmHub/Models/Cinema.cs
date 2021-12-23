using filmHub.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace filmHub.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cinema Logo")]
        [Required(ErrorMessage ="Cinema logo is required")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Cinema Name is required")]

        public string Name { get; set; }
        [Display(Name = "Cinema Description")]
        public string Description { get; set; }


        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
