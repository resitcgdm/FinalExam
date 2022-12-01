using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMissionService
    {
        void Add(Mission mission);
        void Delete(Mission mission);
        void Update(Mission mission);
        List<Mission> GetAll();
        Mission GetId(int missionId);
    }
}
