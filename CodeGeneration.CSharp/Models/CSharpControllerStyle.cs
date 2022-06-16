//-----------------------------------------------------------------------
// <copyright file="CSharpControllerStyle.cs" company="NSwag">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/RicoSuter/NSwag/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

namespace CodeGeneration.CSharp.Models
{
    /// <summary>The CSharp controller style enum.</summary>
    public enum CSharpControllerStyle
    {
        /// <summary>Generates partial controllers.</summary>
        Partial,

        /// <summary>Generates abstract controllers.</summary>
        Abstract
    }
}