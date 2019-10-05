'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_CuentaCorriente

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CuentaCorriente
        Try
            Dim oeCuentaCorriente = New e_CuentaCorriente( _
                             o_fila("Id").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre") _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("NombreMoneda").ToString _
                             , o_fila("Saldo").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("Activo") _
                             , o_fila("Tipo") _
                             , o_fila("TipoCuenta").ToString _
                             , o_fila("TotalCargo").ToString _
                             , o_fila("TotalAbono").ToString _
                             , o_fila("Ejercicio").ToString)
            Return oeCuentaCorriente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaCorriente As e_CuentaCorriente) As e_CuentaCorriente

        Try
            Dim ds As New DataSet
            With oeCuentaCorriente
                ds = sqlhelper.ExecuteDataset("TES.Isp_CuentaCorriente_Listar", _
                                            .TipoOperacion, _
                                            .IdTrabajador, _
                                            .Id, _
                                            .Codigo, _
                                            .Tipo)
            End With

            oeCuentaCorriente = New e_CuentaCorriente
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeCuentaCorriente = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCuentaCorriente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaCorriente As e_CuentaCorriente) As List(Of e_CuentaCorriente)
        Try
            Dim ldCuentaCorriente As New List(Of e_CuentaCorriente)
            Dim ds As DataSet
            With oeCuentaCorriente
                ds = sqlhelper.ExecuteDataset("TES.Isp_CuentaCorriente_Listar", .Tipooperacion _
                                            , .IdTrabajador _
                                            , .Id _
                                            , .Codigo _
                                            , .Tipo _
                                            , .Ejercicio)
            End With
            oeCuentaCorriente = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCuentaCorriente = Cargar(o_Fila)
                    ldCuentaCorriente.Add(oeCuentaCorriente)
                Next
                Return ldCuentaCorriente
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaCorriente As e_CuentaCorriente) As Boolean
        Try
            Dim oeSaldoCtaCte As New e_SaldoCtaCorriente
            Dim odSaldoCtaCte As New d_SaldoCtaCorriente
            Dim id As String
            With oeCuentaCorriente
                id = sqlhelper.ExecuteScalar("TES.Isp_CuentaCorriente_IAE", .Tipooperacion _
                                         , "A" _
                                         , .Id _
                                         , .Codigo _
                                         , .IdTrabajador _
                                         , .IdMoneda _
                                         , .Glosa _
                                         , .Saldo _
                                         , .Usuario _
                                         , .IdEstado _
                                         , .Activo _
                                         , .PrefijoID _
                                         , .Tipo _
                                         , .TotalCargo _
                                         , .TotalAbono _
                                         , .Ejercicio)

                .Id = id
                If .Tipo = 2 Or .Tipo = 4 Then
                    If .Tipooperacion = "I" Then
                        oeSaldoCtaCte.TipoOperacion = "I"
                        oeSaldoCtaCte.IdCuentaCorriente = .Id
                        oeSaldoCtaCte.Liquidado = 0
                        oeSaldoCtaCte.Monto = 0
                        oeSaldoCtaCte.TipoCuenta = .Tipo
                        oeSaldoCtaCte.UsuarioCreacion = .Usuario
                        oeSaldoCtaCte.PrefijoID = oeCuentaCorriente.PrefijoID '@0001
                        odSaldoCtaCte.Guardar(oeSaldoCtaCte)
                    End If
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCuentaCorriente As e_CuentaCorriente) As Boolean
        Try
            With oeCuentaCorriente
                sqlhelper.ExecuteNonQuery("TES.Isp_CuentaCorriente_IAE", .TipoOperacion, "", .Id)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class