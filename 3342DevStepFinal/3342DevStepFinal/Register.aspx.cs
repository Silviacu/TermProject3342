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
    public partial class Register : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static string EncodePassword(string password)
        {
            try
            {
                byte[] encData = new byte[password.Length];
                encData = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData);
                return encodedData;
            }
            catch(Exception ex)
            {
                throw new Exception("Error encoding password." + ex.Message);
            }
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
            else
            {
                newUser.fullName = txtName.Text;
                newUser.address = txtAddress.Text;
                newUser.ccNumber = Convert.ToInt64(txtCCNum.Text);
                newUser.expire = txtExpire.Text;
                newUser.secureCode = Convert.ToInt16(txtSecure.Text);
                newUser.email = txtEmail.Text;
                newUser.password = EncodePassword(txtPassword.Text);

                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "RegisterUser";

                SqlParameter inputName = new SqlParameter("@name", txtName.Text);
                objCommand.Parameters.Add(inputName);

                SqlParameter inputAddress = new SqlParameter("@address", newUser.address);
                objCommand.Parameters.Add(inputAddress);

                SqlParameter inputCC = new SqlParameter("@ccNum", newUser.ccNumber);
                objCommand.Parameters.Add(inputCC);

                SqlParameter inputExpire = new SqlParameter("@expire", newUser.expire);
                objCommand.Parameters.Add(inputExpire);

                SqlParameter inputSecure = new SqlParameter("@secure", newUser.secureCode);
                //inputSecure.Direction = ParameterDirection.Input;
                objCommand.Parameters.Add(inputSecure);

                SqlParameter inputEmail = new SqlParameter("@email", newUser.email);
                objCommand.Parameters.Add(inputEmail);

                SqlParameter inputPassword = new SqlParameter("@password", newUser.password);
                objCommand.Parameters.Add(inputPassword);

                objDB.DoUpdateUsingCmdObj(objCommand);

                Response.Redirect("Login.aspx");
            }

            
        }
    }
}