using Domain.Models;
using Repository.ModelsRepository;
using System;
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

        public object GetById(long id)
        {
            var product = _productRepository.Find(id);

            return product;
        }

        public void Save(Product product)
        {
            _productRepository.Save(product);
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }

        public void Delete(long id)
        {
            _productRepository.Delete(x => x.Id == id);
        }
    }
}
