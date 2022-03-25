using System;
using System.Text.Json.Serialization;

namespace Whodo.Profile.Doman.Models.v1.Profile
{
    public class GetProfileQueryResponseData
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long? Cpf { get; set; }
        public long? Cnpj { get; set; }

        [JsonIgnore]
        public string Password { get; set; }
    }
}
