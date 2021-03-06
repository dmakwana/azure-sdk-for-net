// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Redis.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The response of redis list keys operation.
    /// </summary>
    public partial class RedisListKeysResult
    {
        /// <summary>
        /// Initializes a new instance of the RedisListKeysResult class.
        /// </summary>
        public RedisListKeysResult() { }

        /// <summary>
        /// Initializes a new instance of the RedisListKeysResult class.
        /// </summary>
        public RedisListKeysResult(string primaryKey = default(string), string secondaryKey = default(string))
        {
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
        }

        /// <summary>
        /// Gets or sets the current primary key that clients can use to
        /// authenticate with redis cache.
        /// </summary>
        [JsonProperty(PropertyName = "primaryKey")]
        public string PrimaryKey { get; set; }

        /// <summary>
        /// Gets or sets the current secondary key that clients can use to
        /// authenticate with redis cache.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryKey")]
        public string SecondaryKey { get; set; }

    }
}
