'Imports System.Transactions
Imports ISL.EntidadesWCF

Public Class d_Flota_Trabajador
    Private sqlhelper As New SqlHelper

    Private Function Cargar(Fila As DataRow) As e_Flota_Trabajador
        Try
            Dim oeFlota_Trabajador = New e_Flota_Trabajador With {
                             .Id = Fila("Id").ToString() _
                             , .IdTrabajador = Fila("IdTrabajador").ToString() _
                             , .IdFlota = Fila("IdFlota").ToString() _
                             , .Glosa = Fila("Glosa").ToString() _
                             , .FechaInicio = Fila("FechaInicio") _
                             , .FechaFin = Fila("FechaFin") _
                             , .Actual = Fila("Actual") _
                             , .UsuarioCreacion = Fila("UsuarioCreacion").ToString() _
                             , .FechaCreacion = Fila("FechaCreacion") _
                             , .UsuarioModificacion = Fila("UsuarioModificacion").ToString() _
                             , .FechaModificacion = Fila("FechaModificacion") _
                             , .Activo = Fila("Activo") _
            }
            Return oeFlota_Trabajador
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(oeFlota_Trabajador As e_Flota_Trabajador) As DataSet
        Try
            Dim ds As DataSet
            With oeFlota_Trabajador
                ds = sqlhelper.ExecuteDataset("[STD].[Isp_Flota_Trabajador_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdTrabajador _
                        , .IdFlota _
                        , .Glosa _
                        , .FechaInicio _
                        , .FechaFin _
                        , .Actual _
                        , .Activo _
                        )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeFlota_Trabajador As e_Flota_Trabajador) As e_Flota_Trabajador
        Try
            Dim ds As DataSet = ExecuteLST(oeFlota_Trabajador)
            If ds.Tables(0).rows.Count > 0 Then
                oeFlota_Trabajador = Cargar(ds.Tables(0).Rows(0))
            Else
                oeFlota_Trabajador = New e_Flota_Trabajador
            End If
            Return oeFlota_Trabajador
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeFlota_Trabajador As e_Flota_Trabajador) As List(Of e_Flota_Trabajador)
        Try
            Dim lstFlota_Trabajador As New List(Of e_Flota_Trabajador)
            Dim ds As DataSet = ExecuteLST(oeFlota_Trabajador)
            oeFlota_Trabajador = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeFlota_Trabajador = Cargar(o_Fila)
                    lstFlota_Trabajador.Add(oeFlota_Trabajador)
                Next
            End If
            Return lstFlota_Trabajador
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeFlota_Trabajador As e_Flota_Trabajador) As Boolean
        Try
            'Using transScope As New TransactionScope()
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim IdResultado As String
            With oeFlota_Trabajador
                IdResultado = sqlhelper.ExecuteScalar("[STD].[Isp_Flota_Trabajador_IAE]" _
                        , .TipoOperacion _
                        , d_DatosConfiguracion.PrefijoID _
                        , .Id _
                        , .IdTrabajador _
                        , .IdFlota _
                        , .Glosa _
                        , .FechaInicio _
                        , .FechaFin _
                        , .Actual _
                        , .UsuarioCreacion _
                        , .Activo _
                    ).ToString()
                .Id = IdResultado
            End With
            'transScope.Complete()
            'End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(oeFlota_Trabajador As e_Flota_Trabajador) As Boolean
        Try
            With oeFlota_Trabajador
                sqlhelper.ExecuteNonQuery("[STD].[Isp_Flota_Trabajador_IAE]" _
                       , "E" _
                       , "" _
                       , .Id _
                       , .IdTrabajador _
                       , .IdFlota _
                       , .Glosa _
                       , .FechaInicio _
                       , .FechaFin _
                       , .Actual _
                       , .UsuarioCreacion _
                       , .Activo _
                   )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
