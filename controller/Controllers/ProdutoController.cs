using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Service.ModelsService;
using System;
using System.Linq;

namespace Controller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProdutoController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            try
            {
                var user = _productService.GetAll();

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Save(Product product)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.SelectMany(x => x.Errors));

                _productService.Save(product);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}