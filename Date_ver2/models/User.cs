using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Date_ver2.Models;

namespace Date_ver2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
    }
}