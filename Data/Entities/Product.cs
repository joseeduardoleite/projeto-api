using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("Product")]
    public class Product
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Image")]
        public string Image { get; set; }
    }
}