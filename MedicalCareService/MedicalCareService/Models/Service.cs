using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalCareService.Models
{
    public class Service
    {
        [ForeignKey("Employee")]
        public int ServiceID { get; set; }
        public string ServiceType { get; set; }
        public int CustomerID { get; set; }


        public virtual Employee Employee { get; set; }
        public virtual Customer Customer { get; set; }
    }
}