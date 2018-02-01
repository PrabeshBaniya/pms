using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsersCOM.Models
{
    public class UserDetails

    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public DateTime AddedDate { get; set; }
        public Boolean Status { get; set; }
     }
}