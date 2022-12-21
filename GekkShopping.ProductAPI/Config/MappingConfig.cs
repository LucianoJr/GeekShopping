using AutoMapper;
using GekkShopping.ProductAPI.Data.ValueObjects;
using GekkShopping.ProductAPI.Model;

namespace GekkShopping.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO>();
            });
            return mappingConfig;
        }
    }
}
