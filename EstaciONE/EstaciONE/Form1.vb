Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        BTN_conecao.Enabled = False
        BTN_conecao.BringToFront()

        BTN_Disconectar.Enabled = False
        BTN_Disconectar.SendToBack()

        CB_Baud.SelectedItem = "9600"

    End Sub

    Private Sub BTN_Scan_Click(sender As Object, e As EventArgs) Handles BTN_Scan.Click
        CB_Port.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        CB_Port.Items.AddRange(myPort)
        i = CB_Port.Items.Count
        i = i - i
        Try
            CB_Port.SelectedIndex = i
        Catch ex As Exception
            Dim resultado As DialogResult
            resultado = MessageBox.Show("porta nao detectada", "cuidado", MessageBoxButtons.OK)
            CB_Port.Text = ""
            CB_Port.Items.Clear()
            Call Form1_Load(Me, e)
        End Try
        BTN_conecao.Enabled = True
        BTN_conecao.BringToFront()
        CB_Port.DroppedDown = True
    End Sub

    Private Sub BTN_conecao_Click(sender As Object, e As EventArgs) Handles BTN_conecao.Click
        BTN_conecao.Enabled = False
        BTN_conecao.SendToBack()

        Porta_S.BaudRate = CB_Baud.SelectedItem
        Porta_S.PortName = CB_Port.SelectedItem
        Porta_S.Open()
        Timer1.Start()

        BTN_Disconectar.Enabled = True
        BTN_Disconectar.BringToFront()
    End Sub

    Private Sub BTN_Disconectar_Click(sender As Object, e As EventArgs) Handles BTN_Disconectar.Click
        BTN_Disconectar.Enabled = False
        BTN_Disconectar.SendToBack()

        Timer1.Stop()
        Porta_S.Close()

        BTN_conecao.Enabled = True
        BTN_conecao.BringToFront()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim i As Single = Porta_S.ReadExisting
            Label1.Text = i.ToString
        Catch ex As Exception

        End Try
    End Sub
End Class
