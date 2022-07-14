using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.BLL.Mappers
{
    internal static class BorrowingMapper
    {
        public static BorrowingDTO ToDTO(this BorrowingEntity entity)
        {
            return new BorrowingDTO()
            {
                Id = entity.Id,
                DateBegin = entity.DateBegin,
                DateBack = entity.DateBack,
                Additional = entity.Additional,
                FK_Borrowing_Copy = entity.FK_Borrowing_Copy,
                FK_Borrowing_User = entity.FK_Borrowing_User,

            };
        }

        public static BorrowingEntity ToEntity(this BorrowingDTO dto)
        {
            return new BorrowingEntity()
            {
                Id = dto.Id,
                DateBegin = dto.DateBegin,
                DateBack = dto.DateBack,
                Additional = dto.Additional,
                FK_Borrowing_Copy = dto.FK_Borrowing_Copy,
                FK_Borrowing_User = dto.FK_Borrowing_User,
            };
        }
    }
}
