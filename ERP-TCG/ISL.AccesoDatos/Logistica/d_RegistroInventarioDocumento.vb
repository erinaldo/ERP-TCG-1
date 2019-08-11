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
    '        Dim d_DatosConfiguracion As New d_DatosConfiguracion
    '        With oeRegistroInventarioDocumento
    '            sqlhelper.ExecuteNonQuery("ALM.Isp_AfectarInventarioDocumento", _
    '                                      .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
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
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeRegistroInventarioDocumento
                sqlhelper.ExecuteNonQuery("ALM.Isp_RegistroInventarioDocumento_IAE", _
                                          "I", d_DatosConfiguracion.PrefijoID, _
                                          .Id, _
                                          .Codigo, _
                                          .IdRegistroInventario, _
                                          .IdMovimientoDocumento, _
                                          .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class