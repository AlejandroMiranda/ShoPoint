<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.dgvInf = New System.Windows.Forms.DataGridView()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.gbSetShell = New System.Windows.Forms.GroupBox()
        Me.rbtnKeyWords = New System.Windows.Forms.RadioButton()
        Me.rbtnName = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.dgvInf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSetShell.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Articulo"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(12, 41)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(360, 22)
        Me.txtDesc.TabIndex = 1
        '
        'dgvInf
        '
        Me.dgvInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInf.Location = New System.Drawing.Point(12, 69)
        Me.dgvInf.Name = "dgvInf"
        Me.dgvInf.Size = New System.Drawing.Size(360, 315)
        Me.dgvInf.TabIndex = 2
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(216, 8)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Aceptar"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'gbSetShell
        '
        Me.gbSetShell.Controls.Add(Me.rbtnKeyWords)
        Me.gbSetShell.Controls.Add(Me.rbtnName)
        Me.gbSetShell.Location = New System.Drawing.Point(12, 390)
        Me.gbSetShell.Name = "gbSetShell"
        Me.gbSetShell.Size = New System.Drawing.Size(360, 59)
        Me.gbSetShell.TabIndex = 4
        Me.gbSetShell.TabStop = False
        Me.gbSetShell.Text = "Buscar por..."
        '
        'rbtnKeyWords
        '
        Me.rbtnKeyWords.AutoSize = True
        Me.rbtnKeyWords.Location = New System.Drawing.Point(193, 19)
        Me.rbtnKeyWords.Name = "rbtnKeyWords"
        Me.rbtnKeyWords.Size = New System.Drawing.Size(112, 20)
        Me.rbtnKeyWords.TabIndex = 0
        Me.rbtnKeyWords.TabStop = True
        Me.rbtnKeyWords.Text = "Palabras Clave"
        Me.rbtnKeyWords.UseVisualStyleBackColor = True
        '
        'rbtnName
        '
        Me.rbtnName.AutoSize = True
        Me.rbtnName.Location = New System.Drawing.Point(41, 19)
        Me.rbtnName.Name = "rbtnName"
        Me.rbtnName.Size = New System.Drawing.Size(71, 20)
        Me.rbtnName.TabIndex = 0
        Me.rbtnName.TabStop = True
        Me.rbtnName.Text = "Nombre"
        Me.rbtnName.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(297, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Buscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 461)
        Me.Controls.Add(Me.gbSetShell)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.dgvInf)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Buscar"
        Me.Text = "Buscar"
        CType(Me.dgvInf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSetShell.ResumeLayout(False)
        Me.gbSetShell.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents dgvInf As System.Windows.Forms.DataGridView
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents gbSetShell As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnKeyWords As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnName As System.Windows.Forms.RadioButton
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
