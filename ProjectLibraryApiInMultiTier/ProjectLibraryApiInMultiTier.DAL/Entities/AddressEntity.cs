using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.DAL.Entities
{
    public class AddressEntity
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string? Box { get; set; }
    }
}
