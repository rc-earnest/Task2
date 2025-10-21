Imports System.ComponentModel
Imports System.IO.Ports
Public Class Form1
    Public dIn As Byte
    Public timerCount As Integer
    Sub Write()

        Dim data(1) As Byte
        data(0) = &B100000
        Select Case timerCount
            Case 1
                data(1) = &B1
            Case 2
                data(1) = &B10
            Case 3
                data(1) = &B100
            Case 4
                data(1) = &B1000
            Case 5
                data(1) = &B10000
            Case 6
                data(1) = &B100000
            Case 7
                data(1) = &B1000000
            Case 8
                data(1) = &B10000000
            Case 9
                data(1) = &B1
        End Select
        If timerCount >= 9 Then timerCount = 1
        SerialPort1.Write(data, 0, 2)
        timerCount += 1
    End Sub
    Sub Read()
        Dim rDat As Byte = &B0
        Dim data2(0) As Byte
        data2(0) = &B110000
        SerialPort1.Write(data2, 0, 1)
        dIn = SerialPort1.Read(data2, 0, 0)
        Console.WriteLine(dIn)
    End Sub
    Sub Connect()
        SerialPort1.Close()
        SerialPort1.BaudRate = 9600 'Q@ Board Default
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.DataBits = 8
        SerialPort1.PortName = "COM4"

        SerialPort1.Open()

    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Console.WriteLine(SerialPort1.BytesToRead)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        SerialPort1.Close()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Connect()
        Write()
    End Sub
End Class