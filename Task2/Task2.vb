Option Explicit On
Option Strict On
Option Compare Text
Imports System.ComponentModel
Imports System.IO.Ports
Public Class Task2
    Public dIn As Byte
    Public timerCount As Integer
    Sub Write1()
        Dim read0(SerialPort1.BytesToRead) As Byte
        Dim read1(SerialPort1.BytesToRead) As Byte
        Dim data0(0) As Byte
        Dim data1(0) As Byte
        data0(0) = &B100100 ' ASCII for $
        SerialPort1.Write(data0, 0, 1)
        SerialPort1.Read(read0, 0, SerialPort1.BytesToRead)
        If read0(0) = &B100100 Then
            Select Case TrackBar1.Value
                Case 5
                    data1(0) = &H1
                Case 6
                    data1(0) = &H2
                Case 7
                    data1(0) = &H3
                Case 8
                    data1(0) = &H4
                Case 9
                    data1(0) = &H5
                Case 10
                    data1(0) = &H6
                Case 11
                    data1(0) = &H7
                Case 12
                    data1(0) = &H8
                Case 13
                    data1(0) = &H9
                Case 14
                    data1(0) = &HA
                Case 15
                    data1(0) = &HB
                Case 16
                    data1(0) = &HC
                Case 17
                    data1(0) = &HD
                Case 18
                    data1(0) = &HE
                Case 19
                    data1(0) = &HF
                Case 20
                    data1(0) = &H10
                Case 21
                    data1(0) = &H11
                Case 22
                    data1(0) = &H12
                Case 23
                    data1(0) = &H13
                Case 24
                    data1(0) = &H14
                Case 25
                    data1(0) = &H15
            End Select
            SerialPort1.Write(data1, 0, 1)
        End If
    End Sub

    Sub Write2()
        Dim read0(SerialPort1.BytesToRead) As Byte
        Dim read1(SerialPort1.BytesToRead) As Byte
        Dim data0(0) As Byte
        Dim data1(0) As Byte
        Dim mask7 As Byte = 128
        Dim mask6 As Byte = 64
        Dim mask5 As Byte = 32
        Dim mask4 As Byte = 16
        Dim mask3 As Byte = 8
        Dim totalWeight As Integer = 0
        Dim weightedByte(0) As Byte
        data0(0) = &B100100 ' ASCII for $
        SerialPort1.Write(data0, 0, 1)
        SerialPort1.Read(read0, 0, SerialPort1.BytesToRead)
        If read0(0) = &B100100 Then
            SerialPort1.Read(read1, 0, SerialPort1.BytesToRead)
            Dim _read As Byte = read1(0)
            If (_read And mask7) <> 0 Then
                totalWeight += 16
            End If
            If (_read And mask6) <> 0 Then
                totalWeight += 8
            End If
            If (_read And mask5) <> 0 Then
                totalWeight += 4
            End If
            If (_read And mask4) <> 0 Then
                totalWeight += 2
            End If
            If (_read And mask3) <> 0 Then
                totalWeight += 1
            End If
            weightedByte(0) = CByte(totalWeight)
            SerialPort1.Write(weightedByte, 0, 1)
        End If
    End Sub

    Function WriteDollar() As Byte
        Dim dollar(0) As Byte
        dollar(0) = &B100100
        SerialPort1.Write(dollar, 0, 1)
        Dim read0(SerialPort1.BytesToRead) As Byte
        SerialPort1.Read(read0, 0, SerialPort1.BytesToRead)
        'Dim dollar(0) As Byte
        'dollar(0) = &B100100
        'SerialPort1.DiscardInBuffer()
        'SerialPort1.Write(dollar, 0, 1)
        'Dim read0 As Integer = SerialPort1.ReadByte()

        Return read0(0)
    End Function
    Enum Flags
        bit9 = CInt(2 ^ 9)
        bit8 = CInt(2 ^ 8)
        Bit7 = CInt(2 ^ 7)
        Bit6 = CInt(2 ^ 6)
        Bit5 = CInt(2 ^ 5)
        Bit4 = CInt(2 ^ 4)
        Bit3 = CInt(2 ^ 3)
        Bit2 = CInt(2 ^ 2)
        Bit1 = CInt(2 ^ 1)
        Bit0 = CInt(2 ^ 0)
    End Enum

    Sub WriteandRead()
        Dim lessThan(0) As Byte
        Dim servoData(0) As Byte
        Dim container As Integer
        Dim container2 As Integer
        Dim sum As UInt16
        Dim temp As Integer
        'Dim dollar(0) As Byte
        'dollar(0) = &B100100
        'SerialPort1.DiscardInBuffer()
        'SerialPort1.Write(dollar, 0, 1)
        'Dim read0 As Integer = SerialPort1.ReadByte()
        'If read0 = &B100100 Then

        lessThan(0) = &H3C
        temp = SerialPort1.BytesToRead
        System.Threading.Thread.Sleep(20)
        SerialPort1.DiscardInBuffer()
        temp = SerialPort1.BytesToRead
        'SerialPort1.ReadByte()
        SerialPort1.Write(lessThan, 0, 1)
        System.Threading.Thread.Sleep(10)
        temp = SerialPort1.BytesToRead
        container = SerialPort1.ReadByte
        temp = SerialPort1.BytesToRead
        container2 = SerialPort1.ReadByte
        temp = SerialPort1.BytesToRead

        If (container And Flags.Bit7) = Flags.Bit7 Then
            temp += 16
        End If
        If (container And Flags.Bit6) = Flags.Bit6 Then
            temp += 8
        End If
        If (container And Flags.Bit5) = Flags.Bit5 Then
            temp += 4
        End If
        If (container And Flags.Bit4) = Flags.Bit4 Then
            temp += 2
        End If
        If (container And Flags.Bit3) = Flags.Bit3 Then
            temp += 1
        End If

        servoData(0) = CType(temp, Byte)
        SerialPort1.Write(servoData, 0, 1)

        container = container << 2
        container2 = container2 >> 6
        sum = CType(container + container2, UShort)

        ListBox1.Items.Add($"Received Servo Data: {CStr(sum)} ")
        'End If
    End Sub
    Sub WritetoReadTemp()
        Dim lessThan(0) As Byte
        Dim servoData(0) As Byte
        Dim container As Integer
        Dim container2 As Integer
        Dim sum As Integer
        Dim temp As Double
        'Dim dollar(0) As Byte
        'dollar(0) = &B100100
        'SerialPort1.DiscardInBuffer()
        'SerialPort1.Write(dollar, 0, 1)
        'Dim read0 As Integer = SerialPort1.ReadByte()
        'If read0 = &B100100 Then

        lessThan(0) = &H3C
        temp = SerialPort1.BytesToRead
        System.Threading.Thread.Sleep(20)
        SerialPort1.DiscardInBuffer()
        temp = SerialPort1.BytesToRead
        'SerialPort1.ReadByte()
        SerialPort1.Write(lessThan, 0, 1)
        System.Threading.Thread.Sleep(10)
        temp = SerialPort1.BytesToRead
        container = SerialPort1.ReadByte
        temp = SerialPort1.BytesToRead
        container2 = SerialPort1.ReadByte
        temp = SerialPort1.BytesToRead

        If (container And Flags.Bit7) = Flags.Bit7 Then
            temp += 1.96 * 2 ^ 7
        End If
        If (container And Flags.Bit6) = Flags.Bit6 Then
            temp += 1.96 * 2 ^ 6
        End If
        If (container And Flags.Bit5) = Flags.Bit5 Then
            temp += 1.96 * 2 ^ 5
        End If
        If (container And Flags.Bit4) = Flags.Bit4 Then
            temp += 1.96 * 2 ^ 4
        End If
        If (container And Flags.Bit3) = Flags.Bit3 Then
            temp += 1.96 * 2 ^ 3
        End If
        If (container And Flags.Bit2) = Flags.Bit2 Then
            temp += 1.96 * 2 ^ 2
        End If
        If (container And Flags.Bit1) = Flags.Bit1 Then
            temp += 1.96 * 2
        End If
        If (container And Flags.Bit0) = Flags.Bit0 Then
            temp += 1.96
        End If
        ListBox1.Items.Add($"Received Temperature: {CStr(temp)} °F ")
        'servoData(0) = CType(temp, Byte)
        'SerialPort1.Write(servoData, 0, 1)
    End Sub

    Private Sub PopulateComPorts()
        ComComboBox.Items.Clear()

        ' Get an array of all available COM port names on the system
        Dim portNames As String() = SerialPort.GetPortNames()

        If portNames.Length > 0 Then
            ' Add each port name to the ComboBox
            For Each portName In portNames
                ComComboBox.Items.Add(portName)
            Next

            ' Select the first item in the list by default
            ComComboBox.SelectedIndex = 0
        Else
            ' Handle case where no ports are found
            ComComboBox.Items.Add("No COM Ports Found")
            ComComboBox.SelectedIndex = 0
            ConnectButton.Enabled = False ' Disable connect button
        End If
    End Sub


    Sub Connect()
        Try
            ' 1. Set the port properties based on ComboBox selection
            SerialPort1.PortName = ComComboBox.SelectedItem.ToString()

            ' 2. Set Baud Rate 
            SerialPort1.BaudRate = 9600

            ' 3. Set standard data format properties
            SerialPort1.DataBits = 8
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One

            ' 4. Open the connection
            SerialPort1.Open()

            ' 5. Update UI state
            UpdateConnectionState(True)
            ListBox1.Items.Add($"Successfully connected to {SerialPort1.PortName} at {SerialPort1.BaudRate} Baud.")

        Catch ex As Exception
            ' Handle errors (e.g., port already in use, invalid settings, permissions)
            MessageBox.Show($"Could not open port: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UpdateConnectionState(False)
        End Try
    End Sub

    Private Sub DisconnectButton_Click(sender As Object, e As EventArgs) Handles DisconnectButton.Click
        Timer1.Enabled = False
        If SerialPort1.IsOpen Then
            Try
                ' Close the connection
                SerialPort1.Close()

                ' Update UI state
                UpdateConnectionState(False)
                ListBox1.Items.Add("Disconnected successfully.")

            Catch ex As Exception
                ' Handle errors during close (rare, but good practice)
                MessageBox.Show($"Error during disconnect: {ex.Message}", "Disconnection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    ' Helper function to manage button and ComboBox state
    Private Sub UpdateConnectionState(ByVal isConnected As Boolean)
        ConnectButton.Enabled = Not isConnected
        StartButton.Enabled = isConnected
        DisconnectButton.Enabled = isConnected
        ComComboBox.Enabled = Not isConnected ' Disable changing port while connected
    End Sub


    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Console.WriteLine(SerialPort1.BytesToRead)
    End Sub



    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click





        Timer1.Enabled = True
        'Write()
    End Sub

    Private Sub Task2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        Connect()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        PopulateComPorts()
    End Sub

    Private Sub Task2_Load(sender As Object, e As EventArgs) Handles Me.Load
        UpdateConnectionState(False)
        PopulateComPorts()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Write1()
        ' Write2()
        'Dim tempByte As Byte
        'tempByte = WriteDollar()

        'If tempByte = &B100100 Then
        '    ListBox1.Items.Clear()
        '    WritetoReadTemp()

        '    'WriteandRead()
        'End If
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        Timer1.Enabled = False
    End Sub

    Private Sub SendDollarButton_Click(sender As Object, e As EventArgs) Handles SendDollarButton.Click
        WriteDollar()
    End Sub

    Private Sub ServoDataButton_Click(sender As Object, e As EventArgs) Handles ServoDataButton.Click
        WriteandRead()
    End Sub
End Class