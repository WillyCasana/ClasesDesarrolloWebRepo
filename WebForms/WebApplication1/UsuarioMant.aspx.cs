using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SisPlaBLL;

namespace WebApplication1
{
    public partial class UsuarioMant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           cargarUsuarios();

            cargarRoles();
                
        }

        private void cargarRoles()
        {

            ddlRol.DataSource = SisplaLogic.RolListado();
            ddlRol.DataValueField = "RolId";
            ddlRol.DataTextField = "RolDescripcion";
            ddlRol.DataBind();
        }

        private void cargarUsuarios()
        {
            gvUsuarios.DataSource = SisplaLogic.UsuarioListado();
            gvUsuarios.DataBind();
        }
    }
}