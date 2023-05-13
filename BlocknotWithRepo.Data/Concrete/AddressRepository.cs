using BlocknotWithRepo.Data.Abstract;
using BlocknotWithRepo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocknotWithRepo.Data.Concrete
{
    internal class AddressRepository : IRepository<Address>
    {
        public void Add(Address record)
        {
            throw new NotImplementedException();
        }

        public void Delete(Address record)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Address> GetAll()
        {
            throw new NotImplementedException();
        }

        public Address GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Address record)
        {
            throw new NotImplementedException();
        }
    }
}
