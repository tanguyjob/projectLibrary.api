using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.BLL.Mappers
{
    internal static class UserMapper
    {
        public static UserDTO ToDTO(this UserEntity entity)
        {
            return new UserDTO()
            {
                Id = entity.Id,
                Name = entity.Name,
                Firstname = entity.Firstname,
                Birthdate = entity.Birthdate,
                Email = entity.Email,
                Password = entity.Password,
                Phone = entity.Phone,
                IsActive = entity.IsActive,
                FK_User_Address = entity.FK_User_Address,
                FK_User_Subscription = entity.FK_User_Subscription,
                FK_User_Profile = entity.FK_User_Profile
            };
        }

        public static UserEntity ToEntity(this UserDTO dto)
        {
            return new UserEntity()
            {
                Id = dto.Id,
                Name = dto.Name,
                Firstname = dto.Firstname,
                Birthdate = dto.Birthdate,
                Email = dto.Email,
                Password = dto.Password,
                Phone = dto.Phone,
                IsActive = dto.IsActive,
                FK_User_Address = dto.FK_User_Address,
                FK_User_Subscription = dto.FK_User_Subscription,
                FK_User_Profile = dto.FK_User_Profile
            };
        }
    }
}
