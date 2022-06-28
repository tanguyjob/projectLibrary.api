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
    public class AuthorRepository : RepositoryBase<int, AuthorEntity>, IAuthorRepository
    {
        public AuthorRepository(Connection connection) : base(connection, "Author", "Id")
        {
        }

        public override int Insert(AuthorEntity entity)
        {
            Command cmd = new Command($"INSERT INTO {TableName} (Name,Firstname, Birthdate)" +
               $" OUTPUT inserted.{TableId}" +
               " VALUES (@Name,@Firstname, @Birthdate)");

            cmd.AddParameter("Name", entity.Name);
            cmd.AddParameter("Firstname", entity.Firstname);
            cmd.AddParameter("Birthdate", entity.Birthdate);
        

            int? rep = (int?)_Connection.ExecuteScalar(cmd);

            return rep ?? -1;
        }

        public override bool Update(int id, AuthorEntity entity)
        {
            Command cmd = new Command($"UPDATE {TableName}" +
               " SET Name = @Name," +
               "     Firstname = @Firstname," +
               "     Birthdate = @Birthdate" +
               $" WHERE {TableId} = @Id");


            cmd.AddParameter("Id", entity.Id);
            cmd.AddParameter("Name", entity.Name);
            cmd.AddParameter("Firstname", entity.Firstname);
            cmd.AddParameter("Birthdate", entity.Birthdate);

            return _Connection.ExecuteNonQuery(cmd) == 1;
        }

        protected override AuthorEntity MapRecordToEntity(IDataRecord record)
        {
            return new AuthorEntity()
            {
                Id = (int)record[TableId],
                Name = (string)record["Name"],
                Firstname = (string)record["Firstname"],
                Birthdate = (DateTime)record["Birthdate"],
              
            };
        }
    }
}
