using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Data;
using System.Data.SqlClient;
using Utilities;
using TermProjectLibrary;

namespace _3342DevStepFinal
{
    public partial class Cart : System.Web.UI.Page
    {
        /*Cart cart;
        Cars.CarService carProxy = new Cars.CarService();
        Flights.AirService flightProxy = new Flights.AirService();
        Hotels.HotelService hotelProxy = new Hotels.HotelService();
        Experiences.ActivitiesService expProxy = new Experiences.ActivitiesService();*/
        double total = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if(Session["UserVacation"] != null)
                {
                    double carPrice = 0;
                    double activityPrice = 0;
                    UserVacation vacation = (UserVacation)Session["UserVacation"];
                    for(int i = 0; i < vacation.car.Count; i++)
                    {
                        Cars.Car car = vacation.car[i];
                        divCar.InnerHtml += "<div class='col-md-3'><div class='panel panel-default'><div class='panel-body'><h4>";
                        divCar.InnerHtml += car.make + "&nbsp";
                        divCar.InnerHtml += car.model + "</h4><p>";
                        divCar.InnerHtml += "Price: $" + car.price + "<br/>";
                        divCar.InnerHtml += "Number of Doors:" + car.numDoors + "<br/>";
                        divCar.InnerHtml += "Eco-Friendly:" + car.eco + "<br/>";
                        divCar.InnerHtml += "Number of Passengers:" + car.numPassenger + "</p></div></div></div>";
                        carPrice = carPrice + car.price;
                        
                    }
                    for(int y = 0; y < vacation.flight.Count; y++)
                    {
                        Flights.FlightClass flight = vacation.flight[y];
                        divFlight.InnerHtml += "<div class='col-md-3'><div class='panel panel-default'><div class='panel-body'><h4>";
                        divFlight.InnerHtml += "</div></div></div>";
                    }
                    for(int x = 0; x <vacation.room.Count; x++)
                    {
                        Hotels.Room room = vacation.room[x];
                        divHotel.InnerHtml += "<div class='col-md-3'><div class='panel panel-default'><div class='panel-body'><h4>";
                        divHotel.InnerHtml += "</div></div></div>";
                    }
                    for (int j = 0; j < vacation.activity.Count; j++)
                    {
                        Experiences.Activities activity = vacation.activity[j];
                        divActivity.InnerHtml += "<div class='col-md-3'><div class='panel panel-default'><div class='panel-body'><h4>";
                        divActivity.InnerHtml += activity.Activity_type + "</h4><p>";
                        divActivity.InnerHtml += "Price: $" + activity.Activity_cost + "</p></div></div></div>";
                        activityPrice = activityPrice + (double)activity.Activity_cost;
                    }
                    total = activityPrice + carPrice;
                    lblTotal.Text = total.ToString();
                }
            }

            //this.UpdateSubtotals();
        }

        /*private void UpdateSubtotals()
        {
            double totalCost = 0;

            for (int i = 0; i < gvCars.Rows.Count; i++)
            {
                double price = double.Parse(gvCars.Rows[i].Cells[1].Text, NumberStyles.Currency);
                int quantity = int.Parse(gvCars.Rows[i].Cells[2].Text);
                double subTotal = price * quantity;
                totalCost += subTotal;
                gvCars.Rows[i].Cells[3].Text = "$" + subTotal.ToString();
            }

            for (int i = 0; i < gvFlights.Rows.Count; i++)
            {
                double price = double.Parse(gvFlights.Rows[i].Cells[1].Text, NumberStyles.Currency);
                int quantity = int.Parse(gvFlights.Rows[i].Cells[2].Text);
                double subTotal = price * quantity;
                totalCost += subTotal;
                gvFlights.Rows[i].Cells[3].Text = "$" + subTotal.ToString();
            }

            for (int i = 0; i < gvActivity.Rows.Count; i++)
            {
                double price = double.Parse(gvActivity.Rows[i].Cells[1].Text, NumberStyles.Currency);
                int quantity = int.Parse(gvActivity.Rows[i].Cells[2].Text);
                double subTotal = price * quantity;
                totalCost += subTotal;
                gvActivity.Rows[i].Cells[3].Text = "$" + subTotal.ToString();
            }

            for (int i = 0; i < gvHotels.Rows.Count; i++)
            {
                double price = double.Parse(gvHotels.Rows[i].Cells[1].Text, NumberStyles.Currency);
                int quantity = int.Parse(gvHotels.Rows[i].Cells[2].Text);
                double subTotal = price * quantity;
                totalCost += subTotal;
                gvHotels.Rows[i].Cells[3].Text = "$" + subTotal.ToString();
            }

            Session["TotalCost"] = totalCost;
            //lblTotal.Text = "Total Cost: " + totalCost.ToString();
        }*/
    }
}
