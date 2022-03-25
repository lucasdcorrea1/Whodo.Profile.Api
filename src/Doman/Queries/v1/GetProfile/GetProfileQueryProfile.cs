namespace Whodo.Profile.Doman.Queries.v1.GetProfile
{
    public class GetProfileQueryProfile : AutoMapper.Profile
    {
        public GetProfileQueryProfile()
        {
            CreateMap<Entities.v1.Profile.Profile, GetProfileQueryResponse>()
                 .ForPath(dest => dest.Data.Password, opt => opt.Ignore())
                 .ForPath(dest => dest.Data.Id, opt => opt.MapFrom(src => src.Id))
                 .ForPath(dest => dest.Data.Name, opt => opt.MapFrom(src => src.Name))
                 .ForPath(dest => dest.Data.Email, opt => opt.MapFrom(src => src.Email))
                 .ForPath(dest => dest.Data.Active, opt => opt.MapFrom(src => src.Active))
                 .ForPath(dest => dest.Data.CreationDate, opt => opt.MapFrom(src => src.CreationDate))
                 .ForPath(dest => dest.Data.LastUpdateDate, opt => opt.MapFrom(src => src.LastUpdateDate))
                 .ForPath(dest => dest.Data.Cpf, opt => opt.MapFrom(src => src.Cpf))
                 .ForPath(dest => dest.Data.Cnpj, opt => opt.MapFrom(src => src.Cnpj));
        }
    }
}
