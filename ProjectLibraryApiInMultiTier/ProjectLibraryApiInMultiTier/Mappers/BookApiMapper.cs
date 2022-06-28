using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.Models;

namespace ProjectLibraryApiInMultiTier.Mappers
{
    public static class BookApiMapper
    {
        public static BookApiModel ToApi(this BookDTO book)
        {
            return new BookApiModel()
            {
                Id = book.Id,
                Title = book.Title,
                Resume = book.Resume,
                PublicationDate = book.PublicationDate,
                LanguageId = book.LanguageId
            };

        }
        public static BookDTO ToDto(this BookApiModel book)
        {
            return new BookDTO()
            {
                Id = book.Id,
                Title = book.Title,
                Resume = book.Resume,
                PublicationDate = book.PublicationDate,
                LanguageId = book.LanguageId

            };
        }
    }
}
