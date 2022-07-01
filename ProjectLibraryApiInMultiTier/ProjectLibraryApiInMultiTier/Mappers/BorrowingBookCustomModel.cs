using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.Models;

namespace ProjectLibraryApiInMultiTier.Mappers
{
    public static class BorrowingBookCustomApiMapper
    {
        public static BorrowingBookCustomModel ToApi(this BorrowingBookCustomDTO b)
        {
            return new BorrowingBookCustomModel()
            {
                BorrowingId = b.BorrowingId,
                DateBack = b.DateBack,
                DateBegin = b.DateBegin,
                Additional = b.Additional,
                CopyId = b.CopyId,
                Title = b.Title,
                Resume=b.Resume,
                PublicationDate = b.PublicationDate
            };

        }
        public static BorrowingBookCustomDTO ToDto(this BorrowingBookCustomModel b)
        {
            return new BorrowingBookCustomDTO()
            {
                BorrowingId = b.BorrowingId,
                DateBack = b.DateBack,
                DateBegin = b.DateBegin,
                Additional = b.Additional,
                CopyId = b.CopyId,
                Title = b.Title,
                Resume = b.Resume,
                PublicationDate = b.PublicationDate

            };
        }
    }
}
