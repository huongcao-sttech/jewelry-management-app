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
    public class CreateProductDto : EntityDto<long>
    {
    }
}
