using Newtonsoft.Json;
using System.Collections.Generic;

namespace Whodo.Profile.Doman.Models.v1.Shared
{
    public abstract class ResponseBase<T>
    {
        [JsonProperty("data")]
        public T Data { get; set; }

        [JsonProperty("notifications")]
        public Dictionary<string, string> Notifications { get; set; }
    }
}
