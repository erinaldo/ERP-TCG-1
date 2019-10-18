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

Public Class d_DepreciacionActivoFijo
    Private sqlhelper As New SqlHelper
    Private Function Cargar(Fila As DataRow) As e_DepreciacionActivoFijo
        Try
            Dim oeDepreciacionActivoFijo = New e_DepreciacionActivoFijo With {
                             .Id = Fila("Id").ToString() _
                             , .IdActivoFijo = Fila("IdActivoFijo").ToString() _
                             , .IdPeriodo = Fila("IdPeriodo").ToString() _
                             , .IdAFCuentaContable = Fila("IdAFCuentaContable").ToString() _
                             , .IdCuentaOrigen = Fila("IdCuentaOrigen").ToString() _
                             , .IdCuentaDestino = Fila("IdCuentaDestino").ToString() _
                             , .Valor = Fila("Valor") _
                             , .Importe = Fila("Importe") _
                             , .Observacion = Fila("Observacion").ToString() _
                             , .Actual = Fila("Actual") _
                             , .FechaCreacion = Fila("FechaCreacion") _
                             , .UsuarioCreacion = Fila("UsuarioCreacion").ToString() _
                             , .Activo = Fila("Activo") _
                             , .IdAsiento = Fila("IdAsiento").ToString() _
                             , .Periodo = Fila("Periodo").ToString() _
            }
            Return oeDepreciacionActivoFijo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(oeDepreciacionActivoFijo As e_DepreciacionActivoFijo) As DataSet
        Try
            sqlhelper = New SqlHelper
            Dim ds As DataSet
            With oeDepreciacionActivoFijo
                ds = sqlhelper.ExecuteDataset("[CON].[Isp_DepreciacionActivoFijo_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdActivoFijo _
                        , .IdPeriodo _
                        , .IdAFCuentaContable _
                        , .IdCuentaOrigen _
                        , .IdCuentaDestino _
                        , .Valor _
                        , .Importe _
                        , .Observacion _
                        , .Actual _
                        , .Activo _
                        , .IdAsiento _
                        )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeDepreciacionActivoFijo As e_DepreciacionActivoFijo) As e_DepreciacionActivoFijo
        Try
            Dim ds As DataSet = ExecuteLST(oeDepreciacionActivoFijo)
            If ds.Tables(0).rows.Count > 0 Then
                oeDepreciacionActivoFijo = Cargar(ds.Tables(0).Rows(0))
            Else
                oeDepreciacionActivoFijo = New e_DepreciacionActivoFijo
            End If
            Return oeDepreciacionActivoFijo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeDepreciacionActivoFijo As e_DepreciacionActivoFijo) As List(Of e_DepreciacionActivoFijo)
        Try
            Dim lstDepreciacionActivoFijo As New List(Of e_DepreciacionActivoFijo)
            Dim ds As DataSet = ExecuteLST(oeDepreciacionActivoFijo)
            oeDepreciacionActivoFijo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDepreciacionActivoFijo = Cargar(o_Fila)
                    lstDepreciacionActivoFijo.Add(oeDepreciacionActivoFijo)
                Next
            End If
            Return lstDepreciacionActivoFijo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeDepreciacionActivoFijo As e_DepreciacionActivoFijo) As Boolean
        Try
            'Using transScope As New TransactionScope()

            Dim IdResultado As String
            With oeDepreciacionActivoFijo
                IdResultado = sqlhelper.ExecuteScalar("[CON].[Isp_DepreciacionActivoFijo_IAE]" _
                        , .TipoOperacion _
                        , .PrefijoID _
                        , .Id _
                        , .IdActivoFijo _
                        , .IdPeriodo _
                        , .IdAFCuentaContable _
                        , .IdCuentaOrigen _
                        , .IdCuentaDestino _
                        , .Valor _
                        , .Importe _
                        , .Observacion _
                        , .Actual _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .IdAsiento _
                        , "" _
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

    Public Function Eliminar(oeDepreciacionActivoFijo As e_DepreciacionActivoFijo) As Boolean
        Try
            sqlhelper = New SqlHelper
            With oeDepreciacionActivoFijo
                sqlhelper.ExecuteNonQuery("[CON].[Isp_DepreciacionActivoFijo_IAE]" _
                       , "E" _
                       , "" _
                       , .Id _
                       , .IdActivoFijo _
                       , .IdPeriodo _
                       , .IdAFCuentaContable _
                       , .IdCuentaOrigen _
                       , .IdCuentaDestino _
                       , .Valor _
                       , .Importe _
                       , .Observacion _
                       , .Actual _
                       , .UsuarioCreacion _
                       , .Activo _
                       , .IdAsiento _
                       , "" _
                   )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo(DTDepreciacion As DataTable, DTAsiento As DataTable, DTAsientoMov As DataTable, DTAnalisis As DataTable, CadenaXML As String) As Boolean
        Try
            Using transScope As New TransactionScope()
                If DTAsiento.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.Asiento", DTAsiento, False)
                If DTAsientoMov.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.AsientoMovimiento", DTAsientoMov, False)
                If DTDepreciacion.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.DepreciacionActivoFijo", DTDepreciacion, False)
                If DTAnalisis.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.MovimientoAnalisis", DTAnalisis, False)
                ActualizarDeprecAcumulada(CadenaXML)
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub ActualizarDeprecAcumulada(XML As String)
        Try

            Dim oeDepreciacionActivoFijo As New e_DepreciacionActivoFijo
            With oeDepreciacionActivoFijo
                sqlhelper.ExecuteNonQuery("[CON].[Isp_DepreciacionActivoFijo_IAE]" _
                        , "A" _
                        , .PrefijoID _
                        , .Id _
                        , .IdActivoFijo _
                        , .IdPeriodo _
                        , .IdAFCuentaContable _
                        , .IdCuentaOrigen _
                        , .IdCuentaDestino _
                        , .Valor _
                        , .Importe _
                        , .Observacion _
                        , .Actual _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .IdAsiento _
                        , XML
                    ).ToString()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.DepreciacionActivoFijo", PrefijoID
                                  )
            Return IIf(stResultado Is Nothing, PrefijoID & "000000000001", stResultado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
