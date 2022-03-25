using System.Threading.Tasks;

namespace Whodo.Profile.Doman.Interfaces.v1.Repository.Profile
{
    public interface IProfileRepository
    {
        Task<Entities.v1.Profile.Profile> GetProfileById(long id);
        Task<Entities.v1.Profile.Profile> GetProfileByEmail(string email);
        Task<int> CreateProfile(Entities.v1.Profile.Profile profile);
        Task<int> UpdateProfile(Entities.v1.Profile.Profile profile);
    }
}
