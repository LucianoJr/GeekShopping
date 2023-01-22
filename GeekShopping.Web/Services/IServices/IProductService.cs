using System.Threading.Tasks;
using GeekShopping.Web.Models;
using System.Collections.Generic;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> FindAllProducts(string token);
        Task<ProductModel> FindProductById(long id, string token);
        Task<ProductModel> CreateProduct(ProductModel model, string token);
        Task<ProductModel> UpdateProduct(ProductModel model, string token);
        Task DeleteProductById(long id, string token);
    }
}
