<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Metodo_biseccion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lx0 = New System.Windows.Forms.Label()
        Me.ldf = New System.Windows.Forms.Label()
        Me.lcs = New System.Windows.Forms.Label()
        Me.lf = New System.Windows.Forms.Label()
        Me.tx0 = New System.Windows.Forms.TextBox()
        Me.tdf = New System.Windows.Forms.TextBox()
        Me.tcs = New System.Windows.Forms.TextBox()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lResultado = New System.Windows.Forms.Label()
        CType(Me.salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lx0
        '
        Me.lx0.AutoSize = True
        Me.lx0.Location = New System.Drawing.Point(104, 34)
        Me.lx0.Name = "lx0"
        Me.lx0.Size = New System.Drawing.Size(49, 13)
        Me.lx0.TabIndex = 0
        Me.lx0.Text = "Dame x0"
        '
        'ldf
        '
        Me.ldf.AutoSize = True
        Me.ldf.Location = New System.Drawing.Point(104, 137)
        Me.ldf.Name = "ldf"
        Me.ldf.Size = New System.Drawing.Size(154, 13)
        Me.ldf.TabIndex = 1
        Me.ldf.Text = "Dame la derivada de la función"
        '
        'lcs
        '
        Me.lcs.AutoSize = True
        Me.lcs.Location = New System.Drawing.Point(104, 67)
        Me.lcs.Name = "lcs"
        Me.lcs.Size = New System.Drawing.Size(126, 13)
        Me.lcs.TabIndex = 2
        Me.lcs.Text = "Dame cifras significativas"
        '
        'lf
        '
        Me.lf.AutoSize = True
        Me.lf.Location = New System.Drawing.Point(104, 103)
        Me.lf.Name = "lf"
        Me.lf.Size = New System.Drawing.Size(73, 13)
        Me.lf.TabIndex = 3
        Me.lf.Text = "Dame función"
        '
        'tx0
        '
        Me.tx0.Location = New System.Drawing.Point(258, 31)
        Me.tx0.Name = "tx0"
        Me.tx0.Size = New System.Drawing.Size(100, 20)
        Me.tx0.TabIndex = 4
        '
        'tdf
        '
        Me.tdf.Location = New System.Drawing.Point(258, 134)
        Me.tdf.Name = "tdf"
        Me.tdf.Size = New System.Drawing.Size(100, 20)
        Me.tdf.TabIndex = 5
        '
        'tcs
        '
        Me.tcs.Location = New System.Drawing.Point(258, 64)
        Me.tcs.Name = "tcs"
        Me.tcs.Size = New System.Drawing.Size(100, 20)
        Me.tcs.TabIndex = 6
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(258, 100)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(100, 20)
        Me.tf.TabIndex = 7
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(463, 127)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 8
        Me.Calcular.Text = "&Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(463, 174)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 9
        Me.Salir.Text = "&Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'salida
        '
        Me.salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column8})
        Me.salida.Location = New System.Drawing.Point(77, 204)
        Me.salida.Name = "salida"
        Me.salida.Size = New System.Drawing.Size(333, 150)
        Me.salida.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "Iteración i"
        Me.Column1.Name = "Column1"
        '
        'Column3
        '
        Me.Column3.HeaderText = "x(i)"
        Me.Column3.Name = "Column3"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Error"
        Me.Column8.Name = "Column8"
        '
        'lResultado
        '
        Me.lResultado.AutoSize = True
        Me.lResultado.Location = New System.Drawing.Point(74, 391)
        Me.lResultado.Name = "lResultado"
        Me.lResultado.Size = New System.Drawing.Size(0, 13)
        Me.lResultado.TabIndex = 11
        '
        'Metodo_biseccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 484)
        Me.Controls.Add(Me.lResultado)
        Me.Controls.Add(Me.salida)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.tcs)
        Me.Controls.Add(Me.tdf)
        Me.Controls.Add(Me.tx0)
        Me.Controls.Add(Me.lf)
        Me.Controls.Add(Me.lcs)
        Me.Controls.Add(Me.ldf)
        Me.Controls.Add(Me.lx0)
        Me.Name = "Metodo_biseccion"
        Me.Text = "Método de Newton-Raphson"
        CType(Me.salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lx0 As Label
    Friend WithEvents ldf As Label
    Friend WithEvents lcs As Label
    Friend WithEvents lf As Label
    Friend WithEvents tx0 As TextBox
    Friend WithEvents tdf As TextBox
    Friend WithEvents tcs As TextBox
    Friend WithEvents tf As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Salir As Button
    Friend WithEvents salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents lResultado As Label
End Class
