Public Class Vender

    Dim LoadComplete As Boolean
    Dim cTickets As Integer
    Dim listVenta As New List(Of ListView)
    Dim countP As Integer

    Private Sub FormLoad(sender As Object, e As EventArgs) Handles Me.Load
        'Configuración inicial del formulario
        listBuy_1.HeaderStyle = ColumnHeaderStyle.Nonclickable
        listVenta.Add(listBuy_1)
        LoadComplete = True

        cTickets = 1
        countP = 0
    End Sub

    Private Sub listBuy_ChangeWithColum(sender As Object, e As EventArgs) Handles listBuy_1.ColumnWidthChanged
        'Subrutina para prevenir la edicion del tamaño de la columna
        If LoadComplete Then
            Dim listAct As ListView = listVenta(tcTickets.SelectedIndex)
            If listAct.Columns(0).Width <> 100 Then : listAct.Columns(0).Width = 100 : End If
            'If listAct.Columns(1).Width <> 200 Then : listAct.Columns(1).Width = 200 : End If
            If listAct.Columns(2).Width <> 70 Then : listAct.Columns(2).Width = 70 : End If
            If listAct.Columns(3).Width <> 70 Then : listAct.Columns(3).Width = 70 : End If
            If listAct.Columns(4).Width <> 80 Then : listAct.Columns(4).Width = 80 : End If
            If listAct.Columns(5).Width <> 80 Then : listAct.Columns(5).Width = 80 : End If
        End If
    End Sub

    Private Sub btnShell_Click(sender As Object, e As EventArgs) Handles btnShell.Click
        Dim res As String = Nothing
        Buscar.MultiSelectedActive = True
        Dim dialogResulShell = Buscar.ShowDialog
        If dialogResulShell = Windows.Forms.DialogResult.OK Then
            For Each ListResult As String In Buscar.getListArt
                InsertCod(ListResult)
            Next
        ElseIf dialogResulShell = Windows.Forms.DialogResult.Cancel Then
            MsgBox("Se cancelo la busqueda")
        End If
    End Sub

    Private Sub InsertCod(cod As String)
        MsgBox("Insercción del código de prueba : " & cod)
    End Sub

    Private Sub NewTicket_Click(sender As Object, e As EventArgs) Handles btnNewTicket.Click
        If MessageBox.Show("¿Crear nuevo ticket?", "Ticket", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            'Variables para el nuevo TabPage y ListView
            cTickets += 1
            Dim txtTabPage As String = "Ticket #" & cTickets
            Dim nTabPage As String = "tpTicket_" & cTickets

            'Crear area de venta nueva
            Dim NewListView As New ListView 'Crea un nuevo ListView
            For i As Integer = 0 To listBuy_1.Columns.Count - 1 'Relleno de cabeceras
                NewListView.Columns.Add(listBuy_1.Columns(i).Text) 'Se agrega el texto
                NewListView.Columns(i).Width = listBuy_1.Columns(i).Width 'Ajuste de Tamaño
                NewListView.Columns(i).Name = listBuy_1.Columns(i).Name 'Asignación del nombre
            Next
            'Configuración del ListView
            NewListView.HeaderStyle = ColumnHeaderStyle.Nonclickable
            NewListView.View = View.Details
            NewListView.Dock = DockStyle.Fill
            NewListView.FullRowSelect = True
            NewListView.Name = "listBuy_" & cTickets 'Creación del nombre
            'Asignación del evento ColumnWidthCahnged para prevenir su manipulación
            AddHandler NewListView.ColumnWidthChanged, AddressOf listBuy_ChangeWithColum
            listVenta.Add(NewListView) 'Se agrega a la lista de las áreas de venta para su control

            'Crear una nueva TabPage
            Dim nTab As New TabPage 'Nueva TabPage
            nTab.Name = nTabPage 'Se asigna el nombre de la consecutividad
            nTab.Text = txtTabPage 'Se asigna el texto de cabecera
            nTab.Controls.Add(NewListView) 'Se agrega la nueva área de venta (ListView) en el nuevo TabPage
            tcTickets.TabPages.Add(nTab) 'Se agrega el nuevo TabPage en el TabControl actual
            'Se asigna el foco a la nueva área de venta Creada
            tcTickets.SelectedIndex = cTickets - 1
        End If
    End Sub

    Private Sub TicketDelte()
        Dim listAct As ListView = listVenta(tcTickets.SelectedIndex)
        Dim indexListAct As Integer
        Dim countLists As Integer = listVenta.Count - 1
        If countLists > 1 Then
            Dim tpDelete As TabPage = tcTickets.TabPages(countLists)
            For indexListAct = tcTickets.SelectedIndex To countLists - 1
                listAct.Items.Clear()
                For Each itList As ListViewItem In listVenta(indexListAct + 1).Items
                    listAct.Items.Add(itList.Clone)
                Next
                listAct = listVenta(indexListAct + 1)
            Next
            listVenta.Remove(listAct)
            tcTickets.TabPages.Remove(tpDelete)
            cTickets -= 1
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim lisAct As ListView = listVenta(tcTickets.SelectedIndex)
        Dim pList As Integer = lisAct.Items.Count
        countP += 1
        lisAct.Items.Add("Prueba " & countP)
        lisAct.Items(pList).SubItems.Add("Descripcion " & countP)
        lisAct.Items(pList).SubItems.Add("Precio " & countP)
        lisAct.Items(pList).SubItems.Add("Cantidad " & countP)
        lisAct.Items(pList).SubItems.Add("Total " & countP)
        lisAct.Items(pList).SubItems.Add("Stock " & countP)

    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click

    End Sub
End Class