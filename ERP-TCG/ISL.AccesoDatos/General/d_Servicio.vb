Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Servicio
    Private sqlhelper As New SqlHelper
    Private odServicioCuentaContable As New d_ServicioCuentaContable

    Private Function Cargar(ByVal o_fila As DataRow) As e_Servicio
        Try
            Dim oeServicio = New e_Servicio(o_fila("Seleccion") _
                             , o_fila("Id") _
                             , o_fila("IdCategoriaServicio") _
                             , o_fila("CategoriaServicio") _
                             , o_fila("Codigo") _
                             , o_fila("Nombre") _
                             , o_fila("Precio") _
                             , o_fila("Activo") _
                             , o_fila("IdUnidad") _
                             , o_fila("IdTipoUnidad") _
                             , o_fila("Descripcion") _
                             , o_fila("IdItemGasto"))
            Return oeServicio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeServicio As e_Servicio) As e_Servicio

        Try
            Dim oeSer As New e_Servicio
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Servicio_Listar", oeServicio.TipoOperacion, oeServicio.Id)
            If ds.Tables.Count > 0 Then
                oeSer = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeSer

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeServicio As e_Servicio) As List(Of e_Servicio)
        Try
            Dim ldServicio As New List(Of e_Servicio)
            Dim ds As DataSet
            With oeServicio
                ds = sqlhelper.ExecuteDataset("STD.Isp_Servicio_Listar", .TipoOperacion _
                        , .Id _
                        , .IdCategoriaServicio _
                        , .Codigo _
                        , .Nombre _
                        , .Precio _
                        , .Descripcion _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeServicio = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeServicio = Cargar(o_Fila)
                    ldServicio.Add(oeServicio)
                Next
            End If
            Return ldServicio
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeServicio As e_Servicio) As Boolean
        Dim stResultado() As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using transScope As New TransactionScope()
                With oeServicio
                    stResultado = sqlhelper.ExecuteScalar("[STD].[Isp_Servicio_IAE]", .TipoOperacion, .PrefijoID, _
                            .Id _
                            , .IdCategoriaServicio _
                            , .Codigo _
                            , .Nombre _
                            , .Precio _
                            , .Descripcion _
                            , .Activo _
                            , .UsuarioCreacion _
                            , .IdItemGasto).ToString.Split("_")
                    For Each ServicioCuentaContable As e_ServicioCuentaContable In oeServicio.ListaServicioCuentaContable
                        ServicioCuentaContable.Id = ""
                        ServicioCuentaContable.IdServicio = stResultado(0)
                        odServicioCuentaContable.Guardar(ServicioCuentaContable)
                    Next
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeServicio As e_Servicio) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[STD].[Isp_Servicio_IAE]", "E", _
             "", oeServicio.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
