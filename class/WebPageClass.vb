Imports System.Net
Imports System.IO
Imports System.Net.Security
Imports System.Security.Authentication
Imports System.Security.Cryptography.X509Certificates
Public Class WebPageClass
    Public Function GetSystemInfo(ByVal itemno As String) As String
        Dim jg As String = ""
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=GetSystemInfo&itemno=" & itemno
        jg = getWebpage(url, "GET")
        Return jg
    End Function
    Public Function GetWebContent(ByVal mc As String) As String
        Dim jg As String = ""
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=GetWebContent&mc=" & mc
        jg = getWebpage(url, "GET")
        Return jg
    End Function
    Public Function GetTitle(ByVal str1 As String, ByVal str2 As String) As String
        Dim jg As String = ""
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=GetTitle&str1=" & str1 & "&str2=" & str2
        jg = getWebpage(url, "GET")
        Return jg
    End Function
    Public Function GetCategoryList(ByVal str1 As String) As String
        Dim jg As String = ""
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=GetCategoryList&str1=" & str1
        jg = getWebpage(url, "GET")
        Return jg
    End Function
    Public Function GetSearchBox()
        Dim jg As String = ""
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=GetSearchBox"
        jg = getWebpage(url, "GET")
        Return jg
    End Function
    ' 显示产品列表
    Function SearchP(ByVal mode As String, ByVal Skey As String, ByVal pagex As String, ByVal thisprog As String) As String
        Dim jg As String = ""
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=SearchP&mode=" & mode & "&skey=" & Skey & "&pagex=" & pagex & "&thisprog=" & thisprog
        jg = getWebpage(url, "GET")
        jg = Replace(jg, "<<Remote_Center_Photos>>", Center_PicUrl)
        Return jg
    End Function
    ' 显示目录产品列表
    Function pCateList(ByVal thisprog As String) As String
        Dim jg As String = ""
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=pCateList&thisprog=" & thisprog
        jg = getWebpage(url, "GET")
        Return jg
    End Function
    Function CateList(ByVal thisprog) As String
        Dim jg As String = ""
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=CateList&thisprog=" & thisprog
        jg = getWebpage(url, "GET")
        Return jg
    End Function
    ' 显示资料列表
    Function SearchZl(ByVal mode As Integer, ByVal Skey As String, ByVal pagex As Integer, ByVal thisprog As String) As String
        Dim jg As String = ""
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=SearchZl&mode=" & mode & "&skey=" & Skey & "&pagex=" & pagex & "&thisprog=" & thisprog
        jg = getWebpage(url, "GET")
        Return jg
    End Function
    Function lxfs() As String
        Dim jg As String = ""
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=lxfs"
        jg = getWebpage(url, "GET")
        Return jg
    End Function
    ' 显示单个资料
    Function xxzl(ByVal cid) As String
        Dim jg As String = ""
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=xxzl&cid=" & cid
        jg = getWebpage(url, "GET")
        Return jg
    End Function
    Function getCateName4cid(ByVal Cid) As String
        Dim jg As String = ""
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=getCateName4cid&cid=" & Cid
        jg = getWebpage(url, "GET")
        Return jg
    End Function
    Sub countManual(ByVal cid)
        Dim jg As String = ""
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=countManual&cid=" & cid
        jg = getWebpage(url, "GET")
    End Sub
    Sub countProduct(ByVal cid)
        Dim jg As String = ""
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=countProduct&cid=" & cid
        jg = getWebpage(url, "GET")
    End Sub
    Function GetProduct4id(ByVal cid) As String()
        Dim jg() As String
        Dim jgx As String
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=GetProduct4id&cid=" & cid
        jgx = getWebpage(url, "GET")
        jg = Split(jgx, "|")
        Return jg
    End Function
    Function GetManual4id(ByVal cid) As String()
        Dim jg(10), jgx As String
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=GetManual4id&cid=" & cid
        jgx = getWebpage(url, "GET")
        jg = Split(jgx, "|")
        Return jg
    End Function

    Function saveOrderItem(ByVal name, ByVal tel, ByVal fax, ByVal email, ByVal company, ByVal address, ByVal resumex, ByVal ywy, ByVal type, ByVal sl, ByVal manufactory, ByVal fz, ByVal jsj) As String
        Dim jg As String = ""
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=saveOrderItem&name=" & name & "&tel=" & tel
        url &= "&fax=" & fax & "&email=" & email & "&company=" & company
        url &= "&address=" & address & "&resumex=" & resumex & "&ywy=" & ywy
        url &= "&type=" & type & "&sl=" & sl & "&manufactory=" & manufactory
        url &= "&fz=" & fz & "&jsj=" & jsj
        jg = getWebpage(url, "GET")
        Return jg
    End Function
    Function GetNewList() As String
        Dim jg As String = ""
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=GetNewList"
        jg = getWebpage(url, "GET")
        Return jg
    End Function
    Function GetNews4id(ByVal cid As String) As String
        Dim jg As String = ""
        Dim url As String = ""
        url = RemoteUrl & "/Ecms_OpenApi.ashx?DBord=" & DBord & "&a=GetNews4id&cid=" & cid
        jg = getWebpage(url, "GET")
        Return jg
    End Function




    '
    ' 以下为工具函数
    '
    Function Checkstr(ByVal Str As String) As String
        Dim sql_injdata As String
        Dim SQL_inj() As String
        Dim i As Integer
        sql_injdata = "'|and|exec|insert|select|delete|update|count|*|%|chr|mid|master|truncate|char|declare|>|<|script|object|applet|/|\|#|"
        If Str = "" Then
            Checkstr = ""
            Exit Function
        End If
        SQL_inj = Split(sql_injdata, "|")
        For i = 0 To UBound(SQL_inj)
            Str = Replace(Str, SQL_inj(i), "_", 1, -1, 1)
        Next
        Checkstr = Replace(Str, " ", "_", 1, -1, 1)
    End Function
    '从后端服务器获得数据
    Public Function getWebpage(ByVal url As String, ByVal method1 As String) As String
        Dim httpReq As HttpWebRequest
        If Left(url.ToLower, 5) = "https" Then
            ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf CheckValidationResult)
            httpReq = Net.WebRequest.CreateDefault(New Uri(url))
        Else
            httpReq = Net.WebRequest.Create(url)
        End If
        Dim wcc As New CookieContainer
        Dim httpResp As System.Net.HttpWebResponse

        Dim Html As String
        Try
            httpReq.Method = method1
            httpReq.KeepAlive = False
            httpReq.CookieContainer = wcc
            httpResp = CType(httpReq.GetResponse(), HttpWebResponse)
            httpResp.Cookies = wcc.GetCookies(httpReq.RequestUri)
            Dim reader As StreamReader = New StreamReader(httpResp.GetResponseStream, System.Text.Encoding.GetEncoding("utf-8"))
            Html = reader.ReadToEnd()
        Catch ex As Exception
            Html = ex.Message.ToString
        End Try
        Return Html
    End Function
    Public Function CheckValidationResult(ByVal sender As Object, ByVal certificate As X509Certificate, ByVal chain As X509Chain, ByVal errors As SslPolicyErrors) As Boolean
        Return True
    End Function

End Class
