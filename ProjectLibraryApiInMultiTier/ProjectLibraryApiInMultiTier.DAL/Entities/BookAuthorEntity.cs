using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.DAL.Entities
{
    public class BookAuthorEntity
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public int AuthorId { get; set; }
    }
}
