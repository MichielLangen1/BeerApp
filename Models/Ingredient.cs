using Newtonsoft.Json;

namespace back_end.Models{
    public class Ingredient{
        
        [JsonProperty(PropertyName = "id")] public string ID {get;set;}
        [JsonProperty(PropertyName = "name")] public string Name {get;set;}
    }
}