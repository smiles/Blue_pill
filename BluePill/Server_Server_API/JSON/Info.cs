using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BluePill.Server_Server_API.JSON
{
    public class Info
    {
        [JsonPropertyName("m.server")]
        public string Server { get; }
    }
}
