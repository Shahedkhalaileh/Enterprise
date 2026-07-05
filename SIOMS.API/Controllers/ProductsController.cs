using Microsoft.AspNetCore.Mvc;
using SIOMS.Application.Features.Products.Commands;

namespace SIOMS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly CreateProductHandler _handler;

        public ProductsController(CreateProductHandler handler)
        {
            _handler = handler;
        }

        [HttpPost]
        public IActionResult Create(CreateProductCommand command)
        {
            var product = _handler.Handle(command);

            return Ok(product);
        }
    }
}