﻿Public Class mtopbar
    Inherits System.Web.UI.UserControl
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = WCS.GetSearchBox
        Label2.Text = WCS.GetWebContent("菜单栏")
    End Sub

End Class