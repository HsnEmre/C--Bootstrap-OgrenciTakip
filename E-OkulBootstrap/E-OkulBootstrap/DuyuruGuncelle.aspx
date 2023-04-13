<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="DuyuruGuncelle.aspx.cs" Inherits="E_OkulBootstrap.WebForm7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <form id="Form2" runat="server">
        <div class="form-group">
            <div>
                <asp:Label for="txtDuyuruID" runat="server">Duyuru ID:</asp:Label>
                <asp:TextBox ID="txtDuyuruID" runat="server" CssClass="form-control"></asp:TextBox>

            </div>
            <br />
            <div>
                <asp:Label for="txtDuyuruBaslik" runat="server">Duyuru Başlık:</asp:Label>
                <asp:TextBox ID="txtDuyuruBaslik" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtDuyuruIcerik" runat="server">Duyuru İçerik:</asp:Label><br />
                <textarea id="TextArea1" cols="230" rows="6" cssclass="form-control" runat="server"></textarea>
            </div>
        </div>


        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-lg" OnClick="Button1_Click" />

    </form>
</asp:Content>
