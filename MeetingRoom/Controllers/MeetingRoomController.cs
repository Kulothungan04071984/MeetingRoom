using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeetingRoom.Models;
namespace MeetingRoom.Controllers
{
    public class MeetingRoomController : Controller
    {
        // GET: MeetingRoom
        MeetingBusiness objBus = new MeetingBusiness();
        public ActionResult MeetingRooms()
        {
            MeetingRoomDet objMeeting = new MeetingRoomDet();
            var PlantDetails = objBus.getPlanMaster();
            objMeeting.PlantMaster = PlantDetails;
            return View(objMeeting);
        }
    }
}