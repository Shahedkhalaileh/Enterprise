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
            var product = Product.Create(
                request.Name,
                request.Description,
                request.Price,
                request.StockQuantity,
                request.CategoryId
            );

            return product;
        }
    }
}
