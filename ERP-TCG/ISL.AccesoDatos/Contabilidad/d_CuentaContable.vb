Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_CuentaContable

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CuentaContable
        Try
            Dim oeCuentaContable = New e_CuentaContable(
                             o_fila("Id").ToString _
                             , o_fila("Cuenta").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Ejercicio") _
                             , o_fila("IdNaturaleza").ToString _
                             , o_fila("Movimiento").ToString _
                             , o_fila("IdTipoCuentaCorriente").ToString _
                             , o_fila("Tesoreria").ToString _
                             , o_fila("IdTipoDocGeneral").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Conciliacion").ToString _
                             , o_fila("MonedaExtrangera").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("NroDocumento").ToString _
                             , o_fila("FechaEmision").ToString _
                             , o_fila("FechaVencimiento").ToString _
                             , o_fila("CentroCosto").ToString _
                             , o_fila("FlujoCaja").ToString _
                             , o_fila("Tracto").ToString _
                             , o_fila("Ruta").ToString _
                             , o_fila("Banco").ToString _
                             , o_fila("Analisis01").ToString _
                             , o_fila("Analisis02").ToString _
                             , o_fila("Activo").ToString _
                            , o_fila("GastoFuncion").ToString _
                            , o_fila("IdTipoCompra").ToString _
                            , o_fila("PartidaAnalisis").ToString _
                            , o_fila("IdTablaContableDet").ToString)
            Return oeCuentaContable
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaContable As e_CuentaContable) As e_CuentaContable

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.ISP_CuentaContable_Listar", "N",
            Left(oeCuentaContable.PrefijoID, 1), "", oeCuentaContable.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeCuentaContable = Cargar(ds.Tables(0).Rows(0))
                'Dim oeCuentaAsociada As New e_CuentaAsociada
                'Dim llCuentaAsociada As New d_CuentaAsociada
                'oeCuentaAsociada.IdCuentaContable = oeCuentaContable.Id
                'oeCuentaAsociada.Activo = True
                'oeCuentaContable.CuentaAsociada.AddRange(llCuentaAsociada.Listar(oeCuentaAsociada))
            End If
            Return oeCuentaContable
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaContable As e_CuentaContable) As List(Of e_CuentaContable)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldCuentaContable As New List(Of e_CuentaContable)
            Dim ds As DataSet
            With oeCuentaContable
                ds = sqlhelper.ExecuteDataset("CON.ISP_CuentaContable_Listar",
                                              IIf(.TipoOperacion Is Nothing, "N", .TipoOperacion) _
                                             , Left(.PrefijoID, 1) _
                                             , "" _
                                            , .Id _
                                            , .Cuenta _
                                            , .Nombre _
                                            , .Ejercicio _
                                            , .Naturaleza _
                                            , .Movimiento _
                                            , .TipoCuentaCorriente _
                                            , .Tesoreria _
                                            , .TipoDocGeneral _
                                            , .Trabajador _
                                            , .Conciliacion _
                                            , .MonedaExtranjera _
                                            , .NroDocumento _
                                            , .FechaEmision _
                                            , .FechaVencimiento _
                                            , .CentroCosto _
                                            , .FlujoCaja _
                                            , .Tracto _
                                            , .Ruta _
                                            , .Banco _
                                            , .Analisis01 _
                                            , .Analisis02 _
                                            , .Activo)
            End With
            oeCuentaContable = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCuentaContable = Cargar(o_Fila)
                    ldCuentaContable.Add(oeCuentaContable)
                Next
            End If
            Return ldCuentaContable
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaContable As e_CuentaContable) As Boolean
        Dim stResultado() As String
        Dim d_DatosConfiguracion As New d_DatosConfiguracion
        Try
            Using transScope As New TransactionScope()
                With oeCuentaContable
                    stResultado = sqlhelper.ExecuteScalar("CON.ISP_CuentaContable_IAE",
                                                          .TipoOperacion, .PrefijoID,
                                                            .Id _
                                                            , .Cuenta _
                                                            , .Nombre _
                                                            , .Ejercicio _
                                                            , .Naturaleza _
                                                            , .Movimiento _
                                                            , .TipoCuentaCorriente _
                                                            , .Tesoreria _
                                                            , .TipoDocGeneral _
                                                            , .Trabajador _
                                                            , .Conciliacion _
                                                            , .MonedaExtranjera _
                                                            , .Serie _
                                                            , .NroDocumento _
                                                            , .FechaEmision _
                                                            , .FechaVencimiento _
                                                            , .CentroCosto _
                                                            , .FlujoCaja _
                                                            , .Tracto _
                                                            , .Ruta _
                                                            , .Banco _
                                                            , .Analisis01 _
                                                            , .Analisis02 _
                                                            , .Activo _
                                                            , .GastoFuncion _
                                                            , .PartidaAnalisis _
                                                            , .IdTablaContableDet).ToString.Split("_")
                    Dim odCuentaAsociada As New d_CuentaAsociada
                    For Each oeCuentaAsociada As e_CuentaAsociada In .CuentaAsociada
                        With oeCuentaAsociada
                            .IdCuentaContable = stResultado(0)
                            If .TipoOperacion = "I" Then
                                odCuentaAsociada.Guardar(oeCuentaAsociada)
                            ElseIf .TipoOperacion = "E" Then
                                odCuentaAsociada.Eliminar(oeCuentaAsociada)
                            End If
                        End With
                    Next
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCuentaContable As e_CuentaContable) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.ISP_CuentaContable_IAE", "E",
             "", oeCuentaContable.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ComboGrilla(ByVal oeCuentaContable As e_CuentaContable)
        Try
            Dim ds = New DataTable
            ds.Columns.Add("Id")
            ds.Columns.Add("Nombre")
            For Each item As e_CuentaContable In Listar(oeCuentaContable)
                Dim newRow As DataRow = ds.NewRow()
                newRow("Id") = item.Id
                newRow("Nombre") = item.Cuenta
                ds.Rows.Add(newRow)
            Next
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
