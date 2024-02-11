Imports PrjFaces

Public Class Form1
    Private WithEvents switchControl As New USwitch
    Private bulbControl As New UBulb

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add the switch and bulb controls to the form
        Me.Controls.Add(switchControl)
        Me.Controls.Add(bulbControl)

        ' Position the controls on the form
        switchControl.Location = New Point(50, 50)
        bulbControl.Location = New Point(150, 50)
    End Sub

    Private Sub switchControl_Click(sender As Object, e As EventArgs) Handles switchControl.Click
        ' Control the bulb state based on the switch state
        bulbControl.IsOn = switchControl.IsOn
    End Sub
    Private Sub BtnConfused_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfused.Click
        UserControl.setMood("confused")
    End Sub

    Private Sub BtnCool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCool.Click
        UserControl.setMood("cool")
    End Sub

    Private Sub BtnSmile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSmile.Click
        UserControl.setMood("smile")
    End Sub

    Private Sub BtnStar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStar.Click
        UserControl.setMood("star")
    End Sub


    Private Sub BtnTeeth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeeth.Click
        UserControl.setMood("teeth")
    End Sub

    Private Sub BtnYell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYell.Click
        UserControl.setMood("yell")
    End Sub
    Private Sub BtnPuhasta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPuhasta.Click
        UserControl.ClearMood()
    End Sub

End Class
