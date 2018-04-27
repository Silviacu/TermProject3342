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
        Cart cart;
        Cars.CarService carProxy = new Cars.CarService();
        Flights.AirService flightProxy = new Flights.AirService();
        Hotels.HotelService hotelProxy = new Hotels.HotelService();
        Experiences.ActivitiesService expProxy = new Experiences.ActivitiesService();

        protected void Page_Load(object sender, EventArgs e)
        {
            cart = (Cart)Session["Cart"];

            if (!IsPostBack)
            {
                gvCars.DataSource = cart.Cars;
                gvCars.DataBind();
                gvFlights.DataSource = cart.Flights;
                gvFlights.DataBind();
                gvHotels.DataSource = cart.Hotels;
                gvHotels.DataBind();
                gvActivity.DataSource = cart.Events;
                gvActivity.DataBind();
            }

            this.UpdateSubtotals();
        }

        private void UpdateSubtotals()
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
            lblTotal.Text = "Total Cost: " + totalCost.ToString();
        }
    }
}
}