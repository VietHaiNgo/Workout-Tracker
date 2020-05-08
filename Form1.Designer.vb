<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tracker_Main
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
        Me.components = New System.ComponentModel.Container()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.rbDumbbell = New System.Windows.Forms.RadioButton()
        Me.rbBarbell = New System.Windows.Forms.RadioButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtSets = New System.Windows.Forms.TextBox()
        Me.txtReps = New System.Windows.Forms.TextBox()
        Me.txt1kg = New System.Windows.Forms.TextBox()
        Me.txt125kg = New System.Windows.Forms.TextBox()
        Me.txt250kg = New System.Windows.Forms.TextBox()
        Me.txtTotWeight = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbExercise = New System.Windows.Forms.ComboBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbPerson = New System.Windows.Forms.ComboBox()
        Me.btRec = New System.Windows.Forms.Button()
        Me.btClear = New System.Windows.Forms.Button()
        Me.btShowChart = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(111, 31)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(239, 22)
        Me.DateTimePicker1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1025, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'rbDumbbell
        '
        Me.rbDumbbell.AutoSize = True
        Me.rbDumbbell.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbDumbbell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDumbbell.Location = New System.Drawing.Point(481, 31)
        Me.rbDumbbell.Name = "rbDumbbell"
        Me.rbDumbbell.Size = New System.Drawing.Size(228, 22)
        Me.rbDumbbell.TabIndex = 9
        Me.rbDumbbell.TabStop = True
        Me.rbDumbbell.Text = "Single Dumbbell / Single Plate"
        Me.rbDumbbell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbDumbbell.UseVisualStyleBackColor = True
        '
        'rbBarbell
        '
        Me.rbBarbell.AutoSize = True
        Me.rbBarbell.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbBarbell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBarbell.Location = New System.Drawing.Point(715, 31)
        Me.rbBarbell.Name = "rbBarbell"
        Me.rbBarbell.Size = New System.Drawing.Size(135, 22)
        Me.rbBarbell.TabIndex = 10
        Me.rbBarbell.TabStop = True
        Me.rbBarbell.Text = "Barbell"
        Me.rbBarbell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbBarbell.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtSets
        '
        Me.txtSets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSets.Location = New System.Drawing.Point(481, 3)
        Me.txtSets.Name = "txtSets"
        Me.txtSets.Size = New System.Drawing.Size(228, 22)
        Me.txtSets.TabIndex = 12
        '
        'txtReps
        '
        Me.txtReps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtReps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReps.Location = New System.Drawing.Point(856, 3)
        Me.txtReps.Name = "txtReps"
        Me.txtReps.Size = New System.Drawing.Size(148, 22)
        Me.txtReps.TabIndex = 13
        '
        'txt1kg
        '
        Me.txt1kg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt1kg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1kg.Location = New System.Drawing.Point(481, 59)
        Me.txt1kg.Name = "txt1kg"
        Me.txt1kg.Size = New System.Drawing.Size(228, 22)
        Me.txt1kg.TabIndex = 14
        '
        'txt125kg
        '
        Me.txt125kg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt125kg.Location = New System.Drawing.Point(481, 115)
        Me.txt125kg.Name = "txt125kg"
        Me.txt125kg.Size = New System.Drawing.Size(228, 22)
        Me.txt125kg.TabIndex = 18
        '
        'txt250kg
        '
        Me.txt250kg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt250kg.Location = New System.Drawing.Point(481, 87)
        Me.txt250kg.Name = "txt250kg"
        Me.txt250kg.Size = New System.Drawing.Size(228, 22)
        Me.txt250kg.TabIndex = 19
        '
        'txtTotWeight
        '
        Me.txtTotWeight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTotWeight.Location = New System.Drawing.Point(856, 143)
        Me.txtTotWeight.Name = "txtTotWeight"
        Me.txtTotWeight.ReadOnly = True
        Me.txtTotWeight.Size = New System.Drawing.Size(148, 22)
        Me.txtTotWeight.TabIndex = 22
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.78596!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.57191!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.41137!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtSets, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtReps, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbExercise, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTotWeight, 5, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txt125kg, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txt250kg, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt1kg, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox7, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox9, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox13, 5, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.rbDumbbell, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.rbBarbell, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 4, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbPerson, 1, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1007, 171)
        Me.TableLayoutPanel1.TabIndex = 25
        '
        'cbExercise
        '
        Me.cbExercise.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbExercise.FormattingEnabled = True
        Me.cbExercise.Items.AddRange(New Object() {"Barbell Curls ", "Dumbbell Lundges ", "Elevated Push-ups ", "Forearm forward & reverse curls ", "Front Raise ", "Front Squats ", "Isolated Bicep Curls ", "Over-head Tricep Extension ", "Push-ups ", "Roman Lifts ", "Side Raise ", "Single Arm Dumbbell Row "})
        Me.cbExercise.Location = New System.Drawing.Point(111, 59)
        Me.cbExercise.Name = "cbExercise"
        Me.cbExercise.Size = New System.Drawing.Size(239, 24)
        Me.cbExercise.TabIndex = 4
        '
        'TextBox7
        '
        Me.TextBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(856, 59)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(148, 22)
        Me.TextBox7.TabIndex = 27
        '
        'TextBox9
        '
        Me.TextBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox9.Location = New System.Drawing.Point(856, 87)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(148, 22)
        Me.TextBox9.TabIndex = 28
        '
        'TextBox13
        '
        Me.TextBox13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox13.Location = New System.Drawing.Point(856, 115)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Size = New System.Drawing.Size(148, 22)
        Me.TextBox13.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 28)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Exercise"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(356, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 28)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Sets"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(356, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 28)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Weigh type"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(356, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 28)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Weight"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(715, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 28)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "x 1.00 Kg"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(715, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 28)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "x 1.25 Kg"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(715, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 28)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "X 2.50 Kg"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(715, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 31)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Total weight"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(715, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 28)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Reps"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 28)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Date"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 28)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Person"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbPerson
        '
        Me.cbPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbPerson.FormattingEnabled = True
        Me.cbPerson.Items.AddRange(New Object() {"Quân", "Hiệp", "Hải"})
        Me.cbPerson.Location = New System.Drawing.Point(111, 3)
        Me.cbPerson.Name = "cbPerson"
        Me.cbPerson.Size = New System.Drawing.Size(239, 24)
        Me.cbPerson.TabIndex = 31
        '
        'btRec
        '
        Me.btRec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btRec.Location = New System.Drawing.Point(178, 3)
        Me.btRec.Name = "btRec"
        Me.btRec.Size = New System.Drawing.Size(169, 25)
        Me.btRec.TabIndex = 26
        Me.btRec.Text = "Record New Data"
        Me.btRec.UseVisualStyleBackColor = True
        '
        'btClear
        '
        Me.btClear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btClear.Location = New System.Drawing.Point(3, 3)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(169, 25)
        Me.btClear.TabIndex = 27
        Me.btClear.Text = "Clear Data"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'btShowChart
        '
        Me.btShowChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btShowChart.Location = New System.Drawing.Point(353, 3)
        Me.btShowChart.Name = "btShowChart"
        Me.btShowChart.Size = New System.Drawing.Size(170, 25)
        Me.btShowChart.TabIndex = 28
        Me.btShowChart.Text = "Show Chart"
        Me.btShowChart.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.btClear, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btRec, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btShowChart, 2, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(493, 204)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(526, 31)
        Me.TableLayoutPanel2.TabIndex = 29
        '
        'Tracker_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1025, 239)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Tracker_Main"
        Me.Text = "Workout Tracker"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents rbDumbbell As RadioButton
    Friend WithEvents rbBarbell As RadioButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtSets As TextBox
    Friend WithEvents txtReps As TextBox
    Friend WithEvents txt1kg As TextBox
    Friend WithEvents txt125kg As TextBox
    Friend WithEvents txt250kg As TextBox
    Friend WithEvents txtTotWeight As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox13 As TextBox



    Friend WithEvents btRec As Button
    Friend WithEvents cbExercise As ComboBox
    Friend WithEvents btClear As Button
    Friend WithEvents btShowChart As Button
    Friend WithEvents cbPerson As ComboBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label


    Private Sub cbExercise_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbExercise.SelectedIndexChanged
        If (cbExercise.SelectedIndex = 2 Or cbExercise.SelectedIndex = 6 Or cbExercise.SelectedIndex = 8 Or cbExercise.SelectedIndex = 10 Or cbExercise.SelectedIndex = 11) Then
            rbDumbbell.Checked = True
            rbBarbell.Checked = False
        Else
            rbDumbbell.Checked = False
            rbBarbell.Checked = True
        End If
    End Sub
    Private Sub btRec_Click(sender As Object, e As EventArgs) Handles btRec.Click

    End Sub
End Class
