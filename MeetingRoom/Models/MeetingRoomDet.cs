using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeetingRoom.Models
{
    public class MeetingRoomDet
    {
        public int PlantID { get; set; }
        public string PlantName { get; set; }
        public List<Unit> lstUnit { get; set; }
        public List<SelectListItem> PlantMaster { get; set; }
    }

    public class Unit
    {
        public int UnitID { get; set; }
        public string UnitName { get; set; }
        public List<MeetingDetails> lstMeetingDetails { get; set; }
    }

    public class MeetingDetails
    {
        public int MeetingRoomId { get; set; }
        public string MeetingRoomName { get; set; }
    }
}