namespace ApiProjeKampi.WebApi.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; } // Her ürünün bir kateoriye ait olduğunu belirtmek için Category sınıfına referans
                                               // eklenir. Bu, ürünlerin hangi
                                               // kategoriye ait olduğunu göstermek ve ilişkili verileri çekmek için kullanılır

    }
}
