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
            lblMensaje.Text = string.Empty;
            if (txtComentario.Text == "")
            {
                lblMensaje.Text="Falta ingresar el campo Comentario";
                return;
            }

            if (txtTiempo.Text == "")
            {
                lblMensaje.Text = "Falta ingresar el campo Tiempo";
                return;
            }

            ActividadEnt actObj = new ActividadEnt();
            actObj.ActComentario = txtComentario.Text;
            //actObj.ActFecha = Convert.ToDateTime( txtFecha.Text);
            actObj.ActFecha = Convert.ToDateTime( dFecha.Value);
            actObj.ActTiempo = Convert.ToDecimal( txtTiempo.Text);
            //actObj.CatId = Convert.ToInt32( ddlCategoria.SelectedValue);
            actObj.CatId = Convert.ToInt32( hfCat.Value);

            actObj.UsuId = 1;

            SisplaLogic.ActividadEntRegistrar(actObj);
            limpiarCtrls();

            cargarActividad();

        }

        protected void lnkSeleccionar_Click(object sender, EventArgs e)
        {
            LinkButton lnk = (LinkButton)sender;
            int id= Convert.ToInt32(lnk.Attributes["Clave"]);

            ActividadEnt actObj=  SisplaLogic.ActividadEntListadoXId(id);

            txtComentario.Text = actObj.ActComentario;
            //txtFecha.Text = actObj.ActFecha.ToString();
            txtTiempo.Text = actObj.ActTiempo.ToString();

            //Para asignar al dropdownlist(combobox)
            //En Visual 6 -> combobox.SelectedValue = valor;
            //En asp.net :


            cargarCategoria();
            ddlCategoria.Items.FindByValue(actObj.CatId.ToString()).Selected = true;
        
            //para tomar un valor y que no se pierda para poder usarlo en otro metodo
            ViewState["id"] = actObj.ActId;
         
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            ActividadEnt actObj = new ActividadEnt();

            actObj.ActComentario = txtComentario.Text;
            //actObj.ActFecha = Convert.ToDateTime( txtFecha.Text);
            actObj.ActFecha = Convert.ToDateTime( dFecha.Value);
            //actObj.CatId = Convert.ToInt32( ddlCategoria.SelectedValue);
            actObj.CatId = Convert.ToInt32( hfCat.Value);

            actObj.ActTiempo = Convert.ToDecimal( txtTiempo.Text);
            actObj.ActId = Convert.ToInt32( ViewState["id"]);
            actObj.UsuId = 1;

            SisplaLogic.ActividadEntActualizar(actObj);

            limpiarCtrls();

            cargarActividad();
        }

        private void limpiarCtrls()
        {
            txtComentario.Text = string.Empty;
           // txtFecha.Text = string.Empty;
            txtTiempo.Text = string.Empty;
            ddlCategoria.SelectedIndex = -1;
        }

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32( ddlCategoria.SelectedValue);
        }

        //protected void ddlCategoria_SelectedIndexChanged1(object sender, EventArgs e)
        //{
        //    ViewState["catAct"]= ddlCategoria.SelectedValue;
        //}
    }
}