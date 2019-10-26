Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos
Imports System.Runtime.Serialization
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_Despacho" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_Despacho.svc o l_Despacho.svc.vb en el Explorador de soluciones e inicie la depuración.

<DataContract(), Serializable()> _
Public Class l_Despacho
    Implements Il_Despacho
    Private odDespacho As New d_Despacho

    Public Function Obtener(oeDespacho As e_Despacho) As e_Despacho Implements Il_Despacho.Obtener
        Try
            oeDespacho = odDespacho.Obtener(oeDespacho)
            Return oeDespacho
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeDespacho As e_Despacho, bolListarDetalles As Boolean) As List(Of e_Despacho) Implements Il_Despacho.Listar
        Try
            Dim loDespacho As List(Of e_Despacho) = odDespacho.Listar(oeDespacho)
            If bolListarDetalles Then
                Dim olDespachoOperacion As New l_DespachoOperaciones
                Dim oeDespachoOperaciones As New e_DespachoOperaciones
                For Each Despacho As e_Despacho In loDespacho
                    With Despacho
                        oeDespachoOperaciones.Dispose()
                        oeDespachoOperaciones.IdDespacho = .Id
                        .ListDespachoOperaciones.AddRange(olDespachoOperacion.Listar(oeDespachoOperaciones))
                    End With
                Next
                olDespachoOperacion = Nothing : oeDespachoOperaciones = Nothing
            End If
            Return loDespacho
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeDespacho As e_Despacho) As Boolean Implements Il_Despacho.Guardar
        Try
            Return odDespacho.Guardar(oeDespacho)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(oeDespacho As e_Despacho) As Boolean Implements Il_Despacho.Eliminar
        Try
            Return odDespacho.Eliminar(oeDespacho)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
