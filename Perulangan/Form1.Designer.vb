<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.AplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProblemBintangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatriksKalkulatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AplikasiToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(792, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'AplikasiToolStripMenuItem
        '
        Me.AplikasiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProblemBintangToolStripMenuItem, Me.MatriksKalkulatorToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.AplikasiToolStripMenuItem.Name = "AplikasiToolStripMenuItem"
        Me.AplikasiToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.AplikasiToolStripMenuItem.Text = "Aplikasi"
        '
        'ProblemBintangToolStripMenuItem
        '
        Me.ProblemBintangToolStripMenuItem.Name = "ProblemBintangToolStripMenuItem"
        Me.ProblemBintangToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ProblemBintangToolStripMenuItem.Text = "Problem Bintang"
        '
        'MatriksKalkulatorToolStripMenuItem
        '
        Me.MatriksKalkulatorToolStripMenuItem.Name = "MatriksKalkulatorToolStripMenuItem"
        Me.MatriksKalkulatorToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.MatriksKalkulatorToolStripMenuItem.Text = "Matriks Kalkulator"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.MenuStrip2)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Perulangan"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents AplikasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProblemBintangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MatriksKalkulatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
