Imports System.IO
Imports System.Reflection
Imports Squirrel

Public Class SquirrelTestingGrounds

    Dim manager As UpdateManager

    Private Async Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Await GetUpdates()
    End Sub

    Private Async Function GetUpdates() As Task

        'Dim mg As New Squirrel.UpdateManager.GitHubUpdateManager("")

        manager = Await UpdateManager.GitHubUpdateManager("https://github.com/DontDoThat21/WinFormsSquirrel")
        Dim mostRecent = manager.CurrentlyInstalledVersion().ToString()

        Dim updateInfo = Await manager.CheckForUpdate()
        If updateInfo.ReleasesToApply.Count > 0 Then
            Await manager.UpdateApp()
        End If


        'If File.Exists("C:\Temp\FabTool\releases\RELEASES") Then

        'Dim lastLine = File.ReadLines("C:\Temp\FabTool\releases\RELEASES").Last()

        'Dim sb As String = ""
        'For index = lastLine.IndexOf("-") + 1 To lastLine.LastIndexOf("-") - 1 ' the first space is when the SHA1 of the Squirrel release format stops. Begin pkg.
        'sb += lastLine(index)
        'Next

        'Me.Text = Assembly.GetExecutingAssembly.GetName().Name

        'Dim version = sb
        'Me.Text += " " + version

        'txtLatestVersion.Text = version

        'End If


    End Function

    Private Sub SquirrelTestingGrounds_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text += " " + Me.GetType.Assembly.GetName.Version.ToString()
        'Dim sqrlApp As Assembly = Assembly.GetExecutingAssembly
        txtCurrentVersion.Text = Me.GetType.Assembly.GetName.Version.ToString()
        txtLatestVersion.Text = "???"

        txtExecLoc.Text = Assembly.GetExecutingAssembly().Location

        timerCheckForUpdate.Start()

    End Sub

    Private Async Sub timerCheckForUpdate_Tick(sender As Object, e As EventArgs) Handles timerCheckForUpdate.Tick
        Await GetUpdates()
    End Sub
End Class
