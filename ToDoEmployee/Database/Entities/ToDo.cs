using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database.Entities
{
    [Table("todo")]
    public class ToDo
    {
        [Key]
        public int itemId { get; set; }
        public string title { get; set; }
        public string details { get; set; }
        public string prioritylevel { get; set; }
        public string taskState { get; set; }
        public string estimate { get; set; }
        public int employeeid { get; set; }
    }
}
