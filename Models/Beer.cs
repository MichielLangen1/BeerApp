using System.Collections.Generic;
using Newtonsoft.Json;

namespace back_end.Models
{
    public class Beer
    {
        [JsonProperty(PropertyName = "id")]
        public string ID { get; set; }

        
    }
}