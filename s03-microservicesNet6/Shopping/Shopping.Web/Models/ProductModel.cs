namespace Shopping.Web.Models
{
    public class ProductModel
    {
        public long Id { get; set; }
        public string Name { set; get; }
        public decimal Price { set; get; }
        public string Description { set; get; }
        public string CategoryName { set; get; }
        public string ImageUrl { set; get; }
    }
}
