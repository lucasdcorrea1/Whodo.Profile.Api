using System;
using System.Linq;
using System.Threading.Tasks;
using Whodo.Profile.CrossCutting.Base.DapperBase;
using Whodo.Profile.Doman.Interfaces.v1.Repository.Profile;

namespace Whodo.Profile.Infrastructure.Data.v1.Sql.Repositories.Profile
{
    public class ProfileRepository: DapperBaseRepository<Doman.Entities.v1.Profile.Profile>, IProfileRepository
    {

        public async Task<Doman.Entities.v1.Profile.Profile> GetProfileById(long id)
        {
            return await QueryFirstOrDefaultAsync($@"SELECT * FROM [Profile] WHERE Id = @Id", new {id});
        }

        public async Task<Doman.Entities.v1.Profile.Profile> GetProfileByEmail(string email)
        {
            return await QueryFirstOrDefaultAsync($@"SELECT * FROM [Profile] WHERE Email = @Email", new { Email = email });
        }

        public async Task<int> CreateProfile(Doman.Entities.v1.Profile.Profile profile)
        {
            var stringSql = $@"INSERT INTO [Profile]
                                   ([Name]
                                    ,[Email]
                                    ,[Password]
                                    ,[Active]
                                    ,[CreationDate]
                                    ,[LastUpdateDate]
                                    ,[Cpf]
                                    ,[Cnpj])
                               VALUES
                                   (@Name
                                    ,@Email
                                    ,@Password
                                    ,@Active
                                    ,@CreationDate
                                    ,@LastUpdateDate
                                    ,@Cpf
                                    ,@Cnpj)";

            var rownsAffected = await ExecuteAsync(stringSql, profile);

            return rownsAffected;
        }

        public async Task<int> UpdateProfile(Doman.Entities.v1.Profile.Profile profile)
        {
            var stringSql = $@"UPDATE [Profile] SET
                                     [Name] = @Name
                                    ,[Email] = @Email
                                    ,[Password] = @Password
                                    ,[Active] = @Active
                                    ,[CreationDate] = @CreationDate
                                    ,[LastUpdateDate] = @LastUpdateDate
                                    ,[Cpf] = @Cpf
                                    ,[Cnpj] = @Cnpj
                               WHERE [Id] = @Id";

            var rownsAffected = await ExecuteAsync(stringSql, profile);

            return rownsAffected;
        }
    }
}
