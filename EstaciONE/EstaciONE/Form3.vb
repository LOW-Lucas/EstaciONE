Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Form3
    Private server As TcpListener
    Private client As TcpClient
    Private stream As NetworkStream

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializa o servidor TCP na porta 12345
        server = New TcpListener(IPAddress.Any, 50254)
        server.Start()
        AppendText("Servidor iniciado. Aguardando conexão...")
        AwaitClientConnection()
    End Sub

    ' Função para aguardar a conexão do ESP8266
    Private Async Sub AwaitClientConnection()
        client = Await server.AcceptTcpClientAsync()
        stream = client.GetStream()
        AppendText("Cliente conectado!")
        ReceiveData()
    End Sub

    ' Função para receber dados do ESP8266
    Private Async Sub ReceiveData()
        Dim buffer(1024) As Byte
        While client.Connected
            Dim bytesRead As Integer = Await stream.ReadAsync(buffer, 0, buffer.Length)
            If bytesRead > 0 Then
                Dim receivedMessage As String = Encoding.ASCII.GetString(buffer, 0, bytesRead)
                AppendText("Recebido: " & receivedMessage)
            End If
        End While
        AppendText("Cliente desconectado.")
    End Sub

    ' Função auxiliar para adicionar texto ao TextBox
    Private Sub AppendText(text As String)
        txtLog.Invoke(Sub() txtLog.AppendText(text & Environment.NewLine))
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Fecha as conexões quando o formulário é fechado
        If client IsNot Nothing Then
            client.Close()
        End If
        If server IsNot Nothing Then
            server.Stop()
        End If
    End Sub
End Class