Public Class UserControl1

    Private Sub selectedMood(ByVal intMood As Integer)
        PbEmoticon.Image = imgLoend.Images(intMood)
    End Sub

    Public Sub setMood(ByVal strMood As String)
        Select Case strMood
            Case "confused"
                Me.selectedMood(0)
            Case "cool"
                Me.selectedMood(1)
            Case "smile"
                Me.selectedMood(2)
            Case "star"
                Me.selectedMood(3)
            Case "teeth"
                Me.selectedMood(4)
            Case "yell"
                Me.selectedMood(5)
            Case Else
                Me.selectedMood(0)
        End Select
    End Sub
    Public Sub ClearMood()
        ' Dispose the current image and set it to Nothing
        PbEmoticon.Image.Dispose()
        PbEmoticon.Image = Nothing
    End Sub

End Class
