Public Class Mypages
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim str As String = WCS.Checkstr(Request("p"))
        Dim cid As String = WCS.Checkstr(Request("id"))

        Select Case str
            Case "Aboutus"
                PageTitle.InnerText = WCS.GetTitle("Title", "Aboutus")
                Content1.Attributes.Add("name", "description")
                Content1.Attributes.Add("content", WCS.GetTitle("MetaContent", "Aboutus"))
                Content2.Attributes.Add("name", "keywords")
                Content2.Attributes.Add("content", WCS.GetTitle("MetaKeywords", "Aboutus"))
                Label1.Text = WCS.GetWebContent("公司简介")
            Case "Career"
                PageTitle.InnerText = WCS.GetTitle("Title", "Career")
                Content1.Attributes.Add("name", "description")
                Content1.Attributes.Add("content", WCS.GetTitle("MetaContent", "Career"))
                Content2.Attributes.Add("name", "keywords")
                Content2.Attributes.Add("content", WCS.GetTitle("MetaKeywords", "Career"))
                Label1.Text = WCS.GetWebContent("招聘")
            Case "Links"
                PageTitle.InnerText = WCS.GetTitle("Title", "Aboutus")
                Content1.Attributes.Add("name", "description")
                Content1.Attributes.Add("content", WCS.GetTitle("MetaContent", "Aboutus"))
                Content2.Attributes.Add("name", "keywords")
                Content2.Attributes.Add("content", WCS.GetTitle("MetaKeywords", "Aboutus"))
                Label1.Text = WCS.GetWebContent("友情链接")
            Case "Notices"
                PageTitle.InnerText = WCS.GetTitle("Title", "Aboutus")
                Content1.Attributes.Add("name", "description")
                Content1.Attributes.Add("content", WCS.GetTitle("MetaContent", "Aboutus"))
                Content2.Attributes.Add("name", "keywords")
                Content2.Attributes.Add("content", WCS.GetTitle("MetaKeywords", "Aboutus"))
                Label1.Text = WCS.GetWebContent("法律声明")
            Case "Contactus"
                PageTitle.InnerText = WCS.GetTitle("Title", "Contactus")
                Content1.Attributes.Add("name", "description")
                Content1.Attributes.Add("content", WCS.GetTitle("MetaContent", "Contactus"))
                Content2.Attributes.Add("name", "keywords")
                Content2.Attributes.Add("content", WCS.GetTitle("MetaKeywords", "Contactus"))
                Label1.Text = WCS.GetWebContent("联系我们")
            Case "News"
                Label1.Text = WCS.GetNews4id(cid)
            Case "bom"
                Label1.Text = WCS.GetWebContent("BOM配单")
        End Select

    End Sub

End Class