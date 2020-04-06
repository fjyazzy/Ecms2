Public Class products
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '在此处放置初始化页的用户代码
        Dim cid As Integer
        cid = CLng(Request("id"))

        Dim fv(10) As String
        fv = WCS.GetProduct4id(cid)
        Dim P_title, P_Meta_C, P_Meta_Key
        P_title = WCS.GetTitle("Title", "Product")
        P_title = Replace(P_title, "<公司名>", GSMC)
        P_title = Replace(P_title, "<网站名>", WZMC)
        P_title = Replace(P_title, "<产品价格>", fv(0))
        P_title = Replace(P_title, "<产品描述>", fv(1))
        P_title = Replace(P_title, "<厂商>", fv(2))
        P_title = Replace(P_title, "<产品型号>", fv(3))

        P_Meta_C = WCS.GetTitle("MetaContent", "Product")
        P_Meta_C = Replace(P_Meta_C, "<公司名>", GSMC)
        P_Meta_C = Replace(P_Meta_C, "<网站名>", WZMC)
        P_Meta_C = Replace(P_Meta_C, "<产品价格>", fv(0))
        P_Meta_C = Replace(P_Meta_C, "<产品描述>", fv(1))
        P_Meta_C = Replace(P_Meta_C, "<厂商>", fv(2))
        P_Meta_C = Replace(P_Meta_C, "<产品型号>", fv(3))

        P_Meta_Key = WCS.GetTitle("MetaKeywords", "Product")
        P_Meta_Key = Replace(P_Meta_Key, "<公司名>", GSMC)
        P_Meta_Key = Replace(P_Meta_Key, "<网站名>", WZMC)
        P_Meta_Key = Replace(P_Meta_Key, "<产品价格>", fv(0))
        P_Meta_Key = Replace(P_Meta_Key, "<产品描述>", fv(1))
        P_Meta_Key = Replace(P_Meta_Key, "<厂商>", fv(2))
        P_Meta_Key = Replace(P_Meta_Key, "<产品型号>", fv(3))


        PageTitle.InnerText = P_title
        Content1.Attributes.Add("name", "description")
        Content1.Attributes.Add("content", P_Meta_C)
        Content2.Attributes.Add("name", "keywords")
        Content2.Attributes.Add("content", P_Meta_Key)

        Dim jg, jgx1, jgx2, jgx3 As String

        '生成产品基本信息 -- jgx1
        jgx1 = ""
        jgx1 &= "<h3>" & fv(3) & "&nbsp&nbsp<a href=Buy.aspx?p=" & fv(3) & ">购买本产品>></a></h3>"
        jgx1 &= WCS.getCateName4cid(fv(6))

        jgx1 &= "<table border=0 width=100% cellpadding=3 cellspacing=1 bgcolor=#999999>"
        jgx1 &= "<tr><td bgcolor=#ffffff>厂商</td><td bgcolor=#ffffff>" & fv(2) & "</td></tr>"
        jgx1 &= "<tr><td bgcolor=#ffffff>封装</td><td bgcolor=#ffffff>" & fv(7) & "</td></tr>"
        jgx1 &= "<tr><td bgcolor=#ffffff>批号</td><td bgcolor=#ffffff>" & fv(8) & "</td></tr>"
        jgx1 &= "<tr><td bgcolor=#ffffff>价格</td><td bgcolor=#ffffff>" & "电询</td></tr>"
        jgx1 &= "<tr><td bgcolor=#ffffff>起售数量</td><td bgcolor=#ffffff>" & fv(9) & "</td></tr>"
        jgx1 &= "<tr><td bgcolor=#ffffff>描述</td><td bgcolor=#ffffff>" & fv(1) & "</td></tr>"
        jgx1 &= "<tr><td colspan=2 bgcolor=#ffffff>"
        jgx1 &= "查看<a target=_blank href=manual.aspx?skey=" & fv(3) & ">" & fv(3) & "资料, 相关资料</a>"
        jgx1 &= "</td></tr>"
        jgx1 &= "<tr><td colspan=2 bgcolor=#abcdef>"
        jgx1 &= "<a href=Buy.aspx?p=" & fv(3) & "><font color=red size=4>购买" & fv(3) & "</a>"
        jgx1 &= "</td></tr>"
        jgx1 &= "</table>"

        '生成产品图片信息 -- jgx2 
        jgx2 = ""
        If Len(fv(4)) > 5 Then
            jgx2 &= "<a href=showpic.aspx?i=" & fv(4) & " target=_blank><img src='photos/" & fv(4) & "' alt=" & fv(3) & " border=0 width=300></a>"
        Else
            jgx2 &= "<img src='images/Come_on.gif' border=0 width=300 alt=" & fv(3) & " >"
        End If

        '生成产品说明信息  -- jgx3
        jgx3 = ""
        If System.Convert.IsDBNull(fv(5)) = True Then
            jgx3 &= "<b>产品说明</b><br>请来电咨询!"
        Else
            jgx3 &= "<b>产品说明</b><br>" & Replace(Replace(fv(5), vbCrLf, "<br>"), " ", "&nbsp") & "<br>"
        End If

        '产品页面最终排版
        jg = "<table width=998 border=0 style='font-size:12pt;'>"
        jg &= "<tr>"
        jg &= "<td width=280 valign=top>"
        jg &= WCS.lxfs()
        jg &= "<h3>最新更新</h3>"
        jg &= WCS.SearchP(9, 0, 0, "Products.aspx")
        jg &= "</td>"
        jg &= "<td valign=top>"
        jg &= "<table border=0>"
        jg &= "<tr>"
        jg &= "<td width=345 valign=top>" & jgx2 & "</td>"
        jg &= "<td>" & jgx1 & "</td>"
        jg &= "</tr>"
        jg &= "<tr>"
        jg &= "<td colspan=2 style=""word-break:break-all;"">" & jgx3 & "</td>"
        jg &= "</tr>"
        jg &= "</table>"
        jg &= "<p><h3>类似" & fv(3) & "产品</h3>"
        jg &= WCS.SearchP(1, Left(fv(3), 2), 1, "Catalogs.aspx")
        jg &= "</p>"
        jg &= "</td>"
        jg &= "</tr>"
        jg &= "</table>"
        'jg &= "<font color=red>错误ID号!"
        '
        WCS.countProduct(cid)
        Label1.Text = jg

    End Sub

End Class