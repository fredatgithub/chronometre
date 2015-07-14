<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
    Me.LabelCompteur = New System.Windows.Forms.Label()
    Me.ButtonStart = New System.Windows.Forms.Button()
    Me.ButtonReset = New System.Windows.Forms.Button()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
    Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
    Me.SourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ÀproposdeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.TimerChrono = New System.Windows.Forms.Timer(Me.components)
    Me.MenuStrip1.SuspendLayout
    Me.SuspendLayout
    '
    'LabelCompteur
    '
    Me.LabelCompteur.AutoSize = true
    Me.LabelCompteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.LabelCompteur.Location = New System.Drawing.Point(26, 45)
    Me.LabelCompteur.Name = "LabelCompteur"
    Me.LabelCompteur.Size = New System.Drawing.Size(140, 17)
    Me.LabelCompteur.TabIndex = 5
    Me.LabelCompteur.Text = "00:00:00:0000000"
    '
    'ButtonStart
    '
    Me.ButtonStart.Location = New System.Drawing.Point(103, 85)
    Me.ButtonStart.Name = "ButtonStart"
    Me.ButtonStart.Size = New System.Drawing.Size(75, 23)
    Me.ButtonStart.TabIndex = 4
    Me.ButtonStart.Text = "&Start"
    Me.ButtonStart.UseVisualStyleBackColor = true
    '
    '
    'ButtonReset
    '
    Me.ButtonReset.Location = New System.Drawing.Point(12, 85)
    Me.ButtonReset.Name = "ButtonReset"
    Me.ButtonReset.Size = New System.Drawing.Size(75, 23)
    Me.ButtonReset.TabIndex = 6
    Me.ButtonReset.Text = "&Reset"
    Me.ButtonReset.UseVisualStyleBackColor = true
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.ToolStripMenuItem1, Me.AideToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(198, 24)
    Me.MenuStrip1.TabIndex = 7
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'FichierToolStripMenuItem
    '
    Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem, Me.toolStripSeparator, Me.QuitterToolStripMenuItem})
    Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
    Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
    Me.FichierToolStripMenuItem.Text = "&Fichier"
    '
    'NouveauToolStripMenuItem
    '
    Me.NouveauToolStripMenuItem.Image = CType(resources.GetObject("NouveauToolStripMenuItem.Image"),System.Drawing.Image)
    Me.NouveauToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
    Me.NouveauToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M),System.Windows.Forms.Keys)
    Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
    Me.NouveauToolStripMenuItem.Text = "&Mise à zéro"
    '
    'toolStripSeparator
    '
    Me.toolStripSeparator.Name = "toolStripSeparator"
    Me.toolStripSeparator.Size = New System.Drawing.Size(175, 6)
    '
    'QuitterToolStripMenuItem
    '
    Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
    Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
    Me.QuitterToolStripMenuItem.Text = "&Quitter"
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SourceToolStripMenuItem})
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(70, 20)
    Me.ToolStripMenuItem1.Text = "&Affichage"
    '
    'SourceToolStripMenuItem
    '
    Me.SourceToolStripMenuItem.Name = "SourceToolStripMenuItem"
    Me.SourceToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.SourceToolStripMenuItem.Text = "&Source"
    '
    'AideToolStripMenuItem
    '
    Me.AideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÀproposdeToolStripMenuItem})
    Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
    Me.AideToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
    Me.AideToolStripMenuItem.Text = "&Aide"
    '
    'ÀproposdeToolStripMenuItem
    '
    Me.ÀproposdeToolStripMenuItem.Name = "ÀproposdeToolStripMenuItem"
    Me.ÀproposdeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.ÀproposdeToolStripMenuItem.Text = "À &propos de..."
    '
    'TimerChrono
    '
    Me.TimerChrono.Enabled = true
    Me.TimerChrono.Interval = 1000
    '
    'FormMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(198, 123)
    Me.Controls.Add(Me.LabelCompteur)
    Me.Controls.Add(Me.ButtonStart)
    Me.Controls.Add(Me.ButtonReset)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Name = "FormMain"
    Me.Text = "Chronomètre"
    Me.MenuStrip1.ResumeLayout(false)
    Me.MenuStrip1.PerformLayout
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub
    Friend WithEvents LabelCompteur As System.Windows.Forms.Label
    Friend WithEvents ButtonStart As System.Windows.Forms.Button
    Friend WithEvents ButtonReset As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÀproposdeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerChrono As System.Windows.Forms.Timer

End Class
