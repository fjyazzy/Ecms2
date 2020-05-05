<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="index.aspx.vb" Inherits="Ecms2.index" %>
<%@ Register tagPrefix="Mtopbar" tagname="mtpb" src="mtopbar.ascx" %>
<%@ Register tagPrefix="Mbottom" tagname="mbbar" src="mbottom.ascx" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>xx网站首页-手机端</title>
    <LINK rel="stylesheet" href="mcss.css">
</head>
<body>
    <mtopbar:mtpb id="TOPBARt" runat="server"></mtopbar:mtpb>

    <form id="form1" runat="server">
    <div>
    <table class="tt">
        <tr><td><asp:Label ID="Label1" runat="server" Text="主页广告图片"></asp:Label>
            <br />
            <img src="../images/slide1.jpg" />
            </td></tr>
    </table>
    <table class="tt">
        <tr><td><asp:Label ID="Label2" runat="server" Text="产品列表"></asp:Label></td></tr>
    </table>
    </div>
    </form>

   <mbottom:mbbar id="Mtpb1" runat="server"></mbottom:mbbar>

</body>
</html>
