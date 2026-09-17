using Abp.Domain.Entities.Auditing;
using MyProject.ProductCategories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Products
{
    [Table("Jew_Product")]
    public class Product : FullAuditedEntity<long>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Material { get; set; }

        public ProductStatus Status { get; set; }

        public long CategoryId { get; set; }

        public virtual ProductCategory Category { get; set; }

        public virtual ICollection<ProductImage> Images { get; set; }

        public Product()
        {
            Images = new HashSet<ProductImage>();
        }
    }
}
