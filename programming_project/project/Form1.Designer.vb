<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_bmi = New System.Windows.Forms.Button()
        Me.btn_bmr = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_data = New System.Windows.Forms.Button()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.rd_male = New System.Windows.Forms.RadioButton()
        Me.rd_female = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_age = New System.Windows.Forms.TextBox()
        Me.txt_height = New System.Windows.Forms.TextBox()
        Me.txt_weight = New System.Windows.Forms.TextBox()
        Me.active = New System.Windows.Forms.ComboBox()
        Me.calc = New System.Windows.Forms.Button()
        Me.track_age = New System.Windows.Forms.TrackBar()
        Me.track_height = New System.Windows.Forms.TrackBar()
        Me.track_weight = New System.Windows.Forms.TrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelBMR = New System.Windows.Forms.Panel()
        Me.rd_male_bmi = New System.Windows.Forms.RadioButton()
        Me.rd_female_bmi = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_age_bmi = New System.Windows.Forms.TextBox()
        Me.txt_height_bmi = New System.Windows.Forms.TextBox()
        Me.txt_weight_bmi = New System.Windows.Forms.TextBox()
        Me.calc_bmi = New System.Windows.Forms.Button()
        Me.track_age_bmi = New System.Windows.Forms.TrackBar()
        Me.track_height_bmi = New System.Windows.Forms.TrackBar()
        Me.track_weight_bmi = New System.Windows.Forms.TrackBar()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PanelBMI = New System.Windows.Forms.Panel()
        Me.Personal_data1 = New project.personal_data()
        Me.Panel1.SuspendLayout()
        CType(Me.track_age, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track_height, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track_weight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBMR.SuspendLayout()
        CType(Me.track_age_bmi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track_height_bmi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track_weight_bmi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBMI.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_bmi
        '
        Me.btn_bmi.BackColor = System.Drawing.Color.Transparent
        Me.btn_bmi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_bmi.FlatAppearance.BorderSize = 0
        Me.btn_bmi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn_bmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bmi.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_bmi.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_bmi.Image = CType(resources.GetObject("btn_bmi.Image"), System.Drawing.Image)
        Me.btn_bmi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_bmi.Location = New System.Drawing.Point(12, 400)
        Me.btn_bmi.Name = "btn_bmi"
        Me.btn_bmi.Size = New System.Drawing.Size(244, 85)
        Me.btn_bmi.TabIndex = 3
        Me.btn_bmi.Text = "حاسبة مؤشر كتلة الجسم"
        Me.btn_bmi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_bmi.UseVisualStyleBackColor = False
        '
        'btn_bmr
        '
        Me.btn_bmr.BackColor = System.Drawing.Color.Transparent
        Me.btn_bmr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_bmr.FlatAppearance.BorderSize = 0
        Me.btn_bmr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn_bmr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btn_bmr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bmr.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_bmr.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_bmr.Image = CType(resources.GetObject("btn_bmr.Image"), System.Drawing.Image)
        Me.btn_bmr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_bmr.Location = New System.Drawing.Point(12, 494)
        Me.btn_bmr.Name = "btn_bmr"
        Me.btn_bmr.Size = New System.Drawing.Size(244, 85)
        Me.btn_bmr.TabIndex = 2
        Me.btn_bmr.Text = "حاسبة السعرات الحرارية"
        Me.btn_bmr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_bmr.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_data)
        Me.Panel1.Controls.Add(Me.SidePanel)
        Me.Panel1.Controls.Add(Me.btn_bmi)
        Me.Panel1.Controls.Add(Me.btn_bmr)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(729, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 617)
        Me.Panel1.TabIndex = 4
        '
        'btn_data
        '
        Me.btn_data.BackColor = System.Drawing.Color.Transparent
        Me.btn_data.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_data.FlatAppearance.BorderSize = 0
        Me.btn_data.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_data.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_data.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_data.Image = CType(resources.GetObject("btn_data.Image"), System.Drawing.Image)
        Me.btn_data.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_data.Location = New System.Drawing.Point(14, 108)
        Me.btn_data.Name = "btn_data"
        Me.btn_data.Size = New System.Drawing.Size(244, 85)
        Me.btn_data.TabIndex = 5
        Me.btn_data.Text = "بيانات الطالب"
        Me.btn_data.UseVisualStyleBackColor = False
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.SidePanel.Location = New System.Drawing.Point(3, 400)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(7, 85)
        Me.SidePanel.TabIndex = 4
        Me.SidePanel.Visible = False
        '
        'rd_male
        '
        Me.rd_male.AutoSize = True
        Me.rd_male.Checked = True
        Me.rd_male.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rd_male.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_male.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rd_male.Location = New System.Drawing.Point(604, 97)
        Me.rd_male.Margin = New System.Windows.Forms.Padding(2)
        Me.rd_male.Name = "rd_male"
        Me.rd_male.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rd_male.Size = New System.Drawing.Size(59, 27)
        Me.rd_male.TabIndex = 59
        Me.rd_male.TabStop = True
        Me.rd_male.Text = "ذكر"
        Me.rd_male.UseVisualStyleBackColor = True
        '
        'rd_female
        '
        Me.rd_female.AutoSize = True
        Me.rd_female.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rd_female.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_female.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rd_female.Location = New System.Drawing.Point(494, 97)
        Me.rd_female.Margin = New System.Windows.Forms.Padding(2)
        Me.rd_female.Name = "rd_female"
        Me.rd_female.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rd_female.Size = New System.Drawing.Size(69, 27)
        Me.rd_female.TabIndex = 60
        Me.rd_female.Text = "أنثي"
        Me.rd_female.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(773, 172)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 23)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "السن"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(773, 260)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "الطول"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(776, 348)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 23)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "الوزن"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(773, 431)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "النشاط"
        '
        'txt_age
        '
        Me.txt_age.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_age.Location = New System.Drawing.Point(401, 169)
        Me.txt_age.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_age.Multiline = True
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(69, 43)
        Me.txt_age.TabIndex = 65
        Me.txt_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_height
        '
        Me.txt_height.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_height.Location = New System.Drawing.Point(401, 260)
        Me.txt_height.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_height.Multiline = True
        Me.txt_height.Name = "txt_height"
        Me.txt_height.Size = New System.Drawing.Size(69, 43)
        Me.txt_height.TabIndex = 66
        Me.txt_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_weight
        '
        Me.txt_weight.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_weight.Location = New System.Drawing.Point(401, 345)
        Me.txt_weight.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_weight.Multiline = True
        Me.txt_weight.Name = "txt_weight"
        Me.txt_weight.Size = New System.Drawing.Size(69, 43)
        Me.txt_weight.TabIndex = 67
        Me.txt_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'active
        '
        Me.active.Cursor = System.Windows.Forms.Cursors.Hand
        Me.active.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.active.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.active.FormattingEnabled = True
        Me.active.IntegralHeight = False
        Me.active.ItemHeight = 18
        Me.active.Items.AddRange(New Object() {"خامل", "قليل النشاط", "نشط من حين لاخر", "نشط جدا", "نشط للغاية"})
        Me.active.Location = New System.Drawing.Point(456, 431)
        Me.active.Margin = New System.Windows.Forms.Padding(2, 11, 10, 2)
        Me.active.Name = "active"
        Me.active.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.active.Size = New System.Drawing.Size(272, 26)
        Me.active.TabIndex = 68
        Me.active.TabStop = False
        Me.active.Text = "خامل"
        '
        'calc
        '
        Me.calc.BackColor = System.Drawing.Color.PowderBlue
        Me.calc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.calc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.calc.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calc.Location = New System.Drawing.Point(450, 511)
        Me.calc.Margin = New System.Windows.Forms.Padding(2)
        Me.calc.Name = "calc"
        Me.calc.Size = New System.Drawing.Size(278, 59)
        Me.calc.TabIndex = 69
        Me.calc.Text = "احسب"
        Me.calc.UseVisualStyleBackColor = False
        '
        'track_age
        '
        Me.track_age.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.track_age.Location = New System.Drawing.Point(494, 172)
        Me.track_age.Margin = New System.Windows.Forms.Padding(2)
        Me.track_age.Name = "track_age"
        Me.track_age.Size = New System.Drawing.Size(234, 45)
        Me.track_age.TabIndex = 70
        '
        'track_height
        '
        Me.track_height.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.track_height.Location = New System.Drawing.Point(494, 262)
        Me.track_height.Margin = New System.Windows.Forms.Padding(2)
        Me.track_height.Name = "track_height"
        Me.track_height.Size = New System.Drawing.Size(234, 45)
        Me.track_height.TabIndex = 71
        '
        'track_weight
        '
        Me.track_weight.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.track_weight.Location = New System.Drawing.Point(494, 347)
        Me.track_weight.Margin = New System.Windows.Forms.Padding(2)
        Me.track_weight.Name = "track_weight"
        Me.track_weight.Size = New System.Drawing.Size(234, 45)
        Me.track_weight.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(355, 172)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 23)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "عام"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(355, 261)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 23)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "سم"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(351, 348)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 23)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "كجم"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(594, 26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(494, 26)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(69, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 77
        Me.PictureBox2.TabStop = False
        '
        'PanelBMR
        '
        Me.PanelBMR.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.PanelBMR.Controls.Add(Me.PictureBox2)
        Me.PanelBMR.Controls.Add(Me.PictureBox1)
        Me.PanelBMR.Controls.Add(Me.Label7)
        Me.PanelBMR.Controls.Add(Me.Label6)
        Me.PanelBMR.Controls.Add(Me.Label5)
        Me.PanelBMR.Controls.Add(Me.track_weight)
        Me.PanelBMR.Controls.Add(Me.track_height)
        Me.PanelBMR.Controls.Add(Me.track_age)
        Me.PanelBMR.Controls.Add(Me.calc)
        Me.PanelBMR.Controls.Add(Me.active)
        Me.PanelBMR.Controls.Add(Me.txt_weight)
        Me.PanelBMR.Controls.Add(Me.txt_height)
        Me.PanelBMR.Controls.Add(Me.txt_age)
        Me.PanelBMR.Controls.Add(Me.Label4)
        Me.PanelBMR.Controls.Add(Me.Label3)
        Me.PanelBMR.Controls.Add(Me.Label2)
        Me.PanelBMR.Controls.Add(Me.Label1)
        Me.PanelBMR.Controls.Add(Me.rd_female)
        Me.PanelBMR.Controls.Add(Me.rd_male)
        Me.PanelBMR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBMR.Location = New System.Drawing.Point(0, 0)
        Me.PanelBMR.Name = "PanelBMR"
        Me.PanelBMR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PanelBMR.Size = New System.Drawing.Size(985, 617)
        Me.PanelBMR.TabIndex = 5
        Me.PanelBMR.Visible = False
        '
        'rd_male_bmi
        '
        Me.rd_male_bmi.AutoSize = True
        Me.rd_male_bmi.Checked = True
        Me.rd_male_bmi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rd_male_bmi.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_male_bmi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rd_male_bmi.Location = New System.Drawing.Point(348, 128)
        Me.rd_male_bmi.Margin = New System.Windows.Forms.Padding(2)
        Me.rd_male_bmi.Name = "rd_male_bmi"
        Me.rd_male_bmi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rd_male_bmi.Size = New System.Drawing.Size(59, 27)
        Me.rd_male_bmi.TabIndex = 77
        Me.rd_male_bmi.TabStop = True
        Me.rd_male_bmi.Text = "ذكر"
        Me.rd_male_bmi.UseVisualStyleBackColor = True
        '
        'rd_female_bmi
        '
        Me.rd_female_bmi.AutoSize = True
        Me.rd_female_bmi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rd_female_bmi.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_female_bmi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rd_female_bmi.Location = New System.Drawing.Point(245, 128)
        Me.rd_female_bmi.Margin = New System.Windows.Forms.Padding(2)
        Me.rd_female_bmi.Name = "rd_female_bmi"
        Me.rd_female_bmi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rd_female_bmi.Size = New System.Drawing.Size(69, 27)
        Me.rd_female_bmi.TabIndex = 78
        Me.rd_female_bmi.Text = "أنثي"
        Me.rd_female_bmi.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(483, 183)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 23)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "السن"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(483, 271)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 23)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "الطول"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(486, 359)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 23)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "الوزن"
        '
        'txt_age_bmi
        '
        Me.txt_age_bmi.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_age_bmi.Location = New System.Drawing.Point(137, 180)
        Me.txt_age_bmi.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_age_bmi.Multiline = True
        Me.txt_age_bmi.Name = "txt_age_bmi"
        Me.txt_age_bmi.Size = New System.Drawing.Size(69, 43)
        Me.txt_age_bmi.TabIndex = 82
        Me.txt_age_bmi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_height_bmi
        '
        Me.txt_height_bmi.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_height_bmi.Location = New System.Drawing.Point(137, 271)
        Me.txt_height_bmi.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_height_bmi.Multiline = True
        Me.txt_height_bmi.Name = "txt_height_bmi"
        Me.txt_height_bmi.Size = New System.Drawing.Size(69, 43)
        Me.txt_height_bmi.TabIndex = 83
        Me.txt_height_bmi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_weight_bmi
        '
        Me.txt_weight_bmi.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_weight_bmi.Location = New System.Drawing.Point(137, 356)
        Me.txt_weight_bmi.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_weight_bmi.Multiline = True
        Me.txt_weight_bmi.Name = "txt_weight_bmi"
        Me.txt_weight_bmi.Size = New System.Drawing.Size(69, 43)
        Me.txt_weight_bmi.TabIndex = 84
        Me.txt_weight_bmi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'calc_bmi
        '
        Me.calc_bmi.BackColor = System.Drawing.Color.PowderBlue
        Me.calc_bmi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.calc_bmi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.calc_bmi.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calc_bmi.Location = New System.Drawing.Point(189, 468)
        Me.calc_bmi.Margin = New System.Windows.Forms.Padding(2)
        Me.calc_bmi.Name = "calc_bmi"
        Me.calc_bmi.Size = New System.Drawing.Size(278, 59)
        Me.calc_bmi.TabIndex = 85
        Me.calc_bmi.Text = "احسب"
        Me.calc_bmi.UseVisualStyleBackColor = False
        '
        'track_age_bmi
        '
        Me.track_age_bmi.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.track_age_bmi.Location = New System.Drawing.Point(221, 183)
        Me.track_age_bmi.Margin = New System.Windows.Forms.Padding(2)
        Me.track_age_bmi.Name = "track_age_bmi"
        Me.track_age_bmi.Size = New System.Drawing.Size(234, 45)
        Me.track_age_bmi.TabIndex = 86
        '
        'track_height_bmi
        '
        Me.track_height_bmi.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.track_height_bmi.Location = New System.Drawing.Point(221, 273)
        Me.track_height_bmi.Margin = New System.Windows.Forms.Padding(2)
        Me.track_height_bmi.Name = "track_height_bmi"
        Me.track_height_bmi.Size = New System.Drawing.Size(234, 45)
        Me.track_height_bmi.TabIndex = 87
        '
        'track_weight_bmi
        '
        Me.track_weight_bmi.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.track_weight_bmi.Location = New System.Drawing.Point(221, 358)
        Me.track_weight_bmi.Margin = New System.Windows.Forms.Padding(2)
        Me.track_weight_bmi.Name = "track_weight_bmi"
        Me.track_weight_bmi.Size = New System.Drawing.Size(234, 45)
        Me.track_weight_bmi.TabIndex = 88
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(88, 183)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 23)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "عام"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(88, 272)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 23)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "سم"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(84, 359)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 23)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "كجم"
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(338, 57)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(69, 65)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 92
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(245, 57)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(69, 65)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 93
        Me.PictureBox3.TabStop = False
        '
        'PanelBMI
        '
        Me.PanelBMI.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.PanelBMI.Controls.Add(Me.Personal_data1)
        Me.PanelBMI.Controls.Add(Me.PictureBox3)
        Me.PanelBMI.Controls.Add(Me.PictureBox4)
        Me.PanelBMI.Controls.Add(Me.Label8)
        Me.PanelBMI.Controls.Add(Me.Label9)
        Me.PanelBMI.Controls.Add(Me.Label10)
        Me.PanelBMI.Controls.Add(Me.track_weight_bmi)
        Me.PanelBMI.Controls.Add(Me.track_height_bmi)
        Me.PanelBMI.Controls.Add(Me.track_age_bmi)
        Me.PanelBMI.Controls.Add(Me.calc_bmi)
        Me.PanelBMI.Controls.Add(Me.txt_weight_bmi)
        Me.PanelBMI.Controls.Add(Me.txt_height_bmi)
        Me.PanelBMI.Controls.Add(Me.txt_age_bmi)
        Me.PanelBMI.Controls.Add(Me.Label11)
        Me.PanelBMI.Controls.Add(Me.Label12)
        Me.PanelBMI.Controls.Add(Me.Label13)
        Me.PanelBMI.Controls.Add(Me.rd_female_bmi)
        Me.PanelBMI.Controls.Add(Me.rd_male_bmi)
        Me.PanelBMI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBMI.Location = New System.Drawing.Point(0, 0)
        Me.PanelBMI.Name = "PanelBMI"
        Me.PanelBMI.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PanelBMI.Size = New System.Drawing.Size(729, 617)
        Me.PanelBMI.TabIndex = 6
        Me.PanelBMI.Visible = False
        '
        'Personal_data1
        '
        Me.Personal_data1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Personal_data1.Location = New System.Drawing.Point(0, 0)
        Me.Personal_data1.Name = "Personal_data1"
        Me.Personal_data1.Size = New System.Drawing.Size(640, 617)
        Me.Personal_data1.TabIndex = 94
        Me.Personal_data1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(985, 617)
        Me.Controls.Add(Me.PanelBMI)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelBMR)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.Panel1.ResumeLayout(False)
        CType(Me.track_age, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track_height, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track_weight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBMR.ResumeLayout(False)
        Me.PanelBMR.PerformLayout()
        CType(Me.track_age_bmi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track_height_bmi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track_weight_bmi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBMI.ResumeLayout(False)
        Me.PanelBMI.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_bmi As System.Windows.Forms.Button
    Friend WithEvents btn_bmr As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SidePanel As System.Windows.Forms.Panel
    Friend WithEvents rd_male As System.Windows.Forms.RadioButton
    Friend WithEvents rd_female As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_age As System.Windows.Forms.TextBox
    Friend WithEvents txt_height As System.Windows.Forms.TextBox
    Friend WithEvents txt_weight As System.Windows.Forms.TextBox
    Friend WithEvents active As System.Windows.Forms.ComboBox
    Friend WithEvents calc As System.Windows.Forms.Button
    Friend WithEvents track_age As System.Windows.Forms.TrackBar
    Friend WithEvents track_height As System.Windows.Forms.TrackBar
    Friend WithEvents track_weight As System.Windows.Forms.TrackBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelBMR As System.Windows.Forms.Panel
    Friend WithEvents btn_data As System.Windows.Forms.Button
    Friend WithEvents rd_male_bmi As System.Windows.Forms.RadioButton
    Friend WithEvents rd_female_bmi As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_age_bmi As System.Windows.Forms.TextBox
    Friend WithEvents txt_height_bmi As System.Windows.Forms.TextBox
    Friend WithEvents txt_weight_bmi As System.Windows.Forms.TextBox
    Friend WithEvents calc_bmi As System.Windows.Forms.Button
    Friend WithEvents track_age_bmi As System.Windows.Forms.TrackBar
    Friend WithEvents track_height_bmi As System.Windows.Forms.TrackBar
    Friend WithEvents track_weight_bmi As System.Windows.Forms.TrackBar
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelBMI As System.Windows.Forms.Panel
    Friend WithEvents Personal_data1 As project.personal_data

End Class
