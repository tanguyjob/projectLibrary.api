using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.BLL.Mappers
{
   
        internal static class BookMapper
        {

            public static BookDTO ToDTO(this BookEntity entity)
            {
                return new BookDTO()
                {
                    Id = entity.Id,
                    Title = entity.Title,
                    Resume = entity.Resume,
                    PublicationDate = entity.PublicationDate,
                    LanguageId= entity.LanguageId

                };
            }

        //Méthode d'extension
            public static BookEntity ToEntity(this BookDTO dto)
            {
                return new BookEntity()
                {
                    Id = dto.Id,
                    Title = dto.Title,
                    Resume = dto.Resume,
                    PublicationDate = dto.PublicationDate,
                    LanguageId = dto.LanguageId

                };
            }

        
    }
}
