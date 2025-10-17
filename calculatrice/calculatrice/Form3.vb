Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        results.Text = results.Text + "4"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        results.Text = results.Text + "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        results.Text = results.Text + "8"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        results.Text = results.Text + "0"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        results.Text = ""
        Label2.Text = ""
        Label3.Text = ""



    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        results.Text = results.Text + ""
        Label2.Text = results.Text
        Label3.Text = "x"
        results.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        results.Text = results.Text + "1"


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        results.Text = results.Text + "2"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        results.Text = results.Text + "3"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        results.Text = results.Text + "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        results.Text = results.Text + "7"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        results.Text = results.Text + "9"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Label3.Text = "+" Then
            results.Text = Val(Label2.Text) + Val(results.Text)
            Label2.Text = "="
            Label3.Text = ""

        End If

        If Label3.Text = "-" Then
            results.Text = Val(Label2.Text) - Val(results.Text)
            Label2.Text = "="
            Label3.Text = ""

        End If

        If Label3.Text = "x" Then
            results.Text = Val(Label2.Text) * Val(results.Text)
            Label2.Text = "="
            Label3.Text = ""

        End If

        If Label3.Text = "/" Then
            results.Text = Val(Label2.Text) / Val(results.Text)
            Label2.Text = "="
            Label3.Text = ""

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        results.Text = results.Text + ""
        Label2.Text = results.Text
        Label3.Text = "+"
        results.Text = ""


    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        results.Text = results.Text + ""
        Label2.Text = results.Text
        Label3.Text = "-"
        results.Text = ""

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        results.Text = results.Text + ""
        Label2.Text = results.Text
        Label3.Text = "/"
        results.Text = ""
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub results_TextChanged(sender As Object, e As EventArgs) Handles results.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If Label2.Text.Contains("=") Then
            Exit Sub
        End If


        If results.Text.Length > 0 Then
            results.Text = results.Text.Remove(results.Text.Length - 1)
        End If
    End Sub
End Class