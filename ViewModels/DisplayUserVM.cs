using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UsersCOM.Models;

namespace UsersCOM.ViewModels
{
    public class DisplayUserVM
    {
        public IEnumerable<Users> Users { get; set; }
        public IEnumerable<UserDetails> UserDetails { get; set; }
        public IEnumerable<UserRoles> UserRoles { get; set; }
    }
}