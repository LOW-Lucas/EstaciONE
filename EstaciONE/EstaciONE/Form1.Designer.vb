<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BTN_Scan = New System.Windows.Forms.Button()
        Me.CB_Port = New System.Windows.Forms.ComboBox()
        Me.TXT_Baud = New System.Windows.Forms.Label()
        Me.CB_Baud = New System.Windows.Forms.ComboBox()
        Me.BTN_conecao = New System.Windows.Forms.Button()
        Me.BTN_Disconectar = New System.Windows.Forms.Button()
        Me.Porta_S = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_Scan
        '
        Me.BTN_Scan.Location = New System.Drawing.Point(12, 22)
        Me.BTN_Scan.Name = "BTN_Scan"
        Me.BTN_Scan.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Scan.TabIndex = 0
        Me.BTN_Scan.Text = "Scannear"
        Me.BTN_Scan.UseVisualStyleBackColor = True
        '
        'CB_Port
        '
        Me.CB_Port.FormattingEnabled = True
        Me.CB_Port.Location = New System.Drawing.Point(103, 24)
        Me.CB_Port.Name = "CB_Port"
        Me.CB_Port.Size = New System.Drawing.Size(121, 21)
        Me.CB_Port.TabIndex = 1
        '
        'TXT_Baud
        '
        Me.TXT_Baud.AutoSize = True
        Me.TXT_Baud.Location = New System.Drawing.Point(230, 27)
        Me.TXT_Baud.Name = "TXT_Baud"
        Me.TXT_Baud.Size = New System.Drawing.Size(61, 13)
        Me.TXT_Baud.TabIndex = 2
        Me.TXT_Baud.Text = "Baud Rate:"
        '
        'CB_Baud
        '
        Me.CB_Baud.FormattingEnabled = True
        Me.CB_Baud.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.CB_Baud.Location = New System.Drawing.Point(298, 24)
        Me.CB_Baud.Name = "CB_Baud"
        Me.CB_Baud.Size = New System.Drawing.Size(121, 21)
        Me.CB_Baud.TabIndex = 3
        '
        'BTN_conecao
        '
        Me.BTN_conecao.Location = New System.Drawing.Point(12, 63)
        Me.BTN_conecao.Name = "BTN_conecao"
        Me.BTN_conecao.Size = New System.Drawing.Size(75, 23)
        Me.BTN_conecao.TabIndex = 4
        Me.BTN_conecao.Text = "Conectar"
        Me.BTN_conecao.UseVisualStyleBackColor = True
        '
        'BTN_Disconectar
        '
        Me.BTN_Disconectar.Location = New System.Drawing.Point(12, 92)
        Me.BTN_Disconectar.Name = "BTN_Disconectar"
        Me.BTN_Disconectar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Disconectar.TabIndex = 5
        Me.BTN_Disconectar.Text = "Disconectar"
        Me.BTN_Disconectar.UseVisualStyleBackColor = True
        '
        'Porta_S
        '
        Me.Porta_S.PortName = "COM3"
        Me.Porta_S.RtsEnable = True
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Saida da porta serial:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 366)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_Disconectar)
        Me.Controls.Add(Me.BTN_conecao)
        Me.Controls.Add(Me.CB_Baud)
        Me.Controls.Add(Me.TXT_Baud)
        Me.Controls.Add(Me.CB_Port)
        Me.Controls.Add(Me.BTN_Scan)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_Scan As System.Windows.Forms.Button
    Friend WithEvents CB_Port As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_Baud As System.Windows.Forms.Label
    Friend WithEvents CB_Baud As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_conecao As System.Windows.Forms.Button
    Friend WithEvents BTN_Disconectar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Porta_S As System.IO.Ports.SerialPort

End Class
