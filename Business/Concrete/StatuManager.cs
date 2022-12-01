using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StatuManager:IStatuService
    {
        IStatuDal _statuDal;
        public StatuManager(IStatuDal statuDal)
        {
            _statuDal = statuDal;
        }
        public void Add(Statu statu)
        {
            _statuDal.Add(statu);
        }

        public void Delete(Statu statu)
        {
            _statuDal.Delete(statu);
        }

        public List<Statu> GetAll()
        {
            return _statuDal.GetAll();
        }

        public Statu GetId(int statuId)
        {
            return _statuDal.GetId(statuId);
        }

        public void Update(Statu statu)
        {
            _statuDal.Update(statu);
        }
    }
}
