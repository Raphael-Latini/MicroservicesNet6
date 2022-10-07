using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shopping.ProductAPI.Data.ValueObjects
{
    public class ProductVO
    {
        public long Id { get; set; }
        public string Name { set; get; }
        public decimal Price { set; get; }
        public string Description { set; get; }
        public string CategoryName { set; get; }
        public string ImageUrl { set; get; }


    }
}
