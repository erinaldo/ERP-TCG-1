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

Public Class d_ControlCargaPersonaES
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ControlCargaPersonaES
        Try
            Dim oeControlCargaPersonaES = New e_ControlCargaPersonaES( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdPersonaES").ToString _
                             , o_Fila("Carga").ToString _
                             , o_Fila("Observacion").ToString _
                             , o_Fila("ControlES").ToString _
                             , o_Fila("Confirmado").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeControlCargaPersonaES
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeControlCargaPersonaES As e_ControlCargaPersonaES) As e_ControlCargaPersonaES

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeControlCargaPersonaES.Id)
            If ds.Tables.Count > 0 Then
                oeControlCargaPersonaES = Cargar(ds.Tables(0).Rows(0))
                Return oeControlCargaPersonaES
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeControlCargaPersonaES As e_ControlCargaPersonaES) As List(Of e_ControlCargaPersonaES)
        Try
            Dim ldControlCargaPersonaES As New List(Of e_ControlCargaPersonaES)
            Dim ds As DataSet
            With oeControlCargaPersonaES
                ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
                        , .Id _
                        , .IdPersonaES _
                        , .Carga _
                        , .Observacion _
                        , .ControlES _
                        , .Confirmado _
                        , .Activo _
                        )
            End With
            oeControlCargaPersonaES = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeControlCargaPersonaES = Cargar(o_Fila)
                    ldControlCargaPersonaES.Add(oeControlCargaPersonaES)
                Next
                Return ldControlCargaPersonaES
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeControlCargaPersonaES As e_ControlCargaPersonaES) As Boolean
        Try
            With oeControlCargaPersonaES
                sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdPersonaES _
                        , .Carga _
                        , .Observacion _
                        , .ControlES _
                        , .Confirmado _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeControlCargaPersonaES As e_ControlCargaPersonaES) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeControlCargaPersonaES.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class