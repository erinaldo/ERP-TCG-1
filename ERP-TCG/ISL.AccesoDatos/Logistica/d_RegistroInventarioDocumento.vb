'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_RegistroInventarioDocumento
    Private sqlhelper As New SqlHelper

    Public Function Guardar(ByVal lstRegistroInventarioDoc As List(Of e_RegistroInventarioDocumento)) As Boolean
        Try
            Using transScope As New TransactionScope()
                For Each oeRID As e_RegistroInventarioDocumento In lstRegistroInventarioDoc
                    Guardar(oeRID)
                Next
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
    'Public Function Guardar(ByVal oeRegistroInventarioDocumento As e_RegistroInventarioDocumento) As Boolean
    '    Try
    '        
    '        With oeRegistroInventarioDocumento
    '            sqlhelper.ExecuteNonQuery("ALM.Isp_AfectarInventarioDocumento", _
    '                                      .TipoOperacion, .PrefijoID, _
    '                                      .IdTipoOrden, _
    '                                      .IdOrden, _
    '                                      .IdMovimientoDocumento, _
    '                                      .IdMaterial, _
    '                                      .Precio, _
    '                                      .IdUnidadMedida)
    '        End With
    '        Return True
    '    Catch ex As Exception
    '        Throw ex
    '        Return False
    '    End Try
    'End Function
    Public Function Guardar(ByVal oeRegistroInventarioDocumento As e_RegistroInventarioDocumento) As Boolean
        Try
            With oeRegistroInventarioDocumento
                sqlhelper.ExecuteNonQuery("ALM.Isp_RegistroInventarioDocumento_IAE",
                                          "I", .PrefijoID,
                                          .Id,
                                          .Codigo,
                                          .IdRegistroInventario,
                                          .IdMovimientoDocumento,
                                          .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class