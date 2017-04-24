<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vender
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
        Dim lstCod As System.Windows.Forms.ColumnHeader
        Dim lstDes As System.Windows.Forms.ColumnHeader
        Dim lstPrice As System.Windows.Forms.ColumnHeader
        Dim lstCant As System.Windows.Forms.ColumnHeader
        Dim lstTot As System.Windows.Forms.ColumnHeader
        Dim lstStock As System.Windows.Forms.ColumnHeader
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.btnShell = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.listBuy_1 = New System.Windows.Forms.ListView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tcTickets = New System.Windows.Forms.TabControl()
        Me.tpTicket_1 = New System.Windows.Forms.TabPage()
        Me.btnNewTicket = New System.Windows.Forms.Button()
        lstCod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        lstDes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        lstPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        lstCant = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        lstTot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        lstStock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.tcTickets.SuspendLayout()
        Me.tpTicket_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstCod
        '
        lstCod.Text = "Código"
        lstCod.Width = 100
        '
        'lstDes
        '
        lstDes.Text = "Descripción"
        lstDes.Width = 200
        '
        'lstPrice
        '
        lstPrice.Text = "Costo"
        lstPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        lstPrice.Width = 70
        '
        'lstCant
        '
        lstCant.Text = "Cantidad"
        lstCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        lstCant.Width = 70
        '
        'lstTot
        '
        lstTot.Text = "Total"
        lstTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        lstTot.Width = 80
        '
        'lstStock
        '
        lstStock.Text = "Existencia"
        lstStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        lstStock.Width = 80
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 56)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(325, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Caja"
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Location = New System.Drawing.Point(12, 65)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(106, 16)
        Me.lblCod.TabIndex = 1
        Me.lblCod.Text = "Código de barras"
        '
        'txtCod
        '
        Me.txtCod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCod.Location = New System.Drawing.Point(124, 62)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(235, 22)
        Me.txtCod.TabIndex = 2
        '
        'btnShell
        '
        Me.btnShell.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShell.Location = New System.Drawing.Point(445, 61)
        Me.btnShell.Name = "btnShell"
        Me.btnShell.Size = New System.Drawing.Size(75, 23)
        Me.btnShell.TabIndex = 3
        Me.btnShell.Text = "Buscar"
        Me.btnShell.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(364, 61)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'listBuy_1
        '
        Me.listBuy_1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {lstCod, lstDes, lstPrice, lstCant, lstTot, lstStock})
        Me.listBuy_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listBuy_1.FullRowSelect = True
        Me.listBuy_1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listBuy_1.LabelWrap = False
        Me.listBuy_1.Location = New System.Drawing.Point(3, 3)
        Me.listBuy_1.MultiSelect = False
        Me.listBuy_1.Name = "listBuy_1"
        Me.listBuy_1.Size = New System.Drawing.Size(646, 252)
        Me.listBuy_1.TabIndex = 4
        Me.listBuy_1.UseCompatibleStateImageBehavior = False
        Me.listBuy_1.View = System.Windows.Forms.View.Details
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 383)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(684, 78)
        Me.Panel2.TabIndex = 5
        '
        'tcTickets
        '
        Me.tcTickets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcTickets.Controls.Add(Me.tpTicket_1)
        Me.tcTickets.Location = New System.Drawing.Point(12, 90)
        Me.tcTickets.Name = "tcTickets"
        Me.tcTickets.SelectedIndex = 0
        Me.tcTickets.Size = New System.Drawing.Size(660, 287)
        Me.tcTickets.TabIndex = 0
        '
        'tpTicket_1
        '
        Me.tpTicket_1.Controls.Add(Me.listBuy_1)
        Me.tpTicket_1.Location = New System.Drawing.Point(4, 25)
        Me.tpTicket_1.Name = "tpTicket_1"
        Me.tpTicket_1.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTicket_1.Size = New System.Drawing.Size(652, 258)
        Me.tpTicket_1.TabIndex = 0
        Me.tpTicket_1.Text = "Ticket #1"
        Me.tpTicket_1.UseVisualStyleBackColor = True
        '
        'btnNewTicket
        '
        Me.btnNewTicket.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewTicket.Location = New System.Drawing.Point(560, 61)
        Me.btnNewTicket.Name = "btnNewTicket"
        Me.btnNewTicket.Size = New System.Drawing.Size(112, 23)
        Me.btnNewTicket.TabIndex = 6
        Me.btnNewTicket.Text = "Nuevo Ticket"
        Me.btnNewTicket.UseVisualStyleBackColor = True
        '
        'Vender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.btnNewTicket)
        Me.Controls.Add(Me.tcTickets)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnShell)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(700, 500)
        Me.Name = "Vender"
        Me.Text = "Vender"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tcTickets.ResumeLayout(False)
        Me.tpTicket_1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents btnShell As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents listBuy_1 As System.Windows.Forms.ListView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tcTickets As System.Windows.Forms.TabControl
    Friend WithEvents tpTicket_1 As System.Windows.Forms.TabPage
    Friend WithEvents btnNewTicket As System.Windows.Forms.Button
End Class
