Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports Microsoft.Win32.SafeHandles

Namespace obi
    Public Class Discovery : Implements IDisposable
        Public Property LocalIp As String
        Public Property IpRange As String
        Private Property CurrIp As Integer = 1
        Private Property Socket As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Private WithEvents ping As New Ping()
        Public Event OnComputerFound(ByVal ip As String, ByVal isObi As Boolean)
        Sub New()
            Me.LocalIp = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(Function(ip) ip.AddressFamily = AddressFamily.InterNetwork).ToString()
            Me.IpRange = CreateRange()
        End Sub
        Private Function CreateRange() As String
            Dim sResult As String = ""
            Dim sIp As String() = Me.LocalIp.Split(".")
            For i = 0 To sIp.Count - 2
                sResult += sIp(i) & "."
            Next
            Return sResult
        End Function
        Private Sub Socket_AsyncResult(ar As IAsyncResult)
            Dim bytes(1023) As Byte
            Try
                Dim success As Boolean = ar.AsyncWaitHandle.WaitOne(100, True)

                If success Then
                    Dim msg() As Byte = Encoding.ASCII.GetBytes("GET / HTTP1.1" & vbCrLf & vbCrLf)
                    Dim bytesSent As Integer = Socket.Send(msg)
                    Dim bytesRec As Integer = Socket.Receive(bytes)
                    Dim resp = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                    Dim splitResp = resp.Split(":")
                    For i = 0 To splitResp.Length - 1
                        If splitResp(i).Contains("Server") Then
                            Dim server = splitResp(i + 1).Split(vbCrLf)(0).Trim
                            If server.ToLower.StartsWith("obi") Then
                                RaiseEvent OnComputerFound(Socket.RemoteEndPoint.ToString().Split(":")(0), True)
                            Else
                                RaiseEvent OnComputerFound(Socket.RemoteEndPoint.ToString().Split(":")(0), False)
                            End If
                        End If
                    Next
                End If
                Socket.Shutdown(SocketShutdown.Both)
                Socket.Close()
            Catch ex As Exception
            End Try
        End Sub
        Public Async Function Discover() As Tasks.Task
            Try
                Dim data As String = "areyoualivemydearobi"
                Dim buffer As Byte() = Encoding.ASCII.GetBytes(data)
                Dim options = New PingOptions
                options.DontFragment = True
                Await ping.SendPingAsync(IpRange & CurrIp, 120, buffer, options)
            Catch ex As Exception
            End Try
        End Function
        Public Sub Cancel()
            Me.Dispose()
        End Sub
        Private Async Sub ping_PingCompleted1(sender As Object, e As PingCompletedEventArgs) Handles ping.PingCompleted
            Try
                If e.Reply.Address.ToString <> "0.0.0.0" Then
                    Socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                    Socket.BeginConnect(e.Reply.Address.ToString, 80, New AsyncCallback(AddressOf Socket_AsyncResult), Socket)
                End If
                If CurrIp >= 255 Then
                    ping.SendAsyncCancel()
                    Exit Sub
                Else
                    CurrIp += 1
                    Await Discover()
                End If
            Catch ex As Exception
            End Try
        End Sub

        Dim _disposed As Boolean = False
        ReadOnly _handle As SafeHandle = New SafeFileHandle(IntPtr.Zero, True)
        Private Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
        Protected Overridable Sub Dispose(disposing As Boolean)
            If _disposed Then Return
            If disposing Then
                _handle.Dispose()
                Socket.Close()
                ping.SendAsyncCancel()
            End If
            ping.Dispose()
            _disposed = True
        End Sub
    End Class

End Namespace