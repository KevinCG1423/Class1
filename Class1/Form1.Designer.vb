<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtContenido = New TextBox()
        btnCargar = New Button()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' txtContenido
        ' 
        txtContenido.Location = New Point(304, 162)
        txtContenido.Name = "txtContenido"
        txtContenido.Size = New Size(100, 23)
        txtContenido.TabIndex = 0
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(304, 94)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(75, 23)
        btnCargar.TabIndex = 1
        btnCargar.Text = "Cargar"
        btnCargar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(276, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 15)
        Label1.TabIndex = 2
        Label1.Text = "Haga click en boton cargar "
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(209, 184)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(8, 23)
        ComboBox1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(btnCargar)
        Controls.Add(txtContenido)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtContenido As TextBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox

End Class
