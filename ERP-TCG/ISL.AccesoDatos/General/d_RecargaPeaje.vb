'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions

Public Class d_RecargaPeaje
    Private sqlhelper As New SqlHelper

    Private Function Cargar(o_fila As DataRow) As e_RecargaPeaje
        Try
            Dim oeRecargaPeaje = New e_RecargaPeaje With {
                         .Id = o_fila("Id").ToString() _
                         , .IdTipoDocumento = o_fila("IdTipoDocumento").ToString() _
                         , .TipoDocumento = o_fila("TipoDocumento").ToString() _
                         , .Serie = o_fila("Serie").ToString() _
                         , .Numero = o_fila("Numero").ToString() _
                         , .Fecha = o_fila("Fecha") _
                         , .IdMoneda = o_fila("IdMoneda").ToString() _
                         , .Moneda = o_fila("Moneda").ToString() _
                         , .IdEstado = o_fila("IdEstado").ToString() _
                         , .Estado = o_fila("Estado").ToString() _
                         , .IdVehiculoTarjeta = o_fila("IdVehiculoTarjeta").ToString() _
                         , .Placa = o_fila("Placa").ToString() _
                         , .NroTarjeta = o_fila("NroTarjeta").ToString() _
                         , .MontoTotal = o_fila("MontoTotal") _
                         , .MontoTarjeta = o_fila("MontoTarjeta") _
                         , .Glosa = o_fila("Glosa").ToString() _
                         , .UsuarioCreacion = o_fila("UsuarioCreacion").ToString() _
                         , .FechaCreacion = o_fila("FechaCreacion") _
                         , .UsuarioModificacion = o_fila("UsuarioModificacion").ToString() _
                         , .FechaModificacion = o_fila("FechaModificacion") _
                         , .Activo = o_fila("Activo") _
            }
            Return oeRecargaPeaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeRecargaPeaje As e_RecargaPeaje) As List(Of e_RecargaPeaje)
        Try
            sqlhelper = New SqlHelper
            Dim ldRecargaPeaje As New List(Of e_RecargaPeaje)
            Dim ds As DataSet
            With oeRecargaPeaje
                ds = sqlhelper.ExecuteDataset("STD.Isp_RecargaPeaje_Listar", _
                                                .TipoOperacion _
                                                , .Id _
                                                , .IdTipoDocumento _
                                                , .IdMoneda _
                                                , .Fecha _
                                                , .FechaHasta _
                                                , .Serie _
                                                , .Numero _
                                                , .IdEstado _
                                                , .IdVehiculoTarjeta _
                                                , .MontoTotal _
                                                , .MontoTarjeta _
                                                , .Glosa _
                                                , .Activo)
            End With
            oeRecargaPeaje = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeRecargaPeaje = Cargar(o_Fila)
                ldRecargaPeaje.Add(oeRecargaPeaje)
            Next
            Return ldRecargaPeaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo(ByVal xml As String, ByVal PrefijoID As String) As Boolean
        Try
            sqlhelper.ExecuteScalar("STD.Isp_RecargaPeaje_IAE",
                                      "M" _
                                        , PrefijoID _
                                        , xml)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeRecargaPeaje As e_RecargaPeaje) As Boolean
        Try
            With oeRecargaPeaje
                sqlhelper.ExecuteScalar("STD.Isp_RecargaPeaje_IAE",
                                          "I" _
                                            , .PrefijoID _
                                            , "" _
                                            , .Id _
                                            , .IdMoneda _
                                            , .IdTipoDocumento _
                                            , .Fecha _
                                            , .Serie _
                                            , .Numero _
                                            , .IdVehiculoTarjeta _
                                            , .IdEstado _
                                            , .MontoTotal _
                                            , .MontoTarjeta _
                                            , .Glosa _
                                            , .Activo _
                                            , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeRecargaPeaje As e_RecargaPeaje) As Boolean
        Try
            With oeRecargaPeaje
                sqlhelper.ExecuteScalar("STD.Isp_RecargaPeaje_IAE",
                                          "E" _
                                            , "" _
                                            , "" _
                                            , .Id _
                                            , .IdMoneda _
                                            , .IdTipoDocumento _
                                            , .Fecha _
                                            , .Serie _
                                            , .Numero _
                                            , .IdVehiculoTarjeta _
                                            , .IdEstado _
                                            , .MontoTotal _
                                            , .MontoTarjeta _
                                            , .Glosa _
                                            , .Activo _
                                            , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function IdInsertar(ByVal PrefijoID As String) As String
        Try
            Dim strResultado As String
            strResultado = sqlhelper.ExecuteScalar("STD.Isp_RecargaPeaje_IAE",
                                                   "Z",
                                                   PrefijoID,
                                                   "")


            Return strResultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizarMasivo(ListaRecargaPeaje As List(Of e_RecargaPeaje)) As Boolean
        Try
            Using TransScope As New TransactionScope
                For Each Detalle As e_RecargaPeaje In ListaRecargaPeaje
                    With Detalle
                        If .TipoOperacion = "E" Then
                            Eliminar(Detalle)
                        Else
                            Guardar(Detalle)
                        End If
                    End With
                Next
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
