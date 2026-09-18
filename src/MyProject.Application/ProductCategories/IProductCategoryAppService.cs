using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyProject.ProductCategories.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ProductCategory
{
    public interface IProductCategoryAppService : IAsyncCrudAppService<ProductCategoryDto, long, PagedProductCategoryResultRequestDto, CreateProductCategoryDto, ProductCategoryDto>
    {
        Task<PagedResultDto<ProductCategoryDto>> GetAllAsync(PagedProductCategoryResultRequestDto input);
    }
}
