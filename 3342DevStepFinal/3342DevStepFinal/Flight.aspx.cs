using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Globalization;
using TermProjectLibrary;
using System.Data.SqlClient;

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
            string departureCity = txtDepartureCity.Text;
            string departureState = ddlDepartureState.SelectedItem.Text;
            string arrivalCity = txtArrivalCity.Text;
            string arrivalState = ddlArrivalState.SelectedItem.Text;

            Flights.RequirementClass reqflight = new Flights.RequirementClass();
            reqflight.requirementStops = ddlStops.SelectedValue;
            reqflight.requirementClass = ddlFlightOption.SelectedValue;

            DataSet myDS = proxy.FindFlights(reqflight, departureCity, departureState, arrivalCity, arrivalState);
            gvFlightResults.DataSource = myDS;
            gvFlightResults.DataBind();
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvFlightResults.Rows.Count; i++)
            {
                if (gvFlightResults.Rows[i].FindControl("btnAddToCart") == sender)
                {
                    UserVacation userVacation = new UserVacation();
                    Flights.FlightClass flight = new Flights.FlightClass();
                    flight.DepartureCity = txtDepartureCity.Text;
                    flight.ArrivalCity = txtArrivalCity.Text;

                    //add.flight.Add(int.Parse(gvFlightResults.Rows[i].Cells[0].Text));
                    //add.Price = int.Parse(gvFlightResults.Rows[i].Cells[4].Text, NumberStyles.Currency);
                    //add.Description = "Air Carrier: " + gvFlightResults.Rows[i].Cells[2].Text +
                    //                    " Departure Time: " + gvFlightResults.Rows[i].Cells[3].Text;
                    //cart.AddtoCart(add);

                    if (Session["UserVacation"] != null)
                    {
                        userVacation = (UserVacation)Session["UserVacation"];
                    }
                    else
                    {
                        userVacation = new UserVacation();
                    }

                    userVacation.flight.Add(flight);
                    userVacation.flightQuan.Add(1);
                    Session["UserVacation"] = userVacation;

                    gvFlightResults.Visible = false;
                    lblMessage.Text = "Your flight has successfully been added to cart";
                }
            }
        }
    }
}