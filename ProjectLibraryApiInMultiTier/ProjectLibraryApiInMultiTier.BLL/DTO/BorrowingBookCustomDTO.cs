using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.BLL.DTO
{
    public class BorrowingBookCustomDTO
    {
        public int BorrowingId { get; set; }
        public DateTime DateBack { get; set; }
        public DateTime DateBegin { get; set; }
        public bool Additional { get; set; }
        public int CopyId { get; set; }
        public string Title { get; set; }
        public string Resume { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}
