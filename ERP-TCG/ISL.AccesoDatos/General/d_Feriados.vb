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

Public Class d_Feriados
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Feriados
        Try
            Dim oeFeriados = New e_Feriados( _
                             o_fila("Id").ToString _
                             , o_fila("IdTipoFeriado").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("IndLaborable").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("TipoFeriado").ToString)
            Return oeFeriados
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeFeriados As e_Feriados) As e_Feriados
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Feriados_Listar", "", oeFeriados.Id, oeFeriados.IdTipoFeriado,oeFeriados.Fecha)
            If ds.Tables(0).Rows.Count > 0 Then
                oeFeriados = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeFeriados
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeFeriados As e_Feriados) As List(Of e_Feriados)
        Try
            Dim ldFeriados As New List(Of e_Feriados)
            Dim ds As DataSet
            With oeFeriados
                ds = sqlhelper.ExecuteDataset("STD.Isp_Feriados_Listar", .TipoOperacion, .Id, .IdTipoFeriado)
            End With
            oeFeriados = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeFeriados = Cargar(o_Fila)
                ldFeriados.Add(oeFeriados)
            Next
            Return ldFeriados
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeFeriados As e_Feriados) As Boolean
        Try
            With oeFeriados
                sqlhelper.ExecuteNonQuery("STD.Isp_Feriados_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdTipoFeriado _
                        , .Fecha _
                        , .Descripcion _
                        , .IndLaborable _
                        , .Activo _
                        , .FechaCreacion _
                        , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeFeriados As e_Feriados) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_Feriados_IAE", "E", _
             "", oeFeriados.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
