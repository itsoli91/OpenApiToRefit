﻿//-----------------------------------------------------------------------
// <copyright file="SwaggerOAuth2Flow.cs" company="NSwag">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/RicoSuter/NSwag/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Core
{
    /// <summary>Enumeration of the OAuth2 flows. </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OpenApiOAuth2Flow
    {
        /// <summary>An undefined flow.</summary>
        [EnumMember(Value = "undefined")]
        Undefined,

        /// <summary>Use implicit flow.</summary>
        [EnumMember(Value = "implicit")]
        Implicit,

        /// <summary>Use password flow.</summary>
        [EnumMember(Value = "password")]
        Password,

        /// <summary>Use application flow.</summary>
        [EnumMember(Value = "application")]
        Application,

        /// <summary>Use access code flow.</summary>
        [EnumMember(Value = "accessCode")]
        AccessCode
    }
}