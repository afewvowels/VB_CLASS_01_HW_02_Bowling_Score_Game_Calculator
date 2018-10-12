' Author: Keith Smith
' Date: 12 October 2018

Option Explicit On
Option Strict On

Public Class BowlingStatistics
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ' Declare Variables
        Dim Score1, Score2, Score3 As Integer

        ' Make sure that name entry field is filled in,
        ' throw an exception and display error message
        ' if the field is empty
        Try
            If NameTextBox.Text = "" Then
                Throw New Exception
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter a name",
                            "Name Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        ' Make sure that one of the gender radio buttons
        ' has been checked, throw and exception and display
        ' a warning message if neither is checked
        Try
            If GenderRadioButtonFemale.Checked = False And GenderRadioButtonMale.Checked = False Then
                Throw New Exception
            End If
        Catch ex As Exception
            MessageBox.Show("Please select a gender",
                            "Gender Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
            Exit Sub
        End Try


        ' Try to parse score text boxes, throw and exception
        ' and display error message if bad data is detected
        Try
            ' Parse text boxes to integer values
            Score1 = Convert.ToInt32(ScoresTextBox1.Text)
            Score2 = Convert.ToInt32(ScoresTextBox2.Text)
            Score3 = Convert.ToInt32(ScoresTextBox3.Text)

            ' Check that parsed values are acceptable
            ' bowling game scores
            If Score1 < 0 Or Score1 > 200 Then
                Throw New ArgumentOutOfRangeException
            ElseIf Score2 < 0 Or Score2 > 200 Then
                Throw New ArgumentOutOfRangeException
            ElseIf Score3 < 0 Or Score3 > 200 Then
                Throw New ArgumentOutOfRangeException
            End If
        Catch ex As FormatException
            MessageBox.Show("Please enter three numeric scores",
                            "Data Parse Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("Please enter a number between 0 and 200",
                            "Out Of Range",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        End Try

        ' Now that scores have been parsed, call functions and subroutines
        ' to populate text boxes with results
        SeriesTextBox.Text = FindSeries(Score1, Score2, Score3).ToString("N0")
        AverageTextBox.Text = FindAverage(Score1, Score2, Score3).ToString("N1")
        DisplayHandicap(Score1, Score2, Score3)
        HighGameTextBox.Text = FindHighGame(Score1, Score2, Score3)

        ' Call reset form subroutine
        ' ResetForm()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Call reset form subroutine
        ResetForm()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Close application
        Me.Close()
    End Sub

    Private Function FindSeries(ByVal _Score1 As Integer, ByVal _Score2 As Integer, ByVal _Score3 As Integer) As Integer
        ' Return sum of three scores
        Return _Score1 + _Score2 + _Score3
    End Function

    Private Function FindAverage(ByVal _Score1 As Integer, ByVal _Score2 As Integer, ByVal _Score3 As Integer) As Decimal
        ' Return calculated average score
        Return (_Score1 + _Score2 + _Score3) / 3D
    End Function

    Private Sub DisplayHandicap(ByVal _Score1 As Integer, ByVal _Score2 As Integer, ByVal _Score3 As Integer)
        ' Set HandicapTextBox.Text to calculated handicap value
        HandicapTextBox.Text = ((200D - FindAverage(_Score1, _Score2, _Score3)) * 0.8D).ToString("N1")
    End Sub

    Private Function FindHighGame(ByVal _Score1 As Integer, ByVal _Score2 As Integer, ByVal _Score3 As Integer) As String
        ' Define variable to hold return value
        Dim HighGameString As String

        ' Logic to determine value to return, first determine if a tie score exists
        ' and if the tied score is larger than the remaining score. If so, display tie.
        ' Otherwise, determine highest score by comparing all values.
        If _Score1 = _Score2 And _Score1 = _Score3 Then
            HighGameString = "Tie"
        ElseIf _Score1 = _Score2 And _Score1 > _Score3 Then
            HighGameString = "Tie"
        ElseIf _Score1 = _Score3 And _Score1 > _Score2 Then
            HighGameString = "Tie"
        ElseIf _Score2 = _Score3 And _Score2 > _Score1 Then
            HighGameString = "Tie"
        ElseIf _Score1 > _Score2 And _Score1 > _Score3 Then
            HighGameString = "1"
        ElseIf _Score2 > _Score3 Then
            HighGameString = "2"
        Else
            HighGameString = "3"
        End If

        ' Return selected value
        Return HighGameString
    End Function

    Private Sub ResetForm()
        ' Clear name entry text box and set focus
        With NameTextBox
            .Clear()
            .Focus()
        End With

        ' Clear all score entry text boxes
        ScoresTextBox1.Clear()
        ScoresTextBox2.Clear()
        ScoresTextBox3.Clear()

        ' Uncheck both radio buttons
        GenderRadioButtonFemale.Checked = False
        GenderRadioButtonMale.Checked = False

        ' Clear results text boxes
        SeriesTextBox.Clear()
        AverageTextBox.Clear()
        HandicapTextBox.Clear()
        HighGameTextBox.Clear()
    End Sub
End Class
