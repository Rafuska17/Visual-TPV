<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuTpv
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtRealizarPedidos = New System.Windows.Forms.Button()
        Me.BtHacerCaja = New System.Windows.Forms.Button()
        Me.BtGestionarProductos = New System.Windows.Forms.Button()
        Me.BtGestionarUsuarios = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtRealizarPedidos
        '
        Me.BtRealizarPedidos.Location = New System.Drawing.Point(82, 52)
        Me.BtRealizarPedidos.Name = "BtRealizarPedidos"
        Me.BtRealizarPedidos.Size = New System.Drawing.Size(138, 23)
        Me.BtRealizarPedidos.TabIndex = 0
        Me.BtRealizarPedidos.Text = "Realizar pedido"
        Me.BtRealizarPedidos.UseVisualStyleBackColor = True
        '
        'BtHacerCaja
        '
        Me.BtHacerCaja.Location = New System.Drawing.Point(82, 81)
        Me.BtHacerCaja.Name = "BtHacerCaja"
        Me.BtHacerCaja.Size = New System.Drawing.Size(138, 23)
        Me.BtHacerCaja.TabIndex = 2
        Me.BtHacerCaja.Text = "Hacer caja"
        Me.BtHacerCaja.UseVisualStyleBackColor = True
        '
        'BtGestionarProductos
        '
        Me.BtGestionarProductos.Location = New System.Drawing.Point(82, 110)
        Me.BtGestionarProductos.Name = "BtGestionarProductos"
        Me.BtGestionarProductos.Size = New System.Drawing.Size(138, 23)
        Me.BtGestionarProductos.TabIndex = 3
        Me.BtGestionarProductos.Text = "Gestionar productos"
        Me.BtGestionarProductos.UseVisualStyleBackColor = True
        '
        'BtGestionarUsuarios
        '
        Me.BtGestionarUsuarios.Location = New System.Drawing.Point(82, 139)
        Me.BtGestionarUsuarios.Name = "BtGestionarUsuarios"
        Me.BtGestionarUsuarios.Size = New System.Drawing.Size(138, 23)
        Me.BtGestionarUsuarios.TabIndex = 4
        Me.BtGestionarUsuarios.Text = "Gestionar usuarios"
        Me.BtGestionarUsuarios.UseVisualStyleBackColor = True
        '
        'MenuTpv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 339)
        Me.Controls.Add(Me.BtGestionarUsuarios)
        Me.Controls.Add(Me.BtGestionarProductos)
        Me.Controls.Add(Me.BtHacerCaja)
        Me.Controls.Add(Me.BtRealizarPedidos)
        Me.Name = "MenuTpv"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtRealizarPedidos As System.Windows.Forms.Button
    Friend WithEvents BtHacerCaja As System.Windows.Forms.Button
    Friend WithEvents BtGestionarProductos As System.Windows.Forms.Button
    Friend WithEvents BtGestionarUsuarios As System.Windows.Forms.Button

End Class
