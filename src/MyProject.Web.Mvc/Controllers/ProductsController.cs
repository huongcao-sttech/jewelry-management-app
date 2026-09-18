using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public ProductsController(IProductAppService productAppService, IProductCategoryAppService productCategoryAppService)
        {
            _productAppService = productAppService;
            _productCategoryAppService = productCategoryAppService;
        }

        // GET: ProductsController
        public async Task<ActionResult> Index(int page = 1, int pageSize = 5)
        {
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
            var categories = _productCategoryAppService.GetAllAsync(
                    new ProductCategories.Dto.PagedProductCategoryResultRequestDto()
                )
                .Result.Items;

            ViewBag.Categories = categories;

            return View(model);
        }

        // POST: ProductsController/Create
        public async Task<ActionResult> CreateProduct(CreateProductDto input)
        {
            await _productAppService.CreateAsync(input);

            return RedirectToAction("Index");
        }

        // GET: ProductsController/Edit/5
        public async Task<ActionResult> EditProductModal(long id)
        {
            var product = await _productAppService.GetProductById(id);

            // get categories into viewbag
            var categories = _productCategoryAppService.GetAllAsync(
                    new ProductCategories.Dto.PagedProductCategoryResultRequestDto()
                )
                .Result.Items;

            ViewBag.Categories = categories;

            return PartialView("_EditModal", product);
        }
    }
}
