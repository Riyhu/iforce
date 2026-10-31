using System;
using System.Text;
using System.Web;
using System.Web.UI;
using IForce.WebFormsTest.Configurations;
using IForce.WebFormsTest.Services.ProductServices;

namespace IForce.WebFormsTest
{
    public partial class Products : System.Web.UI.Page
    {
        private bool isExporting;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindProducts(string.Empty);
            }
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            BindProducts(KeywordTextBox.Text);
        }

        protected void ExportButton_Click(object sender, EventArgs e)
        {
            var productService = ServiceConfiguration.GetRequiredService<ProductService>();
            var csv = productService.ExportCsv(KeywordTextBox.Text);
            isExporting = true;

            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "text/csv";
            Response.ContentEncoding = Encoding.UTF8;
            Response.Charset = "utf-8";
            Response.AddHeader("Content-Disposition", "attachment; filename=products.csv");
            Response.Write(csv);
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }

        protected override void Render(HtmlTextWriter writer)
        {
            if (!isExporting)
            {
                base.Render(writer);
            }
        }

        private void BindProducts(string keyword)
        {
            var productService = ServiceConfiguration.GetRequiredService<ProductService>();
            var products = productService.Search(keyword);

            ProductsGridView.DataSource = products;
            ProductsGridView.DataBind();
        }
    }
}
