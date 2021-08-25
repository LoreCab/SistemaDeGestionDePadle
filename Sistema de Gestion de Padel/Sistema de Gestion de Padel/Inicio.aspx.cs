using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Sistema_de_Gestion_de_Padel
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Roles.IsUserInRole("Contable"))
            {
                Response.Redirect("/Contable/Inicio.aspx");
            }

            if (Roles.IsUserInRole("Operario"))
            {
                Response.Redirect("/Operario/Inicio.aspx");
            }
        }
    }
}