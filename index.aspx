<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="index.aspx.vb" Inherits="Ecms2.index2" %>
<%@ Register tagPrefix="PageBottomhtml" tagname="Bottombar" src="components/pageBottom.ascx" %>
<%@ Register tagPrefix="PageTophtml" tagname="topbar" src="components/pagetop.ascx" %>
<%@ Register tagPrefix="Menubar" tagname="menubar" src="components/menubar.ascx" %>
<%@ Register tagPrefix="CategoryList" tagname="CateList" src="components/CategoryList.ascx" %>
<%@ Register tagPrefix="searchbox" tagname="sbox" src="components/searchbox.ascx" %>
<%@ Register tagPrefix="topbar" tagname="tpb" src="components/topbar.ascx" %>
<html>
<head>
		<title runat="server" id="PageTitle">电子资料-电子-资料中心</title>
		<META runat="server" id="Content1" name="description" content="" />
		<META runat="server" id="Content2" name="keywords" content="" />
		<LINK rel="stylesheet" href="css/style.css">
        <script type="text/javascript" src="js/common.js"></script>
</head>
	<body>
        <topbar:tpb id="TOPBARt" runat="server"></topbar:tpb>
        <table class="tt">
            <tr>
                <td><PAGETOPHTML:TOPBAR id="tBar" runat="server"></PAGETOPHTML:TOPBAR></td>
                <td><searchbox:sbox id="sbox1" runat="server"></searchbox:sbox></td>
            </tr>
        </table>
		<table class="tt" border="0">
            <tr>
                <td class="dhltd2"><CategoryList:CateList id="Menubar1" imode="0" runat="server"></CategoryList:CateList></td>
                <td class="dhltd"><Menubar:Menubar id="mbar" runat="server"></Menubar:Menubar></td>
                <td class="dhltd"></td>
            </tr>
        </table>
        <table style="width:100%;height:1px;background-color:#abcdef;">
            <tr><td></td></tr>
        </table>

        
        <form id="Form1" method="post" runat="server">
        <table class="tt" border="0">
            <tr><td colspan=3 style="height:20px;"></td></tr>
			<tr>
				<td rowspan="2" style="width:600px;"><asp:Label id="Label1" runat="server"></asp:Label></td>
                <td><img src="images/slide1.jpg" /></td>
                <td style="vertical-align:text-top;margin:5px;padding:5px;">
                    <table border="0" style="width:250px;">
                        <tr><td class="homebar2">公告与资讯</td></tr>
                        <tr><td class="newslist">
                        <asp:Label id="Label3" runat="server"></asp:Label>
                        </td></tr>
                    </table>
                </td>
			</tr>
            <tr>
                <td colspan="2" style="height:320px;">
                    <asp:Label id="Label2" runat="server"></asp:Label>
                </td>
            </tr>
		</table>
		</form>

		<PAGEBottomHTML:BottomBAR id="bottombar1" runat="server"></PAGEBottomHTML:BottomBAR>
	</body>

</html>
