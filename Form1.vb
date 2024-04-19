Option Strict On
Option Explicit On

Public Class Form1


    ' ****************************************************************************
    ' Surname, Initials:Sikhipha_A
    ' Student Number:223068260
    ' Practical: P24IFM-01
    ' Class name: Form1
    ' ****************************************************************************


    Private totalHours As Integer = 0
    Private averageHoursPerWeek As Double = 0

    Private Sub calculateBTN_Click(sender As Object, e As EventArgs) Handles calculateBTN.Click
        totalHours = CInt(enter_nqf_credit_input.Text) * 10 'Assuming 1 NQF Credits = 10 hours

        'Semester is said to be 14 weeks long
        averageHoursPerWeek = totalHours / 14

        'Display the results in the corresponding  textboxes
        total_hours_output.Text = totalHours.ToString()
        average_hours_per_week_output.Text = averageHoursPerWeek.ToString("0.00")



    End Sub
End Class
