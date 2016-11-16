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
        Me.CbAlta = New System.Windows.Forms.CheckBox()
        Me.CbModificar = New System.Windows.Forms.CheckBox()
        Me.CbBorrar = New System.Windows.Forms.CheckBox()
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
        Me.GbEmple.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbEmple
        '
        Me.GbEmple.Controls.Add(Me.CbBorrar)
        Me.GbEmple.Controls.Add(Me.CbModificar)
        Me.GbEmple.Controls.Add(Me.CbAlta)
        Me.GbEmple.Location = New System.Drawing.Point(12, 26)
        Me.GbEmple.Name = "GbEmple"
        Me.GbEmple.Size = New System.Drawing.Size(123, 129)
        Me.GbEmple.TabIndex = 0
        Me.GbEmple.TabStop = False
        Me.GbEmple.Text = "¿Qué desea hacer?"
        '
        'CbAlta
        '
        Me.CbAlta.AutoSize = True
        Me.CbAlta.Location = New System.Drawing.Point(7, 30)
        Me.CbAlta.Name = "CbAlta"
        Me.CbAlta.Size = New System.Drawing.Size(44, 17)
        Me.CbAlta.TabIndex = 0
        Me.CbAlta.Text = "Alta"
        Me.CbAlta.UseVisualStyleBackColor = True
        '
        'CbModificar
        '
        Me.CbModificar.AutoSize = True
        Me.CbModificar.Location = New System.Drawing.Point(7, 56)
        Me.CbModificar.Name = "CbModificar"
        Me.CbModificar.Size = New System.Drawing.Size(69, 17)
        Me.CbModificar.TabIndex = 1
        Me.CbModificar.Text = "Modificar"
        Me.CbModificar.UseVisualStyleBackColor = True
        '
        'CbBorrar
        '
        Me.CbBorrar.AutoSize = True
        Me.CbBorrar.Location = New System.Drawing.Point(7, 83)
        Me.CbBorrar.Name = "CbBorrar"
        Me.CbBorrar.Size = New System.Drawing.Size(54, 17)
        Me.CbBorrar.TabIndex = 2
        Me.CbBorrar.Text = "Borrar"
        Me.CbBorrar.UseVisualStyleBackColor = True
        '
        'LbCodEmple
        '
        Me.LbCodEmple.AutoSize = True
        Me.LbCodEmple.Location = New System.Drawing.Point(206, 42)
        Me.LbCodEmple.Name = "LbCodEmple"
        Me.LbCodEmple.Size = New System.Drawing.Size(108, 13)
        Me.LbCodEmple.TabIndex = 1
        Me.LbCodEmple.Text = "Codigo de Empleado:"
        '
        'TbCodEmple
        '
        Me.TbCodEmple.Location = New System.Drawing.Point(347, 35)
        Me.TbCodEmple.Name = "TbCodEmple"
        Me.TbCodEmple.Size = New System.Drawing.Size(103, 20)
        Me.TbCodEmple.TabIndex = 2
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Location = New System.Drawing.Point(206, 72)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(47, 13)
        Me.LbNombre.TabIndex = 3
        Me.LbNombre.Text = "Nombre:"
        '
        'LbApellido1
        '
        Me.LbApellido1.AutoSize = True
        Me.LbApellido1.Location = New System.Drawing.Point(206, 102)
        Me.LbApellido1.Name = "LbApellido1"
        Me.LbApellido1.Size = New System.Drawing.Size(79, 13)
        Me.LbApellido1.TabIndex = 4
        Me.LbApellido1.Text = "Primer Apellido:"
        '
        'LbApellido2
        '
        Me.LbApellido2.AutoSize = True
        Me.LbApellido2.Location = New System.Drawing.Point(206, 136)
        Me.LbApellido2.Name = "LbApellido2"
        Me.LbApellido2.Size = New System.Drawing.Size(93, 13)
        Me.LbApellido2.TabIndex = 5
        Me.LbApellido2.Text = "Segundo Apellido:"
        '
        'LbDni
        '
        Me.LbDni.AutoSize = True
        Me.LbDni.Location = New System.Drawing.Point(206, 169)
        Me.LbDni.Name = "LbDni"
        Me.LbDni.Size = New System.Drawing.Size(29, 13)
        Me.LbDni.TabIndex = 6
        Me.LbDni.Text = "DNI:"
        '
        'LbTelefono
        '
        Me.LbTelefono.AutoSize = True
        Me.LbTelefono.Location = New System.Drawing.Point(206, 202)
        Me.LbTelefono.Name = "LbTelefono"
        Me.LbTelefono.Size = New System.Drawing.Size(52, 13)
        Me.LbTelefono.TabIndex = 7
        Me.LbTelefono.Text = "Telefono:"
        '
        'TbNombre
        '
        Me.TbNombre.Location = New System.Drawing.Point(347, 65)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(100, 20)
        Me.TbNombre.TabIndex = 8
        '
        'TbApellido1
        '
        Me.TbApellido1.Location = New System.Drawing.Point(347, 95)
        Me.TbApellido1.Name = "TbApellido1"
        Me.TbApellido1.Size = New System.Drawing.Size(100, 20)
        Me.TbApellido1.TabIndex = 9
        '
        'TbApellido2
        '
        Me.TbApellido2.Location = New System.Drawing.Point(347, 128)
        Me.TbApellido2.Name = "TbApellido2"
        Me.TbApellido2.Size = New System.Drawing.Size(100, 20)
        Me.TbApellido2.TabIndex = 10
        '
        'TbDni
        '
        Me.TbDni.Location = New System.Drawing.Point(347, 161)
        Me.TbDni.Name = "TbDni"
        Me.TbDni.Size = New System.Drawing.Size(100, 20)
        Me.TbDni.TabIndex = 11
        '
        'TbTelefono
        '
        Me.TbTelefono.Location = New System.Drawing.Point(347, 194)
        Me.TbTelefono.Name = "TbTelefono"
        Me.TbTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TbTelefono.TabIndex = 12
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(322, 271)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 13
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'BtSalir
        '
        Me.BtSalir.Location = New System.Drawing.Point(423, 271)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtSalir.TabIndex = 14
        Me.BtSalir.Text = "Salir"
        Me.BtSalir.UseVisualStyleBackColor = True
        '
        'GestionEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 325)
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
    Friend WithEvents CbBorrar As System.Windows.Forms.CheckBox
    Friend WithEvents CbModificar As System.Windows.Forms.CheckBox
    Friend WithEvents CbAlta As System.Windows.Forms.CheckBox
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
End Class
