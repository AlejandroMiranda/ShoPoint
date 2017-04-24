<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acceso
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.chkvPass = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtUser = New Placeholder.PlaceholderTextBox()
        Me.txtPass = New Placeholder.PlaceholderTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(233, 79)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(87, 28)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "Ingresar"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'chkvPass
        '
        Me.chkvPass.AutoSize = True
        Me.chkvPass.Location = New System.Drawing.Point(14, 86)
        Me.chkvPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkvPass.Name = "chkvPass"
        Me.chkvPass.Size = New System.Drawing.Size(139, 20)
        Me.chkvPass.TabIndex = 2
        Me.chkvPass.Text = "Mostrar contraseña"
        Me.chkvPass.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(88, 17)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PlaceholderText = "Usuario"
        Me.txtUser.Size = New System.Drawing.Size(232, 22)
        Me.txtUser.TabIndex = 4
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(88, 50)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PlaceholderText = "Contraseña"
        Me.txtPass.Size = New System.Drawing.Size(232, 22)
        Me.txtPass.TabIndex = 5
        '
        'Acceso
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 121)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chkvPass)
        Me.Controls.Add(Me.btnOK)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Acceso"
        Me.Text = "Acceso"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents chkvPass As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtUser As Placeholder.PlaceholderTextBox
    Friend WithEvents txtPass As Placeholder.PlaceholderTextBox
End Class
