Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        Dim side1 As Double = CDbl(txtSideOne.Text)
        Dim side2 As Double = CDbl(txtSideTwo.Text)
        Dim hyp As Double 'result

        hyp = hypotenuse(side1, side2)


        txtHyp.Text = CStr(hyp)

    End Sub


    Function hypotenuse(ByVal a As Double, ByVal b As Double) As Double
        Dim c As Double
        c = Math.Sqrt(a ^ 2 + b ^ 2)
        Return c
    End Function
End Class