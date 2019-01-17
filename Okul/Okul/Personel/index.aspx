<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Okul.Personel.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Personel Sayfası</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="card border-dark mb-3 mt-2" style="max-width: 40rem;">
        <div class="card-header ">Personel Ekleme</div>
        <div class="card-body text-dark">
            <table id="girisTablo" class="table table-sm ">
                <tr>
                    <td>Ad
                    </td>
                    <td>
                        <asp:TextBox ID="txtAd" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Soyad
                    </td>
                    <td>
                        <asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Maaş
                    </td>
                    <td>
                        <asp:TextBox ID="txtMaas" runat="server"></asp:TextBox>
                    </td>
                </tr>

            </table>
            <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-success btn-block btn-sm mt-2" />


        </div>
    </div>
    <table class="table table-striped table-sm mt-2">
        <thead class="bg-dark text-light">
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
                    <td><%# Eval("Personel_Adi") %></td>
                    <td><%# Eval("Personel_Soyadi") %></td>
                    <td><%# Eval("Personel_Maas") %></td>
                    <td>
                        <div id="butonlar">
                            <asp:HyperLink NavigateUrl='<%#"personelSil.aspx?sil="+Eval("Personel_ID") %>' Text="Sil" runat="server" CssClass="btn btn-danger btn-sm"></asp:HyperLink>
                            <asp:HyperLink Text="Güncelle" NavigateUrl='<%#"personelGuncelle.aspx?guncelle="+Eval("Personel_ID") %>' runat="server" CssClass="btn btn-primary btn-sm"></asp:HyperLink>
                        </div>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        <tr class="bg-dark text-light">
            <td colspan="6">Listelenen Personel Sayısı :
                <asp:Label ID="lblPersay" runat="server"></asp:Label></td>
        </tr>
    </table>

</asp:Content>
