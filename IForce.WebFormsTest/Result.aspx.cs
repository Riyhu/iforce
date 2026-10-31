using System;
using IForce.WebFormsTest.Services;

namespace IForce.WebFormsTest
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var input = Request.QueryString["text"] ?? "";
                ReversedTextLiteral.Text = new ReverseTextService().Reverse(input);
            }
        }
    }
}
