Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Acceso

    Private Sub FormLoad(sender As Object, e As EventArgs) Handles Me.Load
        'Configuración inicial del formulario
        chkvPass.Checked = False
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

End Class