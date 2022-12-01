using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOwnerService
    {
        void Add(Owner owner);
        void Delete(Owner owner);
        void Update(Owner owner);
        List<Owner> GetAll();
        Owner GetId(int ownerId);
    }
}
