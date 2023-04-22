Imports System.Data.SqlClient
Public Class frmDepartamentos

    Dim AdaptadorDepartamentos As SqlDataAdapter
    Dim DataDepartamentos As New DataSet
    Dim oFila As DataRow
    Dim i As Integer


    'METODO PARA CONECTARSE CON LA BASE DE DATOS'
    Sub conexionBD()
        Dim conexionDepartamentos As SqlConnection = New SqlConnection()
        ' Llenamos varible string, con los datos del string de conexion
        Dim strconexion As String = "data source=DESKTOP-MPLP2PA\SQLEXPRESS;
                       initial catalog=servicios;integrated security=true"
        ' Al objeto conexion le asignamos el string de conexion
        conexionDepartamentos.ConnectionString = strconexion
        'abrimos la conexion, ojo aqui es donde puede fallar si escribimos mal algo en el string de conexion
        conexionDepartamentos.Open()

        '--------------------------
        'LLenamos el adaptador
        AdaptadorDepartamentos = New SqlDataAdapter("select * from departamentos", conexionDepartamentos)
        ' PAra ejecutar comendos sql
        Dim Command As SqlCommandBuilder = New SqlCommandBuilder(AdaptadorDepartamentos)

        'Creamos datset
        DataDepartamentos = New DataSet
        'llenamos el data set
        AdaptadorDepartamentos.Fill(DataDepartamentos, "departamentos")
        '--------------------------

        'MessageBox.Show("Conexion exitosa!!!", " Conexion ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        conexionDepartamentos.Close()
    End Sub



    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim logOpcion As DialogResult
        logOpcion = MessageBox.Show("Desea volver al menú principal?", " Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If logOpcion = DialogResult.Yes Then
            Me.Hide()
            frmMenu.Show()
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCodigo.Clear()
        txtNombre.Clear()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        conexionBD()
        'creamos una fila vacia nueva
        oFila = DataDepartamentos.Tables("departamentos").NewRow()
        ' agregamos la fila al datset
        llenaFilaDepartamentos()

        DataDepartamentos.Tables("departamentos").Rows.Add(oFila)
        ' Sincronizamos con el sql
        AdaptadorDepartamentos.Update(DataDepartamentos, "departamentos")

        MessageBox.Show("Departamentos almacenados correctamente!!", "Almacenar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtNombre.Clear()
    End Sub

    Sub llenaFilaDepartamentos()
        'llenamos uno a uno las celdas de la fila
        oFila("nombre") = txtNombre.Text
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        conexionBD()
        'creamos una fila vacia nueva
        oFila = DataDepartamentos.Tables("departamentos").Rows(i)
        ' agregamos la fila al datset
        llenaFilaDepartamentos()

        ' Sincronizamos con el sql
        AdaptadorDepartamentos.Update(DataDepartamentos, "departamentos")

        MessageBox.Show("Departamento actualizado correctamente!!!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        conexionBD()
        'creamos una fila vacia nueva
        oFila = DataDepartamentos.Tables("departamentos").Rows(i)
        ' agregamos la fila al datset
        oFila.Delete()

        ' Sincronizamos con el sql
        AdaptadorDepartamentos.Update(DataDepartamentos, "departamentos")

        MessageBox.Show("Registros Eliminados", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnAtras.PerformClick()
    End Sub

    Sub cargarTxt()
        txtCodigo.Text = oFila("Id_siesta")
        txtNombre.Text = oFila("nombre")
    End Sub

    Private Sub btnAdelante_Click(sender As Object, e As EventArgs) Handles btnAdelante.Click
        conexionBD()
        i = i + 1
        Try
            oFila = DataDepartamentos.Tables("departamentos").Rows(i)
            cargarTxt()
        Catch ex As IndexOutOfRangeException
            MessageBox.Show("Registro Final", "Final", MessageBoxButtons.OK, MessageBoxIcon.Information)
            i = i - 1
        End Try
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        conexionBD()
        i = i - 1
        Try
            oFila = DataDepartamentos.Tables("departamentos").Rows(i)
            cargarTxt()
        Catch ex As IndexOutOfRangeException
            MessageBox.Show("Registro Inicial", "Inicial", MessageBoxButtons.OK, MessageBoxIcon.Information)
            i = i + 1
        End Try
    End Sub
End Class