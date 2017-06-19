Imports MySql.Data.MySqlClient

Module LogUser

    Dim cnx As New MySqlConnection(My.Settings.ConectionString)
    Public PermisosOt As New Dictionary(Of String, Boolean)

    'Información del usuario
    Public UserName As String = ""
    Public UserNick As String = ""
    Public UserID As String = ""

    Public LogTemp As Boolean
    Public UserTempName As String
    Public UserTempId As String

    'Constructor del Modulo de Usuario
    Sub New()
        'Permisos con usuarios
        PermisosOt.Add("AdUser", False)
        PermisosOt.Add("MdUser", False)
        PermisosOt.Add("DlUser", False)
        PermisosOt.Add("ModPer", False)
        'Permisos con Clientes
        PermisosOt.Add("AdCli", False)
        PermisosOt.Add("MdCli", False)
        PermisosOt.Add("DlCli", False)
        'Permisos con productos
        PermisosOt.Add("AdProd", False)
        PermisosOt.Add("MdProd", False)
        PermisosOt.Add("DlProd", False)
        PermisosOt.Add("MdInv", False)
        'Permisos con las devoluciones
        PermisosOt.Add("RelDev", False)
        PermisosOt.Add("VerDev", False)
        'Permiso con los créditos/abonos
        PermisosOt.Add("RelComC", False)
        PermisosOt.Add("RelAb", False)
        'Ver historial de modificaciones
        PermisosOt.Add("VerMod", False)
        'Permisos con la caja
        PermisosOt.Add("CortCaja", False) 'Ver cierre en caja
        PermisosOt.Add("CerrCaja", False) 'Cerrar el turno
        PermisosOt.Add("EntCaja", False) 'Dar entrada a efectivo
        PermisosOt.Add("SalCaja", False) 'Dar salida a efectivo
        PermisosOt.Add("VerFact", False) 'Realizar y ver facturas
    End Sub

    'Obtener información del usuario registrado
    Public Sub Get_Info(Optional ByVal id As String = "-1")
        Dim SQL As String = "SELECT id, name, nick FROM users WHERE id = " & id
        Dim cmd As New MySqlCommand(SQL, cnx)

        cnx.Open()
        Dim lectura As MySqlDataReader = cmd.ExecuteReader

        If lectura.Read Then 'En caso de existir algo para leer
            UserID = lectura(0) 'Se obtiene el ID del usuario
            UserName = lectura(1) 'Nombre
            UserNick = lectura(2) 'Nick (Apodo)

            cnx.Close()
            usAcceso(id) 'Subrutina para verificar el acceso otorgado
        Else
            cnx.Close()
            reset_Permiso()
        End If


    End Sub

    'Adquirir los permisos otorgados al usuario registrado
    Private Sub usAcceso(ByVal id As String)
        Dim sql As String = "SELECT * FROM permisos WHERE id_user = " & id
        Dim cmd As New MySqlCommand(sql, cnx)

        cnx.Open()
        Dim Lectura As MySqlDataReader = cmd.ExecuteReader
        Lectura.Read() 'Se realiza la lectura de la sentencia 
        'Se analiza si tiene acceso el usuario (1 = Verdadero)
        PermisosOt.Item("AdUser") = Lectura(1).ToString.Equals("1")
        PermisosOt.Item("MdUser") = Lectura(2).ToString.Equals("1")
        PermisosOt.Item("DlUser") = Lectura(3).ToString.Equals("1")
        PermisosOt.Item("AdCli") = Lectura(4).ToString.Equals("1")
        PermisosOt.Item("MdCli") = Lectura(5).ToString.Equals("1")
        PermisosOt.Item("DlCli") = Lectura(6).ToString.Equals("1")
        PermisosOt.Item("AdProd") = Lectura(7).ToString.Equals("1")
        PermisosOt.Item("MdProd") = Lectura(8).ToString.Equals("1")
        PermisosOt.Item("DlProd") = Lectura(9).ToString.Equals("1")
        PermisosOt.Item("MdInv") = Lectura(10).ToString.Equals("1")
        PermisosOt.Item("RelDev") = Lectura(11).ToString.Equals("1")
        PermisosOt.Item("VerDev") = Lectura(12).ToString.Equals("1")
        PermisosOt.Item("RelComC") = Lectura(13).ToString.Equals("1")
        PermisosOt.Item("RelAb") = Lectura(14).ToString.Equals("1")
        PermisosOt.Item("VerMod") = Lectura(15).ToString.Equals("1")
        PermisosOt.Item("ModPer") = Lectura(16).ToString.Equals("1")
        PermisosOt.Item("CortCaja") = Lectura(17).ToString.Equals("1")
        PermisosOt.Item("CerrCaja") = Lectura(18).ToString.Equals("1")
        PermisosOt.Item("EntCaja") = Lectura(19).ToString.Equals("1")
        PermisosOt.Item("SalCaja") = Lectura(20).ToString.Equals("1")
        PermisosOt.Item("VerFact") = Lectura(21).ToString.Equals("1")
        cnx.Close()
    End Sub

    Private Sub reset_Permiso()
        'Eliminar Datos de usuario
        UserID = ""
        UserName = ""
        UserNick = ""

        'Colocar todos los elementos en false
        PermisosOt.Item("AdUser") = False
        PermisosOt.Item("MdUser") = False
        PermisosOt.Item("DlUser") = False
        PermisosOt.Item("AdCli") = False
        PermisosOt.Item("MdCli") = False
        PermisosOt.Item("DlCli") = False
        PermisosOt.Item("AdProd") = False
        PermisosOt.Item("MdProd") = False
        PermisosOt.Item("DlProd") = False
        PermisosOt.Item("MdInv") = False
        PermisosOt.Item("RelDev") = False
        PermisosOt.Item("VerDev") = False
        PermisosOt.Item("RelComC") = False
        PermisosOt.Item("RelAb") = False
        PermisosOt.Item("VerMod") = False
        PermisosOt.Item("ModPer") = False
        PermisosOt.Item("CortCaja") = False
        PermisosOt.Item("CerrCaja") = False
        PermisosOt.Item("EntCaja") = False
        PermisosOt.Item("SalCaja") = False
    End Sub

End Module
