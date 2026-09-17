using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Products.Dto
{
    public class ProductMapProfile : Profile
    {
        public ProductMapProfile()
        {
            CreateMap<Product, ProductDto>();

            CreateMap<ProductImage, ProductImageDto>();

            CreateMap<ProductCategory, ProductCategoryDto>();
        }
    }
}
