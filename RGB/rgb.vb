Public Class rgb
    Dim red As Int16
    Dim green As Int16
    Dim bleu As Int16
    Public Sub New(ByVal sred As String, ByVal sgreen As String, ByVal sbleu As String)
        red = CType(sred, Int16)
        green = CType(sgreen, Int16)
        bleu = CType(sbleu, Int16)
    End Sub
    Public Function in_Iterval() As Boolean
        Return ((red <= 255 And red >= 0) And (green <= 255 And green >= 0) And (bleu <= 255 And bleu >= 0))
    End Function
    Public Sub changeColor(ByRef _color As Color)
        _color = Color.FromArgb(red, green, bleu)
    End Sub

End Class
