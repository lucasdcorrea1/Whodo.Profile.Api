using System;
using Whodo.Profile.CrossCutting.Base.DataMapping;

namespace Whodo.Profile.Doman.Entities.v1.Profile
{
    public class Profile : DataMappingBase<long>
    {
        public Profile(string name, string email, string password, bool active, DateTime creationDate, DateTime? lastUpdateDate, long? cpf, long? cnpj)
        {
            Name = name;
            Email = email;
            Password = password;
            Active = active;
            CreationDate = creationDate;
            LastUpdateDate = lastUpdateDate;
            Cpf = cpf;
            Cnpj = cnpj;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? Cpf { get; set; }
        public long? Cnpj { get; set; }
    }
}
