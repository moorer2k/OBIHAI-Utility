Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Xml
Imports HtmlAgilityPack

Namespace obi

    Public Class Client
        Public Property IpAddress As String
        Public Property Username As String
        Public Property Password As String
        Public Property Port As Integer
        Public Event InvalidLogin(ByVal message As String)
        Public Event OnLoggedIn(ByVal message As String)
        Public Event GetResponse(ByVal response As String)
        Public Event CallStatus(ByVal response As String)
        Public Event OnError(ByVal response As String)
        Public Event CallHistory(ByVal jsonResponse As List(Of PhoneHistory))
        Public IsLoggedin As Boolean
        Private WithEvents _wc As New WebClient
        Private Property RootUrl = ""
        Private ReadOnly _credcache As New CredentialCache
        Public Sub New(ByVal username As String, ByVal password As String, ByVal ipAddress As String, Optional ByVal port As Integer = 80)
            Me.Username = username
            Me.Password = password
            Me.IpAddress = ipAddress
            Me.Port = port
            RootUrl = "http://" & ipAddress & ":" & port
            _credcache.Add(New Uri(RootUrl), "Digest", New NetworkCredential(username, password, "/"))
        End Sub
        Public Sub GetCalls()
            RaiseEvent CallStatus(GetRequest(RootUrl & "/callstatus.htm"))
        End Sub
        Public Sub GetCallHistory()
            Dim lstHistory As New List(Of PhoneHistory)
            Dim xml = GetRequest(RootUrl & "/callhistory.xml")
            Dim doc As New XmlDocument()
            doc.LoadXml(xml)
            Dim xNode As XmlNodeList = doc.DocumentElement.SelectNodes("/CallHistoryFile/CallHistory")
            For Each x As XmlNode In xNode
                Select Case x.Name
                    Case "CallHistory"
                        Dim phone = x.FirstChild.FirstChild.InnerText
                        Dim pTime = x.FirstChild.Attributes("time").Value
                        Dim pDate = x.Attributes("date").Value
                        Dim direction As String = "In"
                        If phone = "From PH1" Then
                            phone = x.FirstChild.LastChild.InnerText
                            direction = "Out"
                        End If
                        If phone <> "Ringing" And phone <> "Call Ended" And phone <> "Call Connected" Then
                            lstHistory.Add(New PhoneHistory(pDate & " / " & pTime, phone.Split("(")(1).Split(")")(0), direction))
                        End If
                End Select
            Next
            RaiseEvent CallHistory(lstHistory)
        End Sub
        Private Function GetRequest(ByVal uri As String) As String
            Dim response As HttpWebResponse = Nothing
            Dim strReturn As String = ""
            Try
                Dim request = DirectCast(WebRequest.Create(uri), HttpWebRequest)
                request.Credentials = _credcache
                response = DirectCast(request.GetResponse(), HttpWebResponse)
                Using streamReader = New StreamReader(response.GetResponseStream(), Encoding.UTF8)
                    strReturn = streamReader.ReadToEnd()
                End Using
            Catch webEx As WebException
                Dim resCode = CInt(CType(webEx.Response, HttpWebResponse).StatusCode)
                strReturn = resCode
            Catch ex As Exception
                RaiseEvent OnError(ex.Message)
            End Try
            Return strReturn
        End Function
        ''' <summary>
        ''' Initiate the login procedure.
        ''' </summary>
        ''' <remarks>
        ''' If returned True, we recieved html back. 
        ''' If false, we got an unauthorized response code.
        ''' </remarks>
        Public Sub Login()
            If IsNumeric(GetRequest(RootUrl)) Then
                IsLoggedin = False
                RaiseEvent InvalidLogin("Username/Password is incorrect.")
            End If
            IsLoggedin = True
            RaiseEvent OnLoggedIn("Logged in!")
        End Sub
        Public Function ParseCalls(ByVal callstatus As String) As String
            If callstatus.Contains("Calls: 0") Then
                Return "0"
            End If
            Try
                Dim doc As New HtmlDocument
                doc.LoadHtml(callstatus)
                Dim strIncoming As String = doc.DocumentNode.SelectSingleNode("//tr[5]/td").InnerHtml
                Dim splitData As String() = strIncoming.Split("<td>")
                Dim strTelephone As String = splitData(1).Remove(0, 3) _
                'had to remove 3 because of it capturing td> with the results.
                Return strTelephone
            Catch ex As Exception
                Return ""
            End Try
        End Function
    End Class
End Namespace
