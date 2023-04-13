<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="E_OkulBootstrap.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Dosyalar1/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 700px; margin: auto">

            <h4>Udemy Web Öğrenci Sınav Not Sistemi Giriş Ekranı</h4>
            <br />
            <br />
            <br />
            <div style="margin: auto; text-align: center;">
                <asp:Image ID="Image1" runat="server" Height="247px" ImageUrl="~/avatar2.png" Width="245px" />
            </div>
            <br />
            <br />

            <div>
                <asp:Label for="txtNumara" runat="server">Kullanıcı Adı:</asp:Label>
                <asp:TextBox ID="txtNumara" runat="server" CssClass="form-control" OnTextChanged="txtDers_TextChanged" Width="497px"></asp:TextBox>
            </div>
            <br />

            <div>
                <asp:Label for="txtSifre" runat="server">Şifre:</asp:Label>
                <asp:TextBox ID="txtSifre" runat="server" CssClass="form-control" OnTextChanged="txtDers_TextChanged" Width="497px"></asp:TextBox>
            </div>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Giriş Yap" CssClass="btn btn-warning" Width="700px" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="İptal Et" CssClass="btn btn-danger" Width="200px" />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Şifremi Unuttum" CssClass="btn btn-default" Width="300px" />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Yardım" CssClass="btn btn-info" Width="200px" />

        </div>

    </form>
</body>
</html>
