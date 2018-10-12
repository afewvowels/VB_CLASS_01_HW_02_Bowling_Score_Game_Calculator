<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BowlingStatistics
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
        Me.DataEntryGroupBox = New System.Windows.Forms.GroupBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.ScoresTextBox1 = New System.Windows.Forms.TextBox()
        Me.ScoresLabel = New System.Windows.Forms.Label()
        Me.ScoresTextBox2 = New System.Windows.Forms.TextBox()
        Me.ScoresTextBox3 = New System.Windows.Forms.TextBox()
        Me.GenderRadioButtonMale = New System.Windows.Forms.RadioButton()
        Me.GenderRadioButtonFemale = New System.Windows.Forms.RadioButton()
        Me.GenderLabel = New System.Windows.Forms.Label()
        Me.DataStatisticsGroupBox = New System.Windows.Forms.GroupBox()
        Me.SeriesTextBox = New System.Windows.Forms.TextBox()
        Me.SeriesLabel = New System.Windows.Forms.Label()
        Me.AverageTextBox = New System.Windows.Forms.TextBox()
        Me.AverageLabel = New System.Windows.Forms.Label()
        Me.HandicapTextBox = New System.Windows.Forms.TextBox()
        Me.HandicapLabel = New System.Windows.Forms.Label()
        Me.HighGameTextBox = New System.Windows.Forms.TextBox()
        Me.HighGameLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DataEntryGroupBox.SuspendLayout()
        Me.DataStatisticsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataEntryGroupBox
        '
        Me.DataEntryGroupBox.Controls.Add(Me.GenderLabel)
        Me.DataEntryGroupBox.Controls.Add(Me.GenderRadioButtonFemale)
        Me.DataEntryGroupBox.Controls.Add(Me.GenderRadioButtonMale)
        Me.DataEntryGroupBox.Controls.Add(Me.ScoresTextBox3)
        Me.DataEntryGroupBox.Controls.Add(Me.ScoresTextBox2)
        Me.DataEntryGroupBox.Controls.Add(Me.ScoresTextBox1)
        Me.DataEntryGroupBox.Controls.Add(Me.ScoresLabel)
        Me.DataEntryGroupBox.Controls.Add(Me.NameTextBox)
        Me.DataEntryGroupBox.Controls.Add(Me.NameLabel)
        Me.DataEntryGroupBox.Location = New System.Drawing.Point(59, 48)
        Me.DataEntryGroupBox.Name = "DataEntryGroupBox"
        Me.DataEntryGroupBox.Size = New System.Drawing.Size(695, 268)
        Me.DataEntryGroupBox.TabIndex = 0
        Me.DataEntryGroupBox.TabStop = False
        Me.DataEntryGroupBox.Text = "Data Entry"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(158, 75)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(249, 35)
        Me.NameTextBox.TabIndex = 1
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(68, 78)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(84, 29)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name:"
        '
        'ScoresTextBox1
        '
        Me.ScoresTextBox1.Location = New System.Drawing.Point(529, 75)
        Me.ScoresTextBox1.Name = "ScoresTextBox1"
        Me.ScoresTextBox1.Size = New System.Drawing.Size(105, 35)
        Me.ScoresTextBox1.TabIndex = 3
        '
        'ScoresLabel
        '
        Me.ScoresLabel.AutoSize = True
        Me.ScoresLabel.Location = New System.Drawing.Point(428, 78)
        Me.ScoresLabel.Name = "ScoresLabel"
        Me.ScoresLabel.Size = New System.Drawing.Size(95, 29)
        Me.ScoresLabel.TabIndex = 2
        Me.ScoresLabel.Text = "Scores:"
        '
        'ScoresTextBox2
        '
        Me.ScoresTextBox2.Location = New System.Drawing.Point(529, 129)
        Me.ScoresTextBox2.Name = "ScoresTextBox2"
        Me.ScoresTextBox2.Size = New System.Drawing.Size(105, 35)
        Me.ScoresTextBox2.TabIndex = 4
        '
        'ScoresTextBox3
        '
        Me.ScoresTextBox3.Location = New System.Drawing.Point(529, 182)
        Me.ScoresTextBox3.Name = "ScoresTextBox3"
        Me.ScoresTextBox3.Size = New System.Drawing.Size(105, 35)
        Me.ScoresTextBox3.TabIndex = 5
        '
        'GenderRadioButtonMale
        '
        Me.GenderRadioButtonMale.AutoSize = True
        Me.GenderRadioButtonMale.Location = New System.Drawing.Point(158, 143)
        Me.GenderRadioButtonMale.Name = "GenderRadioButtonMale"
        Me.GenderRadioButtonMale.Size = New System.Drawing.Size(97, 33)
        Me.GenderRadioButtonMale.TabIndex = 6
        Me.GenderRadioButtonMale.TabStop = True
        Me.GenderRadioButtonMale.Text = "Male"
        Me.GenderRadioButtonMale.UseVisualStyleBackColor = True
        '
        'GenderRadioButtonFemale
        '
        Me.GenderRadioButtonFemale.AutoSize = True
        Me.GenderRadioButtonFemale.Location = New System.Drawing.Point(158, 182)
        Me.GenderRadioButtonFemale.Name = "GenderRadioButtonFemale"
        Me.GenderRadioButtonFemale.Size = New System.Drawing.Size(126, 33)
        Me.GenderRadioButtonFemale.TabIndex = 7
        Me.GenderRadioButtonFemale.TabStop = True
        Me.GenderRadioButtonFemale.Text = "Female"
        Me.GenderRadioButtonFemale.UseVisualStyleBackColor = True
        '
        'GenderLabel
        '
        Me.GenderLabel.AutoSize = True
        Me.GenderLabel.Location = New System.Drawing.Point(52, 141)
        Me.GenderLabel.Name = "GenderLabel"
        Me.GenderLabel.Size = New System.Drawing.Size(100, 29)
        Me.GenderLabel.TabIndex = 8
        Me.GenderLabel.Text = "Gender:"
        '
        'DataStatisticsGroupBox
        '
        Me.DataStatisticsGroupBox.Controls.Add(Me.HighGameTextBox)
        Me.DataStatisticsGroupBox.Controls.Add(Me.HighGameLabel)
        Me.DataStatisticsGroupBox.Controls.Add(Me.HandicapTextBox)
        Me.DataStatisticsGroupBox.Controls.Add(Me.HandicapLabel)
        Me.DataStatisticsGroupBox.Controls.Add(Me.AverageTextBox)
        Me.DataStatisticsGroupBox.Controls.Add(Me.AverageLabel)
        Me.DataStatisticsGroupBox.Controls.Add(Me.SeriesTextBox)
        Me.DataStatisticsGroupBox.Controls.Add(Me.SeriesLabel)
        Me.DataStatisticsGroupBox.Location = New System.Drawing.Point(59, 345)
        Me.DataStatisticsGroupBox.Name = "DataStatisticsGroupBox"
        Me.DataStatisticsGroupBox.Size = New System.Drawing.Size(695, 284)
        Me.DataStatisticsGroupBox.TabIndex = 1
        Me.DataStatisticsGroupBox.TabStop = False
        Me.DataStatisticsGroupBox.Text = "Data Statistics"
        '
        'SeriesTextBox
        '
        Me.SeriesTextBox.Location = New System.Drawing.Point(529, 55)
        Me.SeriesTextBox.Name = "SeriesTextBox"
        Me.SeriesTextBox.Size = New System.Drawing.Size(105, 35)
        Me.SeriesTextBox.TabIndex = 5
        '
        'SeriesLabel
        '
        Me.SeriesLabel.AutoSize = True
        Me.SeriesLabel.Location = New System.Drawing.Point(434, 58)
        Me.SeriesLabel.Name = "SeriesLabel"
        Me.SeriesLabel.Size = New System.Drawing.Size(89, 29)
        Me.SeriesLabel.TabIndex = 4
        Me.SeriesLabel.Text = "Series:"
        '
        'AverageTextBox
        '
        Me.AverageTextBox.Location = New System.Drawing.Point(529, 105)
        Me.AverageTextBox.Name = "AverageTextBox"
        Me.AverageTextBox.Size = New System.Drawing.Size(105, 35)
        Me.AverageTextBox.TabIndex = 7
        '
        'AverageLabel
        '
        Me.AverageLabel.AutoSize = True
        Me.AverageLabel.Location = New System.Drawing.Point(415, 108)
        Me.AverageLabel.Name = "AverageLabel"
        Me.AverageLabel.Size = New System.Drawing.Size(108, 29)
        Me.AverageLabel.TabIndex = 6
        Me.AverageLabel.Text = "Average:"
        '
        'HandicapTextBox
        '
        Me.HandicapTextBox.Location = New System.Drawing.Point(529, 155)
        Me.HandicapTextBox.Name = "HandicapTextBox"
        Me.HandicapTextBox.Size = New System.Drawing.Size(105, 35)
        Me.HandicapTextBox.TabIndex = 9
        '
        'HandicapLabel
        '
        Me.HandicapLabel.AutoSize = True
        Me.HandicapLabel.Location = New System.Drawing.Point(402, 155)
        Me.HandicapLabel.Name = "HandicapLabel"
        Me.HandicapLabel.Size = New System.Drawing.Size(121, 29)
        Me.HandicapLabel.TabIndex = 8
        Me.HandicapLabel.Text = "Handicap:"
        '
        'HighGameTextBox
        '
        Me.HighGameTextBox.Location = New System.Drawing.Point(529, 207)
        Me.HighGameTextBox.Name = "HighGameTextBox"
        Me.HighGameTextBox.Size = New System.Drawing.Size(105, 35)
        Me.HighGameTextBox.TabIndex = 11
        '
        'HighGameLabel
        '
        Me.HighGameLabel.AutoSize = True
        Me.HighGameLabel.Location = New System.Drawing.Point(383, 210)
        Me.HighGameLabel.Name = "HighGameLabel"
        Me.HighGameLabel.Size = New System.Drawing.Size(140, 29)
        Me.HighGameLabel.TabIndex = 10
        Me.HighGameLabel.Text = "High Game:"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(59, 656)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(199, 55)
        Me.CalculateButton.TabIndex = 2
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(307, 656)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(199, 55)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(555, 656)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(199, 55)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'BowlingStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 774)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.DataStatisticsGroupBox)
        Me.Controls.Add(Me.DataEntryGroupBox)
        Me.Name = "BowlingStatistics"
        Me.Text = "Bowling Statistics"
        Me.DataEntryGroupBox.ResumeLayout(False)
        Me.DataEntryGroupBox.PerformLayout()
        Me.DataStatisticsGroupBox.ResumeLayout(False)
        Me.DataStatisticsGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataEntryGroupBox As GroupBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents GenderLabel As Label
    Friend WithEvents GenderRadioButtonFemale As RadioButton
    Friend WithEvents GenderRadioButtonMale As RadioButton
    Friend WithEvents ScoresTextBox3 As TextBox
    Friend WithEvents ScoresTextBox2 As TextBox
    Friend WithEvents ScoresTextBox1 As TextBox
    Friend WithEvents ScoresLabel As Label
    Friend WithEvents DataStatisticsGroupBox As GroupBox
    Friend WithEvents HighGameTextBox As TextBox
    Friend WithEvents HighGameLabel As Label
    Friend WithEvents HandicapTextBox As TextBox
    Friend WithEvents HandicapLabel As Label
    Friend WithEvents AverageTextBox As TextBox
    Friend WithEvents AverageLabel As Label
    Friend WithEvents SeriesTextBox As TextBox
    Friend WithEvents SeriesLabel As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
End Class
