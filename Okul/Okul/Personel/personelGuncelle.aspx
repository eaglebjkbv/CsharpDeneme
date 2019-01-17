<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="personelGuncelle.aspx.cs" Inherits="Okul.Personel.personelGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Güncelleme Sayfası</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card border-dark mb-3 mt-2" style="max-width: 40rem;">
        <div class="card-header ">Personel Güncelleme</div>
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
            <asp:Button ID="Button1"  OnClick="Button1_OnClick" runat="server" Text="Kaydet" CssClass="btn btn-success btn-block btn-sm mt-2" />


        </div>
    </div>
</asp:Content>
