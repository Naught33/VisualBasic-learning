Public Class Form1
    Private Sub btnKaribu_Click(sender As Object, e As EventArgs) Handles btnKaribu.Click
        Dim myName As Integer
        Dim oddoreven As String
        Dim odd As String = "odd"
        Dim even As String = "even"

        oddoreven = TextBox1.Text
        myName = txtName.Text
        If oddoreven = odd Then
            For myName = 1 To myName Step 2

                MsgBox(myName)

            Next
        ElseIf oddoreven = even Then
            For myName = 0 To myName Step 2
                MsgBox(myName)
            Next

        End If




    End Sub
End Class
