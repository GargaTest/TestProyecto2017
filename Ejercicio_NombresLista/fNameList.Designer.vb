<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fNameList
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.listListaDeNombres = New System.Windows.Forms.ListBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtBoxNombres = New System.Windows.Forms.TextBox()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnVaciar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnExtraer = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listListaDeNombres
        '
        Me.listListaDeNombres.FormattingEnabled = True
        Me.listListaDeNombres.Location = New System.Drawing.Point(12, 123)
        Me.listListaDeNombres.Name = "listListaDeNombres"
        Me.listListaDeNombres.Size = New System.Drawing.Size(596, 251)
        Me.listListaDeNombres.Sorted = True
        Me.listListaDeNombres.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTitulo.Location = New System.Drawing.Point(193, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(243, 44)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "¡Bienvenido!"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBoxNombres
        '
        Me.txtBoxNombres.Location = New System.Drawing.Point(12, 83)
        Me.txtBoxNombres.Name = "txtBoxNombres"
        Me.txtBoxNombres.Size = New System.Drawing.Size(180, 20)
        Me.txtBoxNombres.TabIndex = 2
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Location = New System.Drawing.Point(12, 67)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(49, 13)
        Me.lblNombres.TabIndex = 3
        Me.lblNombres.Text = "Nombres"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(209, 81)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnVaciar
        '
        Me.btnVaciar.Location = New System.Drawing.Point(452, 81)
        Me.btnVaciar.Name = "btnVaciar"
        Me.btnVaciar.Size = New System.Drawing.Size(75, 23)
        Me.btnVaciar.TabIndex = 5
        Me.btnVaciar.Text = "Vaciar"
        Me.btnVaciar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(533, 81)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(290, 81)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnExtraer
        '
        Me.btnExtraer.Location = New System.Drawing.Point(371, 81)
        Me.btnExtraer.Name = "btnExtraer"
        Me.btnExtraer.Size = New System.Drawing.Size(75, 23)
        Me.btnExtraer.TabIndex = 8
        Me.btnExtraer.Text = "Extraer"
        Me.btnExtraer.UseVisualStyleBackColor = True
        '
        'SaveFileDialog
        '
        '
        'bModificar
        '
        Me.bModificar.Location = New System.Drawing.Point(63, 29)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(75, 23)
        Me.bModificar.TabIndex = 9
        Me.bModificar.Text = "Modificar"
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'frmListaDeNombres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 386)
        Me.Controls.Add(Me.bModificar)
        Me.Controls.Add(Me.btnExtraer)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVaciar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblNombres)
        Me.Controls.Add(Me.txtBoxNombres)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.listListaDeNombres)
        Me.Name = "frmListaDeNombres"
        Me.Text = "Lista de Nombres"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listListaDeNombres As ListBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtBoxNombres As TextBox
    Friend WithEvents lblNombres As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnVaciar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnExtraer As Button
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents bModificar As Button
End Class
