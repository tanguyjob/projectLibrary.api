using ProjectLibraryApiInMultiTier.BLL.DTO;
using ProjectLibraryApiInMultiTier.BLL.Mappers;
using ProjectLibraryApiInMultiTier.DAL.Interfaces;
using ProjectLibraryApiInMultiTier.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.BLL.Services
{
    public class BorrowingBookCustomService
    {
        private IBorrowingBookCustom Repository;
        public BorrowingBookCustomService(IBorrowingBookCustom Repository)
        {
            this.Repository = Repository;
        }
        public IEnumerable<BorrowingBookCustomDTO> GetByCustomerId(int id)
        {
            return Repository.GetByCustumerId(id)?.Select(b => b.ToDTO());
        }
    }
}
