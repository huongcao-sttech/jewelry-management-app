using MyProject.Products.Dto;
using System.Collections.Generic;

namespace MyProject.Web.Models.Products
{
    public class ProductListViewModel
    {
        public IReadOnlyList<ProductDto> Products { get; set; }
    }
}
