Public Class index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label2.Text = WCS.SearchP(3, CLng(Request("id")), Request("page"), "Catalogs.aspx")
    End Sub

End Class