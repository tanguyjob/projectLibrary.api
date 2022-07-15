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
    public class BookRepository : RepositoryBase<int, BookEntity>, IBookRepository
    {
        public BookRepository(Connection connection)
           : base(connection, "Book", "Id")
        { }

        public IEnumerable<BookEntity> GetBookByAuthorId(int id)
        {
            Command cmd = new Command($"Select b.Id,b.Title, b.[Resume],b.PublicationDate, b.LanguageId from Book b join BookAuthor ba on b.Id = ba.Id join Author a on a.Id= ba.AuthorId where ba.AuthorId=@id");

            cmd.AddParameter("id",id);

            return _Connection.ExecuteReader(cmd, MapRecordToEntity);

        }
        public override int Insert(BookEntity entity)
        {
            Command cmd = new Command($"INSERT INTO {TableName} (Title,Resume, PublicationDate, LanguageId)" +
                $" OUTPUT inserted.{TableId}" +
                " VALUES (@Name,@Resume, @PublicationDate, @LanguageId)");

            cmd.AddParameter("Name", entity.Title);
            cmd.AddParameter("Resume", entity.Resume);
            cmd.AddParameter("PublicationDate", entity.PublicationDate);
            cmd.AddParameter("LanguageId", entity.LanguageId);

            int? rep = (int?)_Connection.ExecuteScalar(cmd);

            return rep ?? -1;
        }




        public override bool Update(int id, BookEntity entity)
        {
            Command cmd = new Command($"UPDATE {TableName}" +
               " SET Title = @Name," +
               "     Resume = @Resume," +
               "     PublicationDate = @PublicationDate," +
               "     LanguageId = @LanguageId," +
               $" WHERE {TableId} = @Id");

            
            cmd.AddParameter("Id", entity.Id);
            cmd.AddParameter("Name", entity.Title);
            cmd.AddParameter("Resume", entity.Resume);
            cmd.AddParameter("PublicationDate", entity.PublicationDate);
            cmd.AddParameter("LanguageId", entity.LanguageId);

            return _Connection.ExecuteNonQuery(cmd) == 1;
        }

        protected override BookEntity MapRecordToEntity(IDataRecord record)
        {
            return new BookEntity()
            {
                Id = (int)record[TableId],
                Title = (string)record["Title"],
                Resume = (string)record["Resume"],
                PublicationDate = (DateTime)record["PublicationDate"],
                LanguageId = (int)record["LanguageId"]
            };
        }
    }
}
