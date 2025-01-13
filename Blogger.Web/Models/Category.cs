using System.ComponentModel.DataAnnotations;

namespace Blogger.Web.Models
{
    // this class will be a table in the database
    public class Category
    {
        // this keyword will set Id as the primary key
        [Key]
        // each property will be a column in the database
        public int Id { get; set; }

        // this attribute will make the Name property required
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
