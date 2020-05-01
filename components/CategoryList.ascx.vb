Public Class Cat_column
    Inherits System.Web.UI.UserControl

    Property iMode() As String
        Get
            Return Me.ViewState("iMode")
        End Get
        Set(ByVal value As String)
            Me.ViewState("iMode") = value
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = WCS.GetCategoryList(iMode)
    End Sub
End Class