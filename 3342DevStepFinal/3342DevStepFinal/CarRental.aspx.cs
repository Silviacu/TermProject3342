using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace _3342DevStepFinal
{
    public partial class CarRental : System.Web.UI.Page
    {
        Cars.CarService carRental = new Cars.CarService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["Email"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                divCars.Visible = false;
                divSearchCars.Visible = false;
                
            }

        }

        protected void rptCars_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            if (txtCity.Text.Equals("") || ddlState.SelectedValue == "Select State")
            {
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "Client Script", "alert('Please enter a valid city and state!')", true);
            }
            else
            {
                DataSet agencies = carRental.GetRentalCarAgencies(txtCity.Text, ddlState.SelectedValue);
                ddlAgencies.DataSource = agencies;
                ddlAgencies.DataTextField = "Name";
                ddlAgencies.DataValueField = "Name";
                ddlAgencies.DataBind();
                divSearchCars.Visible = true;
            }
        }

        protected void btnAgencies_Click(object sender, EventArgs e)
        {
            DataSet agencies = carRental.GetRentalCarAgencies(txtCity.Text, ddlState.SelectedValue);
            Cars.Agency agency = new Cars.Agency();
            agency.agencyID = (int)agencies.Tables[0].Rows[ddlAgencies.SelectedIndex]["AgencyID"];
            agency.name = ddlAgencies.SelectedValue;
            agency.city = (string)agencies.Tables[0].Rows[ddlAgencies.SelectedIndex]["City"];
            agency.state = (string)agencies.Tables[0].Rows[ddlAgencies.SelectedIndex]["State"];

            DataSet myDS = carRental.GetCarsByAgency(agency, txtCity.Text, ddlState.SelectedValue);
            rptCars.DataSource = myDS;
            rptCars.DataBind();

            divSearchCars.Visible = false;
            divCars.Visible = true;
        }

        protected void btnRequirements_Click(object sender, EventArgs e)
        {
            Cars.Requirements require = new Cars.Requirements();
            require.price = Convert.ToInt16(ddlPrice.SelectedValue);
            require.numDoor = Convert.ToInt16(ddlnumDoor.SelectedValue);
            require.eco = ddlEco.SelectedValue;
            require.numPassenger = Convert.ToInt16(ddlnumPassenger.SelectedValue);

            DataSet myDS = carRental.FindCars(require, txtCity.Text, ddlState.SelectedValue);
            rptCars.DataSource = myDS;
            rptCars.DataBind();

            divSearchCars.Visible = false;
            divCars.Visible = true;
        }

        protected void btnSearchAgain_Click(object sender, EventArgs e)
        {
            divCars.Visible = false;
            divSearchCars.Visible = false;
            rptCars.DataSource = null;
            rptCars.DataBind();
        }
    }
}