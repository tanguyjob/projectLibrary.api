using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.BLL.Mappers
{
    internal static class AuthorMapper
    {
        public static AuthorDTO ToDTO(this AuthorEntity entity)
        {
            return new AuthorDTO()
            {
                Id = entity.Id,
                Name = entity.Name,
                Firstname = entity.Firstname,
                Birthdate = entity.Birthdate,
            };
        }

        public static AuthorEntity ToEntity(this AuthorDTO dto)
        {
            return new AuthorEntity()
            {
                Id = dto.Id,
                Name = dto.Name,
                Firstname = dto.Firstname,
                Birthdate = dto.Birthdate
            };
        }
    }
}
