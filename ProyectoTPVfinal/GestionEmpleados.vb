Imports LibreriaValidaciones

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

    Private Sub RbAlta_CheckedChanged(sender As Object, e As EventArgs) Handles RbAlta.CheckedChanged
        Dim vali As New Validaciones
        FileOpen(1, "Empleados.txt", OpenMode.Random, OpenAccess.Write, , Len(user))
        Dim a As Integer = 1
        user.nomuser = vali.validar(TbNombreUser.Text)
        user.contrauser = vali.validar(TbContraUser.Text)
        user.nom = vali.validar(TbNombre.Text)
        user.ape1 = vali.validar(TbApellido1.Text)
        user.ape2 = vali.validar(TbApellido1.Text)
        user.dni = vali.Nif(TbDni.Text)
        user.tel = vali.

        FilePut(1, user, a)
        FileClose()
    End Sub

    Private Sub RbModificar_CheckedChanged(sender As Object, e As EventArgs) Handles RbModificar.CheckedChanged

    End Sub
End Class