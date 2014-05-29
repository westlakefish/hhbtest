<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="b.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>test github</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            我在这里test一下github ,已经可以上传了
                <div>
                    <asp:TextBox ID="tbCompany" runat="server" Height="16px" Width="252px"></asp:TextBox>
                    <asp:Button ID="btnSearch" runat="server" Text="搜索" OnClick="btnSearch_Click" />
                </div>
        </div>
        <div>
            <asp:Repeater ID="rptCompany" runat="server">
                <ItemTemplate><%#Eval("Name") %><br/></ItemTemplate>
            </asp:Repeater>
        </div>
                <div>
            <asp:Repeater ID="rptBuilder" runat="server">
                <ItemTemplate><%#Eval("BName") %><br/></ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
