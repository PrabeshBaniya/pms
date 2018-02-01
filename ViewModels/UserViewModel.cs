using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsersCOM.Models;

namespace UsersCOM.ViewModels
{
    public class UserViewModel
    {
        public Users Users { get; set; }
        public UserDetails UserDetails { get; set; }
        public IEnumerable<SelectListItem> Roles { get; set; }

    }
}