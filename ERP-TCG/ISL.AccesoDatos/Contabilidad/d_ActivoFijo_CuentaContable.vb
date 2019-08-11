Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ActivoFijo_CuentaContable
    Private sqlhelper As SqlHelper

    Private Function Cargar(Fila As DataRow) As e_ActivoFijo_CuentaContable
        Try
            Dim oeActivoFijo_CuentaContable = New e_ActivoFijo_CuentaContable With {
                             .Id = Fila("Id").ToString() _
                             , .IdActivoFijo = Fila("IdActivoFijo").ToString() _
                             , .IdPeriodo = Fila("IdPeriodo").ToString() _
                             , .Descripcion = Fila("Descripcion").ToString() _
                             , .IndInformacionContable = Fila("IndInformacionContable") _
                             , .FechaAdquiere = Fila("FechaAdquiere") _
                             , .IndFecActivacion = Fila("IndFecActivacion") _
                             , .FechaActivacion = Fila("FechaActivacion") _
                             , .IdCtaCtbleCompra = Fila("IdCtaCtbleCompra").ToString() _
                             , .IdCtaCtbleRevalorizacion = Fila("IdCtaCtbleRevalorizacion").ToString() _
                             , .IdCtaCtbeDepreciacion = Fila("IdCtaCtbeDepreciacion").ToString() _
                             , .IdCtaCtbleReadeacuacion = Fila("IdCtaCtbleReadeacuacion").ToString() _
                             , .ValorResidual = Fila("ValorResidual") _
                             , .DepreciacionAcumulada = Fila("DepreciacionAcumulada") _
                             , .TipoAdquisicion = Fila("TipoAdquisicion") _
                             , .Actual = Fila("Actual") _
                             , .IdEmpFinancia = Fila("IdEmpFinancia").ToString() _
                             , .Observacion = Fila("Observacion") _
                             , .Activo = Fila("Activo") _
                             , .UsuarioCreacion = Fila("UsuarioCreacion").ToString() _
                             , .FechaCreacion = Fila("FechaCreacion") _
                             , .UsuarioModificacion = Fila("UsuarioModificacion").ToString() _
                             , .FechaModificacion = Fila("FechaModificacion") _
                             , .NroLeasing = Fila("NroLeasing").ToString() _
                             , .ValorCuota = Fila("ValorCuota") _
                             , .FechaVencimiento = Fila("FechaVencimiento") _
                             , .Ejercicio = Fila("Ejercicio") _
                             , .CtaCtbleCompra = Fila("CtaCtbleCompra").ToString() _
                             , .CtaCtbleRevalorizacion = Fila("CtaCtbleRevalorizacion").ToString() _
                             , .CtaCtbeDepreciacion = Fila("CtaCtbeDepreciacion").ToString() _
                             , .CtaCtbleReadeacuacion = Fila("CtaCtbleReadeacuacion").ToString() _
                             , .CtaCtbleCompraH = Fila("CtaCtbleCompraH").ToString() _
                             , .CtaCtbleRevalorizacionH = Fila("CtaCtbleRevalorizacionH").ToString() _
                             , .CtaCtbeDepreciacionH = Fila("CtaCtbeDepreciacionH").ToString() _
                             , .CtaCtbleReadeacuacionH = Fila("CtaCtbleReadeacuacionH").ToString() _
                             , .IdTipoActivo = Fila("IdTipoActivo").ToString() _
                             , .TipoActivo = Fila("TipoActivo").ToString() _
                             , .CtaCtbleDesactivacionD = Fila("CtaCtbleDesactivacionD").ToString() _
                             , .GastoFuncion = Fila("GastoFuncion").ToString() _
                           , .IdMetodoDepreciacion = Fila("IdMetodoDepreciacion").ToString() _
                         , .NroAutorizacion = Fila("NroAutorizacion").ToString() _
                       , .IdReadecuacion = Fila("IdReadecuacion").ToString() _
            }
            Return oeActivoFijo_CuentaContable
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(oeActivoFijo_CuentaContable As e_ActivoFijo_CuentaContable) As DataSet
        Try
            sqlhelper = New SqlHelper
            Dim ds As DataSet
            With oeActivoFijo_CuentaContable
                ds = sqlhelper.ExecuteDataset("[CON].[Isp_ActivoFijo_CuentaContable_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdActivoFijo _
                        , .IdPeriodo _
                        , .Descripcion _
                        , .IndInformacionContable _
                        , .FechaAdquiere _
                        , .IndFecActivacion _
                        , .FechaActivacion _
                        , .IdCtaCtbleCompra _
                        , .IdCtaCtbleRevalorizacion _
                        , .IdCtaCtbeDepreciacion _
                        , .IdCtaCtbleReadeacuacion _
                        , .ValorResidual _
                        , .DepreciacionAcumulada _
                        , .TipoAdquisicion _
                        , .Actual _
                        , .IdEmpFinancia _
                        , .Observacion _
                        , .Activo _
                        , .NroLeasing _
                        , .ValorCuota _
                        , .FechaVencimiento _
                        , .Ejercicio _
                        , .IdTipoActivo
                        )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeActivoFijo_CuentaContable As e_ActivoFijo_CuentaContable) As e_ActivoFijo_CuentaContable
        Try
            Dim ds As DataSet = ExecuteLST(oeActivoFijo_CuentaContable)
            If ds.Tables(0).rows.Count > 0 Then
                oeActivoFijo_CuentaContable = Cargar(ds.Tables(0).Rows(0))
            Else
                oeActivoFijo_CuentaContable = New e_ActivoFijo_CuentaContable
            End If
            Return oeActivoFijo_CuentaContable
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeActivoFijo_CuentaContable As e_ActivoFijo_CuentaContable) As List(Of e_ActivoFijo_CuentaContable)
        Try
            Dim lstActivoFijo_CuentaContable As New List(Of e_ActivoFijo_CuentaContable)
            Dim ds As DataSet = ExecuteLST(oeActivoFijo_CuentaContable)
            oeActivoFijo_CuentaContable = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeActivoFijo_CuentaContable = Cargar(o_Fila)
                    lstActivoFijo_CuentaContable.Add(oeActivoFijo_CuentaContable)
                Next
            End If
            Return lstActivoFijo_CuentaContable
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeActivoFijo_CuentaContable As e_ActivoFijo_CuentaContable) As Boolean
        Try
            'Using transScope As New TransactionScope()
            sqlhelper = New SqlHelper
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim IdResultado As String
            With oeActivoFijo_CuentaContable
                IdResultado = sqlhelper.ExecuteScalar("[CON].[Isp_ActivoFijo_CuentaContable_IAE]" _
                        , .TipoOperacion _
                        , d_DatosConfiguracion.PrefijoID _
                        , .Id _
                        , .IdActivoFijo _
                        , .IdPeriodo _
                        , .Descripcion _
                        , .IndInformacionContable _
                        , .FechaAdquiere _
                        , .IndFecActivacion _
                        , .FechaActivacion _
                        , .IdCtaCtbleCompra _
                        , .IdCtaCtbleRevalorizacion _
                        , .IdCtaCtbeDepreciacion _
                        , .IdCtaCtbleReadeacuacion _
                        , .ValorResidual _
                        , .DepreciacionAcumulada _
                        , .TipoAdquisicion _
                        , .Actual _
                        , .IdEmpFinancia _
                        , .Observacion _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .NroLeasing _
                        , .ValorCuota _
                        , .FechaVencimiento _
                        , .Ejercicio _
                        , .IdTipoActivo _
                        , .IdMetodoDepreciacion _
                        , .NroAutorizacion _
                        , .IdReadecuacion _
                    ).ToString()
                .Id = IdResultado
            End With
            'transScope.Complete()
            'End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(oeActivoFijo_CuentaContable As e_ActivoFijo_CuentaContable) As Boolean
        Try
            sqlhelper = New SqlHelper
            With oeActivoFijo_CuentaContable
                sqlhelper.ExecuteNonQuery("[CON].[Isp_ActivoFijo_CuentaContable_IAE]" _
                       , "E" _
                       , "" _
                       , .Id _
                       , .IdActivoFijo _
                       , .IdPeriodo _
                       , .Descripcion _
                       , .IndInformacionContable _
                       , .FechaAdquiere _
                       , .IndFecActivacion _
                       , .FechaActivacion _
                       , .IdCtaCtbleCompra _
                       , .IdCtaCtbleRevalorizacion _
                       , .IdCtaCtbeDepreciacion _
                       , .IdCtaCtbleReadeacuacion _
                       , .ValorResidual _
                       , .DepreciacionAcumulada _
                       , .TipoAdquisicion _
                       , .Actual _
                       , .IdEmpFinancia _
                       , .Observacion _
                       , .Activo _
                       , .UsuarioCreacion _
                       , .NroLeasing _
                       , .ValorCuota _
                       , .FechaVencimiento _
                       , .Ejercicio _
                       , .IdTipoActivo _
                   )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class

