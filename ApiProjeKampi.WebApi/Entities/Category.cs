namespace ApiProjeKampi.WebApi.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public List<Product> Products { get; set; } // Bir kategorinin birden fazla ürünü olabilir,
                                                    // bu nedenle List<Product> türünde bir koleksiyon kullanılır.
    }
}
