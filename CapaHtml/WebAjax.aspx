<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="~/WebAjax.aspx.cs" Inherits="CapaHtml.WebAjax" %>
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <title>Buscar número aleatorio en el servidor utilizando AJAX</title>
    <style>
        .label{
            font-size:30px;
        }
    </style>
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server" Height="562px">
            <asp:Panel ID="Panel2" runat="server" Height="65px">
                <asp:Panel ID="Panel3" runat="server" Height="61px" Width="400px">
                    <asp:Panel ID="Panel4" runat="server">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                    </asp:Panel>
                </asp:Panel>
            </asp:Panel>
        </asp:Panel>
        <br />
        <br />
    </div>
    </form>
</body>
</html>