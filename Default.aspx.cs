using System;
using IForce.WebFormsTest.Services;

namespace IForce.WebFormsTest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void GoButton_Click(object sender, EventArgs e)
        {
            var input = InputTextBox.Text ?? "";
            var encodedInput = Server.UrlEncode(input);

            Response.Redirect("Result.aspx?text=" + encodedInput, false);
            Context.ApplicationInstance.CompleteRequest();
        }
    }
}
