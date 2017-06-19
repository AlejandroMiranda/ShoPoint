<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home

    'Inherits System.Windows.Forms.Form
    Inherits DevComponents.DotNetBar.Office2007RibbonForm

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
        Me.components = New System.ComponentModel.Container()
        Me.ribCont = New DevComponents.DotNetBar.RibbonControl()
        Me.RibbonPanel3 = New DevComponents.DotNetBar.RibbonPanel()
        Me.rBarMerma = New DevComponents.DotNetBar.RibbonBar()
        Me.btnItMerma = New DevComponents.DotNetBar.ButtonItem()
        Me.rBarAdmArt = New DevComponents.DotNetBar.RibbonBar()
        Me.btnItAddProd = New DevComponents.DotNetBar.ButtonItem()
        Me.btnItInvProd = New DevComponents.DotNetBar.ButtonItem()
        Me.btnItPreProd = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel1 = New DevComponents.DotNetBar.RibbonPanel()
        Me.rBarCaja = New DevComponents.DotNetBar.RibbonBar()
        Me.btnItIngresarCaj = New DevComponents.DotNetBar.ButtonItem()
        Me.btnItExtraerCaj = New DevComponents.DotNetBar.ButtonItem()
        Me.rBarSesion = New DevComponents.DotNetBar.RibbonBar()
        Me.btnItLog = New DevComponents.DotNetBar.ButtonItem()
        Me.btnItSwitch = New DevComponents.DotNetBar.ButtonItem()
        Me.rBarVender = New DevComponents.DotNetBar.RibbonBar()
        Me.btnItVender = New DevComponents.DotNetBar.ButtonItem()
        Me.btnItDevProd = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel4 = New DevComponents.DotNetBar.RibbonPanel()
        Me.rBarRepProd = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem20 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem21 = New DevComponents.DotNetBar.ButtonItem()
        Me.rBarRepVentas = New DevComponents.DotNetBar.RibbonBar()
        Me.btnItVentas = New DevComponents.DotNetBar.ButtonItem()
        Me.btnItDevolucion = New DevComponents.DotNetBar.ButtonItem()
        Me.btnItFacturas = New DevComponents.DotNetBar.ButtonItem()
        Me.rBarRepCaja = New DevComponents.DotNetBar.RibbonBar()
        Me.btnItSaldoAct = New DevComponents.DotNetBar.ButtonItem()
        Me.btnItCorte = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel5 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonPanel2 = New DevComponents.DotNetBar.RibbonPanel()
        Me.rBarProvedores = New DevComponents.DotNetBar.RibbonBar()
        Me.btnAddPro = New DevComponents.DotNetBar.ButtonItem()
        Me.btnItInformacion = New DevComponents.DotNetBar.ButtonItem()
        Me.rBarClientes = New DevComponents.DotNetBar.RibbonBar()
        Me.btnItAddCliente = New DevComponents.DotNetBar.ButtonItem()
        Me.btnItSalCliente = New DevComponents.DotNetBar.ButtonItem()
        Me.btnItComCliente = New DevComponents.DotNetBar.ButtonItem()
        Me.btnItAbCliente = New DevComponents.DotNetBar.ButtonItem()
        Me.rBarUsuarios = New DevComponents.DotNetBar.RibbonBar()
        Me.btnItAdUs = New DevComponents.DotNetBar.ButtonItem()
        Me.btnItPermisos = New DevComponents.DotNetBar.ButtonItem()
        Me.ribTabPrincipal = New DevComponents.DotNetBar.RibbonTabItem()
        Me.ribTabReg = New DevComponents.DotNetBar.RibbonTabItem()
        Me.ribTabProd = New DevComponents.DotNetBar.RibbonTabItem()
        Me.ribTabReportes = New DevComponents.DotNetBar.RibbonTabItem()
        Me.ribTabOpc = New DevComponents.DotNetBar.RibbonTabItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.lblUserName = New DevComponents.DotNetBar.LabelItem()
        Me.ribCont.SuspendLayout()
        Me.RibbonPanel3.SuspendLayout()
        Me.RibbonPanel1.SuspendLayout()
        Me.RibbonPanel4.SuspendLayout()
        Me.RibbonPanel2.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribCont
        '
        '
        '
        '
        Me.ribCont.BackgroundStyle.Class = ""
        Me.ribCont.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribCont.CaptionVisible = True
        Me.ribCont.Controls.Add(Me.RibbonPanel1)
        Me.ribCont.Controls.Add(Me.RibbonPanel3)
        Me.ribCont.Controls.Add(Me.RibbonPanel4)
        Me.ribCont.Controls.Add(Me.RibbonPanel5)
        Me.ribCont.Controls.Add(Me.RibbonPanel2)
        Me.ribCont.Dock = System.Windows.Forms.DockStyle.Top
        Me.ribCont.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ribTabPrincipal, Me.ribTabReg, Me.ribTabProd, Me.ribTabReportes, Me.ribTabOpc})
        Me.ribCont.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.ribCont.Location = New System.Drawing.Point(5, 1)
        Me.ribCont.Name = "ribCont"
        Me.ribCont.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.ribCont.Size = New System.Drawing.Size(774, 111)
        Me.ribCont.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribCont.TabGroupHeight = 14
        Me.ribCont.TabIndex = 1
        Me.ribCont.Text = "RibbonControl1"
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel3.Controls.Add(Me.rBarMerma)
        Me.RibbonPanel3.Controls.Add(Me.rBarAdmArt)
        Me.RibbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel3.Location = New System.Drawing.Point(0, 51)
        Me.RibbonPanel3.Name = "RibbonPanel3"
        Me.RibbonPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel3.Size = New System.Drawing.Size(774, 58)
        '
        '
        '
        Me.RibbonPanel3.Style.Class = ""
        Me.RibbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel3.StyleMouseDown.Class = ""
        Me.RibbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel3.StyleMouseOver.Class = ""
        Me.RibbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel3.TabIndex = 3
        Me.RibbonPanel3.Visible = False
        '
        'rBarMerma
        '
        Me.rBarMerma.AutoOverflowEnabled = True
        '
        '
        '
        Me.rBarMerma.BackgroundMouseOverStyle.Class = ""
        Me.rBarMerma.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarMerma.BackgroundStyle.Class = ""
        Me.rBarMerma.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rBarMerma.ContainerControlProcessDialogKey = True
        Me.rBarMerma.Dock = System.Windows.Forms.DockStyle.Left
        Me.rBarMerma.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnItMerma})
        Me.rBarMerma.Location = New System.Drawing.Point(160, 0)
        Me.rBarMerma.Name = "rBarMerma"
        Me.rBarMerma.Size = New System.Drawing.Size(104, 55)
        Me.rBarMerma.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rBarMerma.TabIndex = 1
        Me.rBarMerma.Text = "Salidas"
        '
        '
        '
        Me.rBarMerma.TitleStyle.Class = ""
        Me.rBarMerma.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarMerma.TitleStyleMouseOver.Class = ""
        Me.rBarMerma.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnItMerma
        '
        Me.btnItMerma.Name = "btnItMerma"
        Me.btnItMerma.SubItemsExpandWidth = 14
        Me.btnItMerma.Text = "&Mermas"
        Me.btnItMerma.Tooltip = "Ver o ingresar merma de producto"
        '
        'rBarAdmArt
        '
        Me.rBarAdmArt.AutoOverflowEnabled = True
        '
        '
        '
        Me.rBarAdmArt.BackgroundMouseOverStyle.Class = ""
        Me.rBarAdmArt.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarAdmArt.BackgroundStyle.Class = ""
        Me.rBarAdmArt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rBarAdmArt.ContainerControlProcessDialogKey = True
        Me.rBarAdmArt.Dock = System.Windows.Forms.DockStyle.Left
        Me.rBarAdmArt.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnItAddProd, Me.btnItInvProd, Me.btnItPreProd})
        Me.rBarAdmArt.Location = New System.Drawing.Point(3, 0)
        Me.rBarAdmArt.Name = "rBarAdmArt"
        Me.rBarAdmArt.Size = New System.Drawing.Size(157, 55)
        Me.rBarAdmArt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rBarAdmArt.TabIndex = 0
        Me.rBarAdmArt.Text = "Administrar"
        '
        '
        '
        Me.rBarAdmArt.TitleStyle.Class = ""
        Me.rBarAdmArt.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarAdmArt.TitleStyleMouseOver.Class = ""
        Me.rBarAdmArt.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnItAddProd
        '
        Me.btnItAddProd.Name = "btnItAddProd"
        Me.btnItAddProd.SubItemsExpandWidth = 14
        Me.btnItAddProd.Text = "&Agregar"
        Me.btnItAddProd.Tooltip = "Agregar o modificar"
        '
        'btnItInvProd
        '
        Me.btnItInvProd.Name = "btnItInvProd"
        Me.btnItInvProd.SubItemsExpandWidth = 14
        Me.btnItInvProd.Text = "Inventario"
        Me.btnItInvProd.Tooltip = "Ver o modificar inventario"
        '
        'btnItPreProd
        '
        Me.btnItPreProd.Name = "btnItPreProd"
        Me.btnItPreProd.SubItemsExpandWidth = 14
        Me.btnItPreProd.Text = "&Precios"
        Me.btnItPreProd.Tooltip = "Modificar precios por departamento"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel1.Controls.Add(Me.rBarCaja)
        Me.RibbonPanel1.Controls.Add(Me.rBarSesion)
        Me.RibbonPanel1.Controls.Add(Me.rBarVender)
        Me.RibbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel1.Location = New System.Drawing.Point(0, 51)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel1.Size = New System.Drawing.Size(774, 58)
        '
        '
        '
        Me.RibbonPanel1.Style.Class = ""
        Me.RibbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel1.StyleMouseDown.Class = ""
        Me.RibbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel1.StyleMouseOver.Class = ""
        Me.RibbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel1.TabIndex = 1
        '
        'rBarCaja
        '
        Me.rBarCaja.AutoOverflowEnabled = True
        '
        '
        '
        Me.rBarCaja.BackgroundMouseOverStyle.Class = ""
        Me.rBarCaja.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarCaja.BackgroundStyle.Class = ""
        Me.rBarCaja.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rBarCaja.ContainerControlProcessDialogKey = True
        Me.rBarCaja.Dock = System.Windows.Forms.DockStyle.Left
        Me.rBarCaja.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnItIngresarCaj, Me.btnItExtraerCaj})
        Me.rBarCaja.Location = New System.Drawing.Point(251, 0)
        Me.rBarCaja.Name = "rBarCaja"
        Me.rBarCaja.Size = New System.Drawing.Size(107, 55)
        Me.rBarCaja.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rBarCaja.TabIndex = 2
        Me.rBarCaja.Text = "Caja"
        '
        '
        '
        Me.rBarCaja.TitleStyle.Class = ""
        Me.rBarCaja.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarCaja.TitleStyleMouseOver.Class = ""
        Me.rBarCaja.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnItIngresarCaj
        '
        Me.btnItIngresarCaj.Name = "btnItIngresarCaj"
        Me.btnItIngresarCaj.SubItemsExpandWidth = 14
        Me.btnItIngresarCaj.Text = "&Ingresar"
        Me.btnItIngresarCaj.Tooltip = "Registrar ingreso de dinero"
        '
        'btnItExtraerCaj
        '
        Me.btnItExtraerCaj.Name = "btnItExtraerCaj"
        Me.btnItExtraerCaj.SubItemsExpandWidth = 14
        Me.btnItExtraerCaj.Text = "&Extraer"
        Me.btnItExtraerCaj.Tooltip = "Registrar extracción de dinero"
        '
        'rBarSesion
        '
        Me.rBarSesion.AutoOverflowEnabled = True
        '
        '
        '
        Me.rBarSesion.BackgroundMouseOverStyle.Class = ""
        Me.rBarSesion.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarSesion.BackgroundStyle.Class = ""
        Me.rBarSesion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rBarSesion.ContainerControlProcessDialogKey = True
        Me.rBarSesion.Dock = System.Windows.Forms.DockStyle.Left
        Me.rBarSesion.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnItLog, Me.btnItSwitch})
        Me.rBarSesion.Location = New System.Drawing.Point(154, 0)
        Me.rBarSesion.Name = "rBarSesion"
        Me.rBarSesion.Size = New System.Drawing.Size(97, 55)
        Me.rBarSesion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rBarSesion.TabIndex = 1
        Me.rBarSesion.Text = "&Sesion"
        '
        '
        '
        Me.rBarSesion.TitleStyle.Class = ""
        Me.rBarSesion.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarSesion.TitleStyleMouseOver.Class = ""
        Me.rBarSesion.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnItLog
        '
        Me.btnItLog.Name = "btnItLog"
        Me.btnItLog.SubItemsExpandWidth = 14
        Me.btnItLog.Text = "&Iniciar"
        Me.btnItLog.Tooltip = "Iniciar Sesión"
        '
        'btnItSwitch
        '
        Me.btnItSwitch.Name = "btnItSwitch"
        Me.btnItSwitch.SubItemsExpandWidth = 14
        Me.btnItSwitch.Text = "&Cambiar"
        Me.btnItSwitch.Tooltip = "Cambiar usuario"
        '
        'rBarVender
        '
        Me.rBarVender.AutoOverflowEnabled = True
        '
        '
        '
        Me.rBarVender.BackgroundMouseOverStyle.Class = ""
        Me.rBarVender.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarVender.BackgroundStyle.Class = ""
        Me.rBarVender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rBarVender.ContainerControlProcessDialogKey = True
        Me.rBarVender.Dock = System.Windows.Forms.DockStyle.Left
        Me.rBarVender.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnItVender, Me.btnItDevProd})
        Me.rBarVender.Location = New System.Drawing.Point(3, 0)
        Me.rBarVender.Name = "rBarVender"
        Me.rBarVender.Size = New System.Drawing.Size(151, 55)
        Me.rBarVender.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rBarVender.TabIndex = 0
        Me.rBarVender.Text = "&Vender"
        '
        '
        '
        Me.rBarVender.TitleStyle.Class = ""
        Me.rBarVender.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarVender.TitleStyleMouseOver.Class = ""
        Me.rBarVender.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnItVender
        '
        Me.btnItVender.Image = Global.ShoPoint.My.Resources.Resources.Abarrotes_WinPoint
        Me.btnItVender.ImageFixedSize = New System.Drawing.Size(50, 30)
        Me.btnItVender.Name = "btnItVender"
        Me.btnItVender.SubItemsExpandWidth = 14
        Me.btnItVender.Text = "&Vender"
        Me.btnItVender.Tooltip = "Abrir área de venta"
        '
        'btnItDevProd
        '
        Me.btnItDevProd.Name = "btnItDevProd"
        Me.btnItDevProd.SubItemsExpandWidth = 14
        Me.btnItDevProd.Text = "&Devolución" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RibbonPanel4
        '
        Me.RibbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel4.Controls.Add(Me.rBarRepProd)
        Me.RibbonPanel4.Controls.Add(Me.rBarRepVentas)
        Me.RibbonPanel4.Controls.Add(Me.rBarRepCaja)
        Me.RibbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel4.Location = New System.Drawing.Point(0, 51)
        Me.RibbonPanel4.Name = "RibbonPanel4"
        Me.RibbonPanel4.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel4.Size = New System.Drawing.Size(774, 58)
        '
        '
        '
        Me.RibbonPanel4.Style.Class = ""
        Me.RibbonPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel4.StyleMouseDown.Class = ""
        Me.RibbonPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel4.StyleMouseOver.Class = ""
        Me.RibbonPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel4.TabIndex = 4
        Me.RibbonPanel4.Visible = False
        '
        'rBarRepProd
        '
        Me.rBarRepProd.AutoOverflowEnabled = True
        '
        '
        '
        Me.rBarRepProd.BackgroundMouseOverStyle.Class = ""
        Me.rBarRepProd.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarRepProd.BackgroundStyle.Class = ""
        Me.rBarRepProd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rBarRepProd.ContainerControlProcessDialogKey = True
        Me.rBarRepProd.Dock = System.Windows.Forms.DockStyle.Left
        Me.rBarRepProd.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem20, Me.ButtonItem21})
        Me.rBarRepProd.Location = New System.Drawing.Point(290, 0)
        Me.rBarRepProd.Name = "rBarRepProd"
        Me.rBarRepProd.Size = New System.Drawing.Size(147, 55)
        Me.rBarRepProd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rBarRepProd.TabIndex = 2
        Me.rBarRepProd.Text = "Productos"
        '
        '
        '
        Me.rBarRepProd.TitleStyle.Class = ""
        Me.rBarRepProd.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarRepProd.TitleStyleMouseOver.Class = ""
        Me.rBarRepProd.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem20
        '
        Me.ButtonItem20.Name = "ButtonItem20"
        Me.ButtonItem20.SubItemsExpandWidth = 14
        Me.ButtonItem20.Text = "ButtonItem20"
        '
        'ButtonItem21
        '
        Me.ButtonItem21.Name = "ButtonItem21"
        Me.ButtonItem21.SubItemsExpandWidth = 14
        Me.ButtonItem21.Text = "ButtonItem21"
        '
        'rBarRepVentas
        '
        Me.rBarRepVentas.AutoOverflowEnabled = True
        '
        '
        '
        Me.rBarRepVentas.BackgroundMouseOverStyle.Class = ""
        Me.rBarRepVentas.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarRepVentas.BackgroundStyle.Class = ""
        Me.rBarRepVentas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rBarRepVentas.ContainerControlProcessDialogKey = True
        Me.rBarRepVentas.Dock = System.Windows.Forms.DockStyle.Left
        Me.rBarRepVentas.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnItVentas, Me.btnItDevolucion, Me.btnItFacturas})
        Me.rBarRepVentas.Location = New System.Drawing.Point(121, 0)
        Me.rBarRepVentas.Name = "rBarRepVentas"
        Me.rBarRepVentas.Size = New System.Drawing.Size(169, 55)
        Me.rBarRepVentas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rBarRepVentas.TabIndex = 1
        Me.rBarRepVentas.Text = "Ventas"
        '
        '
        '
        Me.rBarRepVentas.TitleStyle.Class = ""
        Me.rBarRepVentas.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarRepVentas.TitleStyleMouseOver.Class = ""
        Me.rBarRepVentas.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnItVentas
        '
        Me.btnItVentas.Name = "btnItVentas"
        Me.btnItVentas.SubItemsExpandWidth = 14
        Me.btnItVentas.Text = "&Ventas"
        Me.btnItVentas.Tooltip = "Ver historial de ventas"
        '
        'btnItDevolucion
        '
        Me.btnItDevolucion.Name = "btnItDevolucion"
        Me.btnItDevolucion.SubItemsExpandWidth = 14
        Me.btnItDevolucion.Text = "&Devoluciones"
        Me.btnItDevolucion.Tooltip = "Ver historial de devoluciones"
        '
        'btnItFacturas
        '
        Me.btnItFacturas.Name = "btnItFacturas"
        Me.btnItFacturas.SubItemsExpandWidth = 14
        Me.btnItFacturas.Text = "&Facturas"
        Me.btnItFacturas.Tooltip = "Ver historial de facturas"
        '
        'rBarRepCaja
        '
        Me.rBarRepCaja.AutoOverflowEnabled = True
        '
        '
        '
        Me.rBarRepCaja.BackgroundMouseOverStyle.Class = ""
        Me.rBarRepCaja.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarRepCaja.BackgroundStyle.Class = ""
        Me.rBarRepCaja.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rBarRepCaja.ContainerControlProcessDialogKey = True
        Me.rBarRepCaja.Dock = System.Windows.Forms.DockStyle.Left
        Me.rBarRepCaja.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnItSaldoAct, Me.btnItCorte})
        Me.rBarRepCaja.Location = New System.Drawing.Point(3, 0)
        Me.rBarRepCaja.Name = "rBarRepCaja"
        Me.rBarRepCaja.Size = New System.Drawing.Size(118, 55)
        Me.rBarRepCaja.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rBarRepCaja.TabIndex = 0
        Me.rBarRepCaja.Text = "Caja"
        '
        '
        '
        Me.rBarRepCaja.TitleStyle.Class = ""
        Me.rBarRepCaja.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarRepCaja.TitleStyleMouseOver.Class = ""
        Me.rBarRepCaja.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnItSaldoAct
        '
        Me.btnItSaldoAct.Name = "btnItSaldoAct"
        Me.btnItSaldoAct.SubItemsExpandWidth = 14
        Me.btnItSaldoAct.Text = "&Saldo Actual"
        Me.btnItSaldoAct.Tooltip = "Ver el saldo actual en la caja"
        '
        'btnItCorte
        '
        Me.btnItCorte.Name = "btnItCorte"
        Me.btnItCorte.SubItemsExpandWidth = 14
        Me.btnItCorte.Text = "&Corte"
        Me.btnItCorte.Tooltip = "Realizar corte del día al usuario actual"
        '
        'RibbonPanel5
        '
        Me.RibbonPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel5.Location = New System.Drawing.Point(0, 51)
        Me.RibbonPanel5.Name = "RibbonPanel5"
        Me.RibbonPanel5.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel5.Size = New System.Drawing.Size(774, 58)
        '
        '
        '
        Me.RibbonPanel5.Style.Class = ""
        Me.RibbonPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel5.StyleMouseDown.Class = ""
        Me.RibbonPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel5.StyleMouseOver.Class = ""
        Me.RibbonPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel5.TabIndex = 5
        Me.RibbonPanel5.Visible = False
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel2.Controls.Add(Me.rBarProvedores)
        Me.RibbonPanel2.Controls.Add(Me.rBarClientes)
        Me.RibbonPanel2.Controls.Add(Me.rBarUsuarios)
        Me.RibbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel2.Location = New System.Drawing.Point(0, 51)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel2.Size = New System.Drawing.Size(774, 58)
        '
        '
        '
        Me.RibbonPanel2.Style.Class = ""
        Me.RibbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseDown.Class = ""
        Me.RibbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseOver.Class = ""
        Me.RibbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel2.TabIndex = 2
        Me.RibbonPanel2.Visible = False
        '
        'rBarProvedores
        '
        Me.rBarProvedores.AutoOverflowEnabled = True
        '
        '
        '
        Me.rBarProvedores.BackgroundMouseOverStyle.Class = ""
        Me.rBarProvedores.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarProvedores.BackgroundStyle.Class = ""
        Me.rBarProvedores.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rBarProvedores.ContainerControlProcessDialogKey = True
        Me.rBarProvedores.Dock = System.Windows.Forms.DockStyle.Left
        Me.rBarProvedores.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnAddPro, Me.btnItInformacion})
        Me.rBarProvedores.Location = New System.Drawing.Point(290, 0)
        Me.rBarProvedores.Name = "rBarProvedores"
        Me.rBarProvedores.Size = New System.Drawing.Size(126, 55)
        Me.rBarProvedores.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rBarProvedores.TabIndex = 2
        Me.rBarProvedores.Text = "&Provedores"
        '
        '
        '
        Me.rBarProvedores.TitleStyle.Class = ""
        Me.rBarProvedores.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarProvedores.TitleStyleMouseOver.Class = ""
        Me.rBarProvedores.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnAddPro
        '
        Me.btnAddPro.Name = "btnAddPro"
        Me.btnAddPro.SubItemsExpandWidth = 14
        Me.btnAddPro.Text = "&Agregar"
        Me.btnAddPro.Tooltip = "Agregar o modificar"
        '
        'btnItInformacion
        '
        Me.btnItInformacion.Name = "btnItInformacion"
        Me.btnItInformacion.SubItemsExpandWidth = 14
        Me.btnItInformacion.Text = "&Información"
        Me.btnItInformacion.Tooltip = "Buscar la información"
        '
        'rBarClientes
        '
        Me.rBarClientes.AutoOverflowEnabled = True
        '
        '
        '
        Me.rBarClientes.BackgroundMouseOverStyle.Class = ""
        Me.rBarClientes.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarClientes.BackgroundStyle.Class = ""
        Me.rBarClientes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rBarClientes.ContainerControlProcessDialogKey = True
        Me.rBarClientes.Dock = System.Windows.Forms.DockStyle.Left
        Me.rBarClientes.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnItAddCliente, Me.btnItSalCliente, Me.btnItComCliente, Me.btnItAbCliente})
        Me.rBarClientes.Location = New System.Drawing.Point(109, 0)
        Me.rBarClientes.Name = "rBarClientes"
        Me.rBarClientes.Size = New System.Drawing.Size(181, 55)
        Me.rBarClientes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rBarClientes.TabIndex = 1
        Me.rBarClientes.Text = "&Clientes"
        '
        '
        '
        Me.rBarClientes.TitleStyle.Class = ""
        Me.rBarClientes.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarClientes.TitleStyleMouseOver.Class = ""
        Me.rBarClientes.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnItAddCliente
        '
        Me.btnItAddCliente.Name = "btnItAddCliente"
        Me.btnItAddCliente.SubItemsExpandWidth = 14
        Me.btnItAddCliente.Text = "&Agregar"
        Me.btnItAddCliente.Tooltip = "Agregar o modificar"
        '
        'btnItSalCliente
        '
        Me.btnItSalCliente.Name = "btnItSalCliente"
        Me.btnItSalCliente.SubItemsExpandWidth = 14
        Me.btnItSalCliente.Text = "&Saldo"
        Me.btnItSalCliente.Tooltip = "Ver o modificar el saldo"
        '
        'btnItComCliente
        '
        Me.btnItComCliente.Name = "btnItComCliente"
        Me.btnItComCliente.SubItemsExpandWidth = 14
        Me.btnItComCliente.Text = "&Compras"
        Me.btnItComCliente.Tooltip = "Ver historial de compras"
        '
        'btnItAbCliente
        '
        Me.btnItAbCliente.Name = "btnItAbCliente"
        Me.btnItAbCliente.SubItemsExpandWidth = 14
        Me.btnItAbCliente.Text = "&Abonos"
        Me.btnItAbCliente.Tooltip = "Realizar abono a cuenta"
        '
        'rBarUsuarios
        '
        Me.rBarUsuarios.AutoOverflowEnabled = True
        '
        '
        '
        Me.rBarUsuarios.BackgroundMouseOverStyle.Class = ""
        Me.rBarUsuarios.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarUsuarios.BackgroundStyle.Class = ""
        Me.rBarUsuarios.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rBarUsuarios.ContainerControlProcessDialogKey = True
        Me.rBarUsuarios.Dock = System.Windows.Forms.DockStyle.Left
        Me.rBarUsuarios.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnItAdUs, Me.btnItPermisos})
        Me.rBarUsuarios.Location = New System.Drawing.Point(3, 0)
        Me.rBarUsuarios.Name = "rBarUsuarios"
        Me.rBarUsuarios.Size = New System.Drawing.Size(106, 55)
        Me.rBarUsuarios.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rBarUsuarios.TabIndex = 0
        Me.rBarUsuarios.Text = "&Usuarios"
        '
        '
        '
        Me.rBarUsuarios.TitleStyle.Class = ""
        Me.rBarUsuarios.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rBarUsuarios.TitleStyleMouseOver.Class = ""
        Me.rBarUsuarios.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnItAdUs
        '
        Me.btnItAdUs.Name = "btnItAdUs"
        Me.btnItAdUs.SubItemsExpandWidth = 14
        Me.btnItAdUs.Text = "&Agregar"
        Me.btnItAdUs.Tooltip = "Agregar o modificar"
        '
        'btnItPermisos
        '
        Me.btnItPermisos.Name = "btnItPermisos"
        Me.btnItPermisos.SubItemsExpandWidth = 14
        Me.btnItPermisos.Text = "&Permisos"
        Me.btnItPermisos.Tooltip = "Cambiar permisos a usuario"
        '
        'ribTabPrincipal
        '
        Me.ribTabPrincipal.Checked = True
        Me.ribTabPrincipal.Name = "ribTabPrincipal"
        Me.ribTabPrincipal.Panel = Me.RibbonPanel1
        Me.ribTabPrincipal.Text = "Principal"
        '
        'ribTabReg
        '
        Me.ribTabReg.Name = "ribTabReg"
        Me.ribTabReg.Panel = Me.RibbonPanel2
        Me.ribTabReg.Text = "Cuentas"
        '
        'ribTabProd
        '
        Me.ribTabProd.Name = "ribTabProd"
        Me.ribTabProd.Panel = Me.RibbonPanel3
        Me.ribTabProd.Text = "&Productos"
        '
        'ribTabReportes
        '
        Me.ribTabReportes.Name = "ribTabReportes"
        Me.ribTabReportes.Panel = Me.RibbonPanel4
        Me.ribTabReportes.Text = "&Reportes"
        '
        'ribTabOpc
        '
        Me.ribTabOpc.Name = "ribTabOpc"
        Me.ribTabOpc.Panel = Me.RibbonPanel5
        Me.ribTabOpc.Text = "Opciones"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "LabelItem1"
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)"
        Me.Bar1.AccessibleName = "DotNetBar Bar"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar
        Me.Bar1.AntiAlias = True
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.lblUserName})
        Me.Bar1.Location = New System.Drawing.Point(5, 440)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(774, 19)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 2
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'lblUserName
        '
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Text = "Usuario..."
        '
        'Home
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.ribCont)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(500, 300)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.ribCont.ResumeLayout(False)
        Me.ribCont.PerformLayout()
        Me.RibbonPanel3.ResumeLayout(False)
        Me.RibbonPanel1.ResumeLayout(False)
        Me.RibbonPanel4.ResumeLayout(False)
        Me.RibbonPanel2.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ribCont As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents RibbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonPanel2 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents ribTabPrincipal As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents ribTabReg As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents rBarVender As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents rBarSesion As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents rBarProvedores As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents rBarClientes As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents rBarUsuarios As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btnItVender As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnItLog As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnItSwitch As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnItAdUs As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnItPermisos As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonPanel3 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents rBarAdmArt As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ribTabProd As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents btnItAddProd As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnItInvProd As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnItPreProd As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents rBarMerma As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btnItMerma As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnItAddCliente As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnItSalCliente As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonPanel4 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents rBarCaja As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btnItIngresarCaj As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnItExtraerCaj As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ribTabReportes As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents btnAddPro As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnItComCliente As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnItAbCliente As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents rBarRepCaja As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btnItSaldoAct As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnItCorte As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents rBarRepVentas As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btnItVentas As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnItDevolucion As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnItFacturas As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents rBarRepProd As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents RibbonPanel5 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents ButtonItem20 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem21 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ribTabOpc As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents btnItInformacion As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnItDevProd As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents lblUserName As DevComponents.DotNetBar.LabelItem
End Class
