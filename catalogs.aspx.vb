Public Class catalogs
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        PageTitle.InnerText = WCS.GetTitle("Title", "Catalogs")
        Content1.Attributes.Add("name", "description")
        Content1.Attributes.Add("content", WCS.GetTitle("MetaContent", "Catalogs"))
        Content2.Attributes.Add("name", "keywords")
        Content2.Attributes.Add("content", WCS.GetTitle("MetaKeywords", "Catalogs"))

        Dim pagex As String = IIf(Request("page") = "", 1, Request("page"))
        If Request("skey") <> "" Then
            Label1.Text = WCS.SearchP(CInt(Request("mode")), Request("skey"), pagex, "Catalogs.aspx")
            Label1.Text &= WCS.SearchZl(1, Request("skey"), pagex, "Catalogs.aspx")
        Else
            If Request("id") <> "" Then
                Label1.Text = WCS.SearchP(2, CLng(Request("id")), Request("page"), "Catalogs.aspx")
            Else
                Label1.Text = WCS.pCateList("Catalogs.aspx")
            End If
        End If


    End Sub

End Class