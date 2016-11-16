Module ModEmpleados
    Structure empleados
        Dim cod As Integer
        <VBFixedString(10)> Dim nomuser As String
        <VBFixedString(10)> Dim contrauser As String
        <VBFixedString(20)> Dim nom As String
        <VBFixedString(20)> Dim ape1 As String
        <VBFixedString(20)> Dim ape2 As String
        <VBFixedString(9)> Dim dni As String
        <VBFixedString(12)> Dim tel As String

    End Structure
    Public user As New empleados

End Module
