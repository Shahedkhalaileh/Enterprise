using System;
using System.Collections.Generic;
using System.Text;
using SIOMS.Domain.Entities;

namespace SIOMS.Application.Features.Products.Commands
{
    public class CreateProductHandler
    {
        public Product Handle(CreateProductCommand request)
        {
            var product = new Product
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                StockQuantity = request.StockQuantity,
                CategoryId = request.CategoryId
            };

            return product;
        }
    }
}
