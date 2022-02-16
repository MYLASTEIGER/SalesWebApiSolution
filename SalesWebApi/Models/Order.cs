using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApi.Models {
    public class Order {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(80)]
        public string Description { get; set; }
        [Required]
        public bool Shipped { get; set; }
        [Column(TypeName = "decimal(7,2)")]
        public decimal Total { get; set; }

        public Order() {

        }
    }
}
