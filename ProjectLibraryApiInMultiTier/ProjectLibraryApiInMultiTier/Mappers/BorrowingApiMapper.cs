using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.Models;

namespace ProjectLibraryApiInMultiTier.Mappers
{
    public static class BorrowingApiMapper
    {
        public static BorrowingApiModel ToApi(this BorrowingDTO dto)
        {
            return new BorrowingApiModel()
            {
                Id = dto.Id,
                DateBegin = dto.DateBegin,
                DateBack = dto.DateBack,
                Additional = dto.Additional,
                FK_Borrowing_Copy = dto.FK_Borrowing_Copy,
                FK_Borrowing_User = dto.FK_Borrowing_User
            };

        }
        public static BorrowingDTO ToDto(this BorrowingApiModel model)
        {
            return new BorrowingDTO()
            {
                Id = model.Id,
                DateBegin = model.DateBegin,
                DateBack = model.DateBack,
                Additional = model.Additional,
                FK_Borrowing_Copy = model.FK_Borrowing_Copy,
                FK_Borrowing_User = model.FK_Borrowing_User

            };
        }
    }
}
