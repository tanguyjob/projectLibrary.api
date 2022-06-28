using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.BLL.Mappers;
using ProjectLibraryApiInMultiTier.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.BLL.Services
{
    public class UserService
    {
        private IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }


        public UserDTO GetById(int id)
        {
            return userRepository.GetById(id)?.ToDTO();
        }

        public IEnumerable<UserDTO> GetAll()
        {
            return userRepository.GetAll().Select(b => b.ToDTO());
        }


        public bool Insert(UserDTO U)
        {
            return userRepository.Insert(U.ToEntity()) > 0;
        }

    }
}
