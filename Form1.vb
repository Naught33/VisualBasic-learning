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

 Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Dim position As Integer
        Dim randomPeople(3, 3) As String

        randomPeople(0, 0) = "first name"
        randomPeople(1, 0) = "last name"
        randomPeople(2, 0) = "occupation"
        randomPeople(3, 0) = "genre"

        randomPeople(0, 1) = "Kevin"
        randomPeople(1, 1) = "hart"
        randomPeople(2, 1) = "actor"
        randomPeople(3, 1) = "comedy"

        randomPeople(0, 2) = "dwayne"
        randomPeople(1, 2) = "johnson"
        randomPeople(2, 2) = "actor"
        randomPeople(3, 2) = "action"

        randomPeople(0, 3) = "chriss"
        randomPeople(1, 3) = "hemsworth"
        randomPeople(2, 3) = "actor"
        randomPeople(3, 3) = "action"

        For position = 0 To 3
            If txtSearch.Text.ToLower = randomPeople(0, position).ToLower Then
                Dim iterator As Integer
                For iterator = 0 To 3
                    MsgBox(randomPeople(iterator, position))
                Next
            End If

        Next
    End Sub


    
End Class
