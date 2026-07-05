using System;
using System.Collections.Generic;
using System.Text;

namespace SIOMS.Application.Features.Products.Commands
{
    public class CreateProductCommand
    {
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public int CategoryId { get; set; }

    }
}
