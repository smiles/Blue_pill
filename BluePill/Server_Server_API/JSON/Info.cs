using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BluePill.Server_Server_API.JSON
{
    public class Info
    {
        [JsonPropertyName("m.homeserver")]
        public Baseurl Home { get; }

        [JsonPropertyName("m.identity_server")]
        public Baseurl Identity { get; }
    }

    public class Baseurl
    {
        [JsonPropertyName("base_url")]
        public string Base { get; }
    }
}
