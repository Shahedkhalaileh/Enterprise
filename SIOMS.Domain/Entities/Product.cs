namespace SIOMS.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public static Product Create(string name, string? description, decimal price, int stockQuantity, int categoryId)
        {
            return new Product
            {
                Name = name,
                Description = description,
                Price = price,
                StockQuantity = stockQuantity,
                CategoryId = categoryId
            };
        }

        public void IncreaseStock(int quantity)
        {
            StockQuantity += quantity;
        }

        public void DecreaseStock(int quantity)
        {
            if (quantity <= 0 || quantity > StockQuantity)
                throw new InvalidOperationException("Insufficient stock quantity.");

            StockQuantity -= quantity;
        }

        public void UpdatePrice(decimal newPrice)
        {
            if (newPrice < 0)
                throw new ArgumentException("Price cannot be negative.");

            Price = newPrice;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
