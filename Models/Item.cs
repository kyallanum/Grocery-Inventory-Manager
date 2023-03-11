using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Inventory_Manager.Models
{
    public partial class Item
    {
        [JsonProperty("id", Required = Required.Always)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("qty", Required = Required.Always)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Qty { get; set; }
    }
}
