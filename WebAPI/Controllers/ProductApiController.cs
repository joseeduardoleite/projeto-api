using System.Threading.Tasks;
using Data.Entities;
using Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Authorize]
    public class ProductApiController : Controller
    {
        private readonly IProduct _IProduct;

        public ProductApiController(IProduct IProduct)
        {
            this._IProduct = IProduct;
        }

        [HttpGet("api/ProductsList")]
        public async Task<JsonResult> ProductsList()
        {
            return Json(await this._IProduct.List());
        }

        [HttpPost("api/ProductAdd")]
        public async Task ProductAdd([FromBody] Product product)
        {
            await Task.FromResult(this._IProduct.Add(product));
        }
    }
}