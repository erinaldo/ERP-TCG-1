Imports ISL.EntidadesWCF
Public Class d_TipoActivoFijo_CtaCtble

    Private sqlhelper As SqlHelper
    Private Function Cargar(Fila As DataRow) As e_TipoActivoFijo_CtaCtble
        Try
            Dim oeTipoActivoFijo_CtaCtble = New e_TipoActivoFijo_CtaCtble With {
                             .Id = Fila("Id").ToString() _
                             , .IdTipoActivoFijo = Fila("IdTipoActivoFijo").ToString() _
                             , .TipoActivoFijo = Fila("TipoActivoFijo").ToString() _
                             , .IdCtaCtbleCompraD = Fila("IdCtaCtbleCompraD").ToString() _
                             , .CtaCtbleCompraD = Fila("CtaCtbleCompraD").ToString() _
                             , .IdCtaCtbleCompraH = Fila("IdCtaCtbleCompraH").ToString() _
                             , .CtaCtbleCompraH = Fila("CtaCtbleCompraH").ToString() _
                             , .IdCtaCtbleDeprecD = Fila("IdCtaCtbleDeprecD").ToString() _
                             , .CtaCtbleDeprecD = Fila("CtaCtbleDeprecD").ToString() _
                             , .IdCtaCtbleDeprecH = Fila("IdCtaCtbleDeprecH").ToString() _
                             , .CtaCtbleDeprecH = Fila("CtaCtbleDeprecH").ToString() _
                             , .IdCtaCtbleRevalorizacionD = Fila("IdCtaCtbleRevalorizacionD").ToString() _
                             , .CtaCtbleRevalorizacionD = Fila("CtaCtbleRevalorizacionD").ToString() _
                             , .IdCtaCtbleRevalorizacionH = Fila("IdCtaCtbleRevalorizacionH").ToString() _
                             , .CtaCtbleRevalorizacionH = Fila("CtaCtbleRevalorizacionH").ToString() _
                             , .IdCtaCtbleReadecuacionD = Fila("IdCtaCtbleReadecuacionD").ToString() _
                             , .CtaCtbleReadecuacionD = Fila("CtaCtbleReadecuacionD").ToString() _
                             , .IdCtaCtbleReadecuacionH = Fila("IdCtaCtbleReadecuacionH").ToString() _
                             , .CtaCtbleReadecuacionH = Fila("CtaCtbleReadecuacionH").ToString() _
                             , .Ejercicio = Fila("Ejercicio") _
                             , .UsuarioCreacion = Fila("UsuarioCreacion").ToString() _
                             , .FechaCreacion = Fila("FechaCreacion") _
                             , .UsuarioModificacion = Fila("UsuarioModificacion").ToString() _
                             , .FechaModificacion = Fila("FechaModificacion") _
                             , .Activo = Fila("Activo") _
                             , .IdCtaCtbleBajaD = Fila("IdCtaCtbleBajaD").ToString() _
                             , .CtaCtbleBajaD = Fila("CtaCtbleBajaD").ToString() _
                             , .IndTipoVehiculo = Fila("IndTipoVehiculo") _
                             , .IdGastoFuncion = Fila("IdGastoFuncion").ToString() _
                           , .IdDetConPond = Fila("IdDetConPond").ToString() _
                         , .Porcentaje = Fila("Porcentaje") _
            }
            Return oeTipoActivoFijo_CtaCtble
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(oeTipoActivoFijo_CtaCtble As e_TipoActivoFijo_CtaCtble) As DataSet
        Try
            sqlhelper = New SqlHelper
            Dim ds As DataSet
            With oeTipoActivoFijo_CtaCtble
                ds = sqlhelper.ExecuteDataset("[CON].[Isp_TipoActivoFijo_CtaCtble_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdTipoActivoFijo _
                        , .IdCtaCtbleCompraD _
                        , .IdCtaCtbleCompraH _
                        , .IdCtaCtbleDeprecD _
                        , .IdCtaCtbleDeprecH _
                        , .IdCtaCtbleRevalorizacionD _
                        , .IdCtaCtbleRevalorizacionH _
                        , .IdCtaCtbleReadecuacionD _
                        , .IdCtaCtbleReadecuacionH _
                        , .Ejercicio _
                        , .Activo _
                        )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeTipoActivoFijo_CtaCtble As e_TipoActivoFijo_CtaCtble) As e_TipoActivoFijo_CtaCtble
        Try
            Dim ds As DataSet = ExecuteLST(oeTipoActivoFijo_CtaCtble)
            If ds.Tables(0).Rows.Count > 0 Then
                oeTipoActivoFijo_CtaCtble = Cargar(ds.Tables(0).Rows(0))
            Else
            oeTipoActivoFijo_CtaCtble = New e_TipoActivoFijo_CtaCtble
            End If
            Return oeTipoActivoFijo_CtaCtble
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeTipoActivoFijo_CtaCtble As e_TipoActivoFijo_CtaCtble) As List(Of e_TipoActivoFijo_CtaCtble)
        Try
            Dim lstTipoActivoFijo_CtaCtble As New List(Of e_TipoActivoFijo_CtaCtble)
            Dim ds As DataSet = ExecuteLST(oeTipoActivoFijo_CtaCtble)
            oeTipoActivoFijo_CtaCtble = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoActivoFijo_CtaCtble = Cargar(o_Fila)
                    lstTipoActivoFijo_CtaCtble.Add(oeTipoActivoFijo_CtaCtble)
                Next
            End If
            Return lstTipoActivoFijo_CtaCtble
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeTipoActivoFijo_CtaCtble As e_TipoActivoFijo_CtaCtble) As Boolean
        Try
            'Using transScope As New TransactionScope()
            sqlhelper = New SqlHelper
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim IdResultado As String
            With oeTipoActivoFijo_CtaCtble
                IdResultado = sqlhelper.ExecuteScalar("[CON].[Isp_TipoActivoFijo_CtaCtble_IAE]" _
                        , .TipoOperacion _
                        , .PrefijoID _
                        , .Id _
                        , .IdTipoActivoFijo _
                        , .IdCtaCtbleCompraD _
                        , .IdCtaCtbleCompraH _
                        , .IdCtaCtbleDeprecD _
                        , .IdCtaCtbleDeprecH _
                        , .IdCtaCtbleRevalorizacionD _
                        , .IdCtaCtbleRevalorizacionH _
                        , .IdCtaCtbleReadecuacionD _
                        , .IdCtaCtbleReadecuacionH _
                        , .Ejercicio _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .IdCtaCtbleBajaD _
                        , .IdGastoFuncion _
                        , .IdDetConPond _
                        , .Porcentaje _
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

    Public Function Eliminar(oeTipoActivoFijo_CtaCtble As e_TipoActivoFijo_CtaCtble) As Boolean
        Try
            sqlhelper = New SqlHelper
            With oeTipoActivoFijo_CtaCtble
                sqlhelper.ExecuteNonQuery("[CON].[Isp_TipoActivoFijo_CtaCtble_IAE]" _
                       , "E" _
                       , "" _
                       , .Id _
                       , .IdTipoActivoFijo _
                       , .IdCtaCtbleCompraD _
                       , .IdCtaCtbleCompraH _
                       , .IdCtaCtbleDeprecD _
                       , .IdCtaCtbleDeprecH _
                       , .IdCtaCtbleRevalorizacionD _
                       , .IdCtaCtbleRevalorizacionH _
                       , .IdCtaCtbleReadecuacionD _
                       , .IdCtaCtbleReadecuacionH _
                       , .Ejercicio _
                       , .UsuarioCreacion _
                       , .Activo _
                       , .IdCtaCtbleBajaD _
                       , .IdGastoFuncion
                   )

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
