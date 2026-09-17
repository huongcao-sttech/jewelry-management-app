using MyProject.Products.Dto;
using System;
using System.Collections.Generic;

namespace MyProject.Web.Models.Products
{
    public class ProductListViewModel
    {
        public IReadOnlyList<ProductDto> Products { get; set; }

        public int TotalCount { get; set; }

        public int CurrentPage { get; set; }

        public int PageSize { get; set; }

        public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
    }
}
