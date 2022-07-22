using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.BLL.Mappers
{
    internal static class LanguageMapper
    {
        public static LanguageDTO ToDTO(this LanguageEntity entity)
        {
            return new LanguageDTO()
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }

        public static LanguageEntity ToEntity(this LanguageDTO dto)
        {
            return new LanguageEntity()
            {
                Id = dto.Id,
                Name = dto.Name,
            };
        }
    }
}
