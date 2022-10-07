using Microsoft.AspNetCore.Mvc;
using Shopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.ProductAPI.Model
{
    [Table("product")]
    public class Product : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name { set; get; }

        [Column("price")]
        [Required]
        [Range(1, 10000)]

        public decimal Price { set; get; }

        [Column("description")]
        [StringLength(500)]

        public string Description { set; get; }

        [Column("category name")]
        [StringLength(150)]

        public string CategoryName { set; get; }

        [Column("image_url")]
        [StringLength(300)]

        public string ImageUrl { set; get; }




    }
}
