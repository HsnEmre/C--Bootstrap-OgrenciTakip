<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="NotGuncelle.aspx.cs" Inherits="E_OkulBootstrap.WebForm9" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <form id="form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label for="txtDersAd" runat="server">Ders Adı:</asp:Label>
                <asp:TextBox ID="txtDersAd" runat="server" CssClass="form-control"></asp:TextBox>

            </div>
            <br />
            <div>
                <asp:Label for="txtOgrId" runat="server">Öğrenci ID:</asp:Label>
                <asp:TextBox ID="txtOgrId" runat="server" CssClass="form-control"></asp:TextBox>

            </div>
            <br />
            <div>
                <asp:Label for="txtOgrAdSoyad" runat="server">Öğrenci Adı Soyadı:</asp:Label>
                <asp:TextBox ID="txtOgrAdSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtSınav1" runat="server">Sınav1:</asp:Label>
                <asp:TextBox ID="txtSınav1" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtSınav2" runat="server">Sınav2:</asp:Label>
                <asp:TextBox ID="txtSınav2" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtSınav3" runat="server">Sınav3:</asp:Label>
                <asp:TextBox ID="txtSınav3" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtOrtalama" runat="server">Ortalama:</asp:Label>
                <asp:TextBox ID="txtOrtalama" runat="server" CssClass="form-control"></asp:TextBox>

            </div>
            <br />
            <div>
                <asp:Label for="txtDurum" runat="server">Durum:</asp:Label>
                <asp:TextBox ID="txtDurum" runat="server" CssClass="form-control"></asp:TextBox>

            </div>

        </div>

        <asp:Button ID="Button1" runat="server" Text="Hesapla" CssClass="btn btn-danger" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="Button2_Click" />
    </form>

</asp:Content>
