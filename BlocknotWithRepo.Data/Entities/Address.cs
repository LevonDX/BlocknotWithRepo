using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocknotWithRepo.Data.Entities
{
    public class Address : EntityBase
    {
        public string Street { get; set; }
        public string City { get; set; }
    }
}
