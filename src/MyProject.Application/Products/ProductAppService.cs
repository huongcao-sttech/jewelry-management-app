using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<ProductAppService> _logger;

        public ProductAppService(
            IRepository<Product, long> repository,
            ILogger<ProductAppService> logger) : base(repository)
        {
            _logger = logger;
        }

        // get all products
        public override async Task<PagedResultDto<ProductDto>> GetAllAsync(PagedProductResultRequestDto input)
        {
            _logger.LogInformation($"[Products] Fetching products list - SkipCount: {input.SkipCount}, MaxResultCount: {input.MaxResultCount}");

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

            _logger.LogInformation($"[Products] Successfully retrieved {items.Count} products out of {totalCount} total.");

            return new PagedResultDto<ProductDto>(
                totalCount,
                items
            );
        }

        public override async Task<ProductDto> UpdateAsync(UpdateProductDto input)
        {
            _logger.LogInformation($"[Products] Updating product Id: {input.Id}");

            // find product by id with category and images
            var product = await Repository.GetAllIncluding(x => x.Category, x => x.Images)
               .FirstOrDefaultAsync(x => x.Id == input.Id);

            if (product == null)
            {
                _logger.LogWarning($"[Products] Product with Id: {input.Id} not found for update.");
                throw new EntityNotFoundException(typeof(Product), input.Id);
            }

            // update product properties
            ObjectMapper.Map(input, product);

            await CurrentUnitOfWork.SaveChangesAsync();

            _logger.LogInformation($"[Products] Successfully updated product Id: {product.Id}");

            return ObjectMapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> GetProductById(long id)
        {
            _logger.LogInformation($"[Products] Getting product details for Id: {id}");

            var product = await Repository.GetAllIncluding(x => x.Category, x => x.Images)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (product == null)
            {
                _logger.LogWarning($"[Products] Product with Id: {id} not found.");
                throw new EntityNotFoundException(typeof(Product), id);
            }

            return ObjectMapper.Map<ProductDto>(product);
        }

        public async override Task<ProductDto> CreateAsync(CreateProductDto input)
        {
            _logger.LogInformation($"[Products] Creating new product with Title: '{input.Title}', CategoryId: {input.CategoryId}");

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
            await CurrentUnitOfWork.SaveChangesAsync();

            _logger.LogInformation($"[Products] Successfully created product with Id: {result.Id}");

            return ObjectMapper.Map<ProductDto>(result);
        }

        public override async Task DeleteAsync(EntityDto<long> input)
        {
            _logger.LogInformation($"[Products] Request to delete product Id: {input.Id}");

            // find product by id with images
            var product = Repository.GetAllIncluding(x => x.Images)
                .FirstOrDefault(x => x.Id == input.Id);

            if (product == null)
            {
                _logger.LogWarning($"[Products] Product with Id: {input.Id} not found for deletion.");
                throw new EntityNotFoundException(typeof(Product), input.Id);
            }

            // delete product
            await Repository.DeleteAsync(product);

            _logger.LogInformation($"[Products] Successfully deleted product Id: {input.Id}");
        }
    }
}
