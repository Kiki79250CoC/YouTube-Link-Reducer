Public Class MainForm

    ' Window Load

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    ' Step 1 Buttons

    ' "Paste from Clipboard" button
    ' It will just paste the link from the Windows Clipboard to the textbox.

    Private Sub PasteLinkBtn_Click(sender As Object, e As EventArgs) Handles PasteLinkBtn.Click

        Step1_TextBox.Text = My.Computer.Clipboard.GetText

    End Sub

    ' "Reduce link" button.
    ' It will just replace the "youtube.com/watch?v=" part of the link by "youtu.be" one used for short YouTube links.

    Private Sub ReduceLinkBtn_Click(sender As Object, e As EventArgs) Handles ReduceLinkBtn.Click

        Step2_TextBox.Text = Step1_TextBox.Text.Replace("https://www.youtube.com/watch?v=", "https://youtu.be/").Trim()

    End Sub

    ' Step 2 Buttons

    ' "Copy to clipboard" button
    ' It will just copy the result to the Windows Clipboard.

    Private Sub CopyLinkBtn_Click(sender As Object, e As EventArgs) Handles CopyLinkBtn.Click

        My.Computer.Clipboard.SetText(Step2_TextBox.Text)

    End Sub

    ' Other buttons

    ' "About" menu button
    ' It will just opens the "About YouTube Link Reducer" window.

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        Dim AboutModal As New AboutForm
        AboutModal.ShowDialog()

    End Sub

End Class
