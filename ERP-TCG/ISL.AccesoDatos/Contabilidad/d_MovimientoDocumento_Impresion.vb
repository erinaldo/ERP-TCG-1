Imports ERP.EntidadesWCF

Public Class d_MovimientoDocumento_Impresion
    Private SQL As New SqlHelper
    Private DS As New DataSet
    Public Function Obtener(ByVal Item As e_MovimientoDocumento_Impresion) As e_MovimientoDocumento_Impresion
        Try
            Dim ds As DataSet = ExecuteLST(Item)
            If ds.Tables(0).Rows.Count > 0 Then
                Item = Cargar(ds.Tables(0).Rows(0))
            End If
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal item As e_MovimientoDocumento_Impresion) As List(Of e_MovimientoDocumento_Impresion)
        Try
            Dim ldMovimientoDocumento_Impresion As New List(Of e_MovimientoDocumento_Impresion)
            Dim ds As DataSet = ExecuteLST(item)
            item = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    item = Cargar(o_Fila)
                    ldMovimientoDocumento_Impresion.Add(item)
                Next
            End If
            Return ldMovimientoDocumento_Impresion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal Item As e_MovimientoDocumento_Impresion) As e_MovimientoDocumento_Impresion
        Try
            'Using transScope As New TransactionScope()
            Dim stResultado() As String
            With Item
                stResultado = SQL.ExecuteScalar("[CON].[Sp_MovimientoDocumento_Impresion_IAE]" _
                , .TipoOperacion _
                , .PrefijoID _
                , .Id _
                , .IdMovimientoDocumento _
                , .IdTipoDocumento _
                , .TipoDocumento _
                , .IdTurno _
                , .Turno _
                , .NombreClienteProveedor _
                , .NroDocumentoClienteProveedor _
                , .IdDireccion _
                , .Direccion _
                , .IdVechiculo _
                , .Placa _
                , .IdMedioPago _
                , .MedioPago _
                , .IdTrabajador _
                , .Trabajador _
                , .Activo _
                , .UsuarioCreacion _
                , .FechaCreacion _
                , .UsuarioModifica _
                , .FechaModificacion
            ).ToString.Split("_")
                .Id = stResultado(0)
            End With
            'transScope.Complete()
            'End Using
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal Item As e_MovimientoDocumento_Impresion) As Boolean
        Try
            With Item
                SQL.ExecuteNonQuery("[CON].[Sp_MovimientoDocumento_Impresion_IAE]" _
                , "E" _
                , "" _
                , .Id _
                , .IdMovimientoDocumento _
                , .IdTipoDocumento _
                , .TipoDocumento _
                , .IdTurno _
                , .Turno _
                , .NombreClienteProveedor _
                , .NroDocumentoClienteProveedor _
                , .IdDireccion _
                , .Direccion _
                , .IdVechiculo _
                , .Placa _
                , .IdMedioPago _
                , .MedioPago _
                , .IdTrabajador _
                , .Trabajador _
                , .Activo _
                , .UsuarioCreacion _
                , .FechaCreacion _
                , .UsuarioModifica _
                , .FechaModificacion
            )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#Region "Operaciones Basicas"

    Private Function Cargar(ByVal o_fila As DataRow) As e_MovimientoDocumento_Impresion
        Try
            Dim Item = New e_MovimientoDocumento_Impresion(
                         o_fila("Id").ToString _
                         , o_fila("IdMovimientoDocumento").ToString _
                         , o_fila("IdTipoDocumento").ToString _
                         , o_fila("TipoDocumento").ToString _
                         , o_fila("IdTurno").ToString _
                         , o_fila("Turno").ToString _
                         , o_fila("NombreClienteProveedor").ToString _
                         , o_fila("NroDocumentoClienteProveedor").ToString _
                         , o_fila("IdDireccion").ToString _
                         , o_fila("Direccion").ToString _
                         , o_fila("IdVechiculo").ToString _
                         , o_fila("Placa").ToString _
                         , o_fila("IdMedioPago").ToString _
                         , o_fila("MedioPago").ToString _
                         , o_fila("IdTrabajador").ToString _
                         , o_fila("Trabajador").ToString _
                         , o_fila("Activo").ToString _
                         , o_fila("UsuarioCreacion").ToString _
                         , o_fila("FechaCreacion").ToString _
                         , o_fila("UsuarioModifica").ToString _
                         , o_fila("FechaModificacion").ToString
        )
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function ExecuteLST(ByVal Item As e_MovimientoDocumento_Impresion) As DataSet
        Try
            Dim ds As DataSet
            With Item
                ds = SQL.ExecuteDataset("[CON].[Sp_MovimientoDocumento_Impresion_LST]" _
                , .TipoOperacion _
                , "" _
                , "" _
                , .Id _
                , .IdMovimientoDocumento _
                , .IdTipoDocumento _
                , .TipoDocumento _
                , .IdTurno _
                , .Turno _
                , .NombreClienteProveedor _
                , .NroDocumentoClienteProveedor _
                , .IdDireccion _
                , .Direccion _
                , .IdVechiculo _
                , .Placa _
                , .IdMedioPago _
                , .MedioPago _
                , .IdTrabajador _
                , .Trabajador _
                , .Activo _
                , .UsuarioCreacion _
                , .FechaCreacion _
                , .UsuarioModifica _
                , .FechaModificacion
                )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

End Class

