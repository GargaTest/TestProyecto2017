Public Class fNameList

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim nombre As String = ""
        nombre = txtBoxNombres.Text

        If (Not IsNumeric(nombre)) Then

            If (Not listListaDeNombres.Items.Contains(nombre)) Then
                listListaDeNombres.Items.Add(nombre)
            Else
                MsgBox("El nombre especificado ya fué ingresado")
            End If

        Else
            MsgBox("No se pueden ingresar números")
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim indiceNombre As Integer = listListaDeNombres.SelectedIndex

        If (indiceNombre = -1) Then
            MsgBox("Debe seleccionar un elemento primero.")
        Else
            listListaDeNombres.Items.RemoveAt(indiceNombre)

        End If

    End Sub


    Private Sub btnVaciar_Click(sender As Object, e As EventArgs) Handles btnVaciar.Click
        listListaDeNombres.Items.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnExtraer_Click(sender As Object, e As EventArgs) Handles btnExtraer.Click

        'Guardar archivo con el sis. de guardado de Windows'
        Dim save As New SaveFileDialog()
        save.FileName = "ListaNombres.txt"
        save.Filter = "Text File | *.txt"

        If save.ShowDialog() = DialogResult.OK Then
            Dim writer As New IO.StreamWriter(save.OpenFile())
            For i As Integer = 0 To listListaDeNombres.Items.Count - 1
                writer.WriteLine(listListaDeNombres.Items(i).ToString())
            Next
            writer.Dispose()
            writer.Close()
        End If

    End Sub

    Private Sub SaveFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog.FileOk

    End Sub
End Class
