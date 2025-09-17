using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace AdventureWorksWeb
{
    public partial class TotalOrdenes : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTotalOrdenes();
            }
        }

        private void CargarTotalOrdenes()
        {
            string connStr = ConfigurationManager.ConnectionStrings["AdventureWorksDW"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand("sp202581_TotalOrdenesPorMes", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
        }
    }
}
