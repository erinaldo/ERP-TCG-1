Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DetalleConceptoPonderado

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleConceptoPonderado
        Try
            Dim oeDetalleConceptoPonderado = New e_DetalleConceptoPonderado( _
                             o_fila("Id").ToString _
                             , o_fila("IdConceptoPonderado").ToString _
                             , o_fila("NroOrden") _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Porcentaje") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            Return oeDetalleConceptoPonderado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleConceptoPonderado As e_DetalleConceptoPonderado) As e_DetalleConceptoPonderado

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_DetalleConceptoPonderado_Listar", oeDetalleConceptoPonderado.TipoOperacion, oeDetalleConceptoPonderado.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeDetalleConceptoPonderado = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetalleConceptoPonderado
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleConceptoPonderado As e_DetalleConceptoPonderado) As List(Of e_DetalleConceptoPonderado)
        Try
            Dim ldDetalleConceptoPonderado As New List(Of e_DetalleConceptoPonderado)
            Dim ds As DataSet
            With oeDetalleConceptoPonderado
                ds = sqlhelper.ExecuteDataset("STD.Isp_DetalleConceptoPonderado_Listar", .TipoOperacion _
                        , .Id _
                        , .IdConceptoPonderado _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Porcentaje _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeDetalleConceptoPonderado = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetalleConceptoPonderado = Cargar(o_Fila)
                ldDetalleConceptoPonderado.Add(oeDetalleConceptoPonderado)
            Next
            Return ldDetalleConceptoPonderado
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleConceptoPonderado As e_DetalleConceptoPonderado) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDetalleConceptoPonderado
                sqlhelper.ExecuteNonQuery("STD.Isp_DetalleConceptoPonderado_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdConceptoPonderado _
                        , .NroOrden _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Porcentaje _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleConceptoPonderado As e_DetalleConceptoPonderado) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_DetalleConceptoPonderado_IAE", "E", _
             "", oeDetalleConceptoPonderado.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
