//namespace Storage.Models
//{
//    public class Product
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Price { get; set; }
//        public DateTime OrderDate { get; set; }
//        public string Category { get; set; }
//        public string Shelf { get; set; }
//        public int Count { get; set; }
//        public string Description { get; set; }
//    }
//}
using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1, 1000, ErrorMessage = "Price must be between 1 and 1000")]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        public string Category { get; set; }

        public string Shelf { get; set; }

        [Range(0, 100, ErrorMessage = "Count must be between 0 and 100")]
        public int Count { get; set; }

        public string Description { get; set; }
    }
}
