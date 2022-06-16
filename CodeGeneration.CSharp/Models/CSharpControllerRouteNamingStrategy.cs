﻿//-----------------------------------------------------------------------
// <copyright file="CSharpControllerRouteNamingStrategy.cs" company="NSwag">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/RicoSuter/NSwag/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

namespace CodeGeneration.CSharp.Models
{
    /// <summary>The CSharp controller routing naming strategy enum.</summary>
    public enum CSharpControllerRouteNamingStrategy
    {
        /// <summary>Disable route naming.</summary>
        None,

        /// <summary>Use the operationId as the route name, if available.</summary>
        OperationId
    }
}
