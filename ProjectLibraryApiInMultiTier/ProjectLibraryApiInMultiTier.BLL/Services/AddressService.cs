using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.BLL.Mappers;
using ProjectLibraryApiInMultiTier.DAL.Interfaces;
using ProjectLibraryApiInMultiTier.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.BLL.Services
{
    public class AddressService
    {
        private IAddessRepository addressRepository;

        public AddressService(IAddessRepository addressRepository)
        {
            this.addressRepository = addressRepository;
        }


        public AddressDTO GetById(int id)
        {
            return addressRepository.GetById(id)?.ToDTO();
        }
    

        public IEnumerable<AddressDTO> GetAll()
        {
            return addressRepository.GetAll().Select(b => b.ToDTO());
        }


        public bool Insert(AddressDTO address)
        {
            return addressRepository.Insert(address.ToEntity()) > 0;
        }
    }
}
