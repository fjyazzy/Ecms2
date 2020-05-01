<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="buy.aspx.vb" Inherits="Ecms2.buy" %>
<%@ Register tagPrefix="PageBottomhtml" tagname="Bottombar" src="components/pageBottom.ascx" %>
<%@ Register tagPrefix="PageTophtmlx" tagname="topbar" src="components/pagetopx.ascx" %>

<HTML>
	<HEAD>
		<title runat="server" id="PageTitle">电子资料-电子-资料中心</title>
		<META runat="server" id="Content1" name="description" content="" />
		<META runat="server" id="Content2" name="keywords" content="" />
		<LINK rel="stylesheet" href="css/style.css">
        <script type="text/javascript" src="js/common.js"></script>
	</HEAD>
	<body>
     <PAGETOPHTMLx:TOPBAR id="tBarx" runat="server"></PAGETOPHTMLx:TOPBAR>

		<form id="Form1" method="post" runat="server">
			<table width="998" height="64%" border="0" cellpadding="0" align="center" cellspacing="1">
				<tr>
					<td align="center"><br>
						<asp:panel id="Panel2" runat="server">
							<H2 align="center">在线定购询价单(有<font color="#ff0033">*</font>的必须填写)</H2>
							<TABLE id="Table3" cellSpacing="1" cellPadding="1" width="98%" align="center" height="343">
								<tr>
									<td align="right">公司名称：</td>
									<td align="left"><INPUT id="company" maxLength="50" size="62" name="company">
									</td>
								</tr>
								<tr>
									<td height="26" align="right">联系人：</td>
									<td height="26" align="left"><INPUT id="Name" maxLength="10" size="12" name="name"> （<font color="#ff0000"><STRONG>*</STRONG></font>）</td>
								</tr>
								<tr>
									<td align="right">联系电话：</td>
									<td align="left"><INPUT id="phone" maxLength="25" size="25" name="tel"> （<font color="#ff0000"><STRONG>*</STRONG></font>） 
										</td>
								</tr>
								<tr>
									<td align="right">传真：</td>
									<td align="left"><INPUT id="fax" maxLength="25" size="25" name="fax">
									</td>
								</tr>
								<tr>
									<td align="right">E-mail：</td>
									<td align="left"><INPUT id="email" maxLength="50" size="40" name="email">
									</td>
								</tr>
								<tr>
									<td align="right">联系地址：</td>
									<td align="left"><INPUT id="address" maxLength="50" size="40" name="address"> （<font color="#ff0000"><STRONG>*</STRONG></font>）</td>
								</tr>
								<tr>
									<td colspan="2" noWrap align="right">
                                        <div class="buyitem">
										<table>
											<tr>
												<td height="20" width="73" align="center"></td>
												<td height="20" width="142" align="center">型 号（<STRONG>*</STRONG>）</td>
												<td height="20" width="124" align="center">数量（<<STRONG>*</STRONG>）</td>
												<td height="20" width="125" align="center">品 牌</td>
												<td height="20" width="134" align="center">封 装</td>
												<td width="134" align="center">接受价</td>
											</tr>
											<tr>
												<td width="73" align="center">询价1：</td>
												<td width="142" align="left" ><asp:TextBox id="type1" runat="server" Width="126px"></asp:TextBox></td>
												<td align="center"><INPUT maxLength="10" size="5" name="sl1"></td>
												<td align="center"><INPUT maxLength="50" size="10" name="manufactory1"></td>
												<td align="center"><INPUT maxLength="10" size="8" name="fz1"></td>
												<td align="center"><INPUT maxLength="10" size="8" name="jsj1"></td>
											</tr>
											<tr>
												<td height="20" width="73" align="center">询价2：</td>
												<td width="142" align="left" ><INPUT maxLength="50" size="15" name="type2"></td>
												<td align="center"><INPUT maxLength="10" size="5" name="sl2"></td>
												<td align="center"><INPUT maxLength="50" size="10" name="manufactory2"></td>
												<td align="center"><INPUT maxLength="10" size="8" name="fz2"></td>
												<td align="center"><INPUT maxLength="10" size="8" name="jsj2"></td>
											</tr>
											<tr>
												<td height="20" width="73" align="center">询价3：</td>
												<td width="142" align="left" ><INPUT maxLength="50" size="15" name="type3"></td>
												<td align="center"><INPUT maxLength="10" size="5" name="sl3"></td>
												<td align="center"><INPUT maxLength="50" size="10" name="manufactory3"></td>
												<td align="center"><INPUT maxLength="10" size="8" name="fz3"></td>
												<td align="center"><INPUT maxLength="10" size="8" name="jsj3"></td>
											</tr>
										</table>
                                        </div>
									</td>
								</tr>
								<tr>
									<td align="right">备注说明：</td>
									<td align="left" ><TEXTAREA style="Z-INDEX: 0" id="resume" cols="80" rows="5" name="resume"></TEXTAREA></td>
								</tr>
								<tr>
									<td align="right">检验码：</td>
									<td align="left" >
										<asp:TextBox style="Z-INDEX: 0" id="JYPW" runat="server"></asp:TextBox>
										<asp:image style="Z-INDEX: 0" id="Image1" runat="server" Width="96px" ImageUrl="vcode.aspx"
											Height="27px"></asp:image></td>
								</tr>
								<tr>
									<td align="left" colspan="2">
                                        <ol>
                                        <li>填写<font color="#ff0000">接受价</font>的<font color="#339900">询价单</font>本公司将优先处理,对于胡乱填写的本公司一律不与答复.</li>
										<li>打*号的必须填写.</li>
                                        </ol>
                                            </td>
								</tr>
								<tr>
									<td colspan="2" align="center">
										<P><INPUT value="询价订购>>>>" type="submit"></P>
									</td>
								</tr>
							</TABLE>
						</asp:panel>
						<asp:panel id="Panel1" runat="server" Visible="False" Width="742px">
							<P align="center"><font color="#ff0000" size="4"><STRONG>恭喜！您填写询价单已经提交成功！</font></STRONG></P>
							<P><font size="4">您的询价表已经提交到我们的数据库中！ 
								我们会在最短的时间内用EMAIL给您回复，我们的承诺的最晚答复时间是一个工作日EMAIL回复，请您耐心等待。如果您在一个工作日后（节假日延后）还没有收到我们的EMAIL回复请电话质询，谢谢您的合作！</P>
						</asp:panel>
						<asp:panel id="Panel3" runat="server" Visible="False" Width="742px">
							<P align="center"><font color="#ff0000" size="4"><STRONG>对不起,您的定单未提交成功！</STRONG></font></P>
							<P align="center"><font size="4">请认真填写带*的栏目(姓名，联系电话，联系地址等)，点返回继续填写!</font><INPUT onclick="history.go(-1)" value="    返回     " type="button"></P>
						</asp:panel>
						<asp:panel id="Panel4" runat="server" Width="742px" Visible="False">
							<P align="center"><font color="#ff0000" size="4"><STRONG>对不起,您的校验码输入错误！</STRONG></font></P>
							<P align="center"><font size="4">点返回继续填写!</font><INPUT onclick="history.go(-1)" value="    返回     " type="button"></P>
						</asp:panel></font>
					</td>
					<td align="center" valign="top">
						<asp:Label id="Label2" runat="server"></asp:Label>
					</td>
				</tr>
			</table>

		</form>

		<PAGEBottomHTML:BottomBAR id="bottombar1" runat="server"></PAGEBottomHTML:BottomBAR>
	</body>
</HTML>
