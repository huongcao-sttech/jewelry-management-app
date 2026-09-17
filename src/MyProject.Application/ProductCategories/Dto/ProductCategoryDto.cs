using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ProductCategories.Dto
{
    [AutoMapFrom(typeof(ProductCategory))]
    public class ProductCategoryDto : EntityDto<long>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
