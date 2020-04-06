Public Class manual1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cid As Long
        cid = CLng(Request("id"))
        Dim fv(5) As String
        fv = WCS.GetManual4id(cid)
        Dim m_title, M_Meta_C, M_Meta_Key
        m_title = WCS.GetTitle("Title", "Manual")
        m_title = Replace(m_title, "<网站名>", WZMC)
        m_title = Replace(m_title, "<产品描述>", fv(0)) 'rs.Fields("shortdesc").Value
        m_title = Replace(m_title, "<厂商>", fv(1)) 'rs.Fields("manufactory").Value
        m_title = Replace(m_title, "<资料名称>", fv(2)) 'rs.Fields("type").Value
        m_title = Replace(m_title, "<产品型号>", fv(2)) 'rs.Fields("type").Value
        M_Meta_C = WCS.GetTitle("MetaContent", "Manual")
        M_Meta_C = Replace(M_Meta_C, "<公司名>", GSMC)
        M_Meta_C = Replace(M_Meta_C, "<网站名>", WZMC)
        M_Meta_C = Replace(M_Meta_C, "<产品描述>", fv(0))
        M_Meta_C = Replace(M_Meta_C, "<厂商>", fv(1))
        M_Meta_C = Replace(M_Meta_C, "<资料名称>", fv(2))
        M_Meta_C = Replace(M_Meta_C, "<产品型号>", fv(2))
        M_Meta_Key = WCS.GetTitle("MetaKeywords", "Manual")
        M_Meta_Key = Replace(M_Meta_Key, "<公司名>", GSMC)
        M_Meta_Key = Replace(M_Meta_Key, "<网站名>", WZMC)
        M_Meta_Key = Replace(M_Meta_Key, "<产品描述>", fv(0))
        M_Meta_Key = Replace(M_Meta_Key, "<厂商>", fv(1))
        M_Meta_Key = Replace(M_Meta_Key, "<资料名称>", fv(2))
        M_Meta_Key = Replace(M_Meta_Key, "<产品型号>", fv(2))
        PageTitle.InnerText = m_title
        Content1.Attributes.Add("name", "description")
        Content1.Attributes.Add("content", M_Meta_C)
        Content2.Attributes.Add("name", "keywords")
        Content2.Attributes.Add("content", M_Meta_Key)
        Dim jg As String = ""
        jg &= "<h3>资料相关产品</h3><table border=0 width=100%>"
        jg &= "<tr><td colspan=3>"
        jg &= WCS.SearchP(1, Left(fv(2), 2), 1, "Catalogs.aspx")
        jg &= "</td></tr></table>"
        WCS.countManual(cid)
        If cid = "" Then
            cid = 0
        End If
        Label1.Text = WCS.xxzl(cid) & jg

    End Sub




End Class