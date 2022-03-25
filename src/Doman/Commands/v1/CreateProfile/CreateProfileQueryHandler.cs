using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Whodo.Profile.Doman.Interfaces.v1.Repository.Profile;

namespace Whodo.Profile.Doman.Commands.v1.CreateProfile
{
    public class CreateProfileQueryHandler : IRequestHandler<CreateProfileQuery, Unit>
    {
        IProfileRepository _profileRepository;
        IMapper _mapper;

        public CreateProfileQueryHandler(IMapper mapper, IProfileRepository ProfileRepository)
        {
            _mapper = mapper;
            _profileRepository = ProfileRepository;
        }

        public async Task<Unit> Handle(CreateProfileQuery request, CancellationToken cancellationToken)
        {
            await _profileRepository.CreateProfile(_mapper.Map<Entities.v1.Profile.Profile>(request));

            return Unit.Value;
        }
    }
}
