Public Class Form1

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        ' Ruta del archivo de texto
        Dim rutaArchivo As String = "C:\Users\alumnos.republica\Desktop\Estudiantes.txt"

        Try
            ' Verifica si el archivo existe
            If System.IO.File.Exists(rutaArchivo) Then
                ' Lee el contenido del archivo
                Dim contenido As String = System.IO.File.ReadAllText(rutaArchivo)
                ' Muestra el contenido en el TextBox
                txtContenido.Text = contenido

                ' Muestra un mensaje indicando que el archivo fue encontrado y cargado
                MessageBox.Show("El archivo fue encontrado y cargado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Muestra un mensaje indicando que el archivo no fue encontrado
                MessageBox.Show("El archivo no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Muestra un mensaje de error en caso de excepción
            MessageBox.Show("Error al cargar el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
