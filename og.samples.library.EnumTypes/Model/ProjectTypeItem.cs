// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectTypeItem.cs" company="ozkary.com">
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
using System.Text;
using System.Threading.Tasks;

namespace og.samples.library.EnumTypes.Model
{
    /// <summary>
    /// project type model
    /// </summary>
    public class ProjectTypeItem
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
    }

    /// <summary>
    /// list of items
    /// </summary>
    public class ProjectTypeList : List<ProjectTypeItem>
    {
        /// <summary>
        /// build a sample list
        /// </summary>
        /// <returns></returns>
        public static ProjectTypeList BuildList()
        {
            ProjectTypeList list = new ProjectTypeList();

            //list of the categories
            foreach (EnumProjectType type in EnumProjectType.GetValues(typeof(EnumProjectType)))
            {
                var item = new ProjectTypeItem()
                {
                    Id = (int)type,
                    Description = type.Describe(),   //load the description
                    Tag = type.ToString()
                };
                Trace.TraceInformation("{0} {1}",item.Tag,item.Description);
                list.Add(item);
            }
            return list;

        }
    }

}
