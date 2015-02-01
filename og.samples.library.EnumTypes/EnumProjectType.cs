// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnumProjectType.cs" company="ozkary.com">
//   Copyright (c) under http://opensource.org/licenses/MIT
// </copyright>
// <summary>
//   extends enum types
// </summary>
// <remarks>
//  http://ozkary.com
//  02/1/2015
// </remarks>
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace og.samples.library.EnumTypes
{
    /// <summary>
    /// defines the project type categories
    /// </summary>
    public enum EnumProjectType:int
    {
        Web =0,
        Windows=1,
        Console=2,
        Mobile=3,
        Cloud=4
    }
}