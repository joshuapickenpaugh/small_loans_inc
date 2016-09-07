Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Delcares the variables:    
        Dim decSalary As Decimal

        'Assigns variable to text box:
        Decimal.TryParse(txtSalary.Text, decSalary)

        'Decision structure:
        '(IF/THEN can work, but will do SELECT CASE instead!):
        'If (decSalary >= 35000) Then
        '    If chkFiveYearsEmployed.Checked = True Then
        '        lblAnswer.Text = "May borrow up to 25% of salary."
        '    Else
        '        lblAnswer.Text = "May borrow up to 20% of salary."
        '    End If
        'End If

        'If (decSalary < 35000) Then
        '    lblAnswer.Text = "May borrow up to 5% of salary."
        'End If

        Select Case decSalary
            Case >= 35000.0
                If chkFiveYearsEmployed.Checked = True Then
                    lblAnswer.Text = "May borrow up to 25% of salary."
                Else
                    lblAnswer.Text = "May borrow up to 20% of salary."
                End If
            Case < 35000.0
                lblAnswer.Text = "May borrow up to 5% of salary."
        End Select

    End Sub
End Class
