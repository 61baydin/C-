<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ClientSessionState.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>Birinci Sayı: </td>
                <td><asp:TextBox ID="txtBirinciSayi" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>İkinci Sayı: </td>
                <td> <asp:TextBox ID="txtİkinciSayi" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Sonuç: </td>
                <td> <asp:Label ID="lblSonuc" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2"> 
                    <asp:button ID="btnEkle" text="Ekle" runat="server" OnClick="btnEkle_Click"></asp:button></td>
            </tr>
            <tr>
            <td colspan="2"> <asp:GridView ID="gvSonuc" runat="server"></asp:GridView>
            </td>    
            </tr>
        </table>
    </form>
</body>
</html>
