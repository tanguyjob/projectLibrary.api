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
    public class GenreRepository : RepositoryBase<int, GenreEntity>, IGenreRepository
    {
        public GenreRepository(Connection connection)
           : base(connection, "Genre", "Id")
        { }
        public override int Insert(GenreEntity entity)
        {
            Command cmd = new Command($"INSERT INTO {TableName}(Name)" +
                $" OUTPUT inserted.{TableId}" +
                " VALUES (@Name)");

            cmd.AddParameter("Name", entity.Name);

            return (int)_Connection.ExecuteScalar(cmd);
        }

        public override bool Update(int id, GenreEntity entity)
        {
            Command cmd = new Command($"UPDATE {TableName} " +
               " SET Name = @Name," +        
               $" WHERE {TableId} = @Id");

            cmd.AddParameter("Id", id);
            cmd.AddParameter("Name", entity.Name);
            

            return _Connection.ExecuteNonQuery(cmd) == 1;
        }

        protected override GenreEntity MapRecordToEntity(IDataRecord record)
        {
            return new GenreEntity()
            {
                Id = (int)record[TableId],
                Name = (string)record["Name"]
            };
        }
    }
}
