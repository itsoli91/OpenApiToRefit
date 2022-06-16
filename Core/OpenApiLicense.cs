﻿//-----------------------------------------------------------------------
// <copyright file="SwaggerLicense.cs" company="NSwag">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/RicoSuter/NSwag/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

using Newtonsoft.Json;
using NJsonSchema;

namespace Core
{
    /// <summary>The license information.</summary>
    public class OpenApiLicense : JsonExtensionObject
    {
        /// <summary>Gets or sets the name.</summary>
        [JsonProperty(PropertyName = "name", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string Name { get; set; }

        /// <summary>Gets or sets the license URL.</summary>
        [JsonProperty(PropertyName = "url", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string Url { get; set; }
    }
}