using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MyMVC.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public int email { get; set; }
        public int MyProperty { get; set; }
    }
}
