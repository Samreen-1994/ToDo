using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database.Entities
{

    [Table("employees")]
    public class Employee
    {
        [Key]
        public int employee_id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public long salary { get; set; }
    }
}
