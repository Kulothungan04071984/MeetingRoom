using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MeetingRoom.Models
{
    
    public class MeetingLogin
    {
        [Required(ErrorMessage ="User ID Invalid")]
        
        public int UserID { get; set; }
        [Required(ErrorMessage ="Password Invalid")]
        public string PassWord { get; set; }
    }
}