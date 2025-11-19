<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio12.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
    .cal
    {
        position:absolute;
        top:50px;
        left:150px;
        right:400px;
        height:600px;
        bottom:100px;
        background-color:dodgerblue;
        padding: 20px;
    }
    .button-row {
        margin-bottom: 10px;
    }
    .calculator-button {
        height: 37px;
        width: 57px;
        margin: 2px;
    }
    </style>
</head>
<body>
    <form id="format" runat="server">
    <div class="cal">
        <asp:Label ID="Label1" Text="CALCULADORA BASICA" runat="server" Style="margin-left: 50px"
            Font-Bold="True" Font-Italic="False" ForeColor="White" Font-Size="25px"></asp:Label>
        <br />
        <asp:TextBox ID="t" runat="server" Style="margin-left: 50px; margin-top: 24px;"
            Width="335px" Height="41px"></asp:TextBox>
        <br /><br />
        
        <!-- Fila 1: 7 8 9 + -->
        <div class="button-row" style="margin-left: 50px;">
            <asp:Button ID="b7" Text="7" runat="server" CssClass="calculator-button" OnClick="b7_Click" />
            <asp:Button ID="b8" Text="8" runat="server" CssClass="calculator-button" OnClick="b8_Click" />
            <asp:Button ID="b9" Text="9" runat="server" CssClass="calculator-button" OnClick="b9_Click" />
            <asp:Button ID="add" Text="+" runat="server" CssClass="calculator-button" OnClick="add_Click" />
        </div>
        
        <!-- Fila 2: 4 5 6 - -->
        <div class="button-row" style="margin-left: 50px;">
            <asp:Button ID="b4" Text="4" runat="server" CssClass="calculator-button" OnClick="b4_Click" />
            <asp:Button ID="b5" Text="5" runat="server" CssClass="calculator-button" OnClick="b5_Click" />
            <asp:Button ID="b6" Text="6" runat="server" CssClass="calculator-button" OnClick="b6_Click" />
            <asp:Button ID="sub" Text="-" runat="server" CssClass="calculator-button" OnClick="sub_Click" />
        </div>
        
        <!-- Fila 3: 1 2 3 * -->
        <div class="button-row" style="margin-left: 50px;">
            <asp:Button ID="b1" Text="1" runat="server" CssClass="calculator-button" OnClick="b1_Click" />
            <asp:Button ID="b2" Text="2" runat="server" CssClass="calculator-button" OnClick="b2_Click" />
            <asp:Button ID="b3" Text="3" runat="server" CssClass="calculator-button" OnClick="b3_Click" />
            <asp:Button ID="mul" Text="*" runat="server" CssClass="calculator-button" OnClick="mul_Click" />
        </div>
        
        <!-- Fila 4: 0 CLR = / -->
        <div class="button-row" style="margin-left: 50px;">
            <asp:Button ID="b0" Text="0" runat="server" CssClass="calculator-button" OnClick="b0_Click" />
            <asp:Button ID="clr" Text="CLR" runat="server" CssClass="calculator-button" OnClick="clr_Click" />
            <asp:Button ID="eql" Text="=" runat="server" CssClass="calculator-button" OnClick="eql_Click" />
            <asp:Button ID="div" Text="/" runat="server" CssClass="calculator-button" OnClick="div_Click" />
        </div>
    </div>
    </form>
</body>
</html>