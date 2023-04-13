<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="NotListesi.aspx.cs" Inherits="E_OkulBootstrap.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <table class="table table-bordered table-hover">

        <tr>
            <th scope="col">ÖĞRENCİ ID</th>
            <th scope="col">AD SOYAD</th>
            <th scope="col">DERS AD</th>
            <th scope="col">SINAV1</th>
            <th scope="col">SINAV2</th>
            <th scope="col">SINAV3</th>
            <th scope="col">ORTALAMA</th>
            <th scope="col">DURUM</th>
        </tr>
        <%--<th scope="row">1</th>--%>
        <tbody>
            <%--Repeater Ekleme işlemi--%>
            <asp:Repeater ID="Repeater1" runat="server">

                <ItemTemplate>
                    <tr>
                        <%--eval metodu ile veri çekicez
                        backend tarafındada kodları yazınca gelicek--%>
                        
                        <td><%#Eval("OGRENCIID")%></td>
                        <td><%#Eval("ÖĞRENCİADSOYAD")%></td>
                        <td><%#Eval("DERSAD")%></td>
                        <td><%#Eval("SINAV1")%></td>
                        <td><%#Eval("SINAV2")%></td>
                        <td><%#Eval("SINAV3")%></td>
                        <td><%#Eval("ORTALAMA")%></td>
                        <td><%#Eval("DURUM")%></td>
                                             
                        <td>
                            
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"NotGuncelle.aspx?NOTID="+Eval("NOTID") %>' runat="server" CssClass="btn btn-danger">GÜNCELLE</asp:HyperLink>
                            
                        </td>


                    </tr>
                </ItemTemplate>
            </asp:Repeater>



        </tbody>
    </table>


</asp:Content>
