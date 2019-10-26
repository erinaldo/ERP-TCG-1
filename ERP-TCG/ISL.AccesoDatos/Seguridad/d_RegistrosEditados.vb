'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_RegistrosEditados
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_RegistrosEditados
        Try
            Dim oeRegistrosEditados = New e_RegistrosEditados( _
                             o_fila("Id").ToString _
                             , o_fila("IdTabla").ToString _
                             , o_fila("IdRegistro").ToString _
                             , o_fila("Referencia").ToString _
                             , o_fila("UsuarioEdita").ToString _
                             , o_fila("FechaEditado").ToString _
                             , o_fila("FechaModificado").ToString _
                             , o_fila("IndEditado").ToString _
                             , o_fila("Activo").ToString)
            Return oeRegistrosEditados
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRegistrosEditados As e_RegistrosEditados) As e_RegistrosEditados
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[SGD].[RegistrosEditados_Listar]", oeRegistrosEditados.TipoOperacion, oeRegistrosEditados.Id)
            oeRegistrosEditados = New e_RegistrosEditados
            If ds.Tables(0).Rows.Count > 0 Then
                oeRegistrosEditados = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeRegistrosEditados
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeRegistrosEditados As e_RegistrosEditados) As List(Of e_RegistrosEditados)
        Try
            Dim ldRegistrosEditados As New List(Of e_RegistrosEditados)
            Dim ds As DataSet
            With oeRegistrosEditados
                ds = sqlhelper.ExecuteDataset("[SGD].[RegistrosEditados_Listar]", .TipoOperacion _
                                                , .Id _
                                                , .IdTabla _
                                                , .IdRegistro _
                                                , .Referencia _
                                                , .IndEditado)
            End With
            oeRegistrosEditados = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeRegistrosEditados = Cargar(o_Fila)
                    ldRegistrosEditados.Add(oeRegistrosEditados)
                Next
            Else
                ldRegistrosEditados = New List(Of e_RegistrosEditados)
            End If
            Return ldRegistrosEditados
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeRegistrosEditados As e_RegistrosEditados) As String
        Try
            With oeRegistrosEditados
                Return sqlhelper.ExecuteScalar("[SGD].[RegistrosEditados_IAE]",
                                                .TipoOperacion,
                                                .PrefijoID,
                                                .Id _
                                                , .IdTabla _
                                                , .IdRegistro _
                                                , .Referencia _
                                                , .UsuarioEdita _
                                                , .FechaModificado)
            End With
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeRegistrosEditados As e_RegistrosEditados) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[SGD].[RegistrosEditados_IAE]", "E", _
                                        "", _
                                        oeRegistrosEditados.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
