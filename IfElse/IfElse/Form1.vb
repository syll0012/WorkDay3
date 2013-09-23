Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largerNum As Double

        'Now, we want to make sure it doesn't crash if one were to accidently put in letters that can't be doubled. Both
        'of the IsNumeric statements have to be true in order for it to proceed'
        If IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text) Then
            num1 = CDbl(txtFirstNum.Text)
            num2 = CDbl(txtSecondNum.Text)

            'Take the input and immediately convert it into a double'
            'For comparing numbers'
            'Return will take you to the end of the program if it fails' 'it will take you to End Sub'
            'Return'


            If (num1 > num2) Then
                largerNum = num1
                txtResult.Text = "The larger number is " & num1
            ElseIf (num1 < num2) Then
                txtResult.Text = "The larger number is " & num2
            Else
                txtResult.Text = "They are equal"
            End If
        Else
            MessageBox.Show("Error: please type a number")
        End If



    End Sub
End Class
