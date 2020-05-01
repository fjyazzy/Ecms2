Public Class index2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label2.Text = WCS.SearchP(3, CLng(Request("id")), Request("page"), "Catalogs.aspx")
        Label3.Text = WCS.GetNewList()

    End Sub

End Class