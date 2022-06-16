﻿//-----------------------------------------------------------------------
// <copyright file="OpenApiServerVariable.cs" company="NSwag">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/RicoSuter/NSwag/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Core
{
    /// <summary>Describes an OpenAPI server variable.</summary>
    public class OpenApiServerVariable
    {
        /// <summary>Gets or sets the enum of the server.</summary>
        [JsonProperty(PropertyName = "enum", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public ICollection<string> Enum { get; } = new Collection<string>();

        /// <summary>Gets or sets the variables of the server.</summary>
        [JsonProperty(PropertyName = "default", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string Default { get; set; }

        /// <summary>Gets or sets the description of the server.</summary>
        [JsonProperty(PropertyName = "description", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string Description { get; set; }
    }
}