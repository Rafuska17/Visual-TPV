Imports LibreriaValidaciones
Imports System.IO

Public Class GestionEmpleados
    Private Sub GestionEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

Private Sub limpiar()
        TbCodEmple.Clear()
        TbNombre.Clear()
        TbApellido1.Clear()
        TbApellido2.Clear()
        TbDni.Clear()
        TbTelefono.Clear()
    End Sub

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        If RbAlta.Checked Then
            Dim vali As New Validaciones
            FileOpen(1, "Empleados.txt", OpenMode.Random, OpenAccess.Write, , Len(user))
            Dim aux As String = TbDni.Text.TrimEnd
            Dim aux2 As String = aux + vali.Nif(aux).ToString

            If TbDni.Text.Equals(aux2) Then
                Dim a As Integer = Val(TbCodEmple.Text)
                user.nomuser = vali.validar(TbNombreUser.Text)
                user.contrauser = vali.validar(TbContraUser.Text)
                user.cod = a
                user.nom = vali.validar(TbNombre.Text)
                user.ape1 = vali.validar(TbApellido1.Text)
                user.ape2 = vali.validar(TbApellido1.Text)
                user.dni = vali.Nif(TbDni.Text)
                user.tel = vali.validartelefono(TbTelefono.Text)

                FilePut(1, user, a)
                FileClose()
            Else
                MsgBox("Nombre de Usuario o Contraseña incorrecta, pruebe de nuevo", 4144, "Error de inicio de sesion")
            End If
        ElseIf RbModificar.Checked Then
        ElseIf RbBorrar.Checked Then

        End If
    End Sub
End Class