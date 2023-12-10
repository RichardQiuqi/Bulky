using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Bulky.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Displayer Order")]
        [Range(1, 100, ErrorMessage = "This is a custom error message for range")]
        public int DisplayOrder { get; set; }
    }
}
