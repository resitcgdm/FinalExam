using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Statu
    {
        [Key]
        public int StatuId { get; set; }
        public string Situtation { get; set; }
    }
}
