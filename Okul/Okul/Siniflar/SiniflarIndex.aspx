<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SiniflarIndex.aspx.cs" Inherits="Okul.Siniflar.SiniflarIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Sınıflar</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-striped table-sm mt-2">
        <thead class="bg-dark text-light">
        <tr>
            <th>Sınıf Id</th>
            <th>Sınıf Adı</th>
            <th>Sınıf Oda Numarası</th>
            <th>İşlem</th>
        </tr>
        </thead>
    <asp:Repeater ID="Repeater1" runat="server">
       
        <ItemTemplate>
            <tr>
                <td><%#Eval("SinifId") %></td>
                <td><%#Eval("SinifAdi") %></td>
                <td><%#Eval("SinifOdaNo") %></td>
                <td>
                    <div id="butonlar">
                        <asp:HyperLink NavigateUrl='<%#"sinifSil.aspx?sil="+Eval("SinifId") %>' Text="Sil" runat="server" CssClass="btn btn-danger btn-sm"></asp:HyperLink>
                        <asp:HyperLink Text="Güncelle" NavigateUrl='<%#"sinifGuncelle.aspx?guncelle="+Eval("SinifId") %>' runat="server" CssClass="btn btn-primary btn-sm"></asp:HyperLink>
                    </div>
                </td>
            </tr>
            
        </ItemTemplate>

   
        </asp:Repeater>
    </table>

</asp:Content>
