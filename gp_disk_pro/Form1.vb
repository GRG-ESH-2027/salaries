Public Class Form1

    Private Sub ادخاليوميهجديدهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ادخاليوميهجديدهToolStripMenuItem.Click
        Form_add_gp.MdiParent = Me
        Form_add_gp.Show()
    End Sub

    Private Sub تقريريوميهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تقريريوميهToolStripMenuItem.Click
        Form_report_day.MdiParent = Me
        Form_report_day.Show()
    End Sub
End Class
