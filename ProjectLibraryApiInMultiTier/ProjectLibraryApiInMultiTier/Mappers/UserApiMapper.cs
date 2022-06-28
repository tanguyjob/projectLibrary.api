using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.Models;

namespace ProjectLibraryApiInMultiTier.Mappers
{
    public static class UserApiMapper
    {
        public static UserApiModel ToApi(this UserDTO user)
        {
            return new UserApiModel()
            {
                Id = user.Id,
                Name = user.Name,
                Firstname = user.Firstname,
                Birthdate = user.Birthdate,
                Email = user.Email,
                Password=user.Password,
                Phone = user.Phone,
                IsActive = user.IsActive,
                FK_User_Address = user.FK_User_Address,
                FK_User_Subscription = user.FK_User_Subscription,
                FK_User_Profile = user.FK_User_Profile
            };

        }
        public static UserDTO ToDto(this UserApiModel user)
        {
            return new UserDTO()
            {
                Id = user.Id,
                Name = user.Name,
                Firstname = user.Firstname,
                Birthdate = user.Birthdate,
                Email = user.Email,
                Password=user.Password,
                Phone = user.Phone,
                IsActive = user.IsActive,
                FK_User_Address = user.FK_User_Address,
                FK_User_Subscription = user.FK_User_Subscription,
                FK_User_Profile = user.FK_User_Profile

            };
        }
    }
}
