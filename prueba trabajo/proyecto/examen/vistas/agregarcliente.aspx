<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="agregarcliente.aspx.cs" Inherits="vistas.agregarcliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div>
            <div class="container mt-3">
                <h2>Agregar Cliente</h2>

                <div class="mb-3 mt-3">
                    <label for="lblcliente">cliente:</label>
                    <asp:TextBox ID="txtcliente" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="lbltelefono">Telefono:</label>
                    <asp:TextBox ID="txttelefono" CssClass="form-control" runat="server"></asp:TextBox>
                </div>

                 <div class="mb-3">
                    <label for="lblcorreo">Correo:</label>
                      <asp:TextBox ID="txtcorreo" CssClass="form-control" placeholder="Enter email" runat="server"></asp:TextBox>
                </div>

                
                <asp:Button ID="btnagregar" CssClass="btn btn-primary" runat="server" Text="Agregar" OnClick="btnagregar_Click" />
            </div>
        </div>



</asp:Content>
