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

Public Class d_ConfiguracionNeumatico
    Private sqlhelper As New SqlHelper
    Dim odDetalleConfigNeu As New d_DetalleConfiguracionNeumatico

    Private Function Cargar(ByVal o_fila As DataRow) As e_ConfiguracionNeumatico
        Try
            Dim oeConfiguracionNeumatico = New e_ConfiguracionNeumatico( _
                             o_fila("Id").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("NroEjes").ToString _
                             , o_fila("NroNeumatico").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             )
            Return oeConfiguracionNeumatico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeConfiguracionNeumatico As e_ConfiguracionNeumatico) As e_ConfiguracionNeumatico

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[NEU].[Isp_ConfiguracionNeumaticos_Listar]", "", oeConfiguracionNeumatico.Id)
            If ds.Tables.Count > 0 Then
                oeConfiguracionNeumatico = Cargar(ds.Tables(0).Rows(0))
                Return oeConfiguracionNeumatico
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConfiguracionNeumatico As e_ConfiguracionNeumatico) As List(Of e_ConfiguracionNeumatico)
        Try
            Dim ldConfiguracionNeumatico As New List(Of e_ConfiguracionNeumatico)
            Dim ds As DataSet
            With oeConfiguracionNeumatico
                ds = sqlhelper.ExecuteDataset("[NEU].[Isp_ConfiguracionNeumaticos_Listar]", "" _
                        , .Id _
                        , .Nombre _
                        , .NroEjes _
                        , .Activo _
                        , .UsuarioCreacion _
                                                )
            End With
            oeConfiguracionNeumatico = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeConfiguracionNeumatico = Cargar(o_Fila)
                    ldConfiguracionNeumatico.Add(oeConfiguracionNeumatico)
                Next
            End If
            Return ldConfiguracionNeumatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConfiguracionNeumatico As e_ConfiguracionNeumatico) As Boolean
        Try
            Dim stResultado() As String
            With oeConfiguracionNeumatico
                stResultado = sqlhelper.ExecuteScalar("[NEU].[Isp_ConfiguracionNeumaticos_IAE]", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Nombre _
                        , .NroEjes _
                        , .NroNeumaticos _
                        , .Activo _
                        , .UsuarioCreacion
                                   ).ToString.Split("_")

                Dim oeDetalleConfigNeumatico As New e_DetalleConfiguracionNeumatico
                oeDetalleConfigNeumatico.Id = "" : oeDetalleConfigNeumatico.IdConfiguracionNeumatico = stResultado(0)
                odDetalleConfigNeu.Eliminar(oeDetalleConfigNeumatico)
                For Each Detalle As e_DetalleConfiguracionNeumatico In .lstDetalleConfiguracionNeumatico
                    Detalle.IdConfiguracionNeumatico = stResultado(0) : Detalle.UsuarioCreacion = .UsuarioCreacion
                    Detalle.TipoOperacion = IIf(String.IsNullOrEmpty(Detalle.Id), "I", .TipoOperacion)
                    Detalle.PrefijoID = oeConfiguracionNeumatico.PrefijoID '@0001
                    odDetalleConfigNeu.Guardar(Detalle)
                Next

            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeConfiguracionNeumatico As e_ConfiguracionNeumatico) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[NEU].[Isp_ConfiguracionNeumaticos_IAE]", "E", _
             "", oeConfiguracionNeumatico.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
