using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Whodo.Profile.Doman.Interfaces.v1.Repository.Profile;

namespace Whodo.Profile.Doman.Queries.v1.GetProfile
{
    public class GetProfileQueryHandler : IRequestHandler<GetProfileQuery, GetProfileQueryResponse>
    {
        IProfileRepository _profileRepository;
        IMapper _mapper;

        public GetProfileQueryHandler(IMapper mapper, IProfileRepository ProfileRepository)
        {
            _mapper = mapper;
            _profileRepository = ProfileRepository;
        }

        public async Task<GetProfileQueryResponse> Handle(GetProfileQuery request, CancellationToken cancellationToken)
        {
            var response = await _profileRepository.GetProfileByEmail(request.Email);

            return _mapper.Map<GetProfileQueryResponse>(response);
        }
    }
}
