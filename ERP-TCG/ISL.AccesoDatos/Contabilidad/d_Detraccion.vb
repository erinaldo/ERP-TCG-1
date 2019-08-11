Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Detraccion
    Dim d_DatosConfiguracion As New d_DatosConfiguracion
    Dim bd As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Detraccion
        Try
            Dim oeDetraccion = New e_Detraccion( _
                             o_fila("Id").ToString _
                             , o_fila("IdAdquirienteProveedor").ToString _
                             , o_fila("Empresa").ToString _
                             , o_fila("RUC").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("NroLote").ToString _
                             , o_fila("Tipo").ToString _
                             , o_fila("NombreTipo").ToString _
                             , o_fila("Total") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Activo").ToString)
            Return oeDetraccion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(ByVal oeDetraccion As e_Detraccion) As DataSet
        Try
            Dim ds As DataSet
            With oeDetraccion
                ds = bd.ExecuteDataset("[CON].[Isp_Detraccion_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdAdquirienteProveedor _
                        , .NroLote _
                        , .Tipo)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetraccion As e_Detraccion) As e_Detraccion
        Try
            Dim ds As DataSet = ExecuteLST(oeDetraccion)
            If ds.Tables(0).Rows.Count > 0 Then
                oeDetraccion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetraccion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeDetraccion As e_Detraccion) As List(Of e_Detraccion)
        Try
            Dim ldDetraccion As New List(Of e_Detraccion)
            Dim ds As DataSet = ExecuteLST(oeDetraccion)
            oeDetraccion = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDetraccion = Cargar(o_Fila)
                    ldDetraccion.Add(oeDetraccion)
                Next
            End If
            Return ldDetraccion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeDetraccion As e_Detraccion) As Boolean
        Try
            Dim odDetDetalle As New d_DetraccionDetalle
            Dim odMovimientoDocumento As New d_MovimientoDocumento
            Using transScope As New TransactionScope()
                Dim stResultado() As String
                With oeDetraccion
                    stResultado = bd.ExecuteScalar("[CON].[Isp_Detraccion_IAE]" _
                            , .TipoOperacion _
                            , d_DatosConfiguracion.PrefijoID _
                            , .Id _
                            , .IdAdquirienteProveedor _
                            , .IdEstado _
                            , .NroLote _
                            , .Tipo _
                            , .Total _
                            , .UsuarioCreacion).ToString.Split("_")
                    .Id = stResultado(0)
                    For Each detdet As e_DetraccionDetalle In .loDetraccionDet
                        detdet.IdDetraccion = .Id
                        If detdet.TipoOperacion = "" Then detdet.TipoOperacion = .TipoOperacion
                        detdet.UsuarioCreacion = .UsuarioCreacion
                        odDetDetalle.Guardar(detdet)     
                    Next
                    If .TipoOperacion = "S" Then
                        For Each oe As e_MovimientoDocumento In .loDocumento
                            odMovimientoDocumento.GuardarGastoOperacion(oe)
                        Next
                        For Each detdet As e_DetraccionDetalle In .loDetraccionDet
                            detdet.TipoOperacion = .TipoOperacion
                            odDetDetalle.Guardar(detdet)
                        Next
                    End If
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetraccion As e_Detraccion) As Boolean
        Try
            With oeDetraccion
                bd.ExecuteNonQuery("[CON].[Sp_Detraccion_IAE]" _
                       , "E" _
                       , "" _
                       , .Id)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub GuardaMasivo(DTAsiento As DataTable, DTAsiMov As DataTable, DTMovCajBan As DataTable, DTAsiMovMovDoc As DataTable, DTCtaCyP As DataTable)
        Try
            If DTAsiento.Rows.Count > 0 Then bd.InsertarMasivo("CON.Asiento", DTAsiento, False)
            If DTAsiMov.Rows.Count > 0 Then bd.InsertarMasivo("CON.AsientoMovimiento", DTAsiMov, False)
            If DTMovCajBan.Rows.Count > 0 Then bd.InsertarMasivo("CON.MovimientoCajaBanco", DTMovCajBan, False)
            If DTCtaCyP.Rows.Count > 0 Then bd.InsertarMasivo("TES.CuentaxCyP", DTCtaCyP, False)
            If DTAsiMovMovDoc.Rows.Count > 0 Then bd.InsertarMasivo("CON.AsientoMov_MovDoc", DTAsiMovMovDoc, False)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
