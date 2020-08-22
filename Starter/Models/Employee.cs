using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Starter.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage = "Full Name is required") ]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(250)")]
        [DisplayName("Emp Code")]

        public string EmpCode { get; set; }
        [Column(TypeName = "varchar(250)")]

        public string Position { get; set; }
        [DisplayName("Office Location")]

        [Column(TypeName = "varchar(250)")]
        public string OfficeLocation { get; set; }
    }
}
