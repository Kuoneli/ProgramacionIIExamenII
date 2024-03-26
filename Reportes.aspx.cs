using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgramacionIIExamenII
{
    public partial class Reportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //EncuestasTotales();
            //EncuestasConCarro();

        }

        //protected void EncuestasTotales()
        //{
        //    string constr = ConfigurationManager.ConnectionStrings["ToServer"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("select COUNT (*) from Encuestas"))
        //        {
        //            using (SqlDataAdapter sda = new SqlDataAdapter())
        //            {
        //                cmd.Connection = con;
        //                sda.SelectCommand = cmd;
        //                using (DataTable dt = new DataTable())
        //                {
        //                    sda.Fill(dt);
        //                    GridView1.DataSource = dt;
        //                    GridView1.DataBind(); // refrescar la tabla
        //                }
        //            }
        //        }
        //    }
        //}

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TotalEncuestas_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //protected void EncuestasConCarro()
        //{
        //    string constr = ConfigurationManager.ConnectionStrings["ToServer"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("select COUNT (*) from Encuestas where CarroPropio = 'Si'"))
        //        {
        //            using (SqlDataAdapter sda = new SqlDataAdapter())
        //            {
        //                cmd.Connection = con;
        //                sda.SelectCommand = cmd;
        //                using (DataTable dt = new DataTable())
        //                {
        //                    sda.Fill(dt);
        //                    GridView1.DataSource = dt;
        //                    GridView1.DataBind(); // refrescar la tabla
        //                }
        //            }
        //        }
        //    }
        //}

        //protected void EncuestasSinCarro()
        //{
        //    string constr = ConfigurationManager.ConnectionStrings["ToServer"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("select COUNT (*) from Encuestas where CarroPropio = 'No'"))
        //        {
        //            using (SqlDataAdapter sda = new SqlDataAdapter())
        //            {
        //                cmd.Connection = con;
        //                sda.SelectCommand = cmd;
        //                using (DataTable dt = new DataTable())
        //                {
        //                    sda.Fill(dt);
        //                    GridView1.DataSource = dt;
        //                    GridView1.DataBind(); // refrescar la tabla
        //                }
        //            }
        //        }
        //    }
        //}
    }
}