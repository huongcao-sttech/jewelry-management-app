using Abp.Domain.Entities.Auditing;
using MyProject.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ProductCategories
{
    [Table("Jew_ProductCategory")]
    public class ProductCategory : FullAuditedEntity<long>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
