Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Flota_Cuota
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Flota_Cuota
        Try
            Dim oeFlota_Cuota = New e_Flota_Cuota( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdFlota").ToString _
                             , o_Fila("Importe").ToString _
                             , o_Fila("FechaInicio").ToString _
                             , o_Fila("FechaFin").ToString _
                             , o_Fila("Vigente").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("UsuarioModifica").ToString _
                             , o_Fila("FechaModifica").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeFlota_Cuota
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeFlota_Cuota As e_Flota_Cuota) As e_Flota_Cuota
        Try
            Dim ds As DataSet
            With oeFlota_Cuota
                ds = sqlhelper.ExecuteDataset("[STD].[Isp_Flota_Cuota_Listar]" _
                       , .TipoOperacion _
                       , "" _
                       , "" _
                       , .Id _
                       , .IdFlota _
                       , .Importe _
                       , .FechaInicio _
                       , .FechaFin _
                       , .Vigente _
                       , .UsuarioCreacion _
                       , .FechaCreacion _
                       , .UsuarioModifica _
                       , .FechaModifica _
                       , .Activo _
                       )
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeFlota_Cuota = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeFlota_Cuota
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeFlota_Cuota As e_Flota_Cuota) As List(Of e_Flota_Cuota)
        Try
            Dim ldFlota_Cuota As New List(Of e_Flota_Cuota)
            Dim ds As DataSet
            With oeFlota_Cuota
                ds = sqlhelper.ExecuteDataset("[STD].[Isp_Flota_Cuota_Listar]" _
                       , .TipoOperacion _
                       , "" _
                       , "" _
                       , .Id _
                       , .IdFlota _
                       , .FechaInicio _
                       , .FechaFin _
                       , .Vigente _
                       , .Activo _
                       )
            End With
            oeFlota_Cuota = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeFlota_Cuota = Cargar(o_Fila)
                    ldFlota_Cuota.Add(oeFlota_Cuota)
                Next
            End If
            Return ldFlota_Cuota
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeFlota_Cuota As e_Flota_Cuota) As Boolean
        Try
            'Using transScope As New TransactionScope()
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado() As String
            With oeFlota_Cuota
                stResultado = sqlhelper.ExecuteScalar("[STD].[Isp_Flota_Cuota_IAE]" _
                        , .TipoOperacion _
                        , .PrefijoID _
                        , .Id _
                        , .IdFlota _
                        , .Importe _
                        , .FechaInicio _
                        , .FechaFin _
                        , .Vigente _
                        , .UsuarioCreacion _
                        , .UsuarioModifica _
                        , .Activo _
                    ).ToString.Split("_")
                .Id = stResultado(0)
            End With
            'transScope.Complete()
            'End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeFlota_Cuota As e_Flota_Cuota) As Boolean
        Try
            With oeFlota_Cuota
                sqlhelper.ExecuteNonQuery("[STD].[Isp_Flota_Cuota_IAE]" _
                       , "E" _
                       , "" _
                       , .Id _
                       , .IdFlota _
                       , .Importe _
                       , .FechaInicio _
                       , .FechaFin _
                       , .Vigente _
                       , .UsuarioCreacion _
                       , .FechaCreacion _
                       , .UsuarioModifica _
                       , .FechaModifica _
                       , .Activo _
                   )

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
