Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ChequeDocumento
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ChequeDocumento
        Try
            Dim oeChequeDocumento = New e_ChequeDocumento( _
                             o_fila("Id").ToString _
                             , o_fila("IdChequeEmitido").ToString _
                             , o_fila("IdMovimientoDocumento").ToString _
                             , o_fila("Documento").ToString _
                             , o_fila("Proveedor").ToString _
                             , o_fila("Moneda").ToString _
                             , o_fila("Importe").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeChequeDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeChequeDocumento As e_ChequeDocumento) As e_ChequeDocumento

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_ChequeDocumento_Listar", "", oeChequeDocumento.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeChequeDocumento = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeChequeDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeChequeDocumento As e_ChequeDocumento) As List(Of e_ChequeDocumento)
        Try
            Dim ldChequeDocumento As New List(Of e_ChequeDocumento)
            Dim ds As DataSet
            With oeChequeDocumento
                ds = sqlhelper.ExecuteDataset("TES.Isp_ChequeDocumento_Listar", "" _
                        , .Id _
                        , .IdChequeEmitido _
                        , .IdMovimientoDocumento)
            End With
            oeChequeDocumento = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeChequeDocumento = Cargar(o_Fila)
                ldChequeDocumento.Add(oeChequeDocumento)
            Next
            Return ldChequeDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeChequeDocumento As e_ChequeDocumento) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeChequeDocumento
                sqlhelper.ExecuteNonQuery("TES.Isp_ChequeDocumento_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdChequeEmitido _
                        , .IdMovimientoDocumento _
                        , .Importe _
                        , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeChequeDocumento As e_ChequeDocumento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_ChequeDocumento_IAE", "E", _
             "", oeChequeDocumento.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
