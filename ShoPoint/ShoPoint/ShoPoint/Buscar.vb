Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Buscar

    'Se utiliza para crear un pequeño retraso al momento de realizar la busqueda
    'así se busca no sobrecargar el sistema al hacerlo buscar letra por letra
    Dim tick As New Timer
    Dim result As DialogResult
    Dim listArt As New List(Of String)
    Public MultiSelectedActive As Boolean

    Private Sub FormLoad(sender As Object, e As EventArgs) Handles Me.Load
        'Configucarión inicial
        rbtnName.Checked = True
        tick.Interval = 500 'Espera de 500ms
        tick.Stop() 'Se inicia el timer detenido
        AddHandler tick.Tick, AddressOf Tick_Tock 'Se le da el control al evento TickTock
        result = Windows.Forms.DialogResult.Abort 'Variable para controlar si se realizo la busqueda
        listArt.Clear() 'Se limpia la lista de Articulos
        dgvInf.MultiSelect = MultiSelectedActive
    End Sub
    Private Sub FormClose(sender As Object, e As EventArgs) Handles Me.FormClosed
        'Insercción del resultado de la busqueda
        DialogResult = result
    End Sub
    Private Sub Form_Closing(sender As Object, e As EventArgs) Handles Me.FormClosing
        'Al cerrar el formulario se limpia la información extradida del mismo
        Dim dt As New DataTable 'Variable para limpiar el DataGridView
        dt.Clear()
        txtDesc.Text = ""
        dgvInf.DataSource = dt
    End Sub

    Private Sub Tick_Tock(sender As Object, e As EventArgs)
        'Evento producido al pasar los 500ms de espera para realizar la busqueda
        Busqueda()
        tick.Stop()
        tick.Dispose()
    End Sub
    Private Sub txtDes_TextChange(sender As Object, e As EventArgs) Handles txtDesc.TextChanged
        'Al modificar el TextBox txtDes si no esta vacio se empieza Timer para realizar la busqueda depues de introducir el texto
        If txtDesc.Text IsNot "" Then
            tick.Stop() 'Se reinicia el Timer para que pase 500 después de escribir la última letra
            tick.Start()
        Else 'Si el TextBox esta vacio se detiene el Timer
            tick.Stop()
        End If
    End Sub
    Private Sub Busqueda()
        tick.Stop() 'Se detiene el Timer y se realiza la busqueda
        MsgBox("Prueba rapida del timer")
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Si se cancela la busqueda se retorna el DialogResult Cancel notificando su cancelación
        result = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'En caso de encontrar el artículo se retorna un OK como resultado en el DialogResult de Formulario
        result = Windows.Forms.DialogResult.OK
        'Se pasa por la etiqueta (Tag) del Botón btnOk el código del artículo
        listArt.Add("Esta es una prueba rapida")

        Me.Close()
    End Sub
    Public Function getListArt() As List(Of String)
        Return listArt
    End Function
End Class