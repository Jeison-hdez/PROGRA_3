<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoluciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSoluciones))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.lblIncidencia = New System.Windows.Forms.Label()
        Me.txtIncidencia = New System.Windows.Forms.TextBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.dtpFechaIncidencia = New System.Windows.Forms.DateTimePicker()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnAdelante = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtmanoo = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcausa = New System.Windows.Forms.TextBox()
        Me.txtTecnico = New System.Windows.Forms.TextBox()
        Me.txtcostore = New System.Windows.Forms.TextBox()
        Me.txthoras = New System.Windows.Forms.TextBox()
        Me.txtsolucion = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.cbDepartamentos = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackgroundImage = Global.PROYECTO.My.Resources.Resources.Imagen_de_WhatsApp_2023_04_19_a_las_21_011
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(959, 450)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.cbDepartamentos)
        Me.Panel2.Controls.Add(Me.cbTipo)
        Me.Panel2.Controls.Add(Me.btnConsulta)
        Me.Panel2.Controls.Add(Me.lblIncidencia)
        Me.Panel2.Controls.Add(Me.txtIncidencia)
        Me.Panel2.Controls.Add(Me.cbEstado)
        Me.Panel2.Controls.Add(Me.dtpFechaIncidencia)
        Me.Panel2.Controls.Add(Me.txtdescripcion)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtusuario)
        Me.Panel2.Controls.Add(Me.txtcorreo)
        Me.Panel2.Controls.Add(Me.txttelefono)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnAtras)
        Me.Panel2.Controls.Add(Me.dtpFecha)
        Me.Panel2.Controls.Add(Me.btnAdelante)
        Me.Panel2.Controls.Add(Me.btnmodificar)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtmanoo)
        Me.Panel2.Controls.Add(Me.btnVolver)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtcausa)
        Me.Panel2.Controls.Add(Me.txtTecnico)
        Me.Panel2.Controls.Add(Me.txtcostore)
        Me.Panel2.Controls.Add(Me.txthoras)
        Me.Panel2.Controls.Add(Me.txtsolucion)
        Me.Panel2.Controls.Add(Me.txttotal)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(30, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(881, 379)
        Me.Panel2.TabIndex = 0
        '
        'btnConsulta
        '
        Me.btnConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsulta.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsulta.ForeColor = System.Drawing.Color.White
        Me.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsulta.Location = New System.Drawing.Point(728, 180)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(124, 34)
        Me.btnConsulta.TabIndex = 79
        Me.btnConsulta.Text = "Consultar"
        Me.btnConsulta.UseVisualStyleBackColor = False
        '
        'lblIncidencia
        '
        Me.lblIncidencia.AutoSize = True
        Me.lblIncidencia.BackColor = System.Drawing.Color.Transparent
        Me.lblIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncidencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblIncidencia.Location = New System.Drawing.Point(15, 16)
        Me.lblIncidencia.Name = "lblIncidencia"
        Me.lblIncidencia.Size = New System.Drawing.Size(96, 20)
        Me.lblIncidencia.TabIndex = 77
        Me.lblIncidencia.Text = "Incidencia:"
        '
        'txtIncidencia
        '
        Me.txtIncidencia.Location = New System.Drawing.Point(114, 18)
        Me.txtIncidencia.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIncidencia.Name = "txtIncidencia"
        Me.txtIncidencia.Size = New System.Drawing.Size(181, 20)
        Me.txtIncidencia.TabIndex = 78
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"Seleccione", "Cerrado", "En Proceso", "Espera de parte", "Espera de Usuario"})
        Me.cbEstado.Location = New System.Drawing.Point(525, 236)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(162, 21)
        Me.cbEstado.TabIndex = 76
        '
        'dtpFechaIncidencia
        '
        Me.dtpFechaIncidencia.Enabled = False
        Me.dtpFechaIncidencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIncidencia.Location = New System.Drawing.Point(102, 253)
        Me.dtpFechaIncidencia.Name = "dtpFechaIncidencia"
        Me.dtpFechaIncidencia.Size = New System.Drawing.Size(193, 20)
        Me.dtpFechaIncidencia.TabIndex = 75
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(124, 292)
        Me.txtdescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdescripcion.MaxLength = 1000
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.ReadOnly = True
        Me.txtdescripcion.Size = New System.Drawing.Size(171, 20)
        Me.txtdescripcion.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(15, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Descripcion :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(15, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Tipo :"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(102, 131)
        Me.txtusuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtusuario.MaxLength = 50
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.ReadOnly = True
        Me.txtusuario.Size = New System.Drawing.Size(193, 20)
        Me.txtusuario.TabIndex = 69
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(115, 174)
        Me.txtcorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcorreo.MaxLength = 50
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.ReadOnly = True
        Me.txtcorreo.Size = New System.Drawing.Size(180, 20)
        Me.txtcorreo.TabIndex = 70
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(102, 220)
        Me.txttelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.txttelefono.MaxLength = 10
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.ReadOnly = True
        Me.txttelefono.Size = New System.Drawing.Size(193, 20)
        Me.txttelefono.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(15, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 20)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Departamento :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(15, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 20)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Usuario :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(15, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Correo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(15, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Telefono :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(15, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Fecha :"
        '
        'btnAtras
        '
        Me.btnAtras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtras.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.ForeColor = System.Drawing.Color.White
        Me.btnAtras.Image = CType(resources.GetObject("btnAtras.Image"), System.Drawing.Image)
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(728, 81)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(124, 34)
        Me.btnAtras.TabIndex = 51
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(491, 86)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(196, 20)
        Me.dtpFecha.TabIndex = 50
        '
        'btnAdelante
        '
        Me.btnAdelante.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdelante.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAdelante.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdelante.ForeColor = System.Drawing.Color.White
        Me.btnAdelante.Image = CType(resources.GetObject("btnAdelante.Image"), System.Drawing.Image)
        Me.btnAdelante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdelante.Location = New System.Drawing.Point(728, 34)
        Me.btnAdelante.Name = "btnAdelante"
        Me.btnAdelante.Size = New System.Drawing.Size(124, 34)
        Me.btnAdelante.TabIndex = 44
        Me.btnAdelante.Text = "Adelante"
        Me.btnAdelante.UseVisualStyleBackColor = False
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.Color.White
        Me.btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), System.Drawing.Image)
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodificar.Location = New System.Drawing.Point(728, 129)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(124, 34)
        Me.btnmodificar.TabIndex = 49
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(392, 194)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(167, 20)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Costo de repuesto :"
        '
        'txtmanoo
        '
        Me.txtmanoo.Location = New System.Drawing.Point(503, 280)
        Me.txtmanoo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmanoo.Name = "txtmanoo"
        Me.txtmanoo.ReadOnly = True
        Me.txtmanoo.Size = New System.Drawing.Size(184, 20)
        Me.txtmanoo.TabIndex = 48
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVolver.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(728, 323)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(124, 34)
        Me.btnVolver.TabIndex = 29
        Me.btnVolver.Text = "Volver a menu"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(392, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 20)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Tecnico :"
        '
        'txtcausa
        '
        Me.txtcausa.Location = New System.Drawing.Point(491, 50)
        Me.txtcausa.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcausa.Name = "txtcausa"
        Me.txtcausa.Size = New System.Drawing.Size(196, 20)
        Me.txtcausa.TabIndex = 38
        '
        'txtTecnico
        '
        Me.txtTecnico.Location = New System.Drawing.Point(491, 20)
        Me.txtTecnico.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTecnico.Name = "txtTecnico"
        Me.txtTecnico.Size = New System.Drawing.Size(196, 20)
        Me.txtTecnico.TabIndex = 37
        '
        'txtcostore
        '
        Me.txtcostore.Location = New System.Drawing.Point(582, 196)
        Me.txtcostore.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcostore.Name = "txtcostore"
        Me.txtcostore.Size = New System.Drawing.Size(105, 20)
        Me.txtcostore.TabIndex = 43
        '
        'txthoras
        '
        Me.txthoras.Location = New System.Drawing.Point(496, 160)
        Me.txthoras.Margin = New System.Windows.Forms.Padding(2)
        Me.txthoras.Name = "txthoras"
        Me.txthoras.Size = New System.Drawing.Size(191, 20)
        Me.txthoras.TabIndex = 41
        '
        'txtsolucion
        '
        Me.txtsolucion.Location = New System.Drawing.Point(496, 129)
        Me.txtsolucion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtsolucion.Name = "txtsolucion"
        Me.txtsolucion.Size = New System.Drawing.Size(191, 20)
        Me.txtsolucion.TabIndex = 40
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(467, 339)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(220, 20)
        Me.txttotal.TabIndex = 45
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(392, 337)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 20)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Total :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(392, 280)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 20)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Manoobra :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(392, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 20)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Causa :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(392, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 20)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "FechaS :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(392, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 20)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Solucion :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(392, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 20)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Horas :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(392, 236)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(127, 20)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Nuevo Status :"
        '
        'cbTipo
        '
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(102, 48)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(193, 21)
        Me.cbTipo.TabIndex = 80
        '
        'cbDepartamentos
        '
        Me.cbDepartamentos.FormattingEnabled = True
        Me.cbDepartamentos.Location = New System.Drawing.Point(155, 88)
        Me.cbDepartamentos.Name = "cbDepartamentos"
        Me.cbDepartamentos.Size = New System.Drawing.Size(140, 21)
        Me.cbDepartamentos.TabIndex = 81
        '
        'frmSoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSoluciones"
        Me.Text = "frmSoluciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAdelante As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtmanoo As TextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcausa As TextBox
    Friend WithEvents txtTecnico As TextBox
    Friend WithEvents txtcostore As TextBox
    Friend WithEvents txthoras As TextBox
    Friend WithEvents txtsolucion As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnAtras As Button
    Friend WithEvents dtpFechaIncidencia As DateTimePicker
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents btnConsulta As Button
    Friend WithEvents lblIncidencia As Label
    Friend WithEvents txtIncidencia As TextBox
    Friend WithEvents cbDepartamentos As ComboBox
    Friend WithEvents cbTipo As ComboBox
End Class
