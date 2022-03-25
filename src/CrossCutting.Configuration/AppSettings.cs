using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whodo.Profile.CrossCutting.Configuration
{
    public class AppSettings
    {
        [JsonProperty(PropertyName = "applicationName")]
        public string ApplicationName { get; set; }
    }
}
