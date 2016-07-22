// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class BusinessIdentity
    {
        /// <summary>
        /// Initializes a new instance of the BusinessIdentity class.
        /// </summary>
        public BusinessIdentity() { }

        /// <summary>
        /// Initializes a new instance of the BusinessIdentity class.
        /// </summary>
        public BusinessIdentity(string qualifier = default(string), string value = default(string))
        {
            Qualifier = qualifier;
            Value = value;
        }

        /// <summary>
        /// Gets or sets the business identity qualifier.
        /// </summary>
        [JsonProperty(PropertyName = "Qualifier")]
        public string Qualifier { get; set; }

        /// <summary>
        /// Gets or sets the business identity value.
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

    }
}