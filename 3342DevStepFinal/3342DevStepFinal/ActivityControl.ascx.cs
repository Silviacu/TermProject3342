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
    public partial class ActivityControl : System.Web.UI.UserControl
    {
        Experiences.ActivitiesService pxy = new Experiences.ActivitiesService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Email"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                divSearchActivities.Visible = false;
                divActivities.Visible = false;
            }

        }

        protected void rptActivities_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int index = e.Item.ItemIndex;

            Label activityType = (Label)rptActivities.Items[index].FindControl("lblActivityType");
            Label price = (Label)rptActivities.Items[index].FindControl("lblPrice");

            Experiences.Activities activity = new Experiences.Activities();
            activity.Activity_type = activityType.Text;
            activity.Activity_cost = decimal.Parse(price.Text);

            UserVacation userVacation;
            if (Session["UserVacation"] != null)
            {
                userVacation = (UserVacation)Session["UserVacation"];
            }
            else
            {
                userVacation = new UserVacation();
            }

            userVacation.activity.Add(activity);
            userVacation.activityQuan.Add(1);
            Session["UserVacation"] = userVacation;
            lblMessage.Visible = true;
            lblMessage.Text = "The activity has been added to your cart!";
            divActivities.Visible = false;
            divSearchActivities.Visible = false;
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            if (txtCity.Text.Equals("") || ddlState.SelectedValue == "Select State")
            {
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "Client Script", "alert('Please enter a valid city and state!')", true);
            }
            else
            {
                DataSet agencies = pxy.GetActivityAgencies(ddlState.SelectedValue, txtCity.Text);
                ddlAgencies.DataSource = agencies;
                ddlAgencies.DataTextField = "Agency_Name";
                ddlAgencies.DataValueField = "Agency_Id";
                ddlAgencies.DataBind();
                divSearchActivities.Visible = true;
            }
        }

        protected void btnAgencies_Click(object sender, EventArgs e)
        {
            DataSet agencies = pxy.GetActivityAgencies(ddlState.SelectedValue, txtCity.Text);
            Experiences.Agency agency = new Experiences.Agency();
            agency.Agency_id = (int)agencies.Tables[0].Rows[ddlAgencies.SelectedIndex]["Agency_Id"];
            agency.Agency_name = ddlAgencies.SelectedValue;
            agency.Agency_city = (string)agencies.Tables[0].Rows[ddlAgencies.SelectedIndex]["Agency_City"];
            agency.Agency_state = (string)agencies.Tables[0].Rows[ddlAgencies.SelectedIndex]["Agency_State"];

            DataSet myDS = pxy.GetActivities(agency, ddlState.SelectedValue, txtCity.Text);
            rptActivities.DataSource = myDS;
            rptActivities.DataBind();

            divSearchActivities.Visible = false;
            divActivities.Visible = true;
        }

        protected void btnCriteria_Click(object sender, EventArgs e)
        {
            Experiences.Activities activity = new Experiences.Activities();
            activity.Activity_type = ddlType.SelectedValue;
            activity.Activity_cost = Convert.ToInt16(ddlPrice.SelectedValue);
            activity.Activity_startDate = "";
            activity.Activity_enddate = "";

            DataSet myDS = pxy.FindActivities(activity, ddlState.SelectedValue, txtCity.Text);
            rptActivities.DataSource = myDS;
            rptActivities.DataBind();

            divSearchActivities.Visible = false;
            divActivities.Visible = true;
        }

        protected void btnSearchAgain_Click(object sender, EventArgs e)
        {
            divActivities.Visible = false;
            divSearchActivities.Visible = false;
            rptActivities.DataSource = null;
            rptActivities.DataBind();
        }
    }
}