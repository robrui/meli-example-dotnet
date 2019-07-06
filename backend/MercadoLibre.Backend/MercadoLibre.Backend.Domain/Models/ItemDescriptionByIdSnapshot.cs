﻿using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Models
{
    public class ItemDescriptionByIdSnapshot
    {
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }

        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }
}
