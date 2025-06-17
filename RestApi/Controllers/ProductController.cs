using Microsoft.AspNetCore.Mvc;
using BusinessLayer;
using Models;
using AutoMapper;
using DataAccessLayer.Models;

namespace RestApi.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase

    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET api/Product/ProductID
        [HttpGet("{id}")]
        public ProductModel Get(int id)
        {
            return _productService.Get(id);
        }

        // GET api/product
        [HttpGet]
        public IEnumerable<ProductModel> GetAll()
        {
            return _productService.GetAll();
        }
    }
}
