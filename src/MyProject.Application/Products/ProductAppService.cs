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
    public class ProductAppService : AsyncCrudAppService<Product, ProductDto, long, PagedProductResultRequestDto, CreateProductDto, UpdateProductDto>, IProductAppService
    {
        public ProductAppService(IRepository<Product, long> repository) : base(repository)
        {
        }

        // create product
        public async Task<ProductDto> CreateProduct(CreateProductDto input)
        {
            var product = new Product
            {
                Title = input.Title,
                Description = input.Description,
                Material = input.Material,
                Status = input.Status,
                CategoryId = input.CategoryId,
                Images = input.Images?.Select(x => new ProductImage
                {
                    Url = x.Url,
                }).ToList()
            };
            var result = await Repository.InsertAsync(product);

            return ObjectMapper.Map<ProductDto>(result);
        }

        // get all products
        public override async Task<PagedResultDto<ProductDto>> GetAllAsync(PagedProductResultRequestDto input)
        {
            // query products with category and images
            var query = await Repository
                .GetAllIncludingAsync(
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

        public async Task<ProductDto> GetProductById(long id)
        {
            var product = await Repository.GetAllIncluding(x => x.Category, x => x.Images)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (product == null)
            {
                throw new Exception($"Product with id {id} not found");
            }

            return ObjectMapper.Map<ProductDto>(product);
        }

        // update product
        public async Task<ProductDto> UpdateProduct(UpdateProductDto input)
        {
            // find product by id with category and images
            var product = await Repository.GetAllIncluding(x => x.Category, x => x.Images)
               .FirstOrDefaultAsync(x => x.Id == input.Id);

            if (product == null)
            {
                throw new Exception($"Product with id {input.Id} not found");
            }

            ObjectMapper.Map(input, product);

            var result =  await Repository.UpdateAsync(product);

            return ObjectMapper.Map<ProductDto>(result);
        }
    }
}
