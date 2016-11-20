Public Class Validaciones
    Public Function validar(ByVal text As String) As Boolean
        Dim cha As Char
        Dim nv As String = "!¡?¿+-$%&/()=""'@*\|ºª€{}[];:,.·¬<>"
        Dim ch2 As Char

        For i As Integer = 1 To text.Length
            cha = GetChar(text, i)
            If IsNumeric(cha) Then
                MsgBox("Tiene que ser una letra")
                Return False
            Else
                For k As Integer = 1 To nv.Length
                    ch2 = GetChar(nv, k)
                    If cha.Equals(ch2) Then
                        MsgBox("Tiene que ser un caracter valido")
                        Return False
                    End If
                Next
            End If
        Next
        Return True
    End Function

    Public Function validartelefono(ByVal text As String) As Boolean

        Dim cha As Char
        For i As Integer = 1 To text.Length
            cha = GetChar(text, i)
            If IsNumeric(cha) Or cha.Equals("+") Then
                Return True
            Else
                MsgBox("Tiene que ser una letra")
                Return False
            End If
        Next
        Return True
    End Function

    Public Function Nif(ByVal num As Long) As String
        Dim tab() As String = {"T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "O", "H", "L", "C", "K", "E"}
        Return tab(num Mod 23)
    End Function
End Class
