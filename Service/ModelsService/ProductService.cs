using Domain.Models;
using Repository.ModelsRepository;
using System.Collections.Generic;
using System.Linq;

namespace Service.ModelsService
{
    public class ProductService
    {
        private readonly ProdutoRepository _productRepository;

        public ProductService(ProdutoRepository produtoRepository)
        {
            _productRepository = produtoRepository;
        }

        public IList<Product> GetAll()
        {
            var products = _productRepository.GetAll();

            return products.ToList();
        }
    }
}
