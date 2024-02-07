Imports PrjFaces

Public Class Form1
    Private Sub BtnConfused_Click(sender As Object, e As EventArgs) Handles BtnConfused.Click
        Dim userControlInstance As New UserControl1()
        userControlInstance.setMood("Confused")
    End Sub

    Private Sub btnCool_Click(sender As Object, e As EventArgs) Handles btnCool.Click
        Dim userControlInstance As New UserControl1()
        userControlInstance.setMood("Cool")
    End Sub

    Private Sub btnSmile_Click(sender As Object, e As EventArgs) Handles btnSmile.Click
        Dim userControlInstance As New UserControl1()
        userControlInstance.setMood("Smile")
    End Sub

    Private Sub btnStar_Click(sender As Object, e As EventArgs) Handles btnStar.Click
        Dim userControlInstance As New UserControl1()
        userControlInstance.setMood("Star")
    End Sub

    Private Sub btnTeeth_Click(sender As Object, e As EventArgs) Handles btnTeeth.Click
        Dim userControlInstance As New UserControl1()
        userControlInstance.setMood("Teeth")
    End Sub

    Private Sub btnYell_Click(sender As Object, e As EventArgs) Handles btnYell.Click
        Dim userControlInstance As New UserControl1()
        userControlInstance.setMood("Yell")
    End Sub
End Class
