<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncidentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncidentesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolucionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeIncidentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.IncidentesToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem1})
        Me.InicioToolStripMenuItem.Image = Global.PROYECTO.My.Resources.Resources.abrir_documento__1_
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.InicioToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Image = Global.PROYECTO.My.Resources.Resources.cerrar_sesion
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'IncidentesToolStripMenuItem
        '
        Me.IncidentesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncidentesToolStripMenuItem1, Me.SolucionesToolStripMenuItem, Me.TiposToolStripMenuItem})
        Me.IncidentesToolStripMenuItem.Image = Global.PROYECTO.My.Resources.Resources.verificar
        Me.IncidentesToolStripMenuItem.Name = "IncidentesToolStripMenuItem"
        Me.IncidentesToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.IncidentesToolStripMenuItem.Text = "Registros"
        '
        'IncidentesToolStripMenuItem1
        '
        Me.IncidentesToolStripMenuItem1.Image = Global.PROYECTO.My.Resources.Resources.advertencia
        Me.IncidentesToolStripMenuItem1.Name = "IncidentesToolStripMenuItem1"
        Me.IncidentesToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.IncidentesToolStripMenuItem1.Text = "Incidentes"
        '
        'SolucionesToolStripMenuItem
        '
        Me.SolucionesToolStripMenuItem.Image = Global.PROYECTO.My.Resources.Resources.cierre_de_emergencia
        Me.SolucionesToolStripMenuItem.Name = "SolucionesToolStripMenuItem"
        Me.SolucionesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SolucionesToolStripMenuItem.Text = "Cierres"
        '
        'TiposToolStripMenuItem
        '
        Me.TiposToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiposToolStripMenuItem1, Me.DepartamentosToolStripMenuItem2})
        Me.TiposToolStripMenuItem.Image = Global.PROYECTO.My.Resources.Resources.folleto
        Me.TiposToolStripMenuItem.Name = "TiposToolStripMenuItem"
        Me.TiposToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TiposToolStripMenuItem.Text = "Catálogos"
        '
        'TiposToolStripMenuItem1
        '
        Me.TiposToolStripMenuItem1.Name = "TiposToolStripMenuItem1"
        Me.TiposToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.TiposToolStripMenuItem1.Text = "Tipos"
        '
        'DepartamentosToolStripMenuItem2
        '
        Me.DepartamentosToolStripMenuItem2.Name = "DepartamentosToolStripMenuItem2"
        Me.DepartamentosToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.DepartamentosToolStripMenuItem2.Text = "Departamentos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDeIncidentesToolStripMenuItem, Me.DepartamentosToolStripMenuItem1})
        Me.ReportesToolStripMenuItem.Image = Global.PROYECTO.My.Resources.Resources.file
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.ReportesToolStripMenuItem.Text = "Consultas"
        Me.ReportesToolStripMenuItem.Visible = False
        '
        'ReporteDeIncidentesToolStripMenuItem
        '
        Me.ReporteDeIncidentesToolStripMenuItem.Name = "ReporteDeIncidentesToolStripMenuItem"
        Me.ReporteDeIncidentesToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ReporteDeIncidentesToolStripMenuItem.Text = "Tipos"
        '
        'DepartamentosToolStripMenuItem1
        '
        Me.DepartamentosToolStripMenuItem1.Name = "DepartamentosToolStripMenuItem1"
        Me.DepartamentosToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.DepartamentosToolStripMenuItem1.Text = "departamentos"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.BackgroundImage = CType(resources.GetObject("FlowLayoutPanel1.BackgroundImage"), System.Drawing.Image)
        Me.FlowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(800, 426)
        Me.FlowLayoutPanel1.TabIndex = 3
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmMenu"
        Me.Text = "Menú"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncidentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents IncidentesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SolucionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeIncidentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TiposToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem2 As ToolStripMenuItem
End Class
