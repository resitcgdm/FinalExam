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
    public class MissionManager : IMissionService
    {
        IMissionDal _missionDal;
        public MissionManager(IMissionDal missionDal)
        {
            _missionDal = missionDal;
        }
        public void Add(Mission mission)
        {
             _missionDal.Add(mission);
        }

        public void Delete(Mission mission)
        {
            _missionDal.Add(mission);
        }

        public List<Mission> GetAll()
        {
            return _missionDal.GetAll();
        }

        public Mission GetId(int missionId)
        {
            return _missionDal.GetId(missionId);
        }

        public void Update(Mission mission)
        {
            _missionDal.Add(mission);
        }
    }
}
