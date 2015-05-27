<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Principal.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Vvv.Web.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
       #contenido {
            background-color: #ffffff;
        }


        .auto-style1 {
            width: 344px;
        }
        .auto-style2 {
            width: 344px;
            height: 19px;
        }
        .auto-style3 {
            height: 19px;
            width: 219px;
        }
        .auto-style4 {
            width: 344px;
            height: 21px;
        }
        .auto-style5 {
            height: 21px;
            width: 219px;
        }
        .auto-style6 {
            height: 19px;
            width: 294px;
        }
        .auto-style7 {
            width: 294px;
        }
        .auto-style8 {
            height: 21px;
            width: 294px;
        }
        .auto-style9 {
            width: 219px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contenido">
    <table style="width:100%;">
        <tr>
            <td class="auto-style2">Agregar Productos Al carrito</td>
            <td class="auto-style6"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style1">Codigo</td>
            <td class="auto-style7">
                <asp:Label ID="Codigo" runat="server"></asp:Label>
            </td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Matricula</td>
            <td class="auto-style7">
                <asp:Label ID="Matricula" runat="server"></asp:Label>
            </td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Marca</td>
            <td class="auto-style7">
                <asp:Label ID="Marca" runat="server"></asp:Label>
            </td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Color</td>
            <td class="auto-style7">
                <asp:Label ID="Color" runat="server"></asp:Label>
            </td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Modelo</td>
            <td class="auto-style7">
                <asp:Label ID="Modelo" runat="server"></asp:Label>
            </td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">Precio</td>
            <td class="auto-style8">
                <asp:Label ID="Precio" runat="server"></asp:Label>
            </td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td class="auto-style1">Cantidad</td>
            <td class="auto-style7">
                1</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click1"  />
            </td>
            <td class="auto-style7">
                &nbsp;</td>
            <td class="auto-style9">
                <asp:Button ID="btnRegresar" runat="server" Text="Regresar"  style="height: 26px"  />
            </td>
        </tr>
    </table>
        </div>
  
</asp:Content>
