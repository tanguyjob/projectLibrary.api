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
    public class BookAuthorRepository : RepositoryBase<int, BookAuthorEntity>, IBookAuthorRepository
    {
        public BookAuthorRepository(Connection connection) : base(connection, "BookAuthor", "Id")
        {
        }

        public override int Insert(BookAuthorEntity entity)
        {
            Command cmd = new Command($"INSERT INTO {TableName} (BookId,AuthorId)" +
                                        $" OUTPUT inserted.{TableId}" +
                                        $" VALUES (@BookId,@AuthorId)");

            cmd.AddParameter("BookId", entity.BookId);
            cmd.AddParameter("AuthorId", entity.AuthorId);

            int? rep = (int?)_Connection.ExecuteScalar(cmd);
            return rep ?? -1;
        }

        public override bool Update(int id, BookAuthorEntity entity)
        {
            throw new NotImplementedException();
        }

        protected override BookAuthorEntity MapRecordToEntity(IDataRecord record)
        {
            return new BookAuthorEntity()
            {
                Id = (int)record[TableId],
                BookId = (int)record["BookId"],
                AuthorId = (int)record["AuthorId"]
            };
        }
    }
}
