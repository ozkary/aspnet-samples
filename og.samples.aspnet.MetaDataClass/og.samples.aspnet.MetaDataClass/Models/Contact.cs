// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Contact.cs" company="ozkary.com">
//   Copyright (c) under http://opensource.org/licenses/MIT
// </copyright>
// <summary>
//   extends enum types
// </summary>
// <remarks>
//  http://ozkary.com
// </remarks>
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace og.samples.aspnet.Demo.Models
{
    /// <summary>
    /// contact model
    /// </summary>   
    public partial class Contact
    {       
        [DataMember(Name = "name")]
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [DataMember(Name = "email")]
        [EmailAddress]
        [Required]
        [MinLength(5)]
        public string Email { get; set; }

        [Phone]
        [DataMember(Name = "Phone")]
        public string Phone { get; set; }


        public DateTime Created { get; set; }
    }
}