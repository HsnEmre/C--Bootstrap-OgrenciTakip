<%@ Page Title="" Language="C#" MasterPageFile="~/Ogrenci.Master" AutoEventWireup="true" CodeBehind="OgrenciDefault.aspx.cs" Inherits="E_OkulBootstrap.OgrenciDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1" runat="server">


        <div class="form-group">
            <div>

                <asp:TextBox ID="txtbx1" runat="server" CssClass="form-control" Enabled="False">Numara:</asp:TextBox>

            </div>
            <br />
            <div>

                <asp:TextBox ID="txtbx2" runat="server" CssClass="form-control">Ad Soyad:</asp:TextBox>

            </div>
            
            <br />
            <div>

                <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control">Mail:</asp:TextBox>

            </div>
            <br />
            <div>

                <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control">Fotoğraf:</asp:TextBox>

            </div>
            <br />
            <div>

                <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control">Telefon:</asp:TextBox>

            </div>
            <br />
            <div>

                <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control">Şifre:</asp:TextBox>

            </div>

            <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-success" OnClick="Button1_Click"/>
        </div>



    </form>



</asp:Content>
