using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3342DevStepFinal
{
    public partial class Hotel : System.Web.UI.Page
    {
        Hotels.HotelService proxy = new Hotels.HotelService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Searches for hotels with avaliable rooms
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            gvHotelResults.Visible = true;
            gvRoomResults.Visible = false;

            gvHotelResults.DataSource = proxy.GetHotels(txtCity.Text, ddlState.SelectedItem.ToString());
            gvHotelResults.DataBind();
        }

        protected void btnSearchforRooms_Click(object sender, EventArgs e)
        {
            gvHotelResults.Visible = false;
            gvRoomResults.Visible = true;
            int hotelID = 0;
            Hotel thehotel;

            for (int i = 0; i < gvHotelResults.Rows.Count; i++)
            {
                if (gvHotelResults.Rows[i].FindControl("btnSearchforRooms") == sender)
                {
                    hotelID = int.Parse(gvHotelResults.Rows[i].Cells[0].Text);
                }

                else
                {
                    
                    gvRoomResults.DataSource = proxy.GetRoomsByHotel(thehotel);
                }
            }
            gvRoomResults.DataBind();
        }
    }
}