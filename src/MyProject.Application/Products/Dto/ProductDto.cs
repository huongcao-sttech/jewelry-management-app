using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Products.Dto
{
    [AutoMapFrom(typeof(Product))]
    public class ProductDto : EntityDto<long>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Material { get; set; }

        public ProductStatus Status { get; set; }

        public List<ProductImageDto> Images { get; set; }

        public ProductCategoryDto Category { get; set; }
    }
}
