using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Utilities;

namespace _3342DevStepFinal
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            UserVacation cart = (UserVacation)Session["Cart"];
            BinaryFormatter serial = new BinaryFormatter();
            MemoryStream memory = new MemoryStream();

            try
            {
                serial.Serialize(memory, cart);

                byte[] byteArray = memory.ToArray();

                int userID = (int)Session["Login"];

                DBConnect objDB = new DBConnect();
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TermProjectSerializeCart";

                objCommand.Parameters.AddWithValue("@userID", userID);
                objCommand.Parameters.AddWithValue("@cartArray", byteArray);


                int i = objDB.DoUpdateUsingCmdObj(objCommand);
            }
            catch (Exception ex)
            {
                //Then do nothing
            }
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}