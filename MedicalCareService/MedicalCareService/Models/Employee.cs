using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MedicalCareService.Models
{
    public class Employee : Person
    {
        [Key]
        public int EmployeeID { get; set; }
        //public String EmployeeName { get; set; }
        public virtual Service Service { get; set; }
    }
}