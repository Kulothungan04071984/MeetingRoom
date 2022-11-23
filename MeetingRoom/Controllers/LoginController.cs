﻿using MeetingRoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MeetingRoom.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginMeetingRoom()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginMeetingRoom(MeetingLogin obj)
        {
            return RedirectToAction("MeetingRooms", "MeetingRoom");
        }
    }
}