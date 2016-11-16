<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.LBNomUser = New System.Windows.Forms.Label()
        Me.LBContraUser = New System.Windows.Forms.Label()
        Me.TBNomUser = New System.Windows.Forms.TextBox()
        Me.TBContraUser = New System.Windows.Forms.TextBox()
        Me.BTEntrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBNomUser
        '
        Me.LBNomUser.AutoSize = True
        Me.LBNomUser.Location = New System.Drawing.Point(30, 33)
        Me.LBNomUser.Name = "LBNomUser"
        Me.LBNomUser.Size = New System.Drawing.Size(72, 13)
        Me.LBNomUser.TabIndex = 0
        Me.LBNomUser.Text = "Nombre User:"
        '
        'LBContraUser
        '
        Me.LBContraUser.AutoSize = True
        Me.LBContraUser.Location = New System.Drawing.Point(33, 67)
        Me.LBContraUser.Name = "LBContraUser"
        Me.LBContraUser.Size = New System.Drawing.Size(64, 13)
        Me.LBContraUser.TabIndex = 1
        Me.LBContraUser.Text = "Contraseña:"
        '
        'TBNomUser
        '
        Me.TBNomUser.Location = New System.Drawing.Point(165, 33)
        Me.TBNomUser.Name = "TBNomUser"
        Me.TBNomUser.Size = New System.Drawing.Size(100, 20)
        Me.TBNomUser.TabIndex = 2
        '
        'TBContraUser
        '
        Me.TBContraUser.Location = New System.Drawing.Point(165, 67)
        Me.TBContraUser.Name = "TBContraUser"
        Me.TBContraUser.Size = New System.Drawing.Size(100, 20)
        Me.TBContraUser.TabIndex = 3
        '
        'BTEntrar
        '
        Me.BTEntrar.Location = New System.Drawing.Point(263, 135)
        Me.BTEntrar.Name = "BTEntrar"
        Me.BTEntrar.Size = New System.Drawing.Size(75, 23)
        Me.BTEntrar.TabIndex = 4
        Me.BTEntrar.Text = "Entrar"
        Me.BTEntrar.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 170)
        Me.Controls.Add(Me.BTEntrar)
        Me.Controls.Add(Me.TBContraUser)
        Me.Controls.Add(Me.TBNomUser)
        Me.Controls.Add(Me.LBContraUser)
        Me.Controls.Add(Me.LBNomUser)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBNomUser As System.Windows.Forms.Label
    Friend WithEvents LBContraUser As System.Windows.Forms.Label
    Friend WithEvents TBNomUser As System.Windows.Forms.TextBox
    Friend WithEvents TBContraUser As System.Windows.Forms.TextBox
    Friend WithEvents BTEntrar As System.Windows.Forms.Button
End Class
