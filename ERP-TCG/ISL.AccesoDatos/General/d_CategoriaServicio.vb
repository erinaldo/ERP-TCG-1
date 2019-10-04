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

''' <summary>
''' Clase que permite el acceso a datos de la entidad Categoría de servicios
''' </summary>
''' <remarks></remarks>
Public Class d_CategoriaServicio
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CategoriaServicio
        Try
            Dim oeCategoriaServicio = New e_CategoriaServicio( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                                       )
            Return oeCategoriaServicio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCategoriaServicio As e_CategoriaServicio) As e_CategoriaServicio

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_CategoriaServicio_Listar", "", oeCategoriaServicio.Id, "", oeCategoriaServicio.Nombre)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count Then
                oeCategoriaServicio = Cargar(ds.Tables(0).Rows(0))
                Return oeCategoriaServicio
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCategoriaServicio As e_CategoriaServicio) As List(Of e_CategoriaServicio)
        Try
            Dim ldCategoriaServicio As New List(Of e_CategoriaServicio)
            Dim ds As DataSet
            With oeCategoriaServicio
                ds = sqlhelper.ExecuteDataset("STD.Isp_CategoriaServicio_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Activo _
                        , .UsuarioCreacion)
            End With
            oeCategoriaServicio = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCategoriaServicio = Cargar(o_Fila)
                    ldCategoriaServicio.Add(oeCategoriaServicio)
                Next
                Return ldCategoriaServicio
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCategoriaServicio As e_CategoriaServicio) As Boolean
        Try
            Dim Id As String = ""

            Dim odCtaCtbleCatServ As New d_CtaCtbleCatServicio
            Using transCope As New TransactionScope()
                With oeCategoriaServicio
                    Id = sqlhelper.ExecuteScalar("STD.Isp_CategoriaServicio_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Descripcion _
                        , .Activo _
                        , .UsuarioCreacion)
                    For Each ctactblecatserv As e_CtaCtbleCatServicio In .loCtaCtbleCatServ
                        ctactblecatserv.IdCategoriaServicio = Id
                        ctactblecatserv.PrefijoID = oeCategoriaServicio.PrefijoID '@0001
                        odCtaCtbleCatServ.Guardar(ctactblecatserv)
                    Next
                End With
                transCope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeCategoriaServicio As e_CategoriaServicio) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_CategoriaServicio_IAE", "E", _
             "", oeCategoriaServicio.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
