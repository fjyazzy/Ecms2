<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="catalogs.aspx.vb" Inherits="Ecms2.catalogs" %>
<%@ Register tagPrefix="PageBottomhtml" tagname="Bottombar" src="components/pageBottom.ascx" %>
<%@ Register tagPrefix="PageTophtmlx" tagname="topbar" src="components/pagetopx.ascx" %>

<head>
		<title runat="server" id="PageTitle">电子资料-电子-资料中心</title>
		<META runat="server" id="Content1" name="description" content="" />
		<META runat="server" id="Content2" name="keywords" content="" />
		<LINK rel="stylesheet" href="css/style.css">
        <script type="text/javascript" src="js/common.js"></script>
</head>
<body>
     <PAGETOPHTMLx:TOPBAR id="tBarx" runat="server"></PAGETOPHTMLx:TOPBAR>

        
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
