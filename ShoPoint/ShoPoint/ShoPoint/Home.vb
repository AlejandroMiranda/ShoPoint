Public Class Home

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idPermisos()

    End Sub

    Private Sub idPermisos()
        'Sesión
        btnItLog.Enabled = UserID.Equals("")
        btnItSwitch.Enabled = Not (UserID.Equals(""))
        btnItVender.Enabled = Not (UserID.Equals(""))
        'Permisos de usuario
        btnItPermisos.Enabled = Not (UserID.Equals(""))
        'Información no relevante de clientes
        btnItSalCliente.Enabled = Not (UserID.Equals(""))
        btnItComCliente.Enabled = Not (UserID.Equals(""))
        'Información no relevante de proveedores
        btnItInformacion.Enabled = Not (UserID.Equals(""))
        'Salida de mercancía (Merma/Ventas)
        btnItMerma.Enabled = Not (UserID.Equals("")) 'La merma se relaciona con permisos de modificar inventario
        btnItVentas.Enabled = Not (UserID.Equals(""))

        'Opciones de proveedores
        btnAddPro.Enabled = (PermisosOt.Item("AdProd") Or PermisosOt.Item("MdProd") Or PermisosOt.Item("DlProd"))

        'Opciones de usuarios
        btnItAdUs.Enabled = (PermisosOt.Item("AdUser") Or PermisosOt.Item("MdUser") Or PermisosOt.Item("DlUser"))

        'Opciones de caja
        btnItIngresarCaj.Enabled = Not (UserID.Equals(""))
        btnItExtraerCaj.Enabled = Not (UserID.Equals(""))
        btnItSaldoAct.Enabled = PermisosOt.Item("CortCaja")
        btnItCorte.Enabled = Not (UserID.Equals(""))

        'Opciones de clientes
        btnItAddCliente.Enabled = (PermisosOt.Item("AdCli") Or PermisosOt.Item("MdCli") Or PermisosOt.Item("DlCli"))
        btnItAbCliente.Enabled = PermisosOt.Item("RelAb")

        'Opciones de productos
        btnItAddProd.Enabled = (PermisosOt.Item("AdProd") Or PermisosOt.Item("MdProd") Or PermisosOt.Item("DlProd"))
        btnItPreProd.Enabled = PermisosOt.Item("MdProd")
        btnItInvProd.Enabled = PermisosOt.Item("MdInv")

        'Opciones de devolución y facturas
        'btnItDevProd.Enabled = Not (UserID.Equals(""))
        btnItDevolucion.Enabled = PermisosOt.Item("VerDev")
        btnItFacturas.Enabled = PermisosOt.Item("VerFact")

    End Sub

    Private Sub btnItVender_Click(sender As Object, e As EventArgs) Handles btnItVender.Click
        Vender.MdiParent = Me
        Vender.Show()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnItLog.Click
        'Acceso.MdiParent = Me
        If Acceso.ShowDialog(Me) = Windows.Forms.DialogResult.Yes Then
            idPermisos()
        End If
    End Sub

    Private Sub LogOut(sender As Object, e As EventArgs) Handles btnItCorte.Click
        Get_Info()
        idPermisos()
        lblUserName.Text = "Usuario..."
    End Sub

    Private Sub btnItIngresarCaj_Click(sender As Object, e As EventArgs) Handles btnItIngresarCaj.Click
        If PermisosOt.Item("EntCaja") Then

        End If
    End Sub

    Private Sub btnItAddProd_Click(sender As Object, e As EventArgs) Handles btnItAddProd.Click
        
    End Sub

    Private Sub btnItDevProd_Click(sender As Object, e As EventArgs) Handles btnItDevProd.Click
        If PermisosOt.Item("RelDev") Then

        Else
            If LogTempUser.ShowDialog() = Windows.Forms.DialogResult.OK Then
                MsgBox("Autorización otorgada")
            End If
        End If
    End Sub
End Class