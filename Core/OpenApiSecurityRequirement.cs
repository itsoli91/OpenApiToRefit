//-----------------------------------------------------------------------
// <copyright file="SwaggerSecurityRequirement.cs" company="NSwag">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/RicoSuter/NSwag/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

using System.Collections.Generic;

namespace Core
{
    /// <summary>The operation security requirements.</summary>
    public class OpenApiSecurityRequirement : Dictionary<string, IEnumerable<string>>
    {

    }
}