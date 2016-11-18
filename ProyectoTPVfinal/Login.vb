Imports System.IO
Public Class Login

    Private Sub BTEntrar_Click(sender As Object, e As EventArgs) Handles BTEntrar.Click
        FileOpen(1, "Empleados.txt", OpenMode.Random, OpenAccess.Read, , Len(user))
        Dim usuario = TBNomUser.Text
        Dim contraseña = TBContraUser.Text
        Dim aux As Boolean = False
        Dim b As Integer = 1
        Dim nom As String
        Dim con As String
        While Not EOF(1)
            FileGet(1, user, b)
            nom = Trim(user.nomuser)
            con = Trim(user.contrauser)
            If usuario = nom And contraseña = con Then
                aux = True
            End If
            b = b + 1
        End While
        FileClose()

        If aux = True Then
            Me.Hide()
            MenuTpv.Show()
        Else
            MsgBox("Nombre de Usuario o Contraseña incorrecta, pruebe de nuevo", 4144, "Error de inicio de sesion")
            TBNomUser.Clear()
            TBContraUser.Clear()
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub
End Class