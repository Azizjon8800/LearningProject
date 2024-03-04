using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LearningProject.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Invalid name length")]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(0, 100, ErrorMessage = "Please input number between 1, 100")]
        public int DisplayOrder { get; set; }
    }
}
