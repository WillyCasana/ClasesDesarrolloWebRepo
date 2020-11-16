<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <!-- CSS -->
<!-- CSS -->
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">

<!-- jQuery and JS bundle w/ Popper.js -->
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx" crossorigin="anonymous"></script>
</head>
<body>

    <form id="form1" runat="server">

        <div class="container">

            <div class="row">

                <div class="col">
                    <asp:Label ID="Label1" runat="server" Text="Comentario"></asp:Label>
                    <asp:TextBox ID="txtComentario" CssClass="form-control" runat="server"></asp:TextBox>

                    <asp:Label ID="Label2" runat="server" Text="Fecha"></asp:Label>

                    <asp:TextBox ID="txtFecha" CssClass="form-control" runat="server"></asp:TextBox>

                    <asp:Label ID="Label3" runat="server" Text="Categoria"></asp:Label>

                    <asp:DropDownList ID="ddlCategoria" CssClass="form-control" runat="server"></asp:DropDownList>

                    <asp:Label ID="Label4" runat="server" Text="Tiempo"></asp:Label>
                    <asp:TextBox ID="txtTiempo" CssClass="form-control" runat="server"></asp:TextBox>



                </div>

            </div>


            <div class="row">
                <div class="col-md-1">
                    <asp:Button ID="btnAgregar" CssClass="btn btn-primary"  runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                </div>
                 <div class="col-md-1">
                    <asp:Button ID="btnModificar" CssClass="btn btn-primary"  runat="server" Text="Modificar" OnClick="btnModificar_Click" />
                </div>
            </div>

            <div class="row">
                <div class="col">
                    <asp:GridView ID="gvActividad" runat="server" CssClass="table table-striped" DataKeyNames="ActId" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="ActComentario" HeaderText="Comentario" />
                            <asp:BoundField DataField="ActFecha" HeaderText="Fecha" />
                            <asp:BoundField DataField="CatDescripcion" HeaderText="Descripcion" />
                            <asp:BoundField DataField="ActTiempo" HeaderText="Tiempo" />
                            <asp:TemplateField HeaderText="Seleccionar">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkSeleccionar" runat="server" CssClass="btn btn-primary" Clave='<%# Eval("ActId") %>'  OnClick="lnkSeleccionar_Click" >Seleccionar</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Eliminar">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkEliminar" runat="server" CssClass="btn btn-primary" Clave='<%# Eval("ActId") %>'  OnClick ="lnkEliminar_Click" >Eliminar</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>

                    </asp:GridView>
                </div>
            </div>

        </div>
    </form>





 
        
    
</body>
</html>
