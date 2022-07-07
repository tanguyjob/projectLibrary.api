using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.Models;

namespace ProjectLibraryApiInMultiTier.Mappers
{
    public static class BookAuthorCustomApiMapper
    {
        public static BookAuthorCustomApiModel ToApi(this BookAuthorCustomDTO dto)
        {
            return new BookAuthorCustomApiModel()
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
        public static BookAuthorCustomDTO ToDto(this BookAuthorCustomApiModel model)
        {
            return new BookAuthorCustomDTO()
            {
                BookId = model.BookId,
                Title = model.Title,
                Resume = model.Resume,
                PublicationDate = model.PublicationDate,
                AuthorId = model.AuthorId,
                Firstname = model.Firstname,
                AuthorName = model.AuthorName,
                Birthdate = model.Birthdate,
                GenreId = model.GenreId,
                GenreName = model.GenreName,
                LanguageName = model.LanguageName

            };
        }
    }
}
