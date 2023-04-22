Imports System.Data.SqlClient
Public Class frmTipos

    Dim AdaptadorTipos As SqlDataAdapter
    Dim DataTipos As New DataSet
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
        AdaptadorTipos = New SqlDataAdapter("select * from tipos", conexionDepartamentos)
        ' PAra ejecutar comendos sql
        Dim Command As SqlCommandBuilder = New SqlCommandBuilder(AdaptadorTipos)

        'Creamos datset
        DataTipos = New DataSet
        'llenamos el data set
        AdaptadorTipos.Fill(DataTipos, "tipos")
        '--------------------------

        'MessageBox.Show("Conexion exitosa!!!", " Conexion ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        conexionDepartamentos.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        conexionBD()
        'creamos una fila vacia nueva
        oFila = DataTipos.Tables("tipos").NewRow()
        ' agregamos la fila al datset
        llenaFilaTipos()

        DataTipos.Tables("tipos").Rows.Add(oFila)
        ' Sincronizamos con el sql
        AdaptadorTipos.Update(DataTipos, "tipos")

        MessageBox.Show("Departamentos almacenados correctamente!!", "Almacenar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtNombre.Clear()
        txtCodigo.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim logOpcion As DialogResult
        logOpcion = MessageBox.Show("Desea volver al menú principal?", " Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If logOpcion = DialogResult.Yes Then
            Me.Hide()
            frmMenu.Show()
        End If
    End Sub

    Sub llenaFilaTipos()
        'llenamos uno a uno las celdas de la fila
        oFila("Descripcion") = txtNombre.Text
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim logOpcion As DialogResult
        logOpcion = MessageBox.Show("Desea modificar los tipos?", " Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If logOpcion = DialogResult.Yes Then
            conexionBD()
            'creamos una fila vacia nueva
            oFila = DataTipos.Tables("tipos").Rows(i)
            ' agregamos la fila al datset
            llenaFilaTipos()

            ' Sincronizamos con el sql
            AdaptadorTipos.Update(DataTipos, "tipos")

            MessageBox.Show("Tipos actualizado correctamente!!!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombre.Clear()
            txtCodigo.Clear()
        End If
    End Sub

    Private Sub brnEliminar_Click(sender As Object, e As EventArgs) Handles brnEliminar.Click
        Dim logOpcion As DialogResult
        logOpcion = MessageBox.Show("Desea eliminar los tipos?", " Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If logOpcion = DialogResult.Yes Then
            conexionBD()
            'creamos una fila vacia nueva
            oFila = DataTipos.Tables("tipos").Rows(i)
            ' agregamos la fila al datset
            oFila.Delete()

            ' Sincronizamos con el sql
            AdaptadorTipos.Update(DataTipos, "tipos")

            MessageBox.Show("Registros Eliminados", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAtras.PerformClick()
            txtNombre.Clear()
            txtCodigo.Clear()
        End If
    End Sub

    Private Sub btnAdelante_Click(sender As Object, e As EventArgs) Handles btnAdelante.Click
        conexionBD()
        i = i + 1
        Try
            oFila = DataTipos.Tables("tipos").Rows(i)
            cargarTxt()
        Catch ex As IndexOutOfRangeException
            MessageBox.Show("Registro Final", "Final", MessageBoxButtons.OK, MessageBoxIcon.Information)
            i = i - 1
        End Try
    End Sub

    Sub cargarTxt()
        txtCodigo.Text = oFila("id")
        txtNombre.Text = oFila("Descripcion")
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        conexionBD()
        i = i - 1
        Try
            oFila = DataTipos.Tables("tipos").Rows(i)
            cargarTxt()
        Catch ex As IndexOutOfRangeException
            MessageBox.Show("Registro Inicial", "Inicial", MessageBoxButtons.OK, MessageBoxIcon.Information)
            i = i + 1
        End Try
    End Sub
End Class