using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyProject.Products.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Products
{
    public interface IProductAppService : IAsyncCrudAppService<ProductDto, long, PagedProductResultRequestDto, CreateProductDto, UpdateProductDto>
    {
        Task<PagedResultDto<ProductDto>> GetAllAsync(PagedProductResultRequestDto input);
        Task<ProductDto> CreateProduct(CreateProductDto input);
        Task<ProductDto> UpdateProduct(UpdateProductDto input);
        Task<ProductDto> GetProductById(long id);
    }
}
