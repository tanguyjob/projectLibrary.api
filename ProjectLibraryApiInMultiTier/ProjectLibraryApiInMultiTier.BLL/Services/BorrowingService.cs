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
    public class BorrowingService
    {
        private IBorrowingRepository borrowingRepository;

        public BorrowingService (IBorrowingService borrowingService)
        {
            this.borrowingRepository = borrowingRepository;
        }

        public BorrowingDTO GetById(int id)
        {
            return borrowingRepository.GetById(id)?.ToDTO();
        }
        public IEnumerable<BorrowingDTO> GetAll()
        {
            return borrowingRepository.GetAll().Select(b => b.ToDTO());
        }

        public bool Insert(BorrowingDTO borrowing)
        {
            return borrowingRepository.Insert(borrowing.ToEntity()) > 0;
        }
    }
}
