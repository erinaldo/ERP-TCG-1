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

Public Class d_Bitacora
    Private sqlhelper As New SqlHelper


    Public Function Listar(ByVal oeBitacora As e_Bitacora) As List(Of e_Bitacora)
        Try
            Dim ldBitacora As New List(Of e_Bitacora)
            Dim ds As DataSet
            With oeBitacora
                ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
                        , .Id _
                        , .IdTablaCabecera _
                        , .IdTablaDetalle _
                        , .NombreTablaCabecera _
                        , .NombreTablaDetalle _
                        , .NombreFormulario _
                        , .ColumnasAfectadas _
                        , .FechaRegistro _
                        , .FechaModificacion _
                        , .UsuarioRegistro _
                        , .UsuarioModificacion _
                        , .TipoOPeracion _
                        , .ValoresAnteriores _
                        , .ValoresActuales _
                        , .Indicador _
                        , .Activo _
                        )
            End With
            oeBitacora = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                'oeBitacora = Cargar(o_Fila)
                ldBitacora.Add(oeBitacora)
            Next
            Return ldBitacora
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal l_Bitacora As List(Of e_Bitacora), ByVal PrefijoID As String) As Boolean
        Try
            For Each oeBitacora As e_Bitacora In l_Bitacora
                With oeBitacora
                    sqlhelper.ExecuteNonQuery("[STD].[Isp_Bitacora_IAE]",
                                              .Tipo,
                                              PrefijoID _
                                            , .IdTablaCabecera _
                                            , .IdTablaDetalle _
                                            , .NombreTablaCabecera _
                                            , .NombreTablaDetalle _
                                            , .NombreFormulario _
                                            , IIf(.ColumnasAfectadas Is Nothing, "", String.Join(" - ", .ColumnasAfectadas)) _
                                            , .UsuarioRegistro _
                                            , .TipoOPeracion _
                                            , IIf(.ValoresAnteriores Is Nothing, "", String.Join(" - ", .ValoresAnteriores)) _
                                            , IIf(.ValoresAnteriores Is Nothing, "", String.Join(" - ", .ValoresActuales)) _
                                            , .Indicador _
                                            , .Activo
                                        )
                End With
            Next

            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function VerificarExistenciaDeDetalles(ByVal l_Bitacora As List(Of e_Bitacora)) As Boolean
        Dim cont As Integer = 0
        Try
            Dim oeBitacora = l_Bitacora.Item(0)
            With oeBitacora              
                cont = sqlhelper.ExecuteScalar("[STD].[Isp_Bitacora_IAE]",
                                          "V", _
                                          .PrefijoID _
                                        , .IdTablaCabecera _
                                        , .IdTablaDetalle _
                                        , .NombreTablaCabecera _
                                        , .NombreTablaDetalle _
                                        , .NombreFormulario _
                                        , IIf(.ColumnasAfectadas Is Nothing, "", String.Join(" - ", .ColumnasAfectadas)) _
                                        , .UsuarioRegistro _
                                        , IIf(.TipoOPeracion Is Nothing, "", .TipoOPeracion) _
                                        , IIf(.ValoresAnteriores Is Nothing, "", String.Join(" - ", .ValoresAnteriores)) _
                                        , IIf(.ValoresAnteriores Is Nothing, "", String.Join(" - ", .ValoresActuales)) _
                                        , .Indicador
                                    )
            End With

            If cont = 0 Then
                Guardar(l_Bitacora, oeBitacora.PrefijoID)
            Else
                Dim listaN = New List(Of e_Bitacora)
                Dim obj As e_Bitacora = l_Bitacora.Item(0)
                obj.Tipo = "G"
                listaN.Add(obj)
                Guardar(listaN, oeBitacora.PrefijoID)
            End If
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    'Private Function Cargar(ByVal o_fila As DataRow) As e_Bitacora
    '    Try
    '        Dim oeBitacora = New e_Bitacora( _
    '                         o_Fila("Id").ToString _
    '                         , o_Fila("IdTablaCabecera").ToString _
    '                         , o_Fila("IdTablaDetalle").ToString _
    '                         , o_Fila("NombreTablaCabecera").ToString _
    '                         , o_Fila("NombreTablaDetalle").ToString _
    '                         , o_Fila("NombreFormulario").ToString _
    '                         , o_Fila("ColumnasAfectadas").ToString _
    '                         , o_Fila("FechaRegistro").ToString _
    '                         , o_Fila("FechaModificacion").ToString _
    '                         , o_Fila("UsuarioRegistro").ToString _
    '                         , o_Fila("UsuarioModificacion").ToString _
    '                         , o_Fila("TipoOPeracion").ToString _
    '                         , o_Fila("ValoresAnteriores").ToString _
    '                         , o_Fila("ValoresActuales").ToString _
    '                         , o_Fila("Indicador").ToString _
    '                         , o_Fila("Activo").ToString _
    '        )
    '        Return oeBitacora
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

End Class