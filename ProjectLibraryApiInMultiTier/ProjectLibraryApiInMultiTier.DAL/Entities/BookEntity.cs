using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryApiInMultiTier.DAL.Entities
{
    public class BookEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Resume { get; set; }
        public DateTime PublicationDate { get; set; }
        public int LanguageId { get; set; }
    }
}
