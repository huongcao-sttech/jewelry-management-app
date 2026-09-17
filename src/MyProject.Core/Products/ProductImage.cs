using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Products
{
    [Table("Jew_ProductImage")]
    public class ProductImage : FullAuditedEntity<long>
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public long ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
