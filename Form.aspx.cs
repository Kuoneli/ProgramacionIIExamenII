using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgramacionIIExamenII
{
    public partial class Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void VerificarEdad_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(TextoEdad.Text);
            
            if (edad < 18 && edad > 50)
            {
                AlertaEdad.Visible = true;
                AlertaEdad.Text = "Debe ser mayor a 17 años y menor a 51 para poder completar la Encuesta";
            }
            
        }

        protected void FNacimiento_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}