<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogTempUser
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
        Me.lblMsgAcceso = New System.Windows.Forms.Label()
        Me.txtUser = New Placeholder.PlaceholderTextBox()
        Me.txtPass = New Placeholder.PlaceholderTextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.checkVPass = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblMsgAcceso
        '
        Me.lblMsgAcceso.AutoEllipsis = True
        Me.lblMsgAcceso.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMsgAcceso.ForeColor = System.Drawing.Color.Red
        Me.lblMsgAcceso.Location = New System.Drawing.Point(0, 0)
        Me.lblMsgAcceso.Name = "lblMsgAcceso"
        Me.lblMsgAcceso.Size = New System.Drawing.Size(384, 44)
        Me.lblMsgAcceso.TabIndex = 0
        Me.lblMsgAcceso.Text = "MsgAcceso"
        '
        'txtUser
        '
        Me.txtUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtUser.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(0, 44)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PlaceholderText = "Usuario (con autorización)"
        Me.txtUser.Size = New System.Drawing.Size(384, 22)
        Me.txtUser.TabIndex = 1
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(0, 78)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PlaceholderText = "Contraseña"
        Me.txtPass.Size = New System.Drawing.Size(303, 22)
        Me.txtPass.TabIndex = 2
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnOk
        '
        Me.btnOk.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOk.Location = New System.Drawing.Point(309, 66)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 67)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Autorizar"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'checkVPass
        '
        Me.checkVPass.AutoSize = True
        Me.checkVPass.Location = New System.Drawing.Point(12, 106)
        Me.checkVPass.Name = "checkVPass"
        Me.checkVPass.Size = New System.Drawing.Size(132, 20)
        Me.checkVPass.TabIndex = 4
        Me.checkVPass.Text = "Motrar contraseña"
        Me.checkVPass.UseVisualStyleBackColor = True
        '
        'LogTempUser
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 133)
        Me.Controls.Add(Me.checkVPass)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblMsgAcceso)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "LogTempUser"
        Me.Text = "LogTempUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMsgAcceso As System.Windows.Forms.Label
    Friend WithEvents txtUser As Placeholder.PlaceholderTextBox
    Friend WithEvents txtPass As Placeholder.PlaceholderTextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents checkVPass As System.Windows.Forms.CheckBox
End Class
