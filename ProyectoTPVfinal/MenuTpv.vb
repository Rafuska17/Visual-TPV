Public Class MenuTpv

    Private Sub MenuTpv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtRealizarPedidos.Click

    End Sub

    Private Sub BtGestionarProductos_Click(sender As Object, e As EventArgs) Handles BtGestionarProductos.Click
        Me.Hide()
        Producto.Show()
    End Sub
End Class
