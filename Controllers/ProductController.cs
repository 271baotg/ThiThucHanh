using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using THUCHANH.Models;
using THUCHANH.Repository;

namespace THUCHANH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }

        [HttpPost]
        public IActionResult createProduct(Product product) { 
            var result = productRepository.createProduct(product);
            return Ok(result);
        }
        public IActionResult updateProduct(Product product)
        {
            var result = productRepository.updateProduct(product);
            return Ok("Update succesfully");
        }
        [HttpGet]
        public IActionResult getProducts()
        {
            var products = productRepository.getAll();
            return Ok(products);
        }
    }
}
