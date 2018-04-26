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
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        //If email == email and password == password
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.Cookies["Vacation_Cookie"] != null)
            {
                HttpCookie cookie = Request.Cookies["Vacation_Cookie"];
                txtEmail.Text = cookie.Values["UserEmail"].ToString();
            }

        }

        public string DecodePassword(string encodedPassword)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder decode = encoder.GetDecoder();
            byte[] decode_byte = Convert.FromBase64String(encodedPassword);
            int charCount = decode.GetCharCount(decode_byte, 0, decode_byte.Length);
            char[] decoded = new char[charCount];
            decode.GetChars(decode_byte, 0, decode_byte.Length, decoded, 0);
            string password = new string(decoded);
            return password;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Equals("") && !txtPassword.Text.Equals(""))
            {
                HttpCookie cookie = new HttpCookie("Vacation_Cookie");
                cookie.Values["UserEmail"] = txtEmail.Text;
                cookie.Expires = new DateTime(2030, 1, 1);
                Response.Cookies.Add(cookie);

                Customer user = new Customer();

                user.email = txtEmail.Text;
                user.password = DecodePassword(txtPassword.Text);

                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "GetUserAccount";

                
            }
        }
    }
}