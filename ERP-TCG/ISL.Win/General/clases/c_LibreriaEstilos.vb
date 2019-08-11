Imports System.IO
Imports System.ComponentModel

Public Class c_LibreriaEstilos

#Region "Member Variables"

    Private m_fileSystemWatcher As FileSystemWatcher = Nothing
    Private synchronizingObject As ISynchronizeInvoke = Nothing

#End Region

#Region "Constructor"

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <param name="synchronizingObject">An object that can be used to marshal FileSystemWatcher event handler calls.</param>
    Friend Sub New(ByVal synchronizingObject As ISynchronizeInvoke)
        Me.synchronizingObject = synchronizingObject
    End Sub

#End Region

#Region "Properties"

#Region "FileSystemWatcher"

    Private ReadOnly Property FileSystemWatcher() As FileSystemWatcher
        Get

            If (Me.m_fileSystemWatcher Is Nothing) Then

                Me.m_fileSystemWatcher = New FileSystemWatcher()
                'AddHandler Me.FileSystemWatcher.Changed, New FileSystemEventHandler(AddressOf Me.FileSystemWatcher_Changed)

            End If

            Return Me.m_fileSystemWatcher
        End Get
    End Property

#End Region

#End Region

#Region "Methods"

#Region "UpdateStatus"

    ''' <summary>
    ''' Updates the status of the StyleLibraryWatcher
    ''' </summary>
    ''' <param name="fileToWatch">A FileInfo object that references the StyleLibrary file to watch, or Nothing to stop watching.</param>
    Friend Sub UpdateStatus(ByVal fileToWatch As FileInfo)

        ' If there is currently no StyleLibrary selected to watch, turn off file watching.
        If (fileToWatch Is Nothing) Then
            Me.FileSystemWatcher.EnableRaisingEvents = False
            Return
        End If

        ' Setup the FileSystemWatcher object.
        Me.FileSystemWatcher.SynchronizingObject = Me.synchronizingObject
        Me.FileSystemWatcher.NotifyFilter = NotifyFilters.LastWrite
        Me.FileSystemWatcher.Path = fileToWatch.DirectoryName
        Me.FileSystemWatcher.Filter = fileToWatch.Name
        Me.FileSystemWatcher.EnableRaisingEvents = True
    End Sub

#End Region

#End Region

#Region "Event Handlers"

#Region "FileSystemWatcher_Changed"

    Private Sub FileSystemWatcher_Changed(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs)

        ' Load the StyleLibrary that just changed.
        '
        ' Wrap the load in a try/catch for an IO exception.  This exception can occur randomly based
        ' on timing due to the fact that the application that modified the StyleLibrary might not have
        ' closed the file when we try to load it.
        Try
            Infragistics.Win.AppStyling.StyleManager.Load(e.FullPath)
        Catch ex As System.IO.IOException
        End Try
    End Sub

#End Region

#End Region


End Class
