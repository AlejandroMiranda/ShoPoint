Public Class Home


    'Crear objeto para identificar el usuario que está trabajando en el sistema
    Dim UserLocal As New User("", "", "")
    Private usPermisos As New Dictionary(Of String, Boolean)  'Permisos utilizados por el usuario

    'Constructor del formulario
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se obtiene los permisos (vacíos) del usuario (nulos)
        usPermisos = UserLocal.Get_Permisos
        'Invocación de la subrutina para detectar los lugares permitidos al usuario (nulo)
        idPermisos()
    End Sub

    Private Sub idPermisos()
        'Sesión
        btnItLog.Enabled = UserLocal.GetId.Equals("")
        btnItSwitch.Enabled = Not (UserLocal.GetId.Equals(""))
        btnItVender.Enabled = Not (UserLocal.GetId.Equals(""))
        'Permisos de usuario
        btnItPermisos.Enabled = Not (UserLocal.GetId.Equals(""))
        'Información no relevante de clientes
        btnItSalCliente.Enabled = Not (UserLocal.GetId.Equals(""))
        btnItComCliente.Enabled = Not (UserLocal.GetId.Equals(""))
        'Información no relevante de proveedores
        btnItInformacion.Enabled = Not (UserLocal.GetId.Equals(""))
        'Salida de mercancía (Merma/Ventas)
        btnItMerma.Enabled = Not (UserLocal.GetId.Equals("")) 'La merma se relaciona con permisos de modificar inventario
        btnItVentas.Enabled = Not (UserLocal.GetId.Equals(""))

        'Opciones de proveedores
        btnAddPro.Enabled = (usPermisos.Item("AdProd") Or usPermisos.Item("MdProd") Or usPermisos.Item("DlProd"))

        'Opciones de usuarios
        btnItAdUs.Enabled = (usPermisos.Item("AdUser") Or usPermisos.Item("MdUser") Or usPermisos.Item("DlUser"))

        'Opciones de caja
        btnItIngresarCaj.Enabled = Not (UserLocal.GetId.Equals(""))
        btnItExtraerCaj.Enabled = Not (UserLocal.GetId.Equals(""))
        btnItSaldoAct.Enabled = usPermisos.Item("CortCaja")
        btnItCorte.Enabled = Not (UserLocal.GetId.Equals(""))

        'Opciones de clientes
        btnItAddCliente.Enabled = (usPermisos.Item("AdCli") Or usPermisos.Item("MdCli") Or usPermisos.Item("DlCli"))
        btnItAbCliente.Enabled = usPermisos.Item("RelAb")

        'Opciones de productos
        btnItAddProd.Enabled = (usPermisos.Item("AdProd") Or usPermisos.Item("MdProd") Or usPermisos.Item("DlProd"))
        btnItPreProd.Enabled = usPermisos.Item("MdProd")
        btnItInvProd.Enabled = usPermisos.Item("MdInv")

        'Opciones de devolución y facturas
        'btnItDevProd.Enabled = Not (UserLocal.GetId.Equals(""))
        btnItDevolucion.Enabled = usPermisos.Item("VerDev")
        btnItFacturas.Enabled = usPermisos.Item("VerFact")

    End Sub

    Private Sub btnItVender_Click(sender As Object, e As EventArgs) Handles btnItVender.Click
        Vender.MdiParent = Me
        Vender.Show()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnItLog.Click
        'Se ejecuta el formulario de acceso como un formulario de dialogo y en caso de ingresarse
        'unas credenciales validas se ejecutan
        If Acceso.ShowDialog(Me) = Windows.Forms.DialogResult.Yes Then
            If btnItLog.Tag <> "" Then 'En caso existir alguna Id ingresada en la etiqueta se obtiene la información del usuario
                UserLocal.Get_Info(btnItLog.Tag) 'Se ejecuta la función para obtener la información del usuario
                lblUserName.Text = UserLocal.Get_Name 'Se registra el nombre del usuario en la barra de estado
                usPermisos = UserLocal.Get_Permisos 'Se adquiere los permisos del usuario
                idPermisos() 'Se realizan las modificaciones en el formulario para el acceso a las diferentes opciones
                btnItLog.Tag = ""
            End If
        End If
    End Sub

    Private Sub LogOut(sender As Object, e As EventArgs) Handles btnItCorte.Click
        UserLocal.reset_Permiso() 'Eliminar los permisos que se tienen del usuario
        usPermisos = UserLocal.Get_Permisos 'Se adquiere los permisos (ya borrados)
        idPermisos() 'Se vuelve a bloquear los accesos ya que se cierra el usuario
        lblUserName.Text = "Usuario..." 'Se reinicia el nombre del usuario en la barra de estado
    End Sub

    Private Sub btnItIngresarCaj_Click(sender As Object, e As EventArgs) Handles btnItIngresarCaj.Click
        If usPermisos.Item("EntCaja") Then

        End If
    End Sub

    Private Sub btnItAddProd_Click(sender As Object, e As EventArgs) Handles btnItAddProd.Click
        
    End Sub

    Private Sub btnItDevProd_Click(sender As Object, e As EventArgs) Handles btnItDevProd.Click
        'Se revisa el permiso qué se tiene
        '-> en caso de tener el permiso se ingresa a la ventana para realizar la devoluciones 
        If usPermisos.Item("RelDev") Then

        Else '-> En caso de no tener el permiso se puede pedir autorización a otro usuario con el permiso
            If LogTempUser.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If Autorizacion(Me.Tag, "RelDev") Then 'Se realiza la comprobación del permiso requerido
                    MsgBox("Autorización confirmada")
                Else
                    MsgBox("El usuario no cuenta con el permiso necesario", MsgBoxStyle.Critical, "Usuario sin acceso")
                End If
            Else
                MsgBox("")
            End If
        End If
    End Sub

    Private Function Autorizacion(id As String, permiso As String) As Boolean
        Dim UserTemp As New User("", "", "") '-> Creación del usuario temporal
        UserTemp.Get_Info(id) '-> Se obtiene la información del usuario mediante la etiqueta
        Dim PermisosTemp As Dictionary(Of String, Boolean) = UserTemp.Get_Permisos '-> Se adquieren los permisos
        If (PermisosTemp.Item(permiso)) Then '-> Se revisa que el usuario temporal si tenga el permiso necesario
            Return True
        Else
            Return False
        End If
    End Function

End Class