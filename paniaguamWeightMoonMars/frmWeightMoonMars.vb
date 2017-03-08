'Application name: Weight on the Moon and Mars
'Date: 11/2/15
'Programmer: Manuel Paniagua
'Purpose: Calculates the users weight on Mars or the moon in lbs and kgs

Option Infer Off
Option Strict On
Option Explicit On

Public Class frmWeightMoonMars
    Const cdecMOON As Decimal = 0.166D                              'declares constants
    Const cdecMARS As Decimal = 0.377D
    Const cdecKG As Decimal = 0.454D

    Dim decEarthWeight As Decimal                                   'declares variables
    Dim decPounds As Decimal
    Dim decKG As Decimal

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Button calculates users weight based on choice of Moon or Mars

        If IsNumeric(txtWeight.Text) Then                           'validates whether user input is a number

            decEarthWeight = Convert.ToDecimal(txtWeight.Text)      'converts user input to decimal, initializes variable

            If decEarthWeight > 0 Then                              'validates whether user input is a number greater than 0
                If rdoMoon.Checked Then                             'if moon button is clicked, weight on moon is calculated
                    decPounds = decEarthWeight * cdecMOON           'calculates weight in pounds
                    decKG = decPounds * cdecKG                      'calculates weight in kilograms
                    lblWeight.Text = "Weight on the Moon:" & vbCrLf & decPounds.ToString("n1") & " lbs   " & _
                    decKG.ToString("n1") & " kgs"                   'displays Moon weight in lbs and kgs

                Else                                                'if mars is clicked, weight on mars is calculated
                    decPounds = decEarthWeight * cdecMARS           'calculates weight in pounds
                    decKG = decPounds * cdecKG                      'calculates weight in kilograms
                    lblWeight.Text = "Weight on Mars:" & vbCrLf & decPounds.ToString("n1") & " lbs   " & _
                    decKG.ToString("n1") & " kgs"                   'displays Moon weight in lbs and kgs
                End If
            Else                                                    'error when user input is less than 0
                MsgBox("Please enter a valid weight.", , "Input Error")
                txtWeight.Clear()                                   'clears textbox and returns focus
                txtWeight.Focus()
            End If
        Else                                                        'error when user input is not a number
            MsgBox("Please enter a valid weight.", , "Input Error")
            txtWeight.Clear()                                       'clears textbox and returns focus
            txtWeight.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Button clears user input as well as displayed weight

        txtWeight.Clear()                                           'clears textbox and returns focus
        txtWeight.Focus()

        lblWeight.Text = " "                                        'clears weight displayed

        rdoMoon.Checked = True                                      'checks Moon button
        rdoMars.Checked = False                                     'unchecks Mars button

    End Sub
End Class
