Public Class wasshoss

    Public service As New ser.mywsClient()
    Public r3(10) As String
    Public r4(10) As String
    Public r5 As String
    Public correct As Integer
    Public fal As Integer
    Public j As Integer
    Public rep As String
    Public Timer1 As New Timer
    

    Private Sub wasshoss_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        r5 = ""
        Timer2.Start()
        PictureBox1.Visible = True
        ProgressBar1.Value = 0
        ProgressBar1.Visible = False
        ProgressBar1.Maximum = 100
        Label1.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        correct = 0
        fal = 0
        Label4.Visible = False
        Button4.Visible = False
        Label1.Visible = True
        Label2.Visible = True
        Button2.Visible = False
        Button1.Visible = True
        Button3.Visible = False
        TextBox2.Visible = False
        TextBox1.Visible = True
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        RadioButton3.Visible = False
        RadioButton4.Visible = False
        Dim r(10) As String
        r = service.matiere
        Dim i As Integer
        For i = 0 To 100
            If r(i).CompareTo("") = 0 Then
                Exit For
            Else
                Label1.Text = Label1.Text + r(i) + Chr(10)

            End If
        Next


    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Visible = True
        TextBox2.Visible = True
        Label1.Visible = False
        Label3.Visible = True
        TextBox1.Visible = False
        Button1.Visible = False
        Dim r1(10) As String
        r1 = service.test(Convert.ToInt32(TextBox1.Text))
        Dim i As Integer
        For i = 0 To 100
            If r1(i).CompareTo("") = 0 Then
                Exit For
            Else
                Label3.Text = Label3.Text + r1(i) + Chr(10)
                Label2.Text = ("Numéro du chapitre")

            End If
        Next


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label4.Visible = True
        ProgressBar1.Visible = True
        PictureBox1.Visible = False
        j = 0
        r3 = service.question(Convert.ToInt32(TextBox2.Text))
        r4 = service.rep(Convert.ToInt32(TextBox2.Text))
        Label4.Text = Convert.ToString(j + 1) + "- " + r3(j) + Chr(10)
        j = j + 1
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
        Button2.Visible = False
        Button3.Visible = True
        Label2.Visible = False
        Label3.Visible = False
        TextBox2.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str As String
        Dim i As Integer
        If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False And RadioButton4.Checked = False Then
            MsgBox("Vous devez choisir une réponse !")
        Else
            If RadioButton1.Checked = True Then
                rep = "1"
            ElseIf RadioButton2.Checked = True Then
                rep = "2"
            ElseIf RadioButton3.Checked = True Then
                rep = "3"
            ElseIf RadioButton4.Checked = True Then
                rep = "4"
            End If
            str = r4(j - 1)
            ProgressBar1.Value = (j * 100) / 9
            PictureBox1.Visible = False


            If rep.CompareTo(Convert.ToString(str.ElementAt(0))) = 0 Then
                r5 = r5 + Convert.ToString(j) + "- bonne réponse " + Chr(10) + Chr(10)
                correct = correct + 1
            Else
                r5 = r5 + Convert.ToString(j) + "- mauvaise réponse, la bonne réponse est " + str + Chr(10) + Chr(10)
                fal = fal + 1
            End If
            If r3(j).CompareTo("") = 0 Then
                ProgressBar1.Visible = False
                Button4.Visible = True
                Button3.Visible = False
                RadioButton1.Visible = False
                RadioButton2.Visible = False
                RadioButton3.Visible = False
                RadioButton4.Visible = False
                Dim pourcentage As Integer
                pourcentage = (correct / (correct + fal)) * 100
                If pourcentage > 75 Then
                    MsgBox("Score : " + Convert.ToString(pourcentage) + "%")
                Else
                    MsgBox("Score : " + Convert.ToString(pourcentage) + "%")
                End If
                Label4.Text = Chr(10) + Chr(10) + r5

            Else
                Label4.Text = Convert.ToString(j + 1) + "- " + r3(j) + Chr(10)
                j = j + 1
            End If
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.wasshoss_Load(sender, e)
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label5.Text = TimeOfDay
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
