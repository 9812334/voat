﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Voat.Controllers
{
    public class ManagementController : BaseController
    {
        // GET: Management
        [Authorize]
        public ActionResult Index()
        {
            return View("Dashboard");
        }
    }
}