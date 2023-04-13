<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="OgrenciEkle.aspx.cs" Inherits="E_OkulBootstrap.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label for="txtOgrAd" runat="server">Öğrenci Adı:</asp:Label>
                <asp:TextBox ID="txtOgrAd" runat="server" CssClass="form-control"></asp:TextBox>

            </div>
            <br />
            <div>
                <asp:Label for="txtOgrSoyad" runat="server">Öğrenci Soyadı:</asp:Label>
                <asp:TextBox ID="txtOgrSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtOgrTel" runat="server">Öğrenci Telefon:</asp:Label>
                <asp:TextBox ID="txtOgrTel" runat="server" CssClass="form-control"></asp:TextBox>
            </div>  
            <br />
            <div>
                <asp:Label for="txtOgrMail" runat="server">Öğrenci Mail:</asp:Label>
                <asp:TextBox ID="txtOgrMail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>  
            <br />
            <div>
                <asp:Label for="txtOgrSifre" runat="server">Öğrenci Şifre:</asp:Label>
                <asp:TextBox ID="txtOgrSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>  
            <br />
            <div>
                <asp:Label for="txtOgrFoto" runat="server">Öğrenci Foto:</asp:Label>
                <asp:TextBox ID="txtOgrFoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div> 

        </div>

        <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-info" OnClick="Button1_Click" />

    </form>

</asp:Content>
