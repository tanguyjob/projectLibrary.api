using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.Models;

namespace ProjectLibraryApiInMultiTier.Mappers
{
    public static class AuthorApiMapper
    {
        public static AuthorApiModel ToApi(this AuthorDTO author)
        {
            return new AuthorApiModel()
            {
                Id = author.Id,
                Name = author.Name,
                Firstname = author.Firstname,
                Birthdate = author.Birthdate
            };

        }
        public static AuthorDTO ToDto(this AuthorApiModel author)
        {
            return new AuthorDTO()
            {
                Id = author.Id,
                Name = author.Name,
                Firstname = author.Firstname,
                Birthdate = author.Birthdate,

            };
        }
    }
}
