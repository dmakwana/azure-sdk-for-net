// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using System.Linq;

    /// <summary>
    /// The Sku description for a namespace
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku() { }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">Name of the notification hub sku</param>
        /// <param name="tier">Name of the notification hub tier</param>
        public Sku(string name = default(string), string tier = default(string), string size = default(string), string family = default(string), int? capacity = default(int?))
        {
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Capacity = capacity;
        }

        /// <summary>
        /// Gets or sets name of the notification hub sku
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets name of the notification hub tier
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "family")]
        public string Family { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

    }
}
