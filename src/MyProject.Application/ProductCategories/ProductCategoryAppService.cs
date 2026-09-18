using Abp.Application.Services;
using Abp.Domain.Repositories;
using MyProject.ProductCategories.Dto;
using MyProject.ProductCategory;
using MyProject.Products;
using MyProject.Products.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ProductCategories
{
    public class ProductCategoryAppService : AsyncCrudAppService<ProductCategory, ProductCategoryDto, long, PagedProductCategoryResultRequestDto, CreateProductCategoryDto, ProductCategoryDto>, IProductCategoryAppService
    {
        public ProductCategoryAppService(IRepository<ProductCategory, long> repository) : base(repository)
        {
        }

    }
}
