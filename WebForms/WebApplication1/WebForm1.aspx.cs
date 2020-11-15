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
            GridView1.DataSource = SisplaLogic.ActividadEntListado();
            GridView1.DataBind();
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
            LinkButton lnk = (LinkButton)sender;
            int id= Convert.ToInt32(lnk.Attributes["Clave"]);

            ActividadEnt actObj=  SisplaLogic.ActividadEntListadoXId(id);

            txtComentario.Text = actObj.ActComentario;
            txtFecha.Text = actObj.ActFecha.ToString();
            txtTiempo.Text = actObj.ActTiempo.ToString();

            //Para asignar al dropdownlist(combobox)
            //En Visual 6 -> combobox.SelectedValue = valor;
            //En asp.net :
            ddlCategoria.Items.FindByValue(actObj.CatId.ToString()).Selected = true;
        
            //para tomar un valor y que no se pierda para poder usarlo en otro metodo
            ViewState["id"] = actObj.ActId;
         
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            ActividadEnt actObj = new ActividadEnt();

            actObj.ActComentario = txtComentario.Text;
            actObj.ActFecha = Convert.ToDateTime( txtFecha.Text);

            actObj.CatId = Convert.ToInt32( ddlCategoria.SelectedValue);
            actObj.ActTiempo = Convert.ToDecimal( txtTiempo.Text);
            actObj.ActId = Convert.ToInt32( ViewState["id"]);

            SisplaLogic.ActividadEntActualizar(actObj);
            cargarActividad();
        }
    }
}