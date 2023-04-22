Public Class frmMenu

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim logOpcion As DialogResult
        logOpcion = MessageBox.Show("Desea salir del sistema?", " Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If logOpcion = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub frmMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim logOpcion As DialogResult
        logOpcion = MessageBox.Show("Desea salir del sistema?", " Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If logOpcion = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub IncidentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncidentesToolStripMenuItem.Click

    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Dim logOpcion As DialogResult
        logOpcion = MessageBox.Show("Desea salir del sistema?", " Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If logOpcion = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub IncidentesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IncidentesToolStripMenuItem1.Click
        Me.Hide()
        frmIncidentes.Show()
        frmIncidentes.Departamentos()
        frmIncidentes.Tipos()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click

    End Sub

    Private Sub ReporteDeIncidentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeIncidentesToolStripMenuItem.Click

    End Sub

    Private Sub DepartamentosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DepartamentosToolStripMenuItem1.Click

    End Sub
    Private Sub DepartamentosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DepartamentosToolStripMenuItem2.Click
        Me.Hide()
        frmDepartamentos.Show()
    End Sub

    Private Sub SolucionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolucionesToolStripMenuItem.Click
        Me.Hide()
        frmSoluciones.Show()
    End Sub
End Class