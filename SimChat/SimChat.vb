' Author: Ian P [ippavlin]
' Word list is modified from: http://members.optusnet.com.au/charles57/Creative/Techniques/random_words.htm
' Sentence list is from: http://answers.google.com/answers/threadview/id/745189.html

Imports System.IO

Public Class SimChat

    Private logChat As Boolean

    Private Sub SendMessage(ByVal Output As String)
        Dim Timestamp As String = Now().ToString("HH:mm:ss")
        Dim Datestamp As String = Now().ToString("MMM/d/yy HH:mm:ss")

        ChatHistory.Items.Add("[" & Timestamp & "] " & Output)
        ChatHistory.TopIndex = ChatHistory.Items.Count - 1  'Scroll to bottom of box

        If logChat = True Then
            Dim w As New StreamWriter("chat.log", FileMode.Append)  'Log chat
            w.WriteLine("[" & Datestamp & "] " & Output, FileMode.Append)
            w.Close()
        End If
    End Sub

    Private Sub tmrSimChat_Tick(sender As System.Object, e As System.EventArgs) Handles tmrSimChat.Tick
        Try
            Dim RandomClass As New Random()
            Dim RandomNumber As Integer

            RandomNumber = RandomClass.Next(500, 4000)
            tmrSimChat.Interval = RandomNumber

            Dim simRnd As New Random
            Dim simUser1 As String = Nothing
            Dim simUser2 As String = Nothing
            Dim simUsername As String = Nothing
            Dim simMessage As String = Nothing

            If File.Exists("usernames.db") And File.Exists("sentences.db") Then

                'StreamReader to read our file
                Dim ioFile As New StreamReader("usernames.db")
                'Generic list for holding the lines
                Dim lines As New List(Of String)
                'Random class to generate our random number
                Dim rnd As New Random()
                'Variable to hold our random line number
                Dim line As Integer
                'Now we loop through each line of our text file
                'adding each line to our list
                While ioFile.Peek <> -1
                    lines.Add(ioFile.ReadLine())
                End While

                'Now we need a random number
                line = rnd.Next(lines.Count + 1)
                'Assign the random word to a variable
                simUser1 = lines(line).Trim

                'Close our StreamReader
                ioFile.Close()
                'Dispose of the instance
                ioFile.Dispose()

                'StreamReader to read our file
                Dim ioFile1 As New StreamReader("usernames.db")
                'Generic list for holding the lines
                Dim lines1 As New List(Of String)
                'Random class to generate our random number
                Dim rnd1 As New Random()
                'Variable to hold our random line number
                Dim line1 As Integer
                'Now we loop through each line of our text file
                'adding each line to our list
                While ioFile1.Peek <> -1
                    lines1.Add(ioFile1.ReadLine())
                End While

                'Now we need a random number
                line1 = rnd.Next(lines.Count + 1)
                'Assign the random word to a variable
                simUser2 = lines1(line1).Trim

                'Close our StreamReader
                ioFile.Close()
                'Dispose of the instance
                ioFile.Dispose()

                RandomNumber = RandomClass.Next(1, 259)
                simUsername = simUser1 & simUser2 & RandomNumber
                UserList.Items.Add(simUsername)

                'Now write out the username to the immediate window
                'Debug.Print(simUsername)
                If File.Exists("sentences.db") Then
                    'StreamReader to read our file
                    Dim ioFile2 As New StreamReader("sentences.db")
                    'Generic list for holding the lines
                    Dim lines2 As New List(Of String)
                    'Random class to generate our random number
                    Dim rnd2 As New Random()
                    'Variable to hold our random line number
                    Dim line2 As Integer
                    'Now we loop through each line of our text file
                    'adding each line to our list
                    While ioFile2.Peek <> -1
                        lines2.Add(ioFile2.ReadLine())
                    End While

                    'Now we need a random number
                    line2 = rnd2.Next(lines2.Count + 1)
                    'Assign the random line to a variable
                    simMessage = lines2(line2).Trim

                    'Close our StreamReader
                    ioFile2.Close()
                    'Dispose of the instance
                    ioFile2.Dispose()

                    'Now write out the sentence to the immediate window
                    'Debug.Print(simMessage)
                End If

                SendMessage(simUsername & ": " & simMessage)

            Else
                tmrSimChat.Enabled = False
                If Not File.Exists("usernames.db") Then
                    MessageBox.Show("usernames.db file does not exist.", "File does not exist")
                End If
                If Not File.Exists("sentences.db") Then
                    MessageBox.Show("sentences.db file does not exist.", "File does not exist")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub chkLogChat_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkLogChat.CheckedChanged
        If chkLogChat.Checked = False Then
            logChat = False
            SendMessage("Chat logging is now disabled.")
        Else
            logChat = True
            SendMessage("Chat logging is now enabled.")
        End If
    End Sub

    Private Sub cmdToggle_Click(sender As System.Object, e As System.EventArgs) Handles cmdToggle.Click
        If tmrSimChat.Enabled = False Then
            tmrSimChat.Enabled = True
            SendMessage("Simulated chat on.")
        Else
            tmrSimChat.Enabled = False
            SendMessage("Simulated chat off.")
        End If
    End Sub

    Private Sub txtSndMsg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSndMsg.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtSndMsg.Text <> Nothing Then
                e.SuppressKeyPress = True
                SendMessage("User: " & txtSndMsg.Text)
                txtSndMsg.Text = Nothing
                If Not UserList.Items.Contains("User") Then
                    UserList.Items.Add("User")
                End If
            End If
        End If
    End Sub
End Class
