Imports ERP.EntidadesWCF
Public Class d_CierreTurno
    Private SQL As New SqlHelper
    Private DS As New DataSet
    Private dCTD As New d_CierreTurno_Detalle
    Private Function Cargar(ByVal o_fila As DataRow) As e_CierreTurno
        Try
            Dim Item = New e_CierreTurno(
                             o_fila("Id").ToString _
                             , o_fila("IdEmpresaSis").ToString _
                             , o_fila("IdSucursal").ToString _
                             , o_fila("IdTurno").ToString _
                             , o_fila("Turno").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("HoraInicio").ToString _
                             , o_fila("HoraFin").ToString _
                             , o_fila("IdTrabajador_Apertura").ToString _
                             , o_fila("Trabajador_Apertura").ToString _
                             , o_fila("IdTrabajador_Cierre").ToString _
                             , o_fila("Trabajador_Cierre").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("UsuarioCrea").ToString _
                             , o_fila("FechaCrea").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("FechaModifica").ToString _
                             , o_fila("Activo").ToString
            )
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function ExecuteLST(ByVal Item As e_CierreTurno) As DataSet
        Try
            Dim ds As DataSet
            With Item
                ds = SQL.ExecuteDataset("[CMP].[Sp_CierreTurno_LST]" _
                        , .TipoOperacion _
                        , "" _
                        , "" _
                        , .Id _
                        , .IdEmpresaSis _
                        , .IdSucursal _
                        , .IdTurno _
                        , .Turno _
                        , .IdEstado _
                        , .Estado _
                        , .Fecha _
                        , .HoraInicio _
                        , .HoraFin _
                        , .IdTrabajador_Apertura _
                        , .Trabajador_Apertura _
                        , .IdTrabajador_Cierre _
                        , .Trabajador_Cierre _
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
    Public Function Obtener(ByVal Item As e_CierreTurno) As e_CierreTurno
        Try
            Dim ds As DataSet = ExecuteLST(Item)
            If ds.Tables(0).Rows.Count > 0 Then
                Item = Cargar(ds.Tables(0).Rows(0))
                Item.Detalles = dCTD.Listar(New e_CierreTurno_Detalle With {.IdCierreTurno = Item.Id})
            End If
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal item As e_CierreTurno) As List(Of e_CierreTurno)
        Try
            Dim ldCierreTurno As New List(Of e_CierreTurno)
            Dim ds As DataSet = ExecuteLST(item)
            item = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    item = Cargar(o_Fila)
                    ldCierreTurno.Add(item)
                Next
            End If
            Return ldCierreTurno
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal Item As e_CierreTurno) As e_CierreTurno
        Try
            'Using transScope As New TransactionScope()
            Dim stResultado() As String
            With Item
                stResultado = SQL.ExecuteScalar("[CMP].[Sp_CierreTurno_IAE]" _
                        , .TipoOperacion _
                        , .PrefijoID _
                        , .Id _
                        , .IdEmpresaSis _
                        , .IdSucursal _
                        , .IdTurno _
                        , .Turno _
                        , .IdEstado _
                        , .Estado _
                        , .Fecha _
                        , .HoraInicio _
                        , .HoraFin _
                        , .IdTrabajador_Apertura _
                        , .Trabajador_Apertura _
                        , .IdTrabajador_Cierre _
                        , .Trabajador_Cierre _
                        , .Glosa _
                        , .UsuarioCrea _
                        , .FechaCrea _
                        , .UsuarioModifica _
                        , .FechaModifica _
                        , .Activo
                    ).ToString.Split("_")
                .Id = stResultado(0)
                For Each Detalle In .Detalles
                    Detalle.IdCierreTurno = .Id
                    Detalle.TipoOperacion = .TipoOperacion
                    Detalle.PrefijoID = .PrefijoID
                    Detalle.IdEmpresaSis = .IdEmpresaSis
                    dCTD.Guardar(Detalle)
                Next
            End With
            'transScope.Complete()
            'End Using
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal Item As e_CierreTurno) As Boolean
        Try
            With Item
                SQL.ExecuteNonQuery("[CMP].[Sp_CierreTurno_IAE]" _
                       , "E" _
                       , "" _
                       , .Id _
                       , .IdEmpresaSis _
                       , .IdSucursal _
                       , .IdTurno _
                       , .Turno _
                       , .IdEstado _
                       , .Estado _
                       , .Fecha _
                       , .HoraInicio _
                       , .HoraFin _
                       , .IdTrabajador_Apertura _
                       , .Trabajador_Apertura _
                       , .IdTrabajador_Cierre _
                       , .Trabajador_Cierre _
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

