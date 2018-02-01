using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsersCOM.Models;
using UsersCOM.ViewModels;

namespace UsersCOM.Controllers
{
    public class UserController : Controller
    {
        private UserViewModel uvm;
        private DisplayUserVM duvm;
        public UserController(UserViewModel uvm, DisplayUserVM duvm)
        {
            this.uvm = uvm;
            this.duvm = duvm;
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            List<UserRoles> roles = new List<UserRoles>()
            {
                new UserRoles
                {
                    ID=1,
                    Roles="Admin"
                },
                new UserRoles
                {
                    ID=2,
                    Roles="Employee"
                }
            };
            
            uvm.Roles = from role in roles
                        select new SelectListItem
                        {
                            Text=role.Roles,
                            Value=role.ID.ToString()
                        };
            return View(uvm);
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
