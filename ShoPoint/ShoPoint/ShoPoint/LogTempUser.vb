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
        Dim strPass As String = txtPass.Text
        Dim strUser As String = txtUser.Text
        Dim SQL As String = "SELECT id FROM users as db1, permisos as db2 " & _
                            "WHERE db1.nick = '" & strUser & "' AND db1.pass = '" & strPass & "' AND db2.rel_dev = 1 "

    End Sub
End Class