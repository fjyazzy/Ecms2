<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="showpic.aspx.vb" Inherits="Ecms2.showpic" %>
<%@ Register tagPrefix="PageBottomhtml" tagname="Bottombar" src="components/pageBottom.ascx" %>
<%@ Register tagPrefix="PageTophtmlx" tagname="topbar" src="components/pagetopx.ascx" %>
<html>
<head>
		<title runat="server" id="PageTitle">电子资料-电子-资料中心</title>
		<META runat="server" id="Content1" name="description" content="" />
		<META runat="server" id="Content2" name="keywords" content="" />
		<LINK rel="stylesheet" href="css/style.css">
        <script type="text/javascript" src="js/common.js"></script>
		<script type="text/javascript">
		function fd(tsrc){
			tsrc.width=tsrc.width*1.1;
		}				
		function sx(tsrc){
			tsrc.width=tsrc.width*0.9;
		}
		</script>
</head>

	<body>
 
     <PAGETOPHTMLx:TOPBAR id="tBarx" runat="server"></PAGETOPHTMLx:TOPBAR>


		<table border="1" align="center">
			<tr>
				<td><input type="button" value="放大" onclick="fd(document.all.Img1);">
                    <input type="button" value="缩小" onclick="sx(document.all.Img1);"></td>
			</tr>
			<tr>
				<td align="center" valign="top" height="600" width="800">
                    <form id="Form1" method="post" runat="server">
                        <asp:Label id="Label1" runat="server">Label</asp:Label>
		            </form>
				</td>
			</tr>
		</table>


		<PAGEBottomHTML:BottomBAR id="bottombar1" runat="server"></PAGEBottomHTML:BottomBAR>
	</body>
</html>
