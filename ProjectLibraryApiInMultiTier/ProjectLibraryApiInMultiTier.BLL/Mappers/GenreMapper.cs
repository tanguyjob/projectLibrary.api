using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.BLL.Mappers
{
    internal static class GenreMapper
    {

        public static GenreDTO ToDTO(this GenreEntity entity)
        {
            return new GenreDTO()
            {
                Id = entity.Id,
                Name = entity.Name,
            
            };
        }

        public static GenreEntity ToEntity(this GenreDTO dto)
        {
            return new GenreEntity()
            {
                Id = dto.Id,
                Name = dto.Name,
               
            };
        }

    }
}
