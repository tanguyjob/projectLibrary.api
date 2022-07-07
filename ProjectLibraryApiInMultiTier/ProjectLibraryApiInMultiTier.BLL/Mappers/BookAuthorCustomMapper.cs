using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.BLL.Mappers
{
    internal static class BookAuthorCustomMapper
    {
        public static BookAuthorCustomDTO ToDTO(this BookAuthorCustomEntity entity)
        {
            return new BookAuthorCustomDTO()
            {
                BookId = entity.BookId,
                Title = entity.Title,
                Resume = entity.Resume,
                PublicationDate = entity.PublicationDate,
                AuthorId = entity.AuthorId,
                Firstname = entity.Firstname,
                AuthorName = entity.AuthorName,
                Birthdate = entity.Birthdate,
                GenreId= entity.GenreId,
                GenreName = entity.GenreName,
                LanguageName = entity.LanguageName
            };
        }

        //Méthode d'extension
        public static BookAuthorCustomEntity ToEntity(this BookAuthorCustomDTO dto)
        {
            return new BookAuthorCustomEntity()
            {
                BookId = dto.BookId,
                Title = dto.Title,
                Resume = dto.Resume,
                PublicationDate = dto.PublicationDate,
                AuthorId = dto.AuthorId,
                Firstname = dto.Firstname,
                AuthorName = dto.AuthorName,
                Birthdate = dto.Birthdate,
                GenreId = dto.GenreId,
                GenreName = dto.GenreName,
                LanguageName = dto.LanguageName
            };
        }
    }
}
