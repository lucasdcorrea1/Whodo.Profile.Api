using MediatR;
using System;

namespace Whodo.Profile.Doman.Queries.v1.GetProfile
{
    public class GetProfileQuery : IRequest<GetProfileQueryResponse>
    {
        public string Email { get; set; }
    }
}
