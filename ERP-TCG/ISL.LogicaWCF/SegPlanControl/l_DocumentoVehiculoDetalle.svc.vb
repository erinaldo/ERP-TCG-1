' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_DocumentoVehiculoDetalle" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_DocumentoVehiculoDetalle.svc o l_DocumentoVehiculoDetalle.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_DocumentoVehiculoDetalle
    Implements Il_DocumentoVehiculoDetalle

    Dim odDocumentoVehiculoDetalle As New d_DocumentoVehiculoDetalle

    Public Function Obtener(ByVal oeDocumentoVehiculoDetalle As e_DocumentoVehiculoDetalle) As e_DocumentoVehiculoDetalle Implements Il_DocumentoVehiculoDetalle.Obtener
        Try
            Return odDocumentoVehiculoDetalle.Obtener(oeDocumentoVehiculoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDocumentoVehiculoDetalle As e_DocumentoVehiculoDetalle) As List(Of e_DocumentoVehiculoDetalle) Implements Il_DocumentoVehiculoDetalle.Listar
        Try
            Return odDocumentoVehiculoDetalle.Listar(oeDocumentoVehiculoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDocumentoVehiculoDetalle As e_DocumentoVehiculoDetalle) As Boolean Implements Il_DocumentoVehiculoDetalle.Validar
        Try
            With oeDocumentoVehiculoDetalle
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeDocumentoVehiculoDetalle As e_DocumentoVehiculoDetalle) As Boolean Implements Il_DocumentoVehiculoDetalle.Guardar
        Try
            If Validar(oeDocumentoVehiculoDetalle) Then
                Return odDocumentoVehiculoDetalle.Guardar(oeDocumentoVehiculoDetalle)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal Lista As List(Of e_DocumentoVehiculoDetalle)) As Boolean Implements Il_DocumentoVehiculoDetalle.Guardar
        Try
            Return odDocumentoVehiculoDetalle.Guardar(Lista)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeDocumentoVehiculoDetalle As e_DocumentoVehiculoDetalle) As Boolean Implements Il_DocumentoVehiculoDetalle.Eliminar
        Try
            Return odDocumentoVehiculoDetalle.Eliminar(oeDocumentoVehiculoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub DoWork() Implements Il_DocumentoVehiculoDetalle.DoWork
    End Sub

End Class
