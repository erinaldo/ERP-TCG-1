'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Public Class d_TarjetaMovimiento
    Private sqlhelper As New SqlHelper

    Private Function Cargar(o_fila As DataRow) As e_TarjetaMovimiento
        Try
            Dim oeTarjetaMovimiento = New e_TarjetaMovimiento With {
                         .Id = o_fila("Id").ToString _
                         , .NroTarjeta = o_fila("NroTarjeta").ToString _
                         , .Ticket = o_fila("Ticket") _
                         , .Fecha = o_fila("Fecha") _
                         , .Monto = o_fila("Monto") _
                         , .Tipo = o_fila("Tipo").ToString _
                         , .Lugar = o_fila("Lugar").ToString _
                         , .IdLugar = o_fila("IdLugar").ToString _
                         , .NombreLugar = o_fila("NombreLugar").ToString _
                         , .Placa = o_fila("Placa").ToString _
                         , .IndIngresado = o_fila("IndIngresado").ToString _
                         , .UsuarioCreacion = o_fila("UsuarioCreacion").ToString _
                         , .FechaCreacion = o_fila("FechaCreacion") _
                         , .UsuarioModificacion = o_fila("UsuarioModificacion").ToString _
                         , .FechaModificacion = o_fila("FechaModificacion") _
                         , .Activo = o_fila("Activo") _
            }

            oeTarjetaMovimiento.Valor = o_fila("Valor")

            Return oeTarjetaMovimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeTarjetaMovimiento As e_TarjetaMovimiento) As e_TarjetaMovimiento
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_TarjetaMovimiento_Listar",
                                          "GEN",
                                          oeTarjetaMovimiento.Id,
                                          oeTarjetaMovimiento.NroTarjeta)
            If ds.Tables(0).Rows.Count > 0 Then
                oeTarjetaMovimiento = Cargar(ds.Tables(0).Rows(0))
            Else
                oeTarjetaMovimiento = New e_TarjetaMovimiento
            End If
            Return oeTarjetaMovimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeTarjetaMovimiento As e_TarjetaMovimiento) As List(Of e_TarjetaMovimiento)
        Try
            Dim ldPeajeTarifa As New List(Of e_TarjetaMovimiento)
            Dim ds As DataSet
            With oeTarjetaMovimiento
                ds = sqlhelper.ExecuteDataset("STD.Isp_TarjetaMovimiento_Listar",
                                                .TipoOperacion _
                                                , .Id _
                                                , .NroTarjeta _
                                                , .Ticket _
                                                , .Fecha _
                                                , .FechaHasta _
                                                , .Monto _
                                                , .Tipo _
                                                , .Lugar _
                                                , .Placa _
                                                , .IndIngresado _
                                                , .Activo)
            End With
            oeTarjetaMovimiento = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeTarjetaMovimiento = Cargar(o_Fila)
                ldPeajeTarifa.Add(oeTarjetaMovimiento)
            Next
            Return ldPeajeTarifa
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo(ByVal xml As String, ByVal PrefijoID As String) As Boolean
        Try
            sqlhelper.ExecuteScalar("STD.Isp_TarjetaMovimiento_IAE",
                                      "M" _
                                        , PrefijoID _
                                        , xml)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oePeajeTarifa As e_TarjetaMovimiento) As Boolean
        Try
            'sqlhelper = New SqlHelper
            '
            'With oePeajeTarifa
            '    sqlhelper.ExecuteScalar("STD.Isp_TarjetaMovimiento_IAE", _
            '                              .TipoOperacion _
            '                                , .PrefijoID _
            '                                , .Id _
            '                                , .IdPeaje _
            '                                , .CantidadEjes _
            '                                , .Nombre _
            '                                , .Monto _
            '                                , .Glosa _
            '                                , .Activo _
            '                                , .UsuarioCreacion)
            'End With
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oePeajeTarifa As e_TarjetaMovimiento) As Boolean
        Try
            'sqlhelper = New SqlHelper
            'With oePeajeTarifa
            '    sqlhelper.ExecuteScalar("STD.Isp_TarjetaMovimiento_IAE", _
            '                              "E" _
            '                                , "" _
            '                                , .Id _
            '                                , .IdPeaje _
            '                                , .CantidadEjes _
            '                                , .Nombre _
            '                                , .Monto _
            '                                , .Glosa _
            '                                , .Activo _
            '                                , .UsuarioCreacion)
            'End With
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function IdInsertar(ByVal PrefijoID As String) As String
        Try
            Dim strResultado As String
            strResultado = sqlhelper.ExecuteScalar("STD.Isp_TarjetaMovimiento_IAE",
                                                   "Z",
                                                   PrefijoID,
                                                   "")


            Return strResultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizarMasivo(ByVal xml As String, ByVal PrefijoID As String) As Boolean
        Try
            sqlhelper.ExecuteScalar("STD.Isp_TarjetaMovimiento_IAE",
                                      "S" _
                                        , PrefijoID _
                                        , xml)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
