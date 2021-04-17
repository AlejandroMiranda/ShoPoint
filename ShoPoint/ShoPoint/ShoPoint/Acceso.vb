Imports MySql.Data.MySqlClient

Public Class Acceso

    Dim cnx As New MySqlConnection(My.Settings.ConectionString)

    Private Sub FormLoad(sender As Object, e As EventArgs) Handles Me.Load
        'Configuración inicial del formulario
        chkvPass.Checked = False
        Me.MaximizeBox = False
        Fill_NickUsers() 'Autor relleno para el TextBox del nick name de los usuarios

    End Sub

    Private Sub PaswordChar_Control(sender As Object, e As EventArgs) Handles chkvPass.CheckedChanged, txtPass.TextChanged
        'Control de la propiedad PaswordChar para visualizar u ocultar la contraseña
        If txtPass.Text <> "" Then
            If chkvPass.Checked Then
                txtPass.PasswordChar = ""
            Else
                txtPass.PasswordChar = "*"
            End If
        Else
            txtPass.PasswordChar = ""
        End If
    End Sub
    Private Sub Fill_NickUsers()
        'Sentencia SQL para leer todos los nick name de la bd
        Dim SQL As String = "SELECT nick FROM Users"
        'Se pasa a un DataAdapter para utilizar el método Fill y así rellenar un DataTable
        Dim Info As New MySqlDataAdapter(SQL, cnx)
        'El DataTable es para poder ver la información por Filas
        Dim dTable As New DataTable()
        Info.Fill(dTable) 'Relleno del DataAdapter al DataTable
        'Variable a almacenar la información de la BD
        Dim Colection As New AutoCompleteStringCollection()
        'Se revisa las filas del DataTable para leer todo
        For Each rw As DataRow In dTable.Rows
            Colection.Add(rw(0).ToString) 'Se agrega al StringCollection
        Next

        'Configuración del TextBox para dar las funciones del autorrelleno
        txtUser.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtUser.AutoCompleteCustomSource = Colection
        txtUser.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub

    Private Sub LogIn_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtPass.Text <> "" And txtUser.Text <> "" Then
            'Sentencia para identificarse
            Dim SQL As String = "SELECT id FROM users WHERE nick like '" &
               txtUser.Text & "' AND pass like '" & txtPass.Text & "'"
            Dim cmd As New MySqlCommand(SQL, cnx)

            cnx.Open()
            Dim Lectura As MySqlDataReader = cmd.ExecuteReader()
            If Lectura.Read Then 'Si hay lectura significa que el nick y pass son correctos
                Dim id As String = Lectura(0).ToString 'Se recupera el Id del usuario
                cnx.Close() 'Se cierra la BD para permitir a la siguiente función hacer su procedimiento
                Home.btnItLog.Tag = id 'Se le agrega a la etiqueta el Id del usuario
                Me.DialogResult = Windows.Forms.DialogResult.Yes 'Se retorna al formulario el resultado del dialogo como Yes
                Me.Close() 'Se cierra el formulario de inicio de sesión
            Else 'En caso contrario se especifica que el usuario o contraseña son incorrectos
                cnx.Close()
                Lectura.Close()
                Me.DialogResult = Windows.Forms.DialogResult.No
                MsgBox("Usuario o contraseña incorrecto", MsgBoxStyle.Exclamation, "Error de inicio de sesión")
            End If
        End If
    End Sub

End Class