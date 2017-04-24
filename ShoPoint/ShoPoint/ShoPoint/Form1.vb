Imports System.Data.SQLite
Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Form1Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim cnx As New MySqlConnection("server=127.0.0.1;User Id=root;")
        Try
            cnx.Open()
            cnx.Close()
        Catch ex As Exception
            MsgBox("Error al abrir la BD")
        End Try
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click, btnVentas.Click
        Vender.MdiParent = Me
        Vender.Show()
    End Sub

    Private Sub OpcionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpcionesToolStripMenuItem.Click
        Acceso.MdiParent = Me
        Acceso.Show()
    End Sub
End Class
