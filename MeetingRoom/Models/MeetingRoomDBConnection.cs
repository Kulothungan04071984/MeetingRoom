using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Web.Mvc;

namespace MeetingRoom.Models
{
    public class MeetingRoomDBConnection
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Meetingconn"].ToString());
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        public List<SelectListItem> getPlant()
        {
            var objPlant = new List<SelectListItem>();
            try
            {
                cmd = new SqlCommand("pro_getPlantName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader drPlant = cmd.ExecuteReader();
                while (drPlant.Read())
                {
                    objPlant.Add(new SelectListItem
                    {
                        Value = drPlant["PlantID"].ToString(),
                        Text = drPlant["PlantName"].ToString()
                    });
                }
                con.Close();
                return objPlant;
            }
            catch (Exception ex)
            {
               
                return objPlant;
            }
        }
    }
}