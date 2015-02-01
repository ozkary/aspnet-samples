// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnumProjectTypeExtension.cs" company="ozkary.com">
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
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace og.samples.library.EnumTypes
{
    /// <summary>
    /// extends the enum type to provide self-describing methods.
    /// </summary>
    public static class EnumProjectTypeExtension
    {
        /// <summary>
        /// describe the enumerated type category. Defined the information on the resource file
        /// </summary>
        /// <param name="type"></param>
        /// <returns>the content found on the resource file</returns>
        public static string Describe(this EnumProjectType type)
        {
            string content = type.ToString();       //default to the type
            try
            {
                content = ResProjectType.ResourceManager.GetString(content, ResProjectType.Culture);
                Trace.TraceInformation(String.Format("Message status {0} content {1}", type, content));
            }
            catch (Exception ex)
            {
                Trace.TraceError(String.Format("Message status {0} error {1}", type, ex.Message));
            }
            
            return content;            
        }
    }
}
