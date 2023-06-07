<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="agregarproductos.aspx.cs" Inherits="vistas.agregarproductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     

        <div>
            <div class="container mt-3">
                <h2>Agregar Producto</h2>

                <div class="mb-3 mt-3">
                    <label for="lblnombre">Nombre:</label>
                    <asp:TextBox ID="txtnombre" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="lblprecio">Precio:</label>
                    <asp:TextBox ID="txtprecio" CssClass="form-control" placeholder="ingrese precio" runat="server"></asp:TextBox>
                </div>

                <div class="mb-3">
                    <label for="lblcategoria">Categoria:</label>
                    <asp:TextBox ID="txtcategoria" CssClass="form-control" placeholder="categoria" runat="server"></asp:TextBox>
                </div>


                <asp:Button ID="btnagregar" CssClass="btn btn-primary" runat="server" Text="Agregar" OnClick="btnagregar_Click" />
            </div>
        </div>


</asp:Content>
