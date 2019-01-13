<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebformIlk.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Sınıf Listeleme</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Sınıfların Listesi </h1>
    <table class="table table-hover  table-striped table-sm ">
        <thead class="thead thead-dark">
            <th>Sınıf Id</th>
            <th>Sınıf Adı</th>
            <th>Sınıf Oda No</th>
            <th>İşlem</th>
        </thead>
        <asp:Repeater ID="rep1" runat="server">
            <ItemTemplate>

                <tr>
                    <td><%# Eval("id")%></td>
                    <td><%# Eval("sinifAdi")%></td>
                    <td><%# Eval("odaNo")%></td>
                    <td>
                        <asp:HyperLink NavigateUrl='<%# "sinifsil.aspx?id="+Eval("id")%>' Text="Sil" CssClass="btn btn-danger btn-sm" runat="server" />
                        <asp:HyperLink NavigateUrl='<%# "SinifGuncelle.aspx?id="+Eval("id")%>' Text="Düzenle" CssClass="btn btn-success btn-sm" runat="server" />
                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>
    <div class="card">
        <div class="card-header">
            Yeni Kayıt Girişi
        </div>
        <div class="card-body">

            <table class="table  table-borderless  table-sm">
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
                        <asp:Label ID="label1" runat="server" />

                    </td>
                    <td>
                        <asp:Button ID="Button1" Text="Kaydet" runat="server" OnClick="btnKaydet_Click" CssClass="bnt btn-primary" />


                    </td>
                </tr>
            </table>



        </div>
    </div>




</asp:Content>
