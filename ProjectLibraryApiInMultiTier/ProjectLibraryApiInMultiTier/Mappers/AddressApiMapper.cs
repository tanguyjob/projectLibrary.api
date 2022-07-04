using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.Models;

namespace ProjectLibraryApiInMultiTier.Mappers
{
    public static class AddressApiMapper
    {
        public static AddressApiModel ToApi(this AddressDTO author)
        {
            return new AddressApiModel()
            {
                Id = author.Id,
                City = author.City,
                PostCode = author.PostCode,
                Street = author.Street,
                Number = author.Number,
                Box = author.Box
            };

        }
        public static AddressDTO ToDto(this AddressApiModel author)
        {
            return new AddressDTO()
            {
                Id = author.Id,
                City = author.City,
                PostCode = author.PostCode,
                Street = author.Street,
                Number= author.Number,
                Box= author.Box

            };
        }
    }
}
