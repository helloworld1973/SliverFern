using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeMaps
{
    public class SPECIES_LA_LONG
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public string id { get; set; }

        [Newtonsoft.Json.JsonProperty("speciesName")]
        public string speciesName { get; set; }

        [Newtonsoft.Json.JsonProperty("latitude")]
        public double latitude { get; set; }

        [Newtonsoft.Json.JsonProperty("longtitude")]
        public double longtitude { get; set; }
    }
}
