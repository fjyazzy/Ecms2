<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="products.aspx.vb" Inherits="Ecms2.products" %>
<%@ Register tagPrefix="PageBottomhtml" tagname="Bottombar" src="components/pageBottom.ascx" %>
<%@ Register tagPrefix="PageTophtmlx" tagname="topbar" src="components/pagetopx.ascx" %>
<html>
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
       <table class="tt" border="0">
       <tr>
           <td style="vertical-align:middle;text-align:left;height:40px;"><div class="prnati"><asp:Label id="Label1" runat="server"></asp:Label></div></td>
        </tr>
       <tr>
           <td style="vertical-align:top;width:280px;">
                <asp:Label id="Label2" runat="server"></asp:Label>
                <h3>最新更新</h3>
                <asp:Label id="Label3" runat="server"></asp:Label>
           </td>
           <td style="vertical-align:top;text-align:left;">
                <table style="width:100%;" border="0">
                    <tr>
                        <td style="vertical-align:top;text-align:left;"><asp:Label id="Label4" runat="server">图片</asp:Label></td>
                        <td style="vertical-align:top;text-align:left;"><asp:Label id="Label5" runat="server">参数</asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan=2 style="text-align:left;break-all;">
                            <h3>产品说明</h3>
                            <asp:Label id="Label6" runat="server"></asp:Label>
                        </td>
                    </tr>        
                </table>
                <h3>类似<asp:Label id="Label7" runat="server"></asp:Label>产品</h3>
                <asp:Label id="Label8" runat="server">产品列表</asp:Label>
            </td>
        </tr>
        </table>

		</form>
		<PAGEBottomHTML:BottomBAR id="bottombar1" runat="server"></PAGEBottomHTML:BottomBAR>
</body>
</html>
