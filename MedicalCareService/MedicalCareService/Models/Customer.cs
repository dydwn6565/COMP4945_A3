using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalCareService.Models
{
    public class Customer : Person
    {
        public int CustomerID { get; set; }
        //public string CustomerName { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}