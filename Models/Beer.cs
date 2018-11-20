using System.Collections.Generic;
using Newtonsoft.Json;

namespace back_end.Models
{
    public class Beer
    {
        [JsonProperty(PropertyName = "id")] public string ID { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "brand")] public Brand Brand { get; set; }
        [JsonProperty(PropertyName = "percentage")] public double Percentage { get; set; }
        [JsonProperty(PropertyName = "description")] public string Description { get; set; }
        [JsonProperty(PropertyName = "ingredients")] public IEnumerable<Ingredient> Ingredients { get; set; }

    }
}