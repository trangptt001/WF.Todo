using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TODO.WF.Model.Dto
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Department { get; set; }
        public int Gender { get; set; }
    }
}
