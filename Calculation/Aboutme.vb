Imports System.Diagnostics

Public Class Aboutme
    Private Sub Aboutme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = MainActivity.Icon
    End Sub

    Private Sub LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel.LinkClicked
        Process.Start(New ProcessStartInfo With {
        .FileName = "https://github.com/SlimStar-CN",
        .UseShellExecute = True})
    End Sub
End Class