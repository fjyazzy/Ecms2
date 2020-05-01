Module CommModule
    Public WCS As New Ecms2.WebPageClass

    Public urlStr As String = System.Configuration.ConfigurationManager.AppSettings.Item("URLSTR")
    Public RemoteUrl As String = urlStr & "apis/ecms"
    Public Center_PicUrl As String = urlStr & "Center_photos/ecms"
    Public Center_ManualUrl As String = urlStr & "Center_Manuals/ecms"

    Public DBord As String = System.Configuration.ConfigurationManager.AppSettings.Item("DBORD")
    Public GSMC As String = WCS.GetSystemInfo("021")
    Public WZMC As String = WCS.GetSystemInfo("026")

End Module
