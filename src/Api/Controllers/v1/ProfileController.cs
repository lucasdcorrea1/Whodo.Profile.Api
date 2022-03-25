using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Whodo.Profile.Doman.Commands.v1.CreateProfile;
using Whodo.Profile.Doman.Queries.v1.GetProfile;

namespace Whodo.Profile.Api.Controllers.v1
{
    [ApiController]
    [Route("api/v1/profile")]
    public class ProfileController : ControllerBase
    {
        IMediator _mediator;
        public ProfileController([FromServices] IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<GetProfileQueryResponse> Get([FromQuery] GetProfileQuery query)
        {
            return _mediator.Send(query);
        }

        [HttpPost]
        public Task<Unit> Create([FromBody] CreateProfileQuery command)
        {
            return _mediator.Send(command);
        }
    }
}
