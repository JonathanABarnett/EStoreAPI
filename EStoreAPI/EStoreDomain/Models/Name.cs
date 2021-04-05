using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDomain.Models
{
    public class Name
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Initials { get; set; }
    }
}
