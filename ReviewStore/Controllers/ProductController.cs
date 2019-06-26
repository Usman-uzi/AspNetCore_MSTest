using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReviewStore_Data;
using ReviewStore_Models;

namespace ReviewStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _productRepo;

        List<Product> products = new List<Product>();

        public ProductController(IProductRepo products)
        {
            this._productRepo = products;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var products = await GetAllProductsAsync();
            return Ok(products);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = _productRepo.GetList().FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [NonAction]
        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepo.GetList();
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await Task.FromResult(GetAllProducts());
        }

        //public async Task<IHttpActionResult> GetProductAsync(int id)
        //{
        //    return await Task.FromResult(Get(id));
        //}
    }
}
