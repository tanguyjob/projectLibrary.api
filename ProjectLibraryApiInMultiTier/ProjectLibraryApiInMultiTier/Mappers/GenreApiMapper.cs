using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.Models;

namespace ProjectLibraryApiInMultiTier.Mappers
{
    public static class GenreApiMapper
    {
        public static GenreApiModel ToApi(this GenreDTO genre)
        {
            return new GenreApiModel()
            {
                Id = genre.Id,
                Name = genre.Name,
            };

        }


        public static GenreDTO ToDto(this GenreApiModel genre)
        {
            return new GenreDTO()
            {
                Id = genre.Id,
                Name = genre.Name,
              
            };
        }
    }
}
