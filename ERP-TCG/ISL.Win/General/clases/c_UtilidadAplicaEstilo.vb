Public Class c_UtilidadAplicaEstilo

    Friend Shared Sub LoadStyleFromResource(ByVal resourceName As String)

        Dim stream As System.IO.Stream = GetType(c_UtilidadAplicaEstilo).Module.Assembly.GetManifestResourceStream(GetType(c_UtilidadAplicaEstilo), resourceName)

        If (Not stream Is Nothing) Then
            Infragistics.Win.AppStyling.StyleManager.Load(stream)
        End If
    End Sub

End Class
