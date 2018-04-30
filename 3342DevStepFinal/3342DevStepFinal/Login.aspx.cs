using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace _3342DevStepFinal
{
    public partial class Login : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.Cookies["Vacation_Cookie"] != null)
            {
                HttpCookie cookie = Request.Cookies["Vacation_Cookie"];
                txtEmail.Text = cookie.Values["UserEmail"].ToString();
            }

        }

        /*public string DecodePassword(string encodedPassword)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder decode = encoder.GetDecoder();
            byte[] decode_byte = Convert.FromBase64String(encodedPassword);
            int charCount = decode.GetCharCount(decode_byte, 0, decode_byte.Length);
            char[] decoded = new char[charCount];
            decode.GetChars(decode_byte, 0, decode_byte.Length, decoded, 0);
            string password = new string(decoded);
            return password;
        }*/

        public static string EncodePassword(string password)
        {
            try
            {
                byte[] encData = new byte[password.Length];
                encData = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error encoding password." + ex.Message);
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            Customer user = new Customer();

            user.email = txtEmail.Text;
            user.password = EncodePassword(txtPassword.Text);

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetUserAccount";

            SqlParameter userEmail = new SqlParameter("@Email", user.email);
            objCommand.Parameters.Add(userEmail);

            SqlParameter userPassword = new SqlParameter("@Password", user.password);
            objCommand.Parameters.Add(userPassword);

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            if(myDS.Tables[0].Rows.Count > 0)
            {
                if (!txtEmail.Text.Equals("") && !txtPassword.Text.Equals(""))
                {
                    Session["Email"] = txtEmail.Text;
                    if (chkRemember.Checked)
                    {
                        HttpCookie cookie = new HttpCookie("Vacation_Cookie");
                        cookie.Values["UserEmail"] = txtEmail.Text;
                        cookie.Expires = new DateTime(2030, 1, 1);
                        Response.Cookies.Add(cookie);
                        Response.Redirect("Home.aspx");
                    }
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "Client Script", "alert('Please fill out all parts of the login!')", true);
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "Client Script", "alert('User does not exist!')", true);
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        private UserVacation DeserializeCart()
        {
            int userID = (int)Session["Login"];

            DBConnect sqlDB = new DBConnect();
            UserVacation cart = new UserVacation();

            SqlCommand obj = new SqlCommand();
            obj.CommandType = CommandType.StoredProcedure;
            obj.CommandText = "TermProjectDeserializeCart";
            obj.Parameters.AddWithValue("@userID", userID);

            byte[] byteArray;
            DataSet cartDS = sqlDB.GetDataSetUsingCmdObj(obj);
            DataRow record = cartDS.Tables[0].Rows[0];

            if (record[0] != DBNull.Value)
            {
                byteArray = (byte[])record[0];
                BinaryFormatter deserializer = new BinaryFormatter();
                MemoryStream memStream = new MemoryStream(byteArray);
                cart = (UserVacation)deserializer.Deserialize(memStream);
            }

            return cart;
        }
    }
}