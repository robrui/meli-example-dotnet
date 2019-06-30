﻿using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Models
{
    public class ItemResultAttribute
    {
        [JsonProperty(PropertyName = "attribute_group_name")]
        public string AttributeGroupName { get; set; }

        [JsonProperty(PropertyName = "source")]
        public long? Source { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "value_id")]
        public string ValueId { get; set; }

        [JsonProperty(PropertyName = "value_name")]
        public string ValueName { get; set; }

        [JsonProperty(PropertyName = "value_struct")]
        public string ValueStruct { get; set; }

        [JsonProperty(PropertyName = "attribute_group_id")]
        public string AttributeGroupId { get; set; }
    }
}
