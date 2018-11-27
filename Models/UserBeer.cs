using System.Collections.Generic;
using Newtonsoft.Json;

namespace back_end.Models
{
    public class UserBeer
    {
        [JsonProperty(PropertyName = "userid")]public string UserID { get; set; }
        [JsonProperty(PropertyName = "user")]public User User { get; set; }
        [JsonProperty(PropertyName = "beerid")]public string BeerId { get; set; }
        [JsonProperty(PropertyName = "beer")]public Beer Beer { get; set; }
    }
}