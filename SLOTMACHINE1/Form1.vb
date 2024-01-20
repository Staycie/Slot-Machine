Public Class Form1
    Dim A, B, C As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        PictureBox7.Visible = True
        PictureBox10.Visible = True
        PictureBox11.Visible = True
        PictureBox12.Visible = True

        Button1.Visible = False
        RectangleShape1.Visible = False
        Label1.Visible = False

    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        PictureBox9.Visible = True
        PictureBox8.Visible = False
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Button2.Visible = True

    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        PictureBox8.Visible = True
        PictureBox9.Visible = False
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False

        If A = B And C = B Then
            Label2.Visible = True
            PictureBox13.Visible = True
            Button1.Enabled = False
            Button3.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Randomize()
        A = Int(Rnd() * 3) + 1
        Select Case A
            Case 1
                PictureBox4.Image = PictureBox1.Image
            Case 2
                PictureBox4.Image = PictureBox2.Image
            Case 3
                PictureBox4.Image = PictureBox3.Image
        End Select

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        Randomize()
        B = Int(Rnd() * 3) + 1
        Select Case B
            Case 1
                PictureBox5.Image = PictureBox1.Image
            Case 2
                PictureBox5.Image = PictureBox2.Image
            Case 3
                PictureBox5.Image = PictureBox3.Image
        End Select
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Randomize()
        C = Int(Rnd() * 3) + 1
        Select Case C
            Case 1
                PictureBox6.Image = PictureBox1.Image
            Case 2
                PictureBox6.Image = PictureBox2.Image
            Case 3
                PictureBox6.Image = PictureBox3.Image

        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Visible = False
        Label2.Visible = False
        PictureBox13.Visible = False
    End Sub
End Class

