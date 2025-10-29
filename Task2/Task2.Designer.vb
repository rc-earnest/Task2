<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Task2
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
        Me.StartButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.ComComboBox = New System.Windows.Forms.ComboBox()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.DisconnectButton = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StopButton = New System.Windows.Forms.Button()
        Me.SendDollarButton = New System.Windows.Forms.Button()
        Me.ServoDataButton = New System.Windows.Forms.Button()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(544, 416)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 23)
        Me.StartButton.TabIndex = 3
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(713, 415)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(12, 16)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(776, 228)
        Me.ListBox1.TabIndex = 2
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(12, 415)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(75, 23)
        Me.ConnectButton.TabIndex = 0
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'ComComboBox
        '
        Me.ComComboBox.FormattingEnabled = True
        Me.ComComboBox.Location = New System.Drawing.Point(93, 415)
        Me.ComComboBox.Name = "ComComboBox"
        Me.ComComboBox.Size = New System.Drawing.Size(121, 24)
        Me.ComComboBox.TabIndex = 1
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(220, 416)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton.TabIndex = 2
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'DisconnectButton
        '
        Me.DisconnectButton.Location = New System.Drawing.Point(381, 415)
        Me.DisconnectButton.Name = "DisconnectButton"
        Me.DisconnectButton.Size = New System.Drawing.Size(111, 23)
        Me.DisconnectButton.TabIndex = 5
        Me.DisconnectButton.Text = "Disconnect"
        Me.DisconnectButton.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(150, 292)
        Me.TrackBar1.Maximum = 25
        Me.TrackBar1.Minimum = 5
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(430, 56)
        Me.TrackBar1.TabIndex = 6
        Me.TrackBar1.Value = 5
        '
        'Timer1
        '
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(625, 415)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(75, 23)
        Me.StopButton.TabIndex = 7
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'SendDollarButton
        '
        Me.SendDollarButton.Location = New System.Drawing.Point(12, 386)
        Me.SendDollarButton.Name = "SendDollarButton"
        Me.SendDollarButton.Size = New System.Drawing.Size(202, 23)
        Me.SendDollarButton.TabIndex = 8
        Me.SendDollarButton.Text = "Send Dollar"
        Me.SendDollarButton.UseVisualStyleBackColor = True
        '
        'ServoDataButton
        '
        Me.ServoDataButton.Location = New System.Drawing.Point(12, 357)
        Me.ServoDataButton.Name = "ServoDataButton"
        Me.ServoDataButton.Size = New System.Drawing.Size(202, 23)
        Me.ServoDataButton.TabIndex = 9
        Me.ServoDataButton.Text = "Send ! and Get Servo Data"
        Me.ServoDataButton.UseVisualStyleBackColor = True
        '
        'Task2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ServoDataButton)
        Me.Controls.Add(Me.SendDollarButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.DisconnectButton)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.ComComboBox)
        Me.Controls.Add(Me.ConnectButton)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.StartButton)
        Me.Name = "Task2"
        Me.Text = "Form1"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ConnectButton As Button
    Friend WithEvents ComComboBox As ComboBox
    Friend WithEvents RefreshButton As Button
    Friend WithEvents DisconnectButton As Button
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StopButton As Button
    Friend WithEvents SendDollarButton As Button
    Friend WithEvents ServoDataButton As Button
End Class
