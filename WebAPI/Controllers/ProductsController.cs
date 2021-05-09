using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace WebAPI.Controllers
{

    //Route => istek yapılırken nasıl ulaşılması gerektiğini söyler.
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Loosely coupled
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            //constructor'da doğrudan erişim olmadığı için bu yapıyı(yukarıda tanımladığımız field) kullanıyoruz.
            //IoC Container
            _productService = productService;
        }

        [HttpGet("getall")]
        //public IActionResult Get()
        public IActionResult GetAll()
        {
            //Dependency chain
            //IProductService productService = new ProductManager(new EfProductDal());
            Thread.Sleep(1500);

            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        
        [HttpGet("getbyid")]
        //public IActionResult Get(int productId)
        public IActionResult GetById(int productId)
        {
            var result = _productService.GetById(productId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbycategory")]
        //public IActionResult Get(int productId)
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _productService.GetAllByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        //public IActionResult Post(Product product)
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

       
    }
}
