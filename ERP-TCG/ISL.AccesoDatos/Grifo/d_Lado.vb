' ===================================================================================================
' Modified | Developer
' 02/01/20 | Cess
' ===================================================================================================
Imports ERP.EntidadesWCF
Public Class d_Lado
    Private SQL As New SqlHelper
    Private DS As New DataSet
    Public Function Obtener(ByVal Item As e_Lado) As e_Lado
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

    Public Function Listar(ByVal item As e_Lado) As List(Of e_Lado)
        Try
            Dim ldLado As New List(Of e_Lado)
            Dim ds As DataSet = ExecuteLST(item)
            item = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    item = Cargar(o_Fila)
                    ldLado.Add(item)
                Next
            End If
            Return ldLado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal Item As e_Lado) As e_Lado
        Try
            'Using transScope As New TransactionScope()
            Dim stResultado() As String
            With Item
                stResultado = SQL.ExecuteScalar("[GRF].[Sp_Lado_IAE]" _
                        , .TipoOperacion _
                        , .PrefijoID _
                        , .Id _
                        , .IdEmpresaSis _
                        , .IdSucursal _
                        , .IdIsla _
                        , .Nombre _
                        , .Diesel _
                        , .G84 _
                        , .G90 _
                        , .G95 _
                        , .Estado _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .UsuarioModifica _
                        , .FechaModifica _
                        , .Activo
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

    Public Function Eliminar(ByVal Item As e_Lado) As Boolean
        Try
            With Item
                SQL.ExecuteNonQuery("[GRF].[Sp_Lado_IAE]" _
                       , "E" _
                       , "" _
                       , .Id _
                       , .IdEmpresaSis _
                       , .IdSucursal _
                       , .IdIsla _
                       , .Nombre _
                       , .Diesel _
                       , .G84 _
                       , .G90 _
                       , .G95 _
                       , .Estado _
                       , .UsuarioCreacion _
                       , .FechaCreacion _
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

#Region "Operaciones Basicas"

    Private Function Cargar(ByVal o_fila As DataRow) As e_Lado
        Try
            Dim Item = New e_Lado(
                             o_fila("Id").ToString _
                             , o_fila("IdEmpresaSis").ToString _
                             , o_fila("IdSucursal").ToString _
                             , o_fila("IdIsla").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Diesel").ToString _
                             , o_fila("G84").ToString _
                             , o_fila("G90").ToString _
                             , o_fila("G95").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("FechaModifica").ToString _
                             , o_fila("Activo").ToString
            )
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function ExecuteLST(ByVal Item As e_Lado) As DataSet
        Try
            Dim ds As DataSet
            With Item
                ds = SQL.ExecuteDataset("[GRF].[Sp_Lado_LST]" _
                        , .TipoOperacion _
                        , "" _
                        , "" _
                        , .Id _
                        , .IdEmpresaSis _
                        , .IdSucursal _
                        , .IdIsla _
                        , .Nombre _
                        , .Diesel _
                        , .G84 _
                        , .G90 _
                        , .G95 _
                        , .Estado _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
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
#End Region

End Class
