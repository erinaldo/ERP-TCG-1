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

Public Class d_CuentaxPDocumentoRetencion
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CuentaxPDocumentoRetencion
        Try
            Dim oeCuentaxPDocumentoRetencion = New e_CuentaxPDocumentoRetencion( _
                             o_fila("Id").ToString _
                             , o_fila("IdDocumentoRetencion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdCuentaxCyP").ToString _
                             , o_fila("IdMovimientoDocumento").ToString _
                             , o_fila("UsuarioCrea").ToString _
                             , o_fila("FechaCrea").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("FechaModifica").ToString _
            )
            Return oeCuentaxPDocumentoRetencion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaxPDocumentoRetencion As e_CuentaxPDocumentoRetencion) As e_CuentaxPDocumentoRetencion

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_CuentaxPDocumentoRetencion_Listar", "",
            Left(oeCuentaxPDocumentoRetencion.PrefijoID, 1), "", oeCuentaxPDocumentoRetencion.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeCuentaxPDocumentoRetencion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCuentaxPDocumentoRetencion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaxPDocumentoRetencion As e_CuentaxPDocumentoRetencion) As List(Of e_CuentaxPDocumentoRetencion)
        Try
            Dim ldCuentaxPDocumentoRetencion As New List(Of e_CuentaxPDocumentoRetencion)
            Dim ds As DataSet
            With oeCuentaxPDocumentoRetencion
                ds = sqlhelper.ExecuteDataset("CON.Isp_CuentaxPDocumentoRetencion_Listar", "" _
        , Left(.PrefijoID, 1), "" _
                        , .Id _
                        , .IdDocumentoRetencion _
                        , .Activo _
                        , .IdCuentaxCyP
                        )
            End With
            oeCuentaxPDocumentoRetencion = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCuentaxPDocumentoRetencion = Cargar(o_Fila)
                    ldCuentaxPDocumentoRetencion.Add(oeCuentaxPDocumentoRetencion)
                Next
            End If
            Return ldCuentaxPDocumentoRetencion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaxPDocumentoRetencion As e_CuentaxPDocumentoRetencion) As Boolean
        Try
            With oeCuentaxPDocumentoRetencion
                sqlhelper.ExecuteNonQuery("CON.Isp_CuentaxPDocumentoRetencion_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdDocumentoRetencion _
                        , .Activo _
                        , .IdCuentaxCyP _
                        , .IdMovimientoDocumento _
                        , .UsuarioCrea _
                        , .UsuarioModifica
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeCuentaxPDocumentoRetencion As e_CuentaxPDocumentoRetencion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_CuentaxPDocumentoRetencion_IAE", "E", _
             "", oeCuentaxPDocumentoRetencion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ListarPagos(ByVal oeCuentaxPDocumentoRetencion As e_CuentaxPDocumentoRetencion) As DataTable
        Try
            Dim dsPagos As DataSet
            With oeCuentaxPDocumentoRetencion
                dsPagos = sqlhelper.ExecuteDataset("CON.Isp_CuentaxPDocumentoRetencion_Listar", "E", "", "", .Id, .IdDocumentoRetencion, .Activo, .IdCuentaxCyP)
            End With
            Return dsPagos.Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
