<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="pagetopx.ascx.vb" Inherits="Ecms2.pagetopx" %>
<%@ Register tagPrefix="PageBottomhtml" tagname="Bottombar" src="pageBottom.ascx" %>
<%@ Register tagPrefix="PageTophtml" tagname="topbar" src="pagetop.ascx" %>
<%@ Register tagPrefix="Menubar" tagname="menubar" src="menubar.ascx" %>
<%@ Register tagPrefix="CategoryList" tagname="CateList" src="CategoryList.ascx" %>
<%@ Register tagPrefix="searchbox" tagname="sbox" src="searchbox.ascx" %>
<%@ Register tagPrefix="topbar" tagname="tpb" src="topbar.ascx" %>

<topbar:tpb id="TOPBARt" runat="server"></topbar:tpb>
<table class="tt">
<tr>
    <td><PAGETOPHTML:TOPBAR id="tBar" runat="server"></PAGETOPHTML:TOPBAR></td>
    <td><searchbox:sbox id="sbox1" runat="server"></searchbox:sbox></td>
</tr>
</table>
<table class="tt" border="0">
    <tr>
        <td class="dhltd2"><CategoryList:CateList id="Menubar1" imode="1" runat="server"></CategoryList:CateList></td>
        <td class="dhltd"><Menubar:Menubar id="mbar" runat="server"></Menubar:Menubar></td>
        <td class="dhltd"></td>
    </tr>
</table>
<table style="width:100%;height:1px;background-color:#abcdef;">
     <tr><td></td></tr>
</table>