using System;
using Newtonsoft.Json;

namespace RestEaseSampleApplication
{
    public class User
    {
        public string Name { get; set; }
        public string Blog { get; set; }

        [JsonProperty("created_at")] 
        public DateTime CreatedAt { get; set; }
    }
}
