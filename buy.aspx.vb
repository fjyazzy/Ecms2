Public Class buy
    Inherits System.Web.UI.Page


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PageTitle.InnerText = WCS.GetTitle("Title", "Buy")
        Content1.Attributes.Add("name", "description")
        Content1.Attributes.Add("content", WCS.GetTitle("MetaContent", "Buy"))
        Content2.Attributes.Add("name", "keywords")
        Content2.Attributes.Add("content", WCS.GetTitle("MetaKeywords", "Buy"))

        Dim uid As Integer
        If Request("type1") <> "" Then
            If UCase(JYPW.Text) <> Session("VCode") Then
                Panel2.Visible = False
                Panel3.Visible = False
                Panel4.Visible = True
            Else
                Panel4.Visible = False
            End If

            If Panel4.Visible = False Then
                uid = 1
                If Request("name") = "" Or Request("tel") = "" Or Request("address") = "" Then
                    uid = 0
                End If
                If uid = 1 Then
                    Dim jg As String = ""
                    If Request("type1") <> "" Then
                        jg = WCS.saveOrderItem(Request("name"), Request("tel"), Request("fax"), Request("email"), Request("company"), Request("address"), Request("resume"), Request("ywy"), Request("type1"), Request("sl1"), Request("manufactory1"), Request("fz1"), Request("jsj1"))
                    End If
                    If Request("type2") <> "" Then
                        jg = WCS.saveOrderItem(Request("name"), Request("tel"), Request("fax"), Request("email"), Request("company"), Request("address"), Request("resume"), Request("ywy"), Request("type2"), Request("sl2"), Request("manufactory2"), Request("fz2"), Request("jsj2"))
                    End If
                    If Request("type3") <> "" Then
                        jg = WCS.saveOrderItem(Request("name"), Request("tel"), Request("fax"), Request("email"), Request("company"), Request("address"), Request("resume"), Request("ywy"), Request("type3"), Request("sl3"), Request("manufactory3"), Request("fz3"), Request("jsj3"))
                    End If
                    If jg <> "ok" Then
                        Response.Write(jg)
                    End If
                    Panel1.Visible = True
                    Panel2.Visible = False
                Else
                    Panel2.Visible = False
                    Panel3.Visible = True
                End If
            End If
        End If
        Label2.Text = WCS.lxfs
        If Request("p") <> "" Then
            type1.Text = Request("p")
        End If

    End Sub



End Class