<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="tp_web.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Titulo" runat="server"></asp:Label>
    <h2><%Titulo.Text = TituloVacio;%></h2>
    <hr />
    <div class="row row-cols-3 row-cols-md-3 g-4">

        <asp:Repeater runat="server" ID="repCarrito">
            <ItemTemplate>
                <div class="col">
                    <div class="card">
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("Nombre") %></h5>
                            <p class="card-text">$<%#Eval("Precio") %> </p>
                            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" CommandArgument='<%#Eval("ID") %>' CommandName="CarritoID"/>

        <asp:Repeater runat="server" ID="repRepetidor">
            <ItemTemplate>
                <div class="col">
                    <div class="card">
                        <img src="<%#Eval("URLImagen") %>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("Nombre") %></h5>
                            <p class="card-text"><%#Eval("Precio") %></p>

                            <asp:ImageButton src="img/plus-lg.svg" ID="Agregar" CommandArgument='<%#Eval("ID")%>' runat="server" OnClick="Agregar_Click"/>
                            <asp:ImageButton src="img/dash.svg" ID="Restar" CommandArgument='<%#Eval("ID")%>' runat="server" OnClick="Restar_Click"/>
                            <asp:ImageButton src="img/x-lg.svg" ID="Eliminar" CommandArgument='<%#Eval("ID")%>' runat="server" OnClick="Eliminar_Click"/>

                            <asp:ImageButton src="img/plus-lg.svg" ID="Agregar" CommandArgument='<%#Eval("ID")%>' runat="server"/>
                            <asp:ImageButton src="img/dash.svg" ID="Restar" CommandArgument='<%#Eval("ID")%>' runat="server"/>
                            <asp:ImageButton src="img/x-lg.svg" ID="Eliminar" CommandArgument='<%#Eval("ID")%>' runat="server"/>

                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>


    <asp:GridView runat="server"></asp:GridView>

    <h5>Importe: <%aux.calcularImporte();%></h5>


</asp:Content>
