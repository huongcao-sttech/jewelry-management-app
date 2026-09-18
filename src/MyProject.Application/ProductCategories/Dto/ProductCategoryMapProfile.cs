using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ProductCategories.Dto
{
    public class ProductCategoryMapProfile : Profile
    {
        public ProductCategoryMapProfile()
        {
            CreateMap<ProductCategory, ProductCategoryDto>();
        }
    }
}
