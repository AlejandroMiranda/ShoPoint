Imports MySql.Data.MySqlClient

Public Class LogTempUser

    Dim cnx As New MySqlConnection(My.Settings.ConectionString)

    Private Sub LoadForm(Sender As Object, e As EventArgs) Handles Me.Load
        lblMsgAcceso.Text = "No se te autorizo entrar a este sitio" & vbCr & _
            "Favor de pedir autorización temporal a usuario con acceso"
        Me.MaximizeBox = False
        checkVPass.Checked = False
    End Sub
    Private Sub PaswordChar_Control(sender As Object, e As EventArgs) Handles checkVPass.CheckedChanged, txtPass.TextChanged
        'Control de la propiedad PaswordChar para visualizar u ocultar la contraseña
        If txtPass.Text <> "" Then
            If checkVPass.Checked Then
                txtPass.PasswordChar = ""
            Else
                txtPass.PasswordChar = "*"
            End If
        Else
            txtPass.PasswordChar = ""
        End If
    End Sub

    Private Sub LogTemp_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Subrutina para reconocer que el usuario y la contraseña sean correctas
        Dim strPass As String = txtPass.Text
        Dim strUser As String = txtUser.Text
        Dim SQL As String = "SELECT id FROM users " &
                            "WHERE nick = '" & strUser & "' AND pass = '" & strPass & "'"
        'La variable cmd tiene como referencia la sentencia SQL y la cadena de conexión de MySQL
        Dim cmd As New MySqlCommand(SQL, cnx)

        cnx.Open()
        'Variable para realizar la lectura de la sentencia 
        Dim lectura As MySqlDataReader = cmd.ExecuteReader
        If lectura.Read Then 'En caso de existir una lectura exitosa de la sentencia
            Home.Tag = lectura(0).ToString 'Se pasa el valor del Id en la etiqueta del formulario Home
            Me.DialogResult = DialogResult.OK 'Como se abrió el formulario por ShowDialog se retorna un resultado
            cnx.Close() 'Se cierra la conexión a la BD
            Me.Close() 'Se cierra el formulario
        Else 'En caso de no tener resultado alguno de la sentencia
            Me.DialogResult = DialogResult.No 'Se retorna por medio del ShowDialog el resultado de No
            cnx.Close() 'Se cierra la conexión a la BD
            'Mensaje para notificar el resultado negativo de la búsqueda
            MsgBox("Usuario o contraseña incorrecto", MsgBoxStyle.Exclamation, "Error de inicio de sesión")
        End If

    End Sub

End Class