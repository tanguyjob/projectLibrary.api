using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.BLL.Mappers
{
    internal static class BorrowingBookCustomMapper
    {
        public static BorrowingBookCustomDTO ToDTO(this BorrowingBookCustomEntity entity)
        {
            return new BorrowingBookCustomDTO()
            {
                BorrowingId = entity.BorrowingId,
                DateBack = entity.DateBack,
                DateBegin = entity.DateBegin,
                Additional = entity.Additional,
                CopyId = entity.CopyId,
                Title = entity.Title,
                Resume = entity.Resume,
                PublicationDate = entity.PublicationDate

            };
        }

        //Méthode d'extension
        public static BorrowingBookCustomEntity ToEntity(this BorrowingBookCustomDTO dto)
        {
            return new BorrowingBookCustomEntity()
            {
                BorrowingId = dto.BorrowingId,
                DateBack = dto.DateBack,
                DateBegin = dto.DateBegin,
                CopyId = dto.CopyId,
                Title = dto.Title,
                Resume = dto.Resume,
                PublicationDate = dto.PublicationDate

            };
        }
    }
}
