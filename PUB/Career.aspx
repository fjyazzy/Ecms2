<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Career.aspx.vb" Inherits="Ecms2.Career" %>
<%@ Register tagPrefix="PageBottomhtml" tagname="Bottombar" src="components/pageBottom.ascx" %>
<%@ Register tagPrefix="PageTophtml" tagname="topbar" src="components/pagetop.ascx" %>
<%@ Register tagPrefix="Menubar" tagname="menubar" src="components/menubar.ascx" %>
<%@ Register tagPrefix="CategoryList" tagname="CateList" src="components/CategoryList.ascx" %>
<%@ Register tagPrefix="searchbox" tagname="sbox" src="components/searchbox.ascx" %>
<html>
<head>
		<title runat="server" id="PageTitle">电子资料-电子-资料中心</title>
		<META runat="server" id="Content1" name="description" content="" />
		<META runat="server" id="Content2" name="keywords" content="" />
		<LINK rel="stylesheet" href="css/style.css">
        <script type="text/javascript" src="js/common.js"></script>
</head>

	<body>
        <table class="tt" style="background:url(images/topbar1.png)">
            <tr>
                <td><PAGETOPHTML:TOPBAR id="tBar" runat="server"></PAGETOPHTML:TOPBAR></td>
                <td><searchbox:sbox id="sbox1" runat="server"></searchbox:sbox></td>
            </tr>
        </table>
		<table class="tt" border="0">
            <tr>
                <td class="dhltd"><CategoryList:CateList id="Menubar1" runat="server"></CategoryList:CateList></td>
                <td class="dhltd"><Menubar:Menubar id="mbar" runat="server"></Menubar:Menubar></td>
                <td class="dhltd" ></td>
            </tr>
        </table>
        <table class="tt" style="height:260px;background:url(images/topbar2.png)">
            <tr>
                <td></td>
            </tr>
        </table>
        
        <form id="Form1" method="post" runat="server">
        <table class="tt">
			<tr>
				<td colspan="2"><asp:Label id="Label1" runat="server"></asp:Label></td>
			</tr>
		</table>
		</form>

        <PAGEBottomHTML:BottomBAR id="bottombar1" runat="server"></PAGEBottomHTML:BottomBAR>

	</body>
</html>
