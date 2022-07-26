using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.Models;

namespace ProjectLibraryApiInMultiTier.Mappers
{
    public static class BookAuthorApiMapper
    {
        public static BookAuthorApiModel ToApi(this BookAuthorDTO dto)
        {
            return new BookAuthorApiModel()
            {
                Id = dto.Id,
                BookId = dto.BookId,
                AuthorId = dto.AuthorId
            };

        }
        public static BookAuthorDTO ToDto(this BookAuthorApiModel model)
        {
            return new BookAuthorDTO()
            {
                Id = model.Id,
                BookId = model.BookId,
                AuthorId = model.AuthorId

            };
        }
    }
}
