Imports System.IO

Public Class Form1
    Dim lines() As String = File.ReadAllLines("Teams.txt")


    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim selectedTeam As String = ListBox1.SelectedItem.ToString()

        Dim worldSeriesWins As Integer = 0
        Using reader As New StreamReader("WorldSeriesWinners.txt")
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                If line.Contains(selectedTeam) Then
                    worldSeriesWins += 1
                End If
            End While
        End Using

        Label2.Text = (selectedTeam & " has won the World Series " & worldSeriesWins & " times.")
        Me.Controls.Add(ListBox1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim colorDialog As New ColorDialog()
        If colorDialog.ShowDialog() = DialogResult.OK Then
            Me.BackColor = colorDialog.Color
        End If
    End Sub
End Class
