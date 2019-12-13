Imports ERP.EntidadesWCF

Public Class d_CierreTurno_Detalle

    Private SQL As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_CierreTurno_Detalle
        Try
            Dim oeCierreTurno_Detalle = New e_CierreTurno_Detalle(
                         o_fila("Id").ToString _
                         , o_fila("IdEmpresaSis").ToString _
                         , o_fila("IdSucursal").ToString _
                         , o_fila("IdCierreTurno").ToString _
                         , o_fila("Grupo").ToString _
                         , o_fila("Rubro").ToString _
                         , o_fila("Descripcion").ToString _
                         , o_fila("IdConcepto").ToString _
                         , o_fila("Concepto").ToString _
                         , o_fila("ValorInicial").ToString _
                         , o_fila("ValorFinal").ToString _
                         , o_fila("ValorDiferencia").ToString _
                         , o_fila("ValorERP").ToString _
                         , o_fila("ValorReal").ToString _
                         , o_fila("ValorAux1").ToString _
                         , o_fila("ValorAux2").ToString _
                         , o_fila("Glosa").ToString _
                         , o_fila("UsuarioCrea").ToString _
                         , o_fila("FechaCrea").ToString _
                         , o_fila("UsuarioModifica").ToString _
                         , o_fila("FechaModifica").ToString _
                         , o_fila("Activo").ToString
        )
            Return oeCierreTurno_Detalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(ByVal oeCierreTurno_Detalle As e_CierreTurno_Detalle) As DataSet
        Try
            Dim ds As DataSet
            With oeCierreTurno_Detalle
                ds = SQL.ExecuteDataset("[CMP].[Sp_CierreTurno_Detalle_LST]" _
                , .TipoOperacion _
                , "" _
                , "" _
                , .Id _
                , .IdEmpresaSis _
                , .IdSucursal _
                , .IdCierreTurno _
                , .Grupo _
                , .Rubro _
                , .Descripcion _
                , .IdConcepto _
                , .Concepto _
                , .ValorInicial _
                , .ValorFinal _
                , .ValorDiferencia _
                , .ValorERP _
                , .ValorReal _
                , .ValorAux1 _
                , .ValorAux2 _
                , .Glosa _
                , .UsuarioCrea _
                , .FechaCrea _
                , .UsuarioModifica _
                , .FechaModifica _
                , .Activo
                )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCierreTurno_Detalle As e_CierreTurno_Detalle) As e_CierreTurno_Detalle
        Try
            Dim ds As DataSet = ExecuteLST(oeCierreTurno_Detalle)
            If ds.Tables(0).Rows.Count > 0 Then
                oeCierreTurno_Detalle = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCierreTurno_Detalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCierreTurno_Detalle As e_CierreTurno_Detalle) As List(Of e_CierreTurno_Detalle)
        Try
            Dim ldCierreTurno_Detalle As New List(Of e_CierreTurno_Detalle)
            Dim ds As DataSet = ExecuteLST(oeCierreTurno_Detalle)
            oeCierreTurno_Detalle = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCierreTurno_Detalle = Cargar(o_Fila)
                    ldCierreTurno_Detalle.Add(oeCierreTurno_Detalle)
                Next
            End If
            Return ldCierreTurno_Detalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCierreTurno_Detalle As e_CierreTurno_Detalle) As e_CierreTurno_Detalle
        Try
            'Using transScope As New TransactionScope()
            Dim stResultado() As String
            With oeCierreTurno_Detalle
                stResultado = SQL.ExecuteScalar("[CMP].[Sp_CierreTurno_Detalle_IAE]" _
                , .TipoOperacion _
                , .PrefijoID _
                , .Id _
                , .IdEmpresaSis _
                , .IdSucursal _
                , .IdCierreTurno _
                , .Grupo _
                , .Rubro _
                , .Descripcion _
                , .IdConcepto _
                , .Concepto _
                , .ValorInicial _
                , .ValorFinal _
                , .ValorDiferencia _
                , .ValorERP _
                , .ValorReal _
                , .ValorAux1 _
                , .ValorAux2 _
                , .Glosa _
                , .UsuarioCrea _
                , .FechaCrea _
                , .UsuarioModifica _
                , .FechaModifica _
                , .Activo
            ).ToString.Split("_")
                .Id = stResultado(0)
            End With
            'transScope.Complete()
            'End Using
            Return oeCierreTurno_Detalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCierreTurno_Detalle As e_CierreTurno_Detalle) As Boolean
        Try
            With oeCierreTurno_Detalle
                Sql.ExecuteNonQuery("[CMP].[Sp_CierreTurno_Detalle_IAE]" _
                , "E" _
                , "" _
                , .Id _
                , .IdEmpresaSis _
                , .IdSucursal _
                , .IdCierreTurno _
                , .Grupo _
                , .Rubro _
                , .Descripcion _
                , .IdConcepto _
                , .Concepto _
                , .ValorInicial _
                , .ValorFinal _
                , .ValorDiferencia _
                , .ValorERP _
                , .ValorReal _
                , .ValorAux1 _
                , .ValorAux2 _
                , .Glosa _
                , .UsuarioCrea _
                , .FechaCrea _
                , .UsuarioModifica _
                , .FechaModifica _
                , .Activo
            )

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
