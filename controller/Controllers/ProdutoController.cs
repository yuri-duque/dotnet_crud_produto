using Microsoft.AspNetCore.Mvc;
using Service.ModelsService;
using System;

namespace Controller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProductService _produtoService;

        public ProdutoController(ProductService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            try
            {
                var usuario = _produtoService.GetAll();

                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}