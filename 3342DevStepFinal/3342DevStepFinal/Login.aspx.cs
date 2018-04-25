using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace _3342DevStepFinal
{
    public partial class Login : System.Web.UI.Page
    {
        //If email == email and password == password
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.Cookies["Vacation_Cookie"] != null)
            {
                HttpCookie cookie = Request.Cookies["Vacation_Cookie"];
                txtEmail.Text = cookie.Values["UserEmail"].ToString();
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Equals("") && !txtPassword.Text.Equals(""))
            {
                HttpCookie cookie = new HttpCookie("Vacation_Cookie");
                cookie.Values["UserEmail"] = txtEmail.Text;
                cookie.Expires = new DateTime(2030, 1, 1);
                Response.Cookies.Add(cookie);


            }
        }
    }
}