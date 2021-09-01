<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AboutForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AppTitle_Label = New System.Windows.Forms.Label()
        Me.AppVersion_Label = New System.Windows.Forms.Label()
        Me.AppCopyright_Label = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AppTitle_Label
        '
        Me.AppTitle_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppTitle_Label.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppTitle_Label.Location = New System.Drawing.Point(12, 5)
        Me.AppTitle_Label.Name = "AppTitle_Label"
        Me.AppTitle_Label.Size = New System.Drawing.Size(332, 24)
        Me.AppTitle_Label.TabIndex = 0
        Me.AppTitle_Label.Text = "YouTube Link Reducer"
        Me.AppTitle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AppVersion_Label
        '
        Me.AppVersion_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppVersion_Label.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppVersion_Label.Location = New System.Drawing.Point(12, 28)
        Me.AppVersion_Label.Name = "AppVersion_Label"
        Me.AppVersion_Label.Size = New System.Drawing.Size(332, 20)
        Me.AppVersion_Label.TabIndex = 1
        Me.AppVersion_Label.Text = "Version"
        Me.AppVersion_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AppCopyright_Label
        '
        Me.AppCopyright_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppCopyright_Label.Location = New System.Drawing.Point(12, 65)
        Me.AppCopyright_Label.Name = "AppCopyright_Label"
        Me.AppCopyright_Label.Size = New System.Drawing.Size(332, 13)
        Me.AppCopyright_Label.TabIndex = 2
        Me.AppCopyright_Label.Text = "Copyright © 2014-2021 - •••Kiki79250•••"
        Me.AppCopyright_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CloseBtn
        '
        Me.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CloseBtn.Location = New System.Drawing.Point(141, 87)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(75, 23)
        Me.CloseBtn.TabIndex = 3
        Me.CloseBtn.Text = "OK"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 118)
        Me.ControlBox = False
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.AppCopyright_Label)
        Me.Controls.Add(Me.AppTitle_Label)
        Me.Controls.Add(Me.AppVersion_Label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AboutForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About YouTube link Reducer"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AppTitle_Label As System.Windows.Forms.Label
    Friend WithEvents AppVersion_Label As System.Windows.Forms.Label
    Friend WithEvents AppCopyright_Label As System.Windows.Forms.Label
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
End Class
