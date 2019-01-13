<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SinifGuncelle.aspx.cs" Inherits="WebformIlk.SinifGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Sınıf Güncelleme
    </title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card">
        <div class="card-header">
            Sınıf Kayıt Güncelleme
        </div>
        <div class="card-body">
            <table>
                <tr>
                    <td>Sınıf Adı:
                    </td>
                    <td>
                        <asp:TextBox ID="txtSinifAd" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Sınıf Oda:
                    </td>
                    <td>
                        <asp:TextBox ID="txtSinifOda" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnKaydet" Text="Kaydet" runat="server" OnClick="btnKaydet_Click"
                            CssClass="btn btn-primary" />
                    </td>
                    <td>
                        <asp:Label ID="label1" runat="server" />
                    </td>
                </tr>
            </table>

        </div>

    </div>
</asp:Content>
