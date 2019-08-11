Imports ISL.EntidadesWCF
Imports System.Transactions 

Public Class d_HorarioTrabajador
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_HorarioTrabajador
        Try
            Dim oeHorarioTrabajador = New e_HorarioTrabajador(o_fila("Id").ToString, o_fila("IdTrabajador").ToString, o_fila("IdHorario").ToString, _
                                                              o_fila("Horario").ToString, o_fila("Vigente").ToString, o_fila("Glosa").ToString _
                                                              , o_fila("FechaInicio").ToString, o_fila("FechaFin").ToString, o_fila("HoraInicio").ToString, _
                                                              o_fila("HoraFin").ToString, o_fila("Activo").ToString, _
                                                              o_fila("FechaCreacion").ToString, o_fila("UsuarioCreacion").ToString)
            Return oeHorarioTrabajador
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeHorarioTrabajador As e_HorarioTrabajador) As e_HorarioTrabajador

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeHorarioTrabajador.Id)
            If ds.Tables.Count > 0 Then
                oeHorarioTrabajador = Cargar(ds.Tables(0).Rows(0))
                Return oeHorarioTrabajador
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(ByVal oeHorarioTrabajador As e_HorarioTrabajador) As System.Data.DataSet
        Try
            Dim ds As DataSet
            With oeHorarioTrabajador
                ds = sqlhelper.ExecuteDataset("PER.Isp_HorarioTrabajador_Listar", .TipoOperacion _
                        , .Id _
                        , .IdTrabajador _
                        , .IdHorario)
            End With
            Return ds
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeHorarioTrabajador As e_HorarioTrabajador) As List(Of e_HorarioTrabajador)
        Try
            Dim ds As DataSet
            Dim loHorarioTrabajador As New List(Of e_HorarioTrabajador)
            With oeHorarioTrabajador
                ds = sqlhelper.ExecuteDataset("PER.Isp_HorarioTrabajador_Listar", .TipoOperacion _
                        , .Id _
                        , .IdTrabajador _
                        , .IdHorario)
            End With
            oeHorarioTrabajador = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeHorarioTrabajador = Cargar(o_Fila)
                    loHorarioTrabajador.Add(oeHorarioTrabajador)
                Next
                Return loHorarioTrabajador
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal loHorarioTrabajador As List(Of e_HorarioTrabajador)) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using transScope As New TransactionScope()
                For Each hortra As e_HorarioTrabajador In loHorarioTrabajador
                    With hortra
                        sqlhelper.ExecuteNonQuery("PER.Isp_HorarioTrabajador_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                                                  .Id _
                                                  , .IdTrabajador _
                                                  , .IdHorario _
                                                  , .FechaInicio _
                                                  , .FechaFin _
                                                  , .Vigente _
                                                  , .Glosa _
                                                  , .Activo _
                                                  , .FechaCreacion _
                                                  , .UsuarioCreacion)
                    End With
                Next
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeHorarioTrabajador As e_HorarioTrabajador) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_HorarioTrabajador_IAE", "E", _
             "", oeHorarioTrabajador.Id, oeHorarioTrabajador.IdTrabajador)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
