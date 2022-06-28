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
    public class UserRepository : RepositoryBase<int, UserEntity>, IUserRepository
    {
        public UserRepository(Connection connection) : base(connection, "User", "Id")
        {

        }
        //ne pas oublié de rajouter phonePhone
        public override int Insert(UserEntity entity)
        {
            Command cmd = new Command($"INSERT INTO {TableName} (Name, Firstname, Birthdate, Email, Password, Phone, IsActive, FK_User_Address, FK_User_Subscription, FK_User_Profile)" +
               $" OUTPUT inserted.{TableId}" +
               " VALUES (@Name,@Firstname,@Birthdate,@Email,@Password,@Phone,@IsActive,@FK_User_Address,@FK_User_Subscription,@FK_User_Profile)");

            cmd.AddParameter("Name", entity.Name);
            cmd.AddParameter("Firstname", entity.Firstname);
            cmd.AddParameter("Birthdate", entity.Birthdate);
            cmd.AddParameter("Email", entity.Email);
            cmd.AddParameter("Password", entity.Password);
            cmd.AddParameter("Phone", entity.Phone);
            cmd.AddParameter("IsActive", entity.IsActive);
            cmd.AddParameter("FK_User_Address", entity.FK_User_Address);
            cmd.AddParameter("FK_User_Subscription", entity.FK_User_Subscription);
            cmd.AddParameter("FK_User_Profile", entity.FK_User_Profile);

            return (int)_Connection.ExecuteScalar(cmd);
        }

        public override bool Update(int id, UserEntity entity)
        {
            Command cmd = new Command($"UPDATE {TableName} " +
            " SET Name = @Name," +
            " SET Firstname = @Firstname," +
            " SET Birthdate = @Birthdate," +
            " SET Email = @Email," +
            " SET Password = @Password," +
            " SET Phone = @Phone," +
            " SET IsActive = @IsActive," +
            " SET FK_User_Address = @FK_User_Address," +
            " SET FK_User_Subscription = @FK_User_Subscription," +
            " SET FK_User_Profile = @FK_User_Profile," +
            $" WHERE {TableId} = @Id");

            cmd.AddParameter("Id", id);
            cmd.AddParameter("Name", entity.Name);
            cmd.AddParameter("Firstname", entity.Firstname);
            cmd.AddParameter("Birthdate", entity.Birthdate);
            cmd.AddParameter("Email", entity.Email);
            cmd.AddParameter("Password", entity.Password);
            cmd.AddParameter("Phone", entity.Phone);
            cmd.AddParameter("IsActive", entity.IsActive);
            cmd.AddParameter("FK_User_Address", entity.FK_User_Address);
            cmd.AddParameter("FK_User_Subscription", entity.FK_User_Subscription);
            cmd.AddParameter("FK_User_Profile", entity.FK_User_Profile);
       
            return _Connection.ExecuteNonQuery(cmd) == 1;
        }

        protected override UserEntity MapRecordToEntity(IDataRecord record)
        {
            return new UserEntity()
            {
                Id = (int)record[TableId],
                Name = (string)record["Name"],
                Firstname = (string)record["Firstname"],
                Birthdate = (DateTime)record["Birthdate"],
                Email = (string)record["Email"],
                Password = (string)record["Password"],
                Phone = (string)record["Phone"],
                IsActive = (bool)record["IsActive"],
                FK_User_Address = (int)record["FK_User_Address"],
                FK_User_Subscription = (int)record["FK_User_Subscription"],
                FK_User_Profile = (int)record["FK_User_Profile"],
             
            };
        }
    }
}
