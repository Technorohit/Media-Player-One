Public Class Form1
    Dim playstate As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        Label5.Text = AxWindowsMediaPlayer1.currentMedia.getItemInfo("Title")
        Dim f = New IO.FileInfo(OpenFileDialog1.FileName)
        ListBox1.DisplayMember = "Name"
        ListBox1.ValueMember = "FullName"
        ListBox1.Items.Add(f)
        PictureBox7.Image = Image.FromFile("C:\pause.png")

    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ABout.Show()

    End Sub

    Private Sub PictureBox7_BackgroundImageChanged(sender As Object, e As EventArgs) Handles PictureBox7.BackgroundImageChanged
      


    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If playstate = True Then
            PictureBox7.Image = Image.FromFile("C:\pause.png")
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            playstate = False



        Else
            PictureBox7.Image = Image.FromFile("C:\play.png")
            AxWindowsMediaPlayer1.Ctlcontrols.play()

            playstate = True



        End If



    End Sub

   

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        AxWindowsMediaPlayer1.URL = ListBox1.SelectedItem.ToString
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        playstate = True


    End Sub

  

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        AxWindowsMediaPlayer1.settings.volume = HScrollBar1.Value
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        AxWindowsMediaPlayer1.URL = ListBox1.SelectedIndex + 1
        AxWindowsMediaPlayer1.Ctlcontrols.play()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        ListBox1.Show()


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized



    End Sub

    Private Sub PictureBox9_Click_1(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)


    End Sub
End Class
