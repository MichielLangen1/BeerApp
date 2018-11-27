using System.Collections.Generic;
using Newtonsoft.Json;

namespace back_end.Models
{
    public class User
    {
        [JsonProperty(PropertyName = "id")] public string ID { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "password")] public string password { get; set; }
        [JsonProperty(PropertyName = "userbeer")] public ICollection<UserBeer> UserBeers { get; set; }

    }
}