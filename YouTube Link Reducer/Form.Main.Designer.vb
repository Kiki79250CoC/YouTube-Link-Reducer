<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Step1_TextBox = New System.Windows.Forms.TextBox()
        Me.Step2_TextBox = New System.Windows.Forms.TextBox()
        Me.Step1_Label = New System.Windows.Forms.Label()
        Me.Step2_Label = New System.Windows.Forms.Label()
        Me.ReduceLinkBtn = New System.Windows.Forms.Button()
        Me.CopyLinkBtn = New System.Windows.Forms.Button()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteLinkBtn = New System.Windows.Forms.Button()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Step1_TextBox
        '
        Me.Step1_TextBox.Location = New System.Drawing.Point(12, 42)
        Me.Step1_TextBox.Name = "Step1_TextBox"
        Me.Step1_TextBox.Size = New System.Drawing.Size(460, 20)
        Me.Step1_TextBox.TabIndex = 0
        '
        'Step2_TextBox
        '
        Me.Step2_TextBox.Location = New System.Drawing.Point(12, 114)
        Me.Step2_TextBox.Name = "Step2_TextBox"
        Me.Step2_TextBox.Size = New System.Drawing.Size(460, 20)
        Me.Step2_TextBox.TabIndex = 1
        '
        'Step1_Label
        '
        Me.Step1_Label.AutoSize = True
        Me.Step1_Label.Location = New System.Drawing.Point(12, 24)
        Me.Step1_Label.Name = "Step1_Label"
        Me.Step1_Label.Size = New System.Drawing.Size(118, 13)
        Me.Step1_Label.TabIndex = 2
        Me.Step1_Label.Text = "Paste original long link :"
        '
        'Step2_Label
        '
        Me.Step2_Label.AutoSize = True
        Me.Step2_Label.Location = New System.Drawing.Point(12, 96)
        Me.Step2_Label.Name = "Step2_Label"
        Me.Step2_Label.Size = New System.Drawing.Size(76, 13)
        Me.Step2_Label.TabIndex = 3
        Me.Step2_Label.Text = "Reduced link :"
        '
        'ReduceLinkBtn
        '
        Me.ReduceLinkBtn.Location = New System.Drawing.Point(367, 68)
        Me.ReduceLinkBtn.Name = "ReduceLinkBtn"
        Me.ReduceLinkBtn.Size = New System.Drawing.Size(106, 23)
        Me.ReduceLinkBtn.TabIndex = 4
        Me.ReduceLinkBtn.Text = "Reduce link"
        Me.ReduceLinkBtn.UseVisualStyleBackColor = True
        '
        'CopyLinkBtn
        '
        Me.CopyLinkBtn.Location = New System.Drawing.Point(299, 140)
        Me.CopyLinkBtn.Name = "CopyLinkBtn"
        Me.CopyLinkBtn.Size = New System.Drawing.Size(174, 23)
        Me.CopyLinkBtn.TabIndex = 5
        Me.CopyLinkBtn.Text = "Copy to Clipboard"
        Me.CopyLinkBtn.UseVisualStyleBackColor = True
        '
        'MenuBar
        '
        Me.MenuBar.BackColor = System.Drawing.Color.Transparent
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(484, 24)
        Me.MenuBar.TabIndex = 6
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AboutToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'PasteLinkBtn
        '
        Me.PasteLinkBtn.Location = New System.Drawing.Point(187, 68)
        Me.PasteLinkBtn.Name = "PasteLinkBtn"
        Me.PasteLinkBtn.Size = New System.Drawing.Size(174, 23)
        Me.PasteLinkBtn.TabIndex = 4
        Me.PasteLinkBtn.Text = "Paste from Clipboard"
        Me.PasteLinkBtn.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 175)
        Me.Controls.Add(Me.Step2_Label)
        Me.Controls.Add(Me.CopyLinkBtn)
        Me.Controls.Add(Me.PasteLinkBtn)
        Me.Controls.Add(Me.Step2_TextBox)
        Me.Controls.Add(Me.ReduceLinkBtn)
        Me.Controls.Add(Me.Step1_Label)
        Me.Controls.Add(Me.Step1_TextBox)
        Me.Controls.Add(Me.MenuBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuBar
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YouTube Link Reducer"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Step1_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Step2_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Step1_Label As System.Windows.Forms.Label
    Friend WithEvents Step2_Label As System.Windows.Forms.Label
    Friend WithEvents ReduceLinkBtn As System.Windows.Forms.Button
    Friend WithEvents CopyLinkBtn As System.Windows.Forms.Button
    Friend WithEvents MenuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteLinkBtn As Button
End Class
