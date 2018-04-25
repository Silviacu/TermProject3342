using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace _3342DevStepFinal
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Customer newUser = new Customer();

            if (txtName.Text.Equals("") || txtAddress.Text.Equals("") || txtCCNum.Text.Equals("")||
                txtExpire.Text.Equals("") || txtSecure.Text.Equals("") || txtEmail.Text.Equals("") ||
                txtPassword.Text.Equals(""))
            {
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "Client Script", "alert('Please fill out all parts of registration!')", true);
            }
        }
    }
}