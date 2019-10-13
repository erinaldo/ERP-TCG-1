'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Public Class d_ProcesoFlujoCaja
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ProcesoFlujoCaja
        Try
            Dim oeProcesoFlujoCaja = New e_ProcesoFlujoCaja( _
                             o_fila("Id").ToString _
                             , o_fila("IdProcesoNegocio").ToString _
                             , o_fila("IdFlujoCaja").ToString _
                             , o_fila("Activo") _
                             , o_fila("ProcesoNegocio").ToString _
                             , o_fila("FlujoCaja").ToString _
            )
            Return oeProcesoFlujoCaja
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeProcesoFlujoCaja As e_ProcesoFlujoCaja) As e_ProcesoFlujoCaja
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_ProcesoFlujoCaja_Listar", "", oeProcesoFlujoCaja.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeProcesoFlujoCaja = Cargar(ds.Tables(0).Rows(0))
            End If


            'Dim d_DatosConfiguracion As New d_DatosConfiguracion
            'Dim IdProcesoNegocio As String = oeProcesoFlujoCaja.IdProcesoNegocio
            ''Dim ds As DataSet
            ''ds = sqlhelper.ExecuteDataset("STD.Isp_ProcesoFlujoCaja_Listar", "", oeProcesoFlujoCaja.Id)

            'If IdProcesoNegocio <> "" Then
            '    oeProcesoFlujoCaja = New e_ProcesoFlujoCaja
            '    oeProcesoFlujoCaja.IdProcesoNegocio = IdProcesoNegocio
            '    oeProcesoFlujoCaja.ListaProcesoFlujoCaja = Listar(oeProcesoFlujoCaja)
            'End If

            Return oeProcesoFlujoCaja
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeProcesoFlujoCaja As e_ProcesoFlujoCaja) As List(Of e_ProcesoFlujoCaja)
        Try
            Dim ldProcesoFlujoCaja As New List(Of e_ProcesoFlujoCaja)
            Dim ds As DataSet
            With oeProcesoFlujoCaja
                ds = sqlhelper.ExecuteDataset("STD.Isp_ProcesoFlujoCaja_Listar", "" _
                        , .Id _
                        , .IdProcesoNegocio _
                        , .IdFlujoCaja _
                        , .Activo
                        )
            End With
            oeProcesoFlujoCaja = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeProcesoFlujoCaja = Cargar(o_Fila)
                    ldProcesoFlujoCaja.Add(oeProcesoFlujoCaja)
                Next
            End If
            Return ldProcesoFlujoCaja
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeProcesoFlujoCaja As e_ProcesoFlujoCaja) As Boolean
        Try
            Using TransScope As New TransactionScope
                For Each Lista As e_ProcesoFlujoCaja In oeProcesoFlujoCaja.ListaProcesoFlujoCaja
                    If oeProcesoFlujoCaja.ListaProcesoFlujoCaja IsNot Nothing Then
                        Lista.PrefijoID = oeProcesoFlujoCaja.PrefijoID '@0001
                        With Lista
                            sqlhelper.ExecuteNonQuery("STD.Isp_ProcesoFlujoCaja_IAE", .TipoOperacion, .PrefijoID,
                                    .Id _
                                    , .IdProcesoNegocio _
                                    , .IdFlujoCaja _
                                    , .Activo
                                )
                        End With
                    End If
                Next
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeProcesoFlujoCaja As e_ProcesoFlujoCaja) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_ProcesoFlujoCaja_IAE", "E", _
             oeProcesoFlujoCaja.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class