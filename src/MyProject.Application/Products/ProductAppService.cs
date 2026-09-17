using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using MyProject.Products.Dto;
using MyProject.Sessions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Products
{
    public class ProductAppService : AsyncCrudAppService<Product, ProductDto, long, PagedProductResultRequestDto, CreateProductDto, ProductDto>, IProductAppService
    {
        public ProductAppService(IRepository<Product, long> repository) : base(repository)
        {
        }
        // get all products
        public override async Task<PagedResultDto<ProductDto>> GetAllAsync(PagedProductResultRequestDto input)
        {
            // query products with category and images
            var query = Repository
                .GetAllIncluding(
                    x => x.Category,
                    x => x.Images
                );

            // get total count of products
            var totalCount = await query.CountAsync();

            var products = await query
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount)
                .ToListAsync();

            var items = ObjectMapper.Map<List<ProductDto>>(products);

            return new PagedResultDto<ProductDto>(
                totalCount,
                items
            );
        }
    }
}
