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
           
            EncuestasTotales();
            ConCarro();
            SinCarro();

        }

        protected void EncuestasTotales()
        {
            SqlConnection con = new SqlConnection(@"data source=localhost;initial catalog = Encuesta;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Encuestas", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            con.Close();
        }

        protected void ConCarro()
        {
            SqlConnection con = new SqlConnection(@"data source=localhost;initial catalog = Encuesta;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Encuestas where CarroPropio = 'Si'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            GridView2.DataSource = rdr;
            GridView2.DataBind();
            con.Close();

        }


        protected void SinCarro()
        {
            SqlConnection con = new SqlConnection(@"data source=localhost;initial catalog = Encuesta;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Encuestas where CarroPropio = 'No'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            GridView3.DataSource = rdr;
            GridView3.DataBind();
            con.Close();

        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TotalEncuestas_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}