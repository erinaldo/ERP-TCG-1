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

Public Class d_DetalleRegistroDevolucion

    Private sqlhelper As New SqlHelper


    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleRegistroDevolucion
        Try
            Dim oeDetalleRegistroDevolucion = New e_DetalleRegistroDevolucion( _
                             o_fila("Id").ToString _
                             , o_fila("IdRegistroDevolucion").ToString _
                             , o_fila("IdVidaNeumatico").ToString _
                            , o_fila("IdNeumatico").ToString _
                             , o_fila("CodigoNeumatico").ToString _
                             , o_fila("Diseño").ToString _
                              , o_fila("Marca").ToString _
                              , o_fila("Medida").ToString _
                              , o_fila("KmTotalNeumatico") _
                              , o_fila("CocadaMinima") _
                             , o_fila("NroVida").ToString _
                             , o_fila("FechaIngreso").ToString _
                             , o_fila("Condicion").ToString _
                             , o_fila("EstadoActual").ToString _
                              , o_fila("Ubicacion").ToString _
                             , o_fila("Kilometraje").ToString _
                             , o_fila("Ribete1").ToString _
                             , o_fila("Ribete2").ToString _
                             , o_fila("Ribete3").ToString _
                             , o_fila("Cocada").ToString _
                             , o_fila("CocadaOriginal").ToString _
                             , o_fila("Proveedor").ToString _
                             , o_fila("IdDiseno").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeDetalleRegistroDevolucion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleRegistroDevolucion As e_DetalleRegistroDevolucion) As e_DetalleRegistroDevolucion

        Try
            Dim ds As DataSet
            With oeDetalleRegistroDevolucion
                ds = sqlhelper.ExecuteDataset("NEU.Isp_DetalleRegistroDevolucion_Listar", "", oeDetalleRegistroDevolucion.Id)
            End With

            If ds.Tables(0).Rows.Count > 0 Then
                oeDetalleRegistroDevolucion = Cargar(ds.Tables(0).Rows(0))

            End If
            Return oeDetalleRegistroDevolucion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleRegistroDevolucion As e_DetalleRegistroDevolucion) As List(Of e_DetalleRegistroDevolucion)
        Try
            Dim ldDetalleRegistroDevolucion As New List(Of e_DetalleRegistroDevolucion)
            Dim ds As DataSet
            With oeDetalleRegistroDevolucion
                ds = sqlhelper.ExecuteDataset("NEU.Isp_DetalleRegistroDevolucion_Listar", "" _
                        , .Id _
                        , .IdRegistroDevolucion _
                        , .IdVidaNeumatico _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeDetalleRegistroDevolucion = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetalleRegistroDevolucion = Cargar(o_Fila)
                ldDetalleRegistroDevolucion.Add(oeDetalleRegistroDevolucion)
            Next
            Return ldDetalleRegistroDevolucion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleRegistroDevolucion As e_DetalleRegistroDevolucion) As Boolean
        Try
            With oeDetalleRegistroDevolucion
                sqlhelper.ExecuteNonQuery("NEU.Isp_DetalleRegistroDevolucion_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdRegistroDevolucion _
                        , .IdVidaNeumatico _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleRegistroDevolucion As e_DetalleRegistroDevolucion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("NEU.Isp_DetalleRegistroDevolucion_IAE", "E", _
             "", oeDetalleRegistroDevolucion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class
