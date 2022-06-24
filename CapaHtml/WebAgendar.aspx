<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebAgendar.aspx.cs" Inherits="CapaHtml.WebAgendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Agendar</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <style>
        .label{
            font-size:30px;
        }
    </style>
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
    
</head>
<body class="form-control bg-light">
    <form id="form1" class="form-check" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="margin-left: 413px"   Text ="AGENDAMIENTO" Width="159px" CssClass="active carousel-item-end" ForeColor="#CC3300" Height="234px"></asp:Label>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" style="margin-left: 200px" Text="ID Agendamiento" Width="143px" CssClass="align-content-center"></asp:Label>
            <asp:TextBox ID="txtIdAgendamiento" runat="server" style="margin-left: 6px" Width="210px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" style="margin-left: 198px" Text="Horario" Width="151px"></asp:Label>
            <asp:Calendar ID="Calendario" runat="server" style="margin-left: 344px" Width="231px"></asp:Calendar>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" style="margin-left: 197px" Text="Rut Medico" Width="150px"></asp:Label>
            <asp:TextBox ID="txtRutMedico" runat="server" Width="218px"></asp:TextBox>
        </p>
        <asp:Panel ID="Panel1" runat="server" Width="152px">
        </asp:Panel>
        <p>
            <asp:Label ID="Label5" runat="server" style="margin-left: 197px" Text="Rut Paciente" Width="130px"></asp:Label>
            <asp:TextBox ID="txtRutPaciente" runat="server" style="margin-left: 21px" Width="213px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnAgendar" runat="server" Height="30px" style="margin-left: 351px" Text="Agendar" Width="215px" OnClick="btnAgendar_Click" />
        </p>
    </form>
</body>
</html>
