using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.Models;

namespace ProjectLibraryApiInMultiTier.Mappers
{
    public static class LanguageApiMapper
    {
        public static LanguageApiModel ToApi(this LanguageDTO dto)
        {
            return new LanguageApiModel()
            {
                Id = dto.Id,
                Name = dto.Name
            };

        }
        public static LanguageDTO ToDto(this LanguageApiModel model)
        {
            return new LanguageDTO()
            {
                Id = model.Id,
                Name=model.Name
            };
        }
    }
}
