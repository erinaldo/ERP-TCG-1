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

Public Class d_ChequesTalonarios
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ChequesTalonarios
        Try
            Dim oeChequesTalonarios = New e_ChequesTalonarios(o_fila("Id").ToString _
                             , o_fila("Inicial").ToString _
                             , o_fila("Final").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("IdCaja").ToString _
                             , o_fila("IdResponsable").ToString _
                             , o_fila("IndAnulado").ToString _
                             , o_fila("IndTerminado").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("FechaIngreso").ToString _
                             , o_fila("Talonario").ToString _
                             , o_fila("Correlativo").ToString)
            Return oeChequesTalonarios
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeChequesTalonarios As e_ChequesTalonarios) As e_ChequesTalonarios
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_ChequesTalonarios_Listar", oeChequesTalonarios.TipoOperacion, oeChequesTalonarios.Id, _
                                          oeChequesTalonarios.IdChequesControl, oeChequesTalonarios.IdResponsable)
            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count > 0 Then
                    oeChequesTalonarios = Cargar(ds.Tables(0).Rows(0))
                    Return oeChequesTalonarios
                End If
                oeChequesTalonarios = New e_ChequesTalonarios
                Return oeChequesTalonarios
            Else
                oeChequesTalonarios = New e_ChequesTalonarios
                Return oeChequesTalonarios
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeChequesTalonarios As e_ChequesTalonarios) As List(Of e_ChequesTalonarios)
        Try
            Dim ldChequesTalonarios As New List(Of e_ChequesTalonarios)
            Dim ds As DataSet
            With oeChequesTalonarios
                ds = sqlhelper.ExecuteDataset("TES.Isp_ChequesTalonarios_Listar", .TipoOperacion _
                        , .Id, .IdChequesControl)
            End With
            oeChequesTalonarios = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeChequesTalonarios = Cargar(o_Fila)
                    ldChequesTalonarios.Add(oeChequesTalonarios)
                Next
                Return ldChequesTalonarios
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeChequesTalonarios As e_ChequesTalonarios) As Boolean
        Try
            With oeChequesTalonarios
                sqlhelper.ExecuteNonQuery("TES.Isp_ChequesTalonarios_IAE", .TipoOperacion, .PrefijoID,
                        .Id, .IdChequesControl, .IdCaja, .FechaIngreso, .Inicial, .Final, .Talonario, .Activo,
                        .IdResponsable, .IndAnulado, .IndTerminado, .FechaCreacion, .UsuarioCreacion, .Observacion, .Correlativo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeChequesTalonarios As e_ChequesTalonarios) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_ChequesTalonarios_IAE", "E", _
             "", oeChequesTalonarios.Id)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
