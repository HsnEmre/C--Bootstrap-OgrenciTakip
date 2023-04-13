<%@ Page Title="" Language="C#" MasterPageFile="~/Ogrenci.Master" AutoEventWireup="true" CodeBehind="OgrenciMesajOlustur.aspx.cs" Inherits="E_OkulBootstrap.OgrenciMesajOlustur" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1" runat="server">


        <div class="form-group">
            <div>
                <asp:Label for="txtGonderen" runat="server">Mesaj Gonderen:</asp:Label>
                 <asp:TextBox ID="txtGonderen" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>

            </div>
            <br />
            <div>
                <asp:Label for="txtAlici" runat="server">Alıcı:</asp:Label>
                <asp:TextBox ID="txtAlici" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtBaslik" runat="server">Mesaj Başlık:</asp:Label><br />
                <asp:TextBox ID="txtBaslik" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txticerik" runat="server">Mesaj İçerik:</asp:Label><br />
                <textarea id="txticerik" cols="230" rows="6" cssclass="form-control" runat="server"></textarea>
            </div>
        </div>


        <asp:Button ID="BtnGonder" runat="server" Text="Mesaj Gonder" CssClass="btn btn-info" OnClick="BtnGonder_Click"   />


    </form>

</asp:Content>
