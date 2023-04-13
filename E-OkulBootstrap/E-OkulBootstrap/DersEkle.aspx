<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="DersEkle.aspx.cs" Inherits="E_OkulBootstrap.DersEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1" runat="server">


        <div class="form-group">
            
            <div>
                <asp:Label for="txtDers" runat="server">Ders Adı:</asp:Label>
                <asp:TextBox ID="txtDers" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            
        </div>


        <asp:Button ID="Button1" runat="server"  Text="Oluştur" CssClass="btn btn-info" OnClick="Button1_Click"  />


    </form>


</asp:Content>
