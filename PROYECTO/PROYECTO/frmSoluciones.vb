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
        metCOnexion()
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
        metCOnexion()
        'creamos una fila vacia nueva
        oFila = Dataincidentes.Tables("Incidentes").Rows(i)
        ' agregamos la fila al datset
        llenaFilaSoluciones()
        ' Sincronizamos con el sql
        Adaptadorincidentes.Update(Dataincidentes, "Incidentes")

        MessageBox.Show("Incidentes actualizado correctamente!!!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Limpiar()
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
        dtpFechaIncidencia.Value = Convert.ToDateTime(oFila("Fecha"))
        txtdescripcion.Text = oFila("Descripcion")
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        metCOnexion()
        i = i - 1
        Try
            oFila = Dataincidentes.Tables("Incidentes").Rows(i)
            cargarDatos()
        Catch ex As IndexOutOfRangeException
            MessageBox.Show("Registro Inicial", "Inicial", MessageBoxButtons.OK, MessageBoxIcon.Information)
            i = i + 1
        End Try
    End Sub

    Sub llenaFilaSoluciones()
        'llenamos uno a uno las celdas de la fila
        Try
            'oFila("Tipo") = cbTipo.SelectedItem
            'oFila("Departamento") = cbDepartamentos.SelectedValue
            oFila("Usuario") = txtusuario.Text
            oFila("Correo") = txtcorreo.Text
            oFila("Telefono") = txttelefono.Text
            oFila("fecha") = Convert.ToDateTime(dtpFechaIncidencia.Text)
            oFila("Descripcion") = txtdescripcion.Text

            oFila("Tecnico") = txtTecnico.Text
            oFila("Causa") = txtcausa.Text
            oFila("fechas") = Convert.ToDateTime(dtpFecha.Text)
            oFila("Solucion") = txtsolucion.Text
            oFila("horas") = txthoras.Text
            oFila("Status") = cbEstado.SelectedItem
            oFila("ManoObra") = txtmanoo.Text
            oFila("repuesto") = txtcostore.Text
            oFila("Total") = txttotal.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, " Alerta!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmSoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbEstado.SelectedIndex = 0
    End Sub

    Sub Limpiar()
        txttipo.Clear()
        txtdepartamento.Clear()
        txtusuario.Clear()
        txtcorreo.Clear()
        txttelefono.Clear()
        dtpFechaIncidencia.Value = DateTime.Now()
        txtdescripcion.Clear()

        txtTecnico.Clear()
        txtcausa.Clear()
        dtpFecha.Value = DateTime.Now()
        txthoras.Clear()
        txtcostore.Clear()
        cbEstado.SelectedIndex = 0
        txtmanoo.Clear()
        txttotal.Clear()
    End Sub

    Private Sub cbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEstado.SelectedIndexChanged
        Try
            Dim estado As Integer
            Dim mano, horas, costo, total As Double
            horas = txthoras.Text()
            costo = txtcostore.Text()

            estado = cbEstado.SelectedIndex
            If (estado = 1) Then
                mano = horas * 5000

                total = mano + costo
                txtmanoo.Text = mano
                txttotal.Text() = total
            Else
                txtmanoo.Text = 0
                txttotal.Text() = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, " Alerta!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        Dim incidencia As Integer
        Try
            incidencia = txtIncidencia.Text

            metCOnexion()
            oFila = Dataincidentes.Tables("Incidentes").Rows(incidencia)
            cargarDatos()
        Catch ex As Exception
            MessageBox.Show("Ingrese un número de incidencia válido", " Alerta!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub


End Class