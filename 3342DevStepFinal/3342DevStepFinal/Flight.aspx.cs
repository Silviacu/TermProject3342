using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Globalization;
using TermProjectLibrary;

namespace _3342DevStepFinal
{
    public partial class Flight : System.Web.UI.Page
    {
        Flights.AirService proxy = new Flights.AirService();
        Cart cart;

        protected void Page_Load(object sender, EventArgs e)
        {
            cart = (Cart)Session["Cart"];
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            //aircarrierid  Flights.AirCarrierClass = txtaircarrierID.Text;

            string departureCity = txtDepartureCity.Text;
            string departureState = ddlDepartureState.SelectedItem.Text;
            string arrivalCity = txtArrivalCity.Text;
            string arrivalState = ddlArrivalState.SelectedItem.Text;

            DataSet dataflight = new DataSet();

            //Check how to reference AirCarrierID
            dataflight = proxy.GetFlights(airCarrierID, departureState, arrivalCity, arrivalState);
            gvFlightResults.DataSource = dataflight;
            gvFlightResults.DataBind();
        }
        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvFlightResults.Rows.Count; i++)
            {
                if (gvFlightResults.Rows[i].FindControl("btnAddToCart") == sender)
                {
                    VacationItem add = new VacationItem();
                    add.FlightID = int.Parse(gvFlightResults.Rows[i].Cells[0].Text);
                    add.IsFlight = true;
                    add.Price = int.Parse(gvFlightResults.Rows[i].Cells[4].Text, NumberStyles.Currency);
                    add.Description = "Air Carrier: " + gvFlightResults.Rows[i].Cells[2].Text +
                                        " Departure Time: " + gvFlightResults.Rows[i].Cells[3].Text;

                    cart.AddtoCart(add);
                    gvFlightResults.Visible = false;
                    lblMessage.Text = "Your flight has successfully been added to cart";

                }
            }
        }
    }
}