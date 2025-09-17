using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace AdventureWorksWeb
{
    public partial class Producto : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string productKeyStr = Request.QueryString["ProductKey"];
                if (!string.IsNullOrEmpty(productKeyStr) && int.TryParse(productKeyStr, out int productKey))
                {
                    CargarProducto(productKey);
                }
            }
        }

        private void CargarProducto(int productKey)
        {
            string connStr = ConfigurationManager.ConnectionStrings["AdventureWorksDW"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand("sp202581_ObtenerProducto", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductKey", productKey);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    FormView1.DataSource = dt;
                    FormView1.DataBind();
                }
            }
        }
    }
}
