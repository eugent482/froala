using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SiteProduct.DAL.Entities
{
    [Table("tblProductDescriptionImages")]
    public class ProductDescriptionImage
    {
        [Key]
        [StringLength(150)]
        public string Name { get; set; }
        [ForeignKey("Product")]
        public int ? ProductId { get; set; }
        public virtual Product Product { get; set; }
        public DateTime LoadDate { get; set; }
    }
}