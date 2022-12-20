Public Class Form1
    'BMR
    Dim age As Integer
    Dim height As Integer
    Dim weight As Integer
    Dim bmr As Double

    'BMI
    Dim age_bmi As Integer
    Dim height_bmi As Integer
    Dim weight_bmi As Integer
    Dim bmi As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btn_bmr.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 71, 102)
        btn_bmi.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 150, 124)
        btn_data.FlatAppearance.MouseOverBackColor = Color.DodgerBlue

        Personal_data1.Dock = DockStyle.Fill

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_data.Click
        SidePanel.Visible = True
        SidePanel.Top = btn_data.Top
        SidePanel.BackColor = Color.DodgerBlue
        Personal_data1.Visible = True
        PanelBMI.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_bmr.Click
        PanelBMR.Visible = True
        PanelBMI.Visible = False
        SidePanel.Visible = True
        SidePanel.Top = btn_bmr.Top
        SidePanel.BackColor = Color.FromArgb(237, 71, 102)

        track_age.Minimum = 1
        track_height.Minimum = 50
        track_weight.Minimum = 1
        track_age.Maximum = 100
        track_height.Maximum = 250
        track_weight.Maximum = 250
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_bmi.Click
        PanelBMR.Visible = False
        PanelBMI.Visible = True
        Personal_data1.Visible = False
        SidePanel.Visible = True
        SidePanel.Top = btn_bmi.Top
        SidePanel.BackColor = Color.FromArgb(20, 150, 124)

        track_age_bmi.Minimum = 1
        track_height_bmi.Minimum = 50
        track_weight_bmi.Minimum = 50
        track_age_bmi.Maximum = 100
        track_height_bmi.Maximum = 250
        track_weight_bmi.Maximum = 250
    End Sub

    Private Sub track_age_Scroll(sender As Object, e As EventArgs) Handles track_age.Scroll, track_height.Scroll, track_weight.Scroll
        txt_age.Text = track_age.Value
        age = track_age.Value

        txt_height.Text = track_height.Value
        height = track_height.Value

        txt_weight.Text = track_weight.Value
        weight = track_weight.Value
    End Sub

    Private Sub txt_age_Leave(sender As Object, e As EventArgs) Handles txt_age.Leave
        If IsNumeric(txt_age.Text) Then
            age = txt_age.Text
            track_age.Value = txt_age.Text
        Else
            MsgBox("The number is incorrect")
            Exit Sub
        End If
    End Sub

    Private Sub txt_height_Leave(sender As Object, e As EventArgs) Handles txt_height.Leave
        If IsNumeric(txt_height.Text) Then
            height = txt_height.Text
            track_height.Value = txt_height.Text
        Else
            MsgBox("The number is incorrect")
            Exit Sub
        End If
    End Sub

    Private Sub txt_weight_Leave(sender As Object, e As EventArgs) Handles txt_weight.Leave
        If IsNumeric(txt_weight.Text) Then
            weight = txt_weight.Text
            track_weight.Value = txt_weight.Text
        Else
            MsgBox("The number is incorrect")
            Exit Sub
        End If
    End Sub

    Private Sub calc_Click(sender As Object, e As EventArgs) Handles calc.Click
        If txt_age.Text <> String.Empty And txt_weight.Text <> String.Empty And txt_height.Text <> String.Empty Then

            If rd_male.Checked Then
                bmr = (10 * weight) + (6.25 * height) - (5 * age) + 5
            ElseIf rd_female.Checked Then
                bmr = (10 * weight) + (6.25 * height) - (5 * age) - 161
            End If

            If active.Text = "خامل" Then
                bmr = bmr * 1.2
            ElseIf active.Text = "قليل النشاط" Then
                bmr = bmr * 1.375
            ElseIf active.Text = "نشط من حين لاخر" Then
                bmr = bmr * 1.55
            ElseIf active.Text = "نشط جدا" Then
                bmr = bmr * 1.725
            ElseIf active.Text = "نشط للغاية" Then
                bmr = bmr * 1.9
            End If

            'Me.Hide()
            Form3.Show()

            Form3.l1.Text = "احتياجاتك اليومية من السعرات الحرارية هي " + bmr.ToString("#") + " سعرة حرارية"
            Form3.l2.Text = "انت تحتاج " + (bmr - 500).ToString("#") + " سعرات حرارية / يوم لانقاص وزنك 0.5 كجم"
            Form3.l3.Text = "انت تحتاج " + (bmr - 1000).ToString("#") + " سعرات حرارية / يوم لانقاص وزنك 1 كجم"
            Form3.l4.Text = "انت تحتاج " + (bmr + 500).ToString("#") + " سعرات حرارية / يوم لزيادة وزنك 0.5 كجم"
            Form3.l5.Text = "انت تحتاج " + (bmr + 1000).ToString("#") + " سعرات حرارية / يوم لزيادة وزنك 1 كجم"
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        rd_male.Checked = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        rd_female.Checked = True
    End Sub

    Private Sub PanelBMI_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub track_age_bmi_Scroll(sender As Object, e As EventArgs) Handles track_weight_bmi.Scroll, track_height_bmi.Scroll, track_age_bmi.Scroll
        txt_age_bmi.Text = track_age_bmi.Value
        age_bmi = track_age_bmi.Value

        txt_height_bmi.Text = track_height_bmi.Value
        height_bmi = track_height_bmi.Value

        txt_weight_bmi.Text = track_weight_bmi.Value
        weight_bmi = track_weight_bmi.Value
    End Sub

    Private Sub txt_age_bmi_Leave(sender As Object, e As EventArgs) Handles txt_age_bmi.Leave
        If IsNumeric(txt_age_bmi.Text) Then
            age_bmi = txt_age_bmi.Text
            track_age_bmi.Value = txt_age_bmi.Text
        Else
            MsgBox("The number is incorrect")
            Exit Sub
        End If
    End Sub

    Private Sub txt_height_bmi_Leave(sender As Object, e As EventArgs) Handles txt_height_bmi.Leave
        If IsNumeric(txt_height_bmi.Text) Then
            height_bmi = txt_height_bmi.Text
            track_height_bmi.Value = txt_height_bmi.Text
        Else
            MsgBox("The number is incorrect")
            Exit Sub
        End If
    End Sub

    Private Sub txt_weight_bmi_Leave(sender As Object, e As EventArgs) Handles txt_weight_bmi.Leave
        If IsNumeric(txt_weight_bmi.Text) Then
            weight_bmi = txt_weight_bmi.Text
            track_weight_bmi.Value = txt_weight_bmi.Text
        Else
            MsgBox("The number is incorrect")
            Exit Sub
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        rd_male_bmi.Checked = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        rd_female_bmi.Checked = True
    End Sub

    Private Sub calc_bmi_Click(sender As Object, e As EventArgs) Handles calc_bmi.Click
        If txt_weight_bmi.Text <> String.Empty And txt_height_bmi.Text <> String.Empty Then

            Dim txt_message As String = ""
            Dim w_index As Double
            Dim txt_weightRate As String = ""
            Dim weight_rate As Double

            bmi = weight_bmi / ((height_bmi / 100) ^ 2)

            'حساب المؤشر الوزني
            w_index = weight_bmi / ((height_bmi / 100) ^ 3)

            If bmi < 18.5 Then
                txt_message = "وزن ناقص"
                weight_rate = 53.46 - weight_bmi
                txt_weightRate = "تحتاج لزيادة                      كجم من أجل الوصول الى الوزن الطبيعى"

            ElseIf bmi >= 18.5 And bmi <= 25 Then
                txt_message = "وزن صحي ومثالي"

            ElseIf bmi >= 25 And bmi <= 30 Then
                txt_message = "وزن زائد"
                weight_rate = weight_bmi - 72.25
                txt_weightRate = "تحتاج لإنقاص                      كجم من أجل الوصول الى الوزن الطبيعى"

            ElseIf bmi >= 30 And bmi <= 40 Then
                txt_message = "سمنة"
                weight_rate = weight_bmi - 72.25
                txt_weightRate = "تحتاج لإنقاص                      كجم من أجل الوصول الى الوزن الطبيعى"

            ElseIf bmi >= 40 Then
                txt_message = "سمنة مفرطة"
                weight_rate = weight_bmi - 72.25
                txt_weightRate = "تحتاج لإنقاص                      كجم من أجل الوصول الى الوزن الطبيعى"
            End If


            Form6.Show()

            Form6.l6.Text = bmi.ToString("0.00")
            Form6.l7.Text = "(" + txt_message + ")"
            Form6.l11.Text = bmi.ToString("0.00") + " كجم/م2"
            Form6.l18.Text = txt_message
            Form6.l15.Text = w_index.ToString("0.00") + " كجم/م3"
            Form6.l16.Text = txt_weightRate
            If weight_rate = 0 Then
                Form6.l17.Text = ""
            Else
                Form6.l17.Text = weight_rate.ToString()
            End If
        End If
    End Sub

End Class
