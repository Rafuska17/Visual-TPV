<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionEmpleados
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
        Me.GbEmple = New System.Windows.Forms.GroupBox()
        Me.RbBorrar = New System.Windows.Forms.RadioButton()
        Me.RbModificar = New System.Windows.Forms.RadioButton()
        Me.RbAlta = New System.Windows.Forms.RadioButton()
        Me.LbCodEmple = New System.Windows.Forms.Label()
        Me.TbCodEmple = New System.Windows.Forms.TextBox()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.LbApellido1 = New System.Windows.Forms.Label()
        Me.LbApellido2 = New System.Windows.Forms.Label()
        Me.LbDni = New System.Windows.Forms.Label()
        Me.LbTelefono = New System.Windows.Forms.Label()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.TbApellido1 = New System.Windows.Forms.TextBox()
        Me.TbApellido2 = New System.Windows.Forms.TextBox()
        Me.TbDni = New System.Windows.Forms.TextBox()
        Me.TbTelefono = New System.Windows.Forms.TextBox()
        Me.BtAceptar = New System.Windows.Forms.Button()
        Me.BtSalir = New System.Windows.Forms.Button()
        Me.LbNombreUser = New System.Windows.Forms.Label()
        Me.LbContraUser = New System.Windows.Forms.Label()
        Me.TbNombreUser = New System.Windows.Forms.TextBox()
        Me.TbContraUser = New System.Windows.Forms.TextBox()
        Me.GbEmple.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbEmple
        '
        Me.GbEmple.Controls.Add(Me.RbBorrar)
        Me.GbEmple.Controls.Add(Me.RbModificar)
        Me.GbEmple.Controls.Add(Me.RbAlta)
        Me.GbEmple.Location = New System.Drawing.Point(12, 26)
        Me.GbEmple.Name = "GbEmple"
        Me.GbEmple.Size = New System.Drawing.Size(541, 63)
        Me.GbEmple.TabIndex = 0
        Me.GbEmple.TabStop = False
        Me.GbEmple.Text = "¿Qué desea hacer?"
        '
        'RbBorrar
        '
        Me.RbBorrar.AutoSize = True
        Me.RbBorrar.Location = New System.Drawing.Point(432, 33)
        Me.RbBorrar.Name = "RbBorrar"
        Me.RbBorrar.Size = New System.Drawing.Size(103, 17)
        Me.RbBorrar.TabIndex = 2
        Me.RbBorrar.TabStop = True
        Me.RbBorrar.Text = "Borrar Empleado"
        Me.RbBorrar.UseVisualStyleBackColor = True
        '
        'RbModificar
        '
        Me.RbModificar.AutoSize = True
        Me.RbModificar.Location = New System.Drawing.Point(202, 33)
        Me.RbModificar.Name = "RbModificar"
        Me.RbModificar.Size = New System.Drawing.Size(118, 17)
        Me.RbModificar.TabIndex = 1
        Me.RbModificar.TabStop = True
        Me.RbModificar.Text = "Modificar Empleado"
        Me.RbModificar.UseVisualStyleBackColor = True
        '
        'RbAlta
        '
        Me.RbAlta.AutoSize = True
        Me.RbAlta.Location = New System.Drawing.Point(18, 33)
        Me.RbAlta.Name = "RbAlta"
        Me.RbAlta.Size = New System.Drawing.Size(93, 17)
        Me.RbAlta.TabIndex = 0
        Me.RbAlta.TabStop = True
        Me.RbAlta.Text = "Alta Empleado"
        Me.RbAlta.UseVisualStyleBackColor = True
        '
        'LbCodEmple
        '
        Me.LbCodEmple.AutoSize = True
        Me.LbCodEmple.Location = New System.Drawing.Point(15, 112)
        Me.LbCodEmple.Name = "LbCodEmple"
        Me.LbCodEmple.Size = New System.Drawing.Size(108, 13)
        Me.LbCodEmple.TabIndex = 1
        Me.LbCodEmple.Text = "Codigo de Empleado:"
        '
        'TbCodEmple
        '
        Me.TbCodEmple.Location = New System.Drawing.Point(148, 109)
        Me.TbCodEmple.MaxLength = 3
        Me.TbCodEmple.Name = "TbCodEmple"
        Me.TbCodEmple.Size = New System.Drawing.Size(103, 20)
        Me.TbCodEmple.TabIndex = 9
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Location = New System.Drawing.Point(312, 109)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(47, 13)
        Me.LbNombre.TabIndex = 3
        Me.LbNombre.Text = "Nombre:"
        '
        'LbApellido1
        '
        Me.LbApellido1.AutoSize = True
        Me.LbApellido1.Location = New System.Drawing.Point(312, 143)
        Me.LbApellido1.Name = "LbApellido1"
        Me.LbApellido1.Size = New System.Drawing.Size(79, 13)
        Me.LbApellido1.TabIndex = 4
        Me.LbApellido1.Text = "Primer Apellido:"
        '
        'LbApellido2
        '
        Me.LbApellido2.AutoSize = True
        Me.LbApellido2.Location = New System.Drawing.Point(312, 176)
        Me.LbApellido2.Name = "LbApellido2"
        Me.LbApellido2.Size = New System.Drawing.Size(93, 13)
        Me.LbApellido2.TabIndex = 5
        Me.LbApellido2.Text = "Segundo Apellido:"
        '
        'LbDni
        '
        Me.LbDni.AutoSize = True
        Me.LbDni.Location = New System.Drawing.Point(312, 210)
        Me.LbDni.Name = "LbDni"
        Me.LbDni.Size = New System.Drawing.Size(29, 13)
        Me.LbDni.TabIndex = 6
        Me.LbDni.Text = "DNI:"
        '
        'LbTelefono
        '
        Me.LbTelefono.AutoSize = True
        Me.LbTelefono.Location = New System.Drawing.Point(312, 244)
        Me.LbTelefono.Name = "LbTelefono"
        Me.LbTelefono.Size = New System.Drawing.Size(52, 13)
        Me.LbTelefono.TabIndex = 7
        Me.LbTelefono.Text = "Telefono:"
        '
        'TbNombre
        '
        Me.TbNombre.Location = New System.Drawing.Point(453, 106)
        Me.TbNombre.MaxLength = 20
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(100, 20)
        Me.TbNombre.TabIndex = 4
        '
        'TbApellido1
        '
        Me.TbApellido1.Location = New System.Drawing.Point(453, 140)
        Me.TbApellido1.MaxLength = 20
        Me.TbApellido1.Name = "TbApellido1"
        Me.TbApellido1.Size = New System.Drawing.Size(100, 20)
        Me.TbApellido1.TabIndex = 5
        '
        'TbApellido2
        '
        Me.TbApellido2.Location = New System.Drawing.Point(453, 173)
        Me.TbApellido2.MaxLength = 20
        Me.TbApellido2.Name = "TbApellido2"
        Me.TbApellido2.Size = New System.Drawing.Size(100, 20)
        Me.TbApellido2.TabIndex = 6
        '
        'TbDni
        '
        Me.TbDni.Location = New System.Drawing.Point(453, 207)
        Me.TbDni.MaxLength = 9
        Me.TbDni.Name = "TbDni"
        Me.TbDni.Size = New System.Drawing.Size(100, 20)
        Me.TbDni.TabIndex = 7
        '
        'TbTelefono
        '
        Me.TbTelefono.Location = New System.Drawing.Point(453, 241)
        Me.TbTelefono.MaxLength = 12
        Me.TbTelefono.Name = "TbTelefono"
        Me.TbTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TbTelefono.TabIndex = 8
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(393, 321)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 12
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'BtSalir
        '
        Me.BtSalir.Location = New System.Drawing.Point(494, 321)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtSalir.TabIndex = 13
        Me.BtSalir.Text = "Salir"
        Me.BtSalir.UseVisualStyleBackColor = True
        '
        'LbNombreUser
        '
        Me.LbNombreUser.AutoSize = True
        Me.LbNombreUser.Location = New System.Drawing.Point(15, 144)
        Me.LbNombreUser.Name = "LbNombreUser"
        Me.LbNombreUser.Size = New System.Drawing.Size(86, 13)
        Me.LbNombreUser.TabIndex = 15
        Me.LbNombreUser.Text = "Nombre Usuario:"
        '
        'LbContraUser
        '
        Me.LbContraUser.AutoSize = True
        Me.LbContraUser.Location = New System.Drawing.Point(15, 179)
        Me.LbContraUser.Name = "LbContraUser"
        Me.LbContraUser.Size = New System.Drawing.Size(103, 13)
        Me.LbContraUser.TabIndex = 16
        Me.LbContraUser.Text = "Contraseña Usuario:"
        '
        'TbNombreUser
        '
        Me.TbNombreUser.Location = New System.Drawing.Point(148, 141)
        Me.TbNombreUser.Name = "TbNombreUser"
        Me.TbNombreUser.Size = New System.Drawing.Size(100, 20)
        Me.TbNombreUser.TabIndex = 10
        '
        'TbContraUser
        '
        Me.TbContraUser.Location = New System.Drawing.Point(148, 176)
        Me.TbContraUser.Name = "TbContraUser"
        Me.TbContraUser.Size = New System.Drawing.Size(100, 20)
        Me.TbContraUser.TabIndex = 11
        '
        'GestionEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 356)
        Me.Controls.Add(Me.TbContraUser)
        Me.Controls.Add(Me.TbNombreUser)
        Me.Controls.Add(Me.LbContraUser)
        Me.Controls.Add(Me.LbNombreUser)
        Me.Controls.Add(Me.BtSalir)
        Me.Controls.Add(Me.BtAceptar)
        Me.Controls.Add(Me.TbTelefono)
        Me.Controls.Add(Me.TbDni)
        Me.Controls.Add(Me.TbApellido2)
        Me.Controls.Add(Me.TbApellido1)
        Me.Controls.Add(Me.TbNombre)
        Me.Controls.Add(Me.LbTelefono)
        Me.Controls.Add(Me.LbDni)
        Me.Controls.Add(Me.LbApellido2)
        Me.Controls.Add(Me.LbApellido1)
        Me.Controls.Add(Me.LbNombre)
        Me.Controls.Add(Me.TbCodEmple)
        Me.Controls.Add(Me.LbCodEmple)
        Me.Controls.Add(Me.GbEmple)
        Me.Name = "GestionEmpleados"
        Me.Text = "GestionEmpleados"
        Me.GbEmple.ResumeLayout(False)
        Me.GbEmple.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GbEmple As System.Windows.Forms.GroupBox
    Friend WithEvents LbCodEmple As System.Windows.Forms.Label
    Friend WithEvents TbCodEmple As System.Windows.Forms.TextBox
    Friend WithEvents LbNombre As System.Windows.Forms.Label
    Friend WithEvents LbApellido1 As System.Windows.Forms.Label
    Friend WithEvents LbApellido2 As System.Windows.Forms.Label
    Friend WithEvents LbDni As System.Windows.Forms.Label
    Friend WithEvents LbTelefono As System.Windows.Forms.Label
    Friend WithEvents TbNombre As System.Windows.Forms.TextBox
    Friend WithEvents TbApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents TbApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents TbDni As System.Windows.Forms.TextBox
    Friend WithEvents TbTelefono As System.Windows.Forms.TextBox
    Friend WithEvents BtAceptar As System.Windows.Forms.Button
    Friend WithEvents BtSalir As System.Windows.Forms.Button
    Friend WithEvents RbBorrar As System.Windows.Forms.RadioButton
    Friend WithEvents RbModificar As System.Windows.Forms.RadioButton
    Friend WithEvents RbAlta As System.Windows.Forms.RadioButton
    Friend WithEvents LbNombreUser As System.Windows.Forms.Label
    Friend WithEvents LbContraUser As System.Windows.Forms.Label
    Friend WithEvents TbNombreUser As System.Windows.Forms.TextBox
    Friend WithEvents TbContraUser As System.Windows.Forms.TextBox
End Class
