'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DiseñoNeumatico
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_DiseñoNeumatico
        Try
            Dim oeDiseñoNeumatico = New e_DiseñoNeumatico( _
                             o_fila("Id").ToString _
                             , o_fila("IdMarca").ToString _
                             , o_fila("Marca").ToString _
                             , o_fila("IdMedidaNeumatico").ToString _
                             , o_fila("MedidaNeumatico").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("NroLonas").ToString _
                             , o_fila("Ribete1").ToString _
                             , o_fila("Ribete2").ToString _
                             , o_fila("Ribete3").ToString _
                             , o_fila("Ribete4").ToString _
                             , o_fila("Cocada").ToString _
                             , o_fila("CocadaMinima") _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                                   )
            Return oeDiseñoNeumatico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDiseñoNeumatico As e_DiseñoNeumatico) As e_DiseñoNeumatico

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[NEU].[Isp_DiseñoNeumatico_Listar]", "", oeDiseñoNeumatico.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeDiseñoNeumatico = Cargar(ds.Tables(0).Rows(0))
                Return oeDiseñoNeumatico
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDiseñoNeumatico As e_DiseñoNeumatico) As List(Of e_DiseñoNeumatico)
        Try
            Dim ldDiseñoNeumatico As New List(Of e_DiseñoNeumatico)
            Dim ds As DataSet
            With oeDiseñoNeumatico
                ds = sqlhelper.ExecuteDataset("[NEU].[Isp_DiseñoNeumatico_Listar]", "" _
                        , .Id _
                        , .IdMarca _
                        , .IdMedidaNeumatico _
                        , .Nombre _
                        , .Codigo _
                        , .NroLonas _
                        , .Ribete1 _
                        , .Ribete2 _
                        , .Ribete3 _
                        , .Ribete4 _
                        , .Cocada _
                        , .Activo _
                        , .UsuarioCreacion _
                                          )
            End With
            oeDiseñoNeumatico = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDiseñoNeumatico = Cargar(o_Fila)
                    ldDiseñoNeumatico.Add(oeDiseñoNeumatico)
                Next
            End If
            Return ldDiseñoNeumatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDiseñoNeumatico As e_DiseñoNeumatico) As Boolean
        Try
            With oeDiseñoNeumatico
                sqlhelper.ExecuteNonQuery("[NEU].[Isp_DiseñoNeumatico_IAE]", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdMarca _
                        , .IdMedidaNeumatico _
                        , .Nombre _
                        , .Codigo _
                        , .NroLonas _
                        , .Ribete1 _
                        , .Ribete2 _
                        , .Ribete3 _
                        , .Ribete4 _
                        , .Cocada _
                        , .CocadaMinima _
                        , .Activo _
                        , .UsuarioCreacion
                                   )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDiseñoNeumatico As e_DiseñoNeumatico) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[NEU].[Isp_DiseñoNeumatico_IAE]", "E", _
             "", oeDiseñoNeumatico.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
