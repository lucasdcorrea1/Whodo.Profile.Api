using Newtonsoft.Json;

namespace Whodo.Profile.CrossCutting.Base.DataMapping
{
    public abstract class DataMappingBase<TIdentifier>
    {
        [JsonProperty("id")]
        public virtual TIdentifier Id { get; set; }
    }
}
