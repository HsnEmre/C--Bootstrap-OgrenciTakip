<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="DuyuruEkle.aspx.cs" Inherits="E_OkulBootstrap.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1" runat="server">


        <div class="form-group">
            <div>
                <asp:Label for="txtduyuruOgretmen" runat="server">Duyuru Öğretmen:</asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>

            </div>
            <br />
            <div>
                <asp:Label for="txtDuyuruBaslik" runat="server">Duyuru Başlık:</asp:Label>
                <asp:TextBox ID="txtDuyuruBaslik" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtDuyuruIcerik" runat="server">Duyuru İçerik:</asp:Label><br />
                <textarea id="TextArea1" cols="230" rows="6" CssClass="form-control" runat="server"></textarea>
            </div>
        </div>


        <asp:Button ID="Button1" runat="server" Text="Oluştur" CssClass="btn btn-info" OnClick="Button1_Click"  />


    </form>
</asp:Content>
