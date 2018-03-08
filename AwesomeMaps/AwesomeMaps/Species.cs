using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeMaps
{
    class Species
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public string id { get; set; }

        [Newtonsoft.Json.JsonProperty("speciesName")]
        public string speciesName { get; set; }

        [Newtonsoft.Json.JsonProperty("similarity")]
        public double similarity { get; set; }

        [Newtonsoft.Json.JsonProperty("invasiveOrNot")]
        public Boolean invasiveOrNot { get; set; }

        [Newtonsoft.Json.JsonProperty("imageAddr")]
        public string imageAddr { get; set; }

        [Newtonsoft.Json.JsonProperty("alsoKnownAs")]
        public string alsoKnownAs { get; set; }

        [Newtonsoft.Json.JsonProperty("family")]
        public string family { get; set; }

        [Newtonsoft.Json.JsonProperty("origin")]
        public string origin { get; set; }

        [Newtonsoft.Json.JsonProperty("generalDescription")]
        public string generalDescription { get; set; }

        [Newtonsoft.Json.JsonProperty("habitats")]
        public string habitats { get; set; }

        [Newtonsoft.Json.JsonProperty("dispersal")]
        public string dispersal { get; set; }

        [Newtonsoft.Json.JsonProperty("impactOnEnvironment")]
        public string impactOnEnvironment { get; set; }

        [Newtonsoft.Json.JsonProperty("siteManagement")]
        public string siteManagement { get; set; }

        [Newtonsoft.Json.JsonProperty("recommendedApproaches")]
        public string recommendedApproaches { get; set; }

    }
}
