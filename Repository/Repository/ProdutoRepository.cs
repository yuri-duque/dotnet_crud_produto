using Domain.Models;
using Repository.Context;

namespace Repository.ModelsRepository
{
    public class ProdutoRepository : Repository<Product>
    {
        public ProdutoRepository(BaseContext ctx) : base(ctx) { }
    }
}
