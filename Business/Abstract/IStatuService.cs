using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStatuService
    {
        void Add(Statu statu);
        void Delete(Statu statu);
        void Update(Statu statu);
        List<Statu> GetAll();
        Statu GetId(int statuId);
    }
}
