using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeetingRoom.Models;

namespace MeetingRoom.Models
{
   
    public class MeetingBusiness
    {
        MeetingRoomDBConnection objDB = new MeetingRoomDBConnection();
        public List<SelectListItem> getPlanMaster()
        {
            var result = objDB.getPlant();
            return result;
        }
    }
}