using System;

namespace Whodo.Profile.Doman.Commands.v1.CreateProfile
{
    public class CreateProfileQueryProfile : AutoMapper.Profile
    {
        public CreateProfileQueryProfile()
        {
            CreateMap<CreateProfileQuery, Entities.v1.Profile.Profile> ()
                 .ForPath(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                 .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                 .ForPath(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                 .ForPath(dest => dest.Active, opt => opt.MapFrom(src => true))
                 .ForPath(dest => dest.CreationDate, opt => opt.MapFrom(src => DateTime.Now))
                 .ForPath(dest => dest.LastUpdateDate, opt => opt.MapFrom(src => DateTime.Now))
                 .ForPath(dest => dest.Cpf, opt => opt.MapFrom(src => src.Cpf))
                 .ForPath(dest => dest.Cnpj, opt => opt.MapFrom(src => src.Cnpj));
        }
    }
}
