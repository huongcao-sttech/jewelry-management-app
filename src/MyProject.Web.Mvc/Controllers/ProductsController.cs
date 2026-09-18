using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProject.Authorization;
using MyProject.Controllers;
using MyProject.ProductCategory;
using MyProject.Products;
using MyProject.Products.Dto;
using MyProject.Web.Models.Products;
using System.Threading.Tasks;

namespace MyProject.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class ProductsController : MyProjectControllerBase
    {
        private readonly IProductAppService _productAppService;
        private readonly IProductCategoryAppService _productCategoryAppService;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(
            IProductAppService productAppService,
            IProductCategoryAppService productCategoryAppService,
            ILogger<ProductsController> logger)
        {
            _productAppService = productAppService;
            _productCategoryAppService = productCategoryAppService;
            _logger = logger;
        }

        // GET: ProductsController
        public async Task<ActionResult> Index(int page = 1, int pageSize = 5)
        {
            _logger.LogInformation($"[ProductsController] Loading Index view - Page: {page}, PageSize: {pageSize}");

            // get products with pagination
            var result = await _productAppService.GetAllAsync(
               new PagedProductResultRequestDto
               {
                   MaxResultCount = pageSize,
                   SkipCount = (page - 1) * pageSize
               }
           );

            var model = new ProductListViewModel
            {
                Products = result.Items,
                TotalCount = result.TotalCount,
                CurrentPage = page,
                PageSize = pageSize
            };

            // get categories into viewbag
            var categories = (await _productCategoryAppService.GetAllAsync(
                    new ProductCategories.Dto.PagedProductCategoryResultRequestDto()
                )).Items;

            ViewBag.Categories = categories;

            return View(model);
        }

        // POST: ProductsController/Create
        public async Task<ActionResult> CreateProduct(CreateProductDto input)
        {
            _logger.LogInformation($"[ProductsController] Received request to create product: '{input?.Title}'");

            await _productAppService.CreateAsync(input);

            return RedirectToAction("Index");
        }

        // GET: ProductsController/Edit/5
        public async Task<ActionResult> EditProductModal(long id)
        {
            _logger.LogInformation($"[ProductsController] Loading EditProductModal partial view for Product Id: {id}");

            var product = await _productAppService.GetProductById(id);

            // get categories into viewbag
            var categories = (await _productCategoryAppService.GetAllAsync(
                    new ProductCategories.Dto.PagedProductCategoryResultRequestDto()
                )).Items;

            ViewBag.Categories = categories;

            return PartialView("_EditModal", product);
        }
    }
}
