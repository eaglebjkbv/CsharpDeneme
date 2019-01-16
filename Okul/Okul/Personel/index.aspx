<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Okul.Personel.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Personel Sayfası</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="container">
    <table class="table table-striped mt-5">
        <thead class="thead-dark">
            <tr>
                <th>Personel Id</th>
                <th>Personel Adı</th>
                <th>Personel Soyadı</th>
                <th>Personel Maaşı</th>
                <th>İşlem</th>
            </tr>
        </thead>
        <asp:Repeater ID="repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("Personel_ID") %></td>
                    <td><%# Eval("PensonelAdi") %></td>
                    <td><%# Eval("PersonelSoyadi") %></td>
                    <td><%# Eval("PersonelMaas") %></td>
                    <td>
                      <div id="butonlar">
                            <asp:HyperLink  NavigateUrl='<%#"personelSil?sil="+Eval("Personel_ID") %>' Text="Sil" runat="server" CssClass="btn btn-danger btn-sm"></asp:HyperLink>
                            <asp:HyperLink Text="Güncelle" NavigateUrl='<%#"personelGuncelle?guncelle="+Eval("Personel_ID") %>' runat="server" CssClass="btn btn-primary btn-sm"></asp:HyperLink>
                        </div>  
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    </div>
</asp:Content>
