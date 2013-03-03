using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using LibusoftCicomMVC4.DataAnnotationValidators;

namespace LibusoftCicomMVC4.Entities
{
    public class Partner
    {
        public int PartnerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessageResourceType=typeof(Resources.Resource),
            ErrorMessageResourceName = "OIBRequired")]
        [CheckOIB]
        public long OIB { get; set; }
        [Required]
        public string Contact { get; set; }
        [Required]
        public string Description { get; set; }
    }
}