using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsersCOM.Models
{
    public class Users

    {
        public int ID { get; set; }
        public int RoleID { get; set; }
        public string Password { get; set; }
        public int DetailsID { get; set; }
        public DateTime AddedDate { get; set; }


    }
}