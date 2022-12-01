using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Mission
    {
        [Key]
        public int TaskId { get; set; }  //Task entity ismini verince context'te dbsetlerde hata verdigi icin ismini mission yaptım
        public string Title { get; set; }
        public string Description { get; set; }
        public int OwnerId { get; set; }
        public virtual Owner Owner { get; set; }
        public int StatuId { get; set; }
        public virtual Statu Statu { get; set; }
    

    }
}
