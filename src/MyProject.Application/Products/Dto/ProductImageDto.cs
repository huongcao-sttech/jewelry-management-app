using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Products.Dto
{
    [AutoMapFrom(typeof(ProductImage))]
    public class ProductImageDto : EntityDto<long>
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public long ProductId { get; set; }
    }
}
