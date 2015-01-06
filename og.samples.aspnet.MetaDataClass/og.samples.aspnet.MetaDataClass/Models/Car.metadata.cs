using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace og.samples.aspnet.MetaDataClass.Models
{
    /// <summary>
    /// partial class definition to associate the ORM generated class
    /// NO NEED to add the properties here.
    /// </summary>
    [MetadataType(typeof(CarAnnotation))]
    public partial class Car
    {
    }

    /// <summary>
    /// Buddy Class or Data Annotation Class
    /// Add the properties here with the associated annotations
    /// </summary>
    internal sealed class CarAnnotation
    {
        [Required(ErrorMessage="{0} is required")]
        [MinLength(3,ErrorMessage="{0} should have three or more letters")]   //kia
        public string Make { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [MinLength(5)]
        public string Model { get; set; }
    }
}