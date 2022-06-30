using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.DAL.Entities
{
    public class BorrowingBookCustomEntity
    {
        public int BorrowingId { get; set; }
        public DateTime DateBack { get; set; }
        public DateTime DateBegin { get; set; }
        public bool Additional { get; set; }
        public int CopyId { get; set; }
        public string title { get; set; }
        public string Resume { get; set; }
        public DateTime PublicationDate { get; set; }

    }
}
