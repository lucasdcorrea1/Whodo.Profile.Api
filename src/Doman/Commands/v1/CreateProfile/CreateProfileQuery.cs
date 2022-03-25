
using MediatR;
using Whodo.Profile.Doman.Models.v1.Profile;

namespace Whodo.Profile.Doman.Commands.v1.CreateProfile
{
    public class CreateProfileQuery : IRequest<Unit>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long? Cpf { get; set; }
        public long? Cnpj { get; set; }
    }
}
