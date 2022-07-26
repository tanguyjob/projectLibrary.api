using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.BLL.Mappers
{
    internal static class BookAuthorMapper
    {
        public static BookAuthorDTO ToDTO(this BookAuthorEntity entity)
        {
            return new BookAuthorDTO()
            {
                Id = entity.Id,
                BookId = entity.BookId,
                AuthorId=entity.AuthorId

            };
        }

        //Méthode d'extension
        public static BookAuthorEntity ToEntity(this BookAuthorDTO dto)
        {
            return new BookAuthorEntity()
            {
                Id = dto.Id,
                BookId = dto.BookId,
                AuthorId = dto.AuthorId
            };
        }
    }
}
