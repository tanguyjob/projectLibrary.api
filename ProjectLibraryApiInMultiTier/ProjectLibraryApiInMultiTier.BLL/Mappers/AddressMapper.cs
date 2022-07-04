using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.BLL.Mappers
{
    internal static class AddressMapper
    {
        public static AddressDTO ToDTO(this AddressEntity entity)
        {
            return new AddressDTO()
            {
                Id = entity.Id,
                City = entity.City,
                PostCode = entity.PostCode,
                Street = entity.Street,
                Number = entity.Number,
                Box = entity.Box,

            };
        }

        public static AddressEntity ToEntity(this AddressDTO dto)
        {
            return new AddressEntity()
            {
                Id = dto.Id,
                City = dto.City,
                PostCode = dto.PostCode,
                Street = dto.Street,
                Number = dto.Number,
                Box = dto.Box,
            };
        }
    }
}
