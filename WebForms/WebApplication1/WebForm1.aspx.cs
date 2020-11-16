using SisPla;
using SisPlaBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        #region Variables
        int idAux = 0;
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

           
            cargarActividad();
            cargarCategoria();
        }

        private void cargarCategoria()
        {
            ddlCategoria.DataSource = SisplaLogic.CategoriaEntListado();
            ddlCategoria.DataValueField = "CatId";
            ddlCategoria.DataTextField = "CatDescripcion";
            ddlCategoria.DataBind();
        }

        private void cargarActividad()
        {
            gvActividad.DataSource = SisplaLogic.ActividadEntListado();
            gvActividad.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            ActividadEnt actObj = new ActividadEnt();
            actObj.ActComentario = txtComentario.Text;
            actObj.ActFecha = Convert.ToDateTime( txtFecha.Text);
            actObj.ActTiempo = Convert.ToDecimal( txtTiempo.Text);

           
            actObj.CatId = Convert.ToInt32( ddlCategoria.SelectedValue);
            actObj.UsuId = 1;

            SisplaLogic.ActividadEntRegistrar(actObj);

            cargarActividad();

        }

        protected void lnkSeleccionar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32( ((LinkButton)(sender)).Attributes["Clave"].ToString());
            //int id= (int) gvActividad.DataKeys[2].Value;
            ActividadEnt actObj = SisplaLogic.ActividadEntListadoXId(id);

            txtComentario.Text = actObj.ActComentario;
            txtFecha.Text = actObj.ActFecha.ToString();
            txtTiempo.Text = actObj.ActTiempo.ToString();


            //cargarCategoria();
            ddlCategoria.Items.FindByValue(actObj.CatId.ToString()).Selected = true;

            idAux = actObj.ActId;
            ViewState["id"] = actObj.ActId;
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ViewState["id"]);
            //  id = idAux; //solo funcionaría en el caso de winforms

            ActividadEnt actObj = new ActividadEnt();

            actObj.ActId = id;
            actObj.ActComentario = txtComentario.Text;
            actObj.ActFecha = Convert.ToDateTime(txtFecha.Text);
            actObj.ActTiempo = Convert.ToDecimal(txtTiempo.Text);


            actObj.CatId = Convert.ToInt32(ddlCategoria.SelectedValue);
            actObj.UsuId = 1;

            SisplaLogic.ActividadEntActualizar(actObj);

            cargarActividad();

        }

        protected void lnkEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((LinkButton)(sender)).Attributes["Clave"].ToString());

            SisplaLogic.ActividadEntEliminar(id);

            cargarActividad();
        }
    }
}