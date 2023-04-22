Imports System.Data.SqlClient

Public Class frmSoluciones

    Dim Adaptadorincidentes As SqlDataAdapter
    Dim Dataincidentes As New DataSet
    Dim oFila As DataRow
    Dim i As Integer

    Sub metCOnexion()
        Dim conexionincidentes As SqlConnection = New SqlConnection()
        Dim strconexion As String = "data source=DESKTOP-MPLP2PA\SQLEXPRESS;
                       initial catalog=servicios;integrated security=true"
        conexionincidentes.ConnectionString = strconexion
        conexionincidentes.Open()
        '--------------------------
        'LLenamos el adaptador
        Adaptadorincidentes = New SqlDataAdapter("select * from Incidentes", conexionincidentes)
        ' PAra ejecutar comendos sql
        Dim Command As SqlCommandBuilder = New SqlCommandBuilder(Adaptadorincidentes)
        'Creamos datset
        Dataincidentes = New DataSet
        'llenamos el data set
        Adaptadorincidentes.Fill(Dataincidentes, "Incidentes")
        '--------------------------
        'MessageBox.Show("Conexion exitosa!!!", " Conexion ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        conexionincidentes.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnAdelante.Click
        i = i + 1
        Try
            oFila = Dataincidentes.Tables("Incidentes").Rows(i)
            cargarDatos()
        Catch ex As IndexOutOfRangeException
            MessageBox.Show("Registro Final", "Final", MessageBoxButtons.OK, MessageBoxIcon.Information)
            i = i - 1
        End Try
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim logOpcion As DialogResult
        logOpcion = MessageBox.Show("Desea volver al menú principal?", " Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If logOpcion = DialogResult.Yes Then
            Me.Hide()
            frmMenu.Show()
        End If
    End Sub

    Sub cargarDatos()
        txttipo.Text = oFila("Tipo")
        txtdepartamento.Text = oFila("Departamento")
        txtusuario.Text = oFila("Usuario")
        txtcorreo.Text = oFila("Correo")
        txttelefono.Text = oFila("Telefono")
        dtpFecha.Value = Convert.ToDateTime(oFila("Fecha"))
        txtdescripcion.Text = oFila("Descripcion")
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        i = i - 1
        Try
            oFila = Dataincidentes.Tables("Incidentes").Rows(i)
            cargarDatos()
        Catch ex As IndexOutOfRangeException
            MessageBox.Show("Registro Inicial", "Inicial", MessageBoxButtons.OK, MessageBoxIcon.Information)
            i = i + 1
        End Try
    End Sub
End Class