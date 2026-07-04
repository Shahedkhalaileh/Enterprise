using System;
using System.Collections.Generic;
using System.Text;

namespace SIOMS.Domain.Entities
{
    internal class Product
    {

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public bool IsDeleted { get; set; } = false;
        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;
    }
}
