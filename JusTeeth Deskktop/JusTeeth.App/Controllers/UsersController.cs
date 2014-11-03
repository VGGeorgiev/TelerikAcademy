﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JusTeeth.Data;

namespace JusTeeth.App.Controllers
{
    public class UsersController : BaseController
    {
        public UsersController() : base(new UnitOfWorkData())
        {
        }

        [HttpGet]
        public ActionResult Index(string username)
        {
            var user = this.Db.UsersRepository.All()
                .Include(x => x.Department.Workplace)
                .Include(x => x.LastPlaces)
                .Include(x => x.GroupHistory)
                .Include(x => x.Friends)
                .FirstOrDefault(u => u.UserName == username);
            return View(user);
        }
    }
}