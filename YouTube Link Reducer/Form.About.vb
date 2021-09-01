Public Class AboutForm

    ' Window load
    ' Inserts AppVersion string from My.Resources in the AppVersion_Label text.

    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppVersion_Label.Text += $" {My.Resources.AppVersion}"
    End Sub

    ' Close button

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Close()
    End Sub

End Class