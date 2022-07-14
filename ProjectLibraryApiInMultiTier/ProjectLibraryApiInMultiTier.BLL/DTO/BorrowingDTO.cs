using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.BLL.DTO
{
    public class BorrowingDTO
    {
        public int Id { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime? DateBack { get; set; }
        public bool? Additional { get; set; }
        public int FK_Borrowing_Copy { get; set; }
        public int FK_Borrowing_User { get; set; }
    }
}
