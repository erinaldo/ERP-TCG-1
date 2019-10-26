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

Public Class d_Denominacion

    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_Denominacion
        Try
            Dim oeDenominacion = New e_Denominacion( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdMoneda").ToString _
                             , o_Fila("IdCaja").ToString _
                             , o_Fila("Nombre").ToString _
                             , o_Fila("Abreviatura").ToString _
                             , o_Fila("RutaImagen").ToString _
                             , o_Fila("Cantidad").ToString _
                             , o_Fila("Monto").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeDenominacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDenominacion As e_Denominacion) As e_Denominacion

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_Denominacion_Listar", "", oeDenominacion.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeDenominacion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDenominacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDenominacion As e_Denominacion) As List(Of e_Denominacion)
        Try
            Dim ldDenominacion As New List(Of e_Denominacion)
            Dim ds As DataSet
            With oeDenominacion
                ds = sqlhelper.ExecuteDataset("TES.Isp_Denominacion_Listar", "" _
                        , .Id _
                        , .IdMoneda _
                        , .IdCaja _
                        , .Nombre _
                        , .Abreviatura _
                        , .RutaImagen _
                        , .Cantidad _
                        , .Monto _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeDenominacion = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDenominacion = Cargar(o_Fila)
                ldDenominacion.Add(oeDenominacion)
            Next
            Return ldDenominacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDenominacion As e_Denominacion) As Boolean
        Try
            With oeDenominacion
                sqlhelper.ExecuteNonQuery("TES.Isp_Denominacion_IAE", .TipoOperacion _
                        , .IdMoneda _
                        , .IdCaja _
                        , .Nombre _
                        , .Abreviatura _
                        , .RutaImagen _
                        , .Cantidad _
                        , .Monto _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .PrefijoID
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDenominacion As e_Denominacion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_Denominacion_IAE", "E", oeDenominacion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
