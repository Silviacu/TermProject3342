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
        UserVacation cart;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //lblMessage.Text = "This button works";
            string departureCity = txtDepartureCity.Text;
            string departureState = ddlDepartureState.SelectedItem.Text;
            string arrivalCity = txtArrivalCity.Text;
            string arrivalState = ddlArrivalState.SelectedItem.Text;

            Flights.RequirementClass reqflight = new Flights.RequirementClass();
            reqflight.requirementStops = ddlStops.SelectedValue;
            reqflight.requirementClass = ddlFlightOption.SelectedValue;
            DataSet myDS = new DataSet();
            myDS = proxy.FindFlights(reqflight, departureCity, departureState, arrivalCity, arrivalState);
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
                    flight.ArrivalCity = txtArrivalCity.Text;
                    flight.DepartureCity = txtDepartureCity.Text;
                    flight.DepartureDate = gvFlightResults.Rows[i].Cells[1].Text;
                    flight.DepartureTime = gvFlightResults.Rows[i].Cells[2].Text;
                    flight.ArrivalDate = gvFlightResults.Rows[i].Cells[3].Text;
                    flight.ArrivalTime = gvFlightResults.Rows[i].Cells[4].Text;
                    flight.Stops = Convert.ToInt16(ddlStops.SelectedValue);
                    flight.Class = ddlFlightOption.SelectedValue;
                    string price = gvFlightResults.Rows[i].Cells[5].Text;
                    flight.Price = decimal.Parse(gvFlightResults.Rows[i].Cells[5].Text);
                    
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