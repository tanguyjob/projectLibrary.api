using ProjectLibraryApiInMultiTier.DAL.Entities;
using ProjectLibraryApiInMultiTier.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Connections;

namespace ProjectLibraryApiInMultiTier.DAL.Repositories
{
    public class BookAuthorCustomRepository : RepositoryBase<int, BookAuthorCustomEntity>, IBookAuthorCustomRepository
    {
        protected Connection _Connection { get; set; }

        public BookAuthorCustomRepository(Connection connection)
       : base(connection, "Book", "Id")
        {
            _Connection = connection;

        }
        public IEnumerable<BookAuthorCustomEntity> GetByBookId(int id)
        {
            Command cmd = new Command($"SelectBookAuthorById", true);
            cmd.AddParameter("Id", id);

            return (IEnumerable<BookAuthorCustomEntity>)_Connection.ExecuteReader(cmd, MapRecordToEntity);
        }

        protected override BookAuthorCustomEntity MapRecordToEntity(IDataRecord record)
        {
            return new BookAuthorCustomEntity()
            {
                BookId = (int)record["BookId"],
                Title = (string)record["Title"],
                Resume = (string)record["Resume"],
                PublicationDate = (DateTime)record["PublicationDate"],
                AuthorId = (int)record["AuthorId"],
                Firstname = (string)record["Firstname"],
                AuthorName = (string)record["AuthorName"],
                Birthdate = (DateTime)record["Birthdate"],
                GenreId = (int)record["GenreId"],
                GenreName=(string)record["GenreName"],
                LanguageName=(string)record["LanguageName"]


            };
        }

        public override int Insert(BookAuthorCustomEntity entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(int id, BookAuthorCustomEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
