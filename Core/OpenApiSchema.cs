﻿//-----------------------------------------------------------------------
// <copyright file="SwaggerSchema.cs" company="NSwag">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/RicoSuter/NSwag/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

using System.Runtime.Serialization;

namespace Core
{
    /// <summary>The enumeration of Swagger protocol schemes.</summary>
    public enum OpenApiSchema
    {
        /// <summary>An undefined schema.</summary>
        [EnumMember(Value = "undefined")]
        Undefined,

        /// <summary>The HTTP schema.</summary>
        [EnumMember(Value = "http")]
        Http,

        /// <summary>The HTTPS schema.</summary>
        [EnumMember(Value = "https")]
        Https,

        /// <summary>The WS schema.</summary>
        [EnumMember(Value = "ws")]
        Ws,

        /// <summary>The WSS schema.</summary>
        [EnumMember(Value = "wss")]
        Wss
    }
}